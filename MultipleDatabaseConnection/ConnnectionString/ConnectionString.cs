using OfficeOpenXml;
using System.Diagnostics;

namespace DatabaseConnectionAPI.ConnnectionString
{
    public class ConnectionString
    {
        private string Server;
        private string Database;
        private string User_Id;
        private string Password;

        public ConnectionString(string server, string database, string userId, string password)
        {
            this.Server = server;
            this.Database = database;
            this.User_Id = userId;
            this.Password = password;

           Debug.WriteLine(server);
        } 


        //public void ExcelReader()
        //{
        //    var package = new ExcelPackage(new FileStream(@"C:\Users\kalp.mehta\Desktop\ConnectionStringParameters.xlsx", FileMode.Open, FileAccess.Read));

        //    var firstSheet = package.Workbook.Worksheets[0];
        //    string server = (string)firstSheet.Cells["A2"].Value;
        //    //Debug.WriteLine(server);
        //    string database = (string)firstSheet.Cells["B2"].Value;
        //    //Debug.WriteLine(database);
        //    string password = (string)firstSheet.Cells["C2"].Value;
        //    //Debug.WriteLine(password);
        //    string username = (string)firstSheet.Cells["D2"].Value;
        //    //  Debug.WriteLine(username);

        //    new ConnectionString(server,database,password,username);
        //}

        public string getConnectionString()
        {
            //using (var package = new ExcelPackage(new FileInfo(@"C:\Users\kalp.mehta\Desktop\ConnectionStrinfParameters.xlsx")))
            //{
            //    var firstSheet = package.Workbook.Worksheets[0];
            //    Console.WriteLine(firstSheet.Cells["A1"].Text);
            //    Debug.WriteLine(firstSheet.Cells["A1"].Text);
            //}
            //Console.ReadLine();    
            return "Server="+this.Server+";Database="+this.Database+";User Id="+this.User_Id+";Password="+this.Password;
        }
    }
}
