using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml;



namespace ExcelTest
{
   
    public class ExcelWrite
    {
        public void WriteToSheet(string username, string password, string name, int age)
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

                var cnt = ws.Cells[1, 7].Value;
                int cn = Convert.ToInt32(cnt);




                var dat = new List<object[]>()
                {
                    new object[] {username},
                    new object[] {password},
                    new object[] {name},
                    new object[] {age},
                    new object[] {cn}
                };

                int count = 0;

                for (int col = 1; col <= dat.Count; ++col)
                {
                    {
                        ws.Cells[cn, col].Value = dat[count];
                        ++count;
                    }
                }


                ws.Cells[1, 7].Value = ++cn;
                test.SaveAs(@"E:/test.xlsx");

            }

        }
        public List<string> ReadFromSheet(string username, string password)
        {
            List<string> l = new();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var test = new ExcelPackage())
            {
                using (var stream = File.OpenRead(@"E:/test.xlsx"))
                {
                    test.Load(stream);
                }

                var ws = test.Workbook.Worksheets["New Sheet"];

                var cnt = ws.Cells[1, 7].Value;
                int cn = Convert.ToInt32(cnt);


                for (int i = 1; i <= cn; ++i)
                {
                    var q = (from cell in ws.Cells[i, 1]
                             where cell.Value is string && (string)cell.Value == username
                             select cell);

                    foreach (var cell in q)
                    {
                        string rw = cell.Address.Substring(1);
                        int rwi = Convert.ToInt32(rw);
                        if(Convert.ToString(ws.Cells[rwi, 2].Value) == password)
                        {
                            for (int c = 1; c <= 5; ++c)
                            {
                                l.Add(Convert.ToString(ws.Cells[rwi, c].Value));
                            }
                        }
                    }
                }
            }
            return
                l;
        }
        public void EditData(string username, string password, string name, int age, int id)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var test = new ExcelPackage())
            {
                using (var stream = File.OpenRead(@"E:/test.xlsx"))
                {
                    test.Load(stream);
                }

                var ws = test.Workbook.Worksheets["New Sheet"];

                ws.Cells[id, 1].Value = username;
  
                test.SaveAs(@"E:/test.xlsx");

            }
        }
        public void EditData(string password, int age, string name, string username, int id)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var test = new ExcelPackage())
            {
                using (var stream = File.OpenRead(@"E:/test.xlsx"))
                {
                    test.Load(stream);
                }

                var ws = test.Workbook.Worksheets["New Sheet"];

                ws.Cells[id, 2].Value = password;

                test.SaveAs(@"E:/test.xlsx");

            }
        }
        public void EditData(string name, int age, int id, string username, string password)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var test = new ExcelPackage())
            {
                using (var stream = File.OpenRead(@"E:/test.xlsx"))
                {
                    test.Load(stream);
                }

                var ws = test.Workbook.Worksheets["New Sheet"];

                ws.Cells[id, 3].Value = name;

                test.SaveAs(@"E:/test.xlsx");

            }
        }
        public void EditData(int age, string password, string name, string username, int id)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var test = new ExcelPackage())
            {
                using (var stream = File.OpenRead(@"E:/test.xlsx"))
                {
                    test.Load(stream);
                }

                var ws = test.Workbook.Worksheets["New Sheet"];

                ws.Cells[id, 4].Value = age;

                test.SaveAs(@"E:/test.xlsx");

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