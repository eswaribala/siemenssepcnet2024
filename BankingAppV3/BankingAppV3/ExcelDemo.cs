using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

using System.Linq;

#nullable disable
namespace BankingAppV3
{
    internal class ExcelDemo
    {
        static void Main()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("City", typeof(string));
            dt.Columns.Add("State", typeof(string));
            dt.Columns.Add("Zip", typeof(string));

            for(int i = 0; i < 100; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = Faker.Address.City();
                dr[1] = Faker.Address.CaProvince();
                dr[2] = Faker.Address.ZipCode();
                dt.Rows.Add(dr);

            }
            try
            {
                IWorkbook workbook=null;
                string fileName = @"F:\Local disk\CSharpSiemensDotnetSep2024\BankingAppV3\BankingAppV3\Addresses.xlsx";
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                if (fileName.IndexOf(".xlsx") > 0)
                    workbook = new XSSFWorkbook(fs);
                else if (fileName.IndexOf(".xls") > 0)
                    workbook = new HSSFWorkbook(fs);
                //First sheet
                ISheet sheet = workbook.GetSheetAt(0);
                if (sheet != null)
                {
                    int rowCount = sheet.LastRowNum; // This may not be valid row count.
                                                     // If first row is table head, i starts from 1
                    for (int i = 1; i <= rowCount; i++)
                    {
                        IRow curRow = sheet.GetRow(i);
                        // Works for consecutive data. Use continue otherwise 
                        if (curRow == null)
                        {
                            // Valid row count
                            rowCount = i - 1;
                            break;
                        }
                        // Get data from the 4th column (4th cell of each row)
                        var cellValue = curRow.GetCell(0).StringCellValue.Trim()+","+
                            curRow.GetCell(1).StringCellValue.Trim()+","+
                            curRow.GetCell(2).StringCellValue.Trim();
                        Console.WriteLine(cellValue);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
         

            using (FileStream stream = new FileStream(@"F:\Local disk\CSharpSiemensDotnetSep2024\BankingAppV3\BankingAppV3\AddressesV1.xlsx", FileMode.Create, FileAccess.Write))
            {
                IWorkbook wb = new XSSFWorkbook();
                ISheet sheet = wb.CreateSheet("Sheet1");
                ICreationHelper cH = wb.GetCreationHelper();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    IRow row = sheet.CreateRow(i);
                    for (int j = 0; j < 3; j++)
                    {
                        ICell cell = row.CreateCell(j);
                        cell.SetCellValue(cH.CreateRichTextString(dt.Rows[i].ItemArray[j].ToString()));
                    }
                }
                wb.Write(stream);
            }
            Console.ReadKey();
        }

    }

}
