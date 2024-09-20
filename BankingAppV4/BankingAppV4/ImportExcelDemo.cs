using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV4
{
    internal class ImportExcelDemo
    {
        public static void Main()
        {

            string fileName = @"F:\Local disk\CSharpSiemensDotnetSep2024\BankingAppV4\Reports\TransactionData.xlsx";

            IWorkbook workBook = null;
            List<long> amounts=new List<long>();
            FileStream fileStream = new FileStream(fileName
                , FileMode.Open, FileAccess.Read);
            

                if (fileName.IndexOf(".xlsx")>0)
                {
                    workBook = new XSSFWorkbook(fileStream);
                }
                if (fileName.IndexOf(".xls") > 0)
                {
                    workBook = new HSSFWorkbook(fileStream);
                }
                

                ISheet sheet = workBook.GetSheetAt(0);

                int count =sheet.LastRowNum;
                if (sheet != null)
                {
                    for (int i = 1; i < count; i++)
                    {
                        IRow row = sheet.GetRow(i);
                        ICell cell = row.GetCell(1);
                        amounts.Add(Convert.ToInt64(cell.StringCellValue.Trim()));

                    }
                }

                workBook.Close();
            Console.WriteLine($"Total Transaction={amounts.Sum(x => x)}");
            Console.WriteLine($"Average Transaction={amounts.Average(x => x)}");
            Console.WriteLine($"Minimum Transaction={amounts.Min(x => x)}");
            Console.WriteLine($"Maximum Transaction={amounts.Max(x => x)}");
            Console.WriteLine($"No of Transaction={amounts.Count()}");
            Console.ReadKey();

        }

           

        
    }
}
