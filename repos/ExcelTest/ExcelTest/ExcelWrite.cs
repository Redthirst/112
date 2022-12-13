using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml;


namespace ExcelTest
{

    class Program
    {

        static void Main(string[] args)
        {
            FileInfo file = new FileInfo(@"E:/test.xlsx");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var test = new ExcelPackage())
            {
                using (var stream = File.OpenRead(@"E:/test.xlsx"))
                {
                    test.Load(stream);
                }

                
                
                var ws = test.Workbook.Worksheets["New Sheet"];
                
                void WriteToSheet(string username, string password, string name, int age)
                {
                    var cnt = ws.Cells[1, 7].Value;
                    int cn = Convert.ToInt32(cnt);

                    var dat = new List<object[]>()
                {
                    new object[] {username},
                    new object[] {password},
                    new object[] {name},
                    new object[] {age}

                };
                    int count = 0;

                    for (int col = 1; col <= dat.Count; ++col)
                    {
                        if(dat[count] == null)
                        {
                            ws.Cells[cn, col].Value = "test";
                            ++count;
                            
                        }
                        else
                        {
                            ws.Cells[cn, col].Value = dat[count];
                            ++count;
                        }
                        
                    }

                    ws.Cells[1, 7].Value = ++cn;
                    test.SaveAs(@"E:/test.xlsx");
                }

                WriteToSheet("Al", "12", null, 28);

                

            }

        }
            
        
    }
}
//using (SpreadsheetDocument test = SpreadsheetDocument.Create("E:/test1.xlsx", SpreadsheetDocumentType.Workbook))
//{
//    WorkbookPart wbp = test.AddWorkbookPart();
//    wbp.Workbook = new Workbook();
//    WorksheetPart wsp = wbp.AddNewPart<WorksheetPart>();
//    wsp.Worksheet = new Worksheet(new SheetData());
//    var ws = wsp.Worksheet;
//    Sheets sheets = wbp.Workbook.AppendChild(new Sheets());
//    Sheet sheet = new Sheet();
//    sheets.Append(sheet);
//    Sheet sheet2 = new Sheet();
//    sheets.Append(sheet2);
//    wbp.Workbook.Save();
//}

//using (SpreadsheetDocument test1 = SpreadsheetDocument.Open("E:/test.xlsx", true))
//{
//    WorkbookPart wbp = test1.WorkbookPart;
//    wbp.Workbook = new Workbook();
//    WorksheetPart wsp = wbp.AddNewPart<WorksheetPart>();
//    wsp.Worksheet = new Worksheet(new SheetData());
//    var ws = wsp.Worksheet;
//    Sheets sheets = wbp.Workbook.AppendChild(new Sheets());
//    Sheet sheet = new Sheet();
//    sheets.Append(sheet);
//    Sheet sheet2 = new Sheet();
//    sheets.Append(sheet2);
//    var row = ws.GetFirstChild<SheetData>().AppendChild(new Row());
//    var cell = sheet.
//    cell.CellValue = new CellValue("test");
//    cell.DataType = new EnumValue<CellValues>(CellValues.String);
//    wbp.Workbook.Save();

//}