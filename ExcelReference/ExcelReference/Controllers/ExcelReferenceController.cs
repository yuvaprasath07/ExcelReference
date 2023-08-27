using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Spreadsheet;
using Entity;
using System.Linq;
using Entity.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using OfficeOpenXml;
using OfficeOpenXml.DataValidation;

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

        [HttpGet]
        public object GetExcel()
        {
            var filePath = Path.Combine(Path.GetTempPath(), @"D:\Csharpwork\Reference.xlsx");

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var sheet1 = package.Workbook.Worksheets.Add("CustomerType");
                var sheet2 = package.Workbook.Worksheets.Add("Lookup");
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
                //package.SaveAs(new System.IO.FileInfo(filePath));

                var acceptLanguageHeader = HttpContext.Request.Headers["Accept-Language"].ToString();
                var preferredLanguages = acceptLanguageHeader
               .Split(',')
               .Select(language => language.Split(';')[0])
               .ToList().FirstOrDefault().ToString();

                List<L_CustomerType> customer = new List<L_CustomerType>();
                List<L_PaymentCategory> Payment = new List<L_PaymentCategory>();
                List<UtilityModel> Utility = new List<UtilityModel>();

                if (preferredLanguages == "JP")
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

    }
}


