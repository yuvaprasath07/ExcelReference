using DocumentFormat.OpenXml.Spreadsheet;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public string GetExcel()
        {
            var filePath = Path.Combine(Path.GetTempPath(), @"D:\Csharpwork\ExcelReference.xlsx");
            //string filePath = @"D:\Csharpwork\Reference.xlsx";
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
                package.SaveAs(new System.IO.FileInfo(filePath));

                var customer = _dbContext.L_CustomerType.ToList();
                var Payment = _dbContext.L_PaymentCategory.ToList();
                var Utility = _dbContext.L_Utility.ToList();


                for (int i = 0; i < customer.Count; i++)
                {
                    sheet2.Cells[i + 2, 1].Value = customer[i].CustomerTypeName;
                }

                for (int i = 0; i < Payment.Count; i++)
                {
                    sheet2.Cells[i + 2, 2].Value = Payment[i].PaymentCategoryCode;
                }

                for (int i = 0; i < Utility.Count; i++)
                {
                    sheet2.Cells[i + 2, 3].Value = Utility[i].UtilityName;
                }

                var customerTypeRange = sheet2.Cells[2, 1, customer.Count + 1, 1];
                var paymentMethodRange = sheet2.Cells[2, 2, Payment.Count + 1, 2];
                var utilityNameRange = sheet2.Cells[2, 3, Utility.Count + 1, 3];

                
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
            return "Excel Sheet successfully create";
        }

    }
}

