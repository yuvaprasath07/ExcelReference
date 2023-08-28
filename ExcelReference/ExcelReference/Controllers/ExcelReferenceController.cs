using Entity;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Newtonsoft.Json.Linq;
using System.IO.Packaging;
using System.Reflection.Metadata.Ecma335;

namespace ExcelReference.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelReferenceController : ControllerBase
    {
        public readonly CustomerDbcontext _dbContext;

        public ExcelReferenceController(CustomerDbcontext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("ExcelDownload")]
        public object GetExcel()
        {
            var filePath = Path.Combine(Path.GetTempPath(), @"D:\Csharpwork\Reference.xlsx");

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var acceptLanguageHeader = HttpContext.Request.Headers["Accept-Language"].ToString();
                var preferredLanguages = acceptLanguageHeader.Split(',')
               .Select(language => language.Split(';')[0])
               .ToList().FirstOrDefault().ToString();


                var sheet1 = package.Workbook.Worksheets.Add("CustomerType");
                var sheet2 = package.Workbook.Worksheets.Add("Lookup");

                if (!(preferredLanguages.Contains("JP")))
                {
                    sheet1.Cells["A1"].Value = "Customer type";
                    sheet1.Cells["B1"].Value = "Corporate Name";
                    sheet1.Cells["C1"].Value = "Corporate Name Kana";
                    sheet1.Cells["D1"].Value = "contract_postal code";
                    sheet1.Cells["E1"].Value = "Payment Method";
                    sheet1.Cells["F1"].Value = "area";
                    sheet1.Cells["G1"].Value = "Scheduled supply start date";
                    sheet1.Cells["H1"].Value = "Weighing day";
                    sheet1.Cells["I1"].Value = "main_basic unit price";
                    sheet2.Cells["A1"].Value = "CustomerTypeName";
                    sheet2.Cells["B1"].Value = "paymntCategroyCode";
                    sheet2.Cells["C1"].Value = "UtilityName";
                }
                else
                {
                    sheet1.Cells["A1"].Value = "顧客タイプ";
                    sheet1.Cells["B1"].Value = "法人名";
                    sheet1.Cells["C1"].Value = "法人名カナ";
                    sheet1.Cells["D1"].Value = "契_郵便番号";
                    sheet1.Cells["E1"].Value = "支払方法";
                    sheet1.Cells["F1"].Value = "エリア";
                    sheet1.Cells["G1"].Value = "供給開始予定月";
                    sheet1.Cells["H1"].Value = "計量日";
                    sheet1.Cells["I1"].Value = "主_基本料金単価";
                    sheet2.Cells["A1"].Value = "顧客タイプ";
                    sheet2.Cells["B1"].Value = "支払いカテゴリコード";
                    sheet2.Cells["C1"].Value = "ユーティリティ名";
                }

                List<L_CustomerType> customer = new List<L_CustomerType>();
                List<L_PaymentCategory> Payment = new List<L_PaymentCategory>();
                List<UtilityModel> Utility = new List<UtilityModel>();

                if (preferredLanguages.Contains("JP"))
                {
                    customer = _dbContext.L_CustomerType.ToList();
                    customer.Select(data =>
                    {
                        data.CustomerTypeName = data.NativeDescription;
                        return data;
                    }).ToList();

                    Payment = _dbContext.L_PaymentCategory.ToList();
                    Payment.Select(data =>
                    {
                        data.PaymentCategoryCode = data.NativeDescription;
                        return data;
                    }).ToList();

                    Utility = _dbContext.L_Utility.ToList();

                    Utility.Select(data =>
                    {
                        data.UtilityName = data.NativeDescription;
                        return data;
                    }).ToList();
                }
                else
                {
                    customer = _dbContext.L_CustomerType.ToList();
                    Payment = _dbContext.L_PaymentCategory.ToList();
                    Utility = _dbContext.L_Utility.ToList();
                }


                for (int i = 0; i < customer.Count; i++)
                {
                    sheet2.Cells[i + 2, 1].Value = customer[i].CustomerTypeName;

                }

                var priceColumn = sheet1.Cells[2, 9, customer.Count + 1, 9];
                priceColumn.Style.Numberformat.Format = "0.00";

                for (int i = 0; i < Payment.Count; i++)
                {
                    sheet2.Cells[i + 2, 2].Value = Payment[i].PaymentCategoryCode;

                }

                for (int i = 0; i < Utility.Count; i++)
                {
                    sheet2.Cells[i + 2, 3].Value = Utility[i].UtilityName;
                }

                sheet1.Cells["G2"].Style.Numberformat.Format = "yyyy/mm/dd";
                var customerTypeRange = sheet2.Cells[2, 1, customer.Count + 1, 1];
                var paymentMethodRange = sheet2.Cells[2, 2, Payment.Count + 1, 2];
                var utilityNameRange = sheet2.Cells[2, 3, Utility.Count + 1, 3];

                var headerCells = sheet1.Cells["A1:I1"];
                headerCells.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                headerCells.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                var customerType = sheet1.DataValidations.AddListValidation("A2:A1000");
                customerType.Formula.ExcelFormula = $"Lookup!${customerTypeRange.Address}";

                var paymentMethod = sheet1.DataValidations.AddListValidation("E2:E1000");
                paymentMethod.Formula.ExcelFormula = $"Lookup!${paymentMethodRange.Address}";

                var utilityName = sheet1.DataValidations.AddListValidation("F2:F1000");
                utilityName.Formula.ExcelFormula = $"Lookup!${utilityNameRange.Address}";


                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    package.SaveAs(fileStream);
                }

            }
            var fileStreamResult = new FileStreamResult(new FileStream(filePath, FileMode.Open), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            fileStreamResult.FileDownloadName = "Consumer.xlsx";
            return fileStreamResult;
        }

        [HttpGet("Country")]
  public object GetCountry()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("DropdownSheet");
                var countries = new string[] { "USA", "Canada", "UK", "Australia" };
                var cities = new System.Collections.Generic.Dictionary<string, string[]>
                {
                    { "USA", new string[] { "New York", "Los Angeles", "Chicago" } },
                    { "Canada", new string[] { "Toronto", "Vancouver", "Montreal" } },
                    { "UK", new string[] { "London", "Manchester", "Birmingham" } },
                    { "Australia", new string[] { "Sydney", "Melbourne", "Brisbane" } }
                };
                worksheet.Cells["A1"].Value = "Country";
                var validationList = worksheet.DataValidations.AddListValidation("A1");
                validationList.Formula.Values.Add("\"" + string.Join(",", countries) + "\"");
                FileInfo files = new FileInfo("D:\\Csharpwork\\EOSEcxel\\ExcelDropdownExample.xlsx");
                package.SaveAs(files);
            }
            return "Sucess";
        }
    }
    
}

    



    
    















  





