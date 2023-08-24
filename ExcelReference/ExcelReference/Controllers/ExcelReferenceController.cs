using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace ExcelReference.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelReferenceController : ControllerBase
    {
        [HttpGet]
        public string GetExcel()
        {
            string filePath = @"D:\Csharpwork\Reference.xlsx";
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var sheet1 = package.Workbook.Worksheets.Add("Sheet1");
                var sheet2 = package.Workbook.Worksheets.Add("Sheet2");
                package.SaveAs(new System.IO.FileInfo(filePath));
            }
            return "Excel Sheet successfully create";
        }
        
    }
}

