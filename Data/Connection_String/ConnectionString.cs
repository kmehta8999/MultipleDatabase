using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Connection_String
{
    public class ConnectionString
    {
        private string Server;
        private string Database;
        private string User_Id;
        private string Password;
        private int DBId;

        public ConnectionString(int id)
        {
            this.DBId = id; 
        }

        
        public string getConnectionString()
        {
            //using (var package = new ExcelPackage(new FileInfo(@"C:\Users\kalp.mehta\Desktop\ConnectionStrinfParameters.xlsx")))
            //{
            //    var firstSheet = package.Workbook.Worksheets[0];
            //    Console.WriteLine(firstSheet.Cells["A1"].Text);
            //    Debug.WriteLine(firstSheet.Cells["A1"].Text);
            //}
            //Console.ReadLine();
            //
            var package = new ExcelPackage(new FileStream(@"C:\Users\kalp.mehta\Desktop\ConnectionStringParameters.xlsx", FileMode.Open, FileAccess.Read));


            var firstSheet = package.Workbook.Worksheets[0];
            for (int SheetRow = 2; SheetRow <= 3; SheetRow++)
            {
                if ((double)firstSheet.Cells[SheetRow, 1].Value == DBId) // hear 1 is column number. [SheetRow, 1]
                {
                    string server = (string)firstSheet.Cells[SheetRow, 2].Value;
                    // Debug.WriteLine(server);
                    string database = (string)firstSheet.Cells[SheetRow, 3].Value;
                    //   Debug.WriteLine(database);
                    string username = (string)firstSheet.Cells[SheetRow, 4].Value;
                    //    Debug.WriteLine(username);
                    string password = (string)firstSheet.Cells[SheetRow, 5].Value;
                    // Debug.WriteLine(password); 
                    this.Server = server;
                    this.Database = database;
                    this.User_Id = username;
                    this.Password = password;
                }
            }

            return "Server=" + this.Server + ";Database=" + this.Database + ";User Id=" + this.User_Id + ";Password=" + this.Password;
        }
    }
}
