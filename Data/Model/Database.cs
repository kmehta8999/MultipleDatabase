using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Database
    {
        public int Id { get; set; }
        public string database { get; set; }
    }

    public class DatabaseList
    {
        private List<Database> databaseList = new List<Database>();
        public List<Database> getDatabseList()
        {
            var package = new ExcelPackage(new FileStream(@"C:\Users\kalp.mehta\Desktop\ConnectionStringParameters.xlsx", FileMode.Open, FileAccess.Read));
            var firstSheet = package.Workbook.Worksheets[0];
            // Excel Sheet Column Number 
            var ExcelSheetColumn = 3;
            for (int i = 2; i <= 3; i++)
            {
                //select single database name from excel sheet...
                var databaseName = firstSheet.Cells[i, ExcelSheetColumn].Value;
                // add single database name and Id in databaseList 
                databaseList.Add(new Database { Id = i - 1, database = databaseName.ToString() });
            }
            return databaseList;
        }
    }
}