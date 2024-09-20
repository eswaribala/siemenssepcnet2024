using BankingAppV4.Models;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankingAppV4
{
    internal class ExportToExcel
    {

        public static void Main()
        {
            using (FileStream fileStream = new FileStream("F:\\Local disk\\CSharpSiemensDotnetSep2024" +
                "\\BankingAppV4\\Reports\\TransactionData.xlsx"
                , FileMode.Append,FileAccess.Write)) { 
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("September-2024");
            int rowNum = 0;
            foreach (Transaction transaction in LambdaDemo.GenerateTransactions())
            {
                IRow row = sheet.CreateRow(rowNum);
                int colNum = 0;
                ICell cell = row.CreateCell(colNum);
                cell.SetCellValue(transaction.TransactionNo);
                colNum++;
                cell = row.CreateCell(colNum);
                cell.SetCellValue(transaction.Amount);
                colNum++;
                cell = row.CreateCell(colNum);
                cell.SetCellValue(transaction.TransactionDate.ToShortDateString());
                rowNum++;
            }
            workbook.Write(fileStream);
            workbook.Close();

        }

            Console.ReadKey();

        }
    }
}
