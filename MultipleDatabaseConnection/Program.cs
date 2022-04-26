using Data.Context;
using Data.Repository;
using DatabaseConnectionAPI.ConnnectionString;
using DatabaseConnectionAPI.Enum;
using ExcelDataReader;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using Services.Interface;
using Services.Service;
using System.Configuration;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
//DatabaseType databaseType = DatabaseType.SQLServer;
//ConnectionString connectionString = new ConnectionString(@"WIN-OG3UJ2VF6B5\SQLEXPRESS", "sqlData", "kalp.mehta", "Kmehta@2022");
//ConnectionString connectionString1 = new ConnectionString(@"WIN-OG3UJ2VF6B5\SQLEXPRESS", "myDatabase","kalp.mehta","Kmehta@2022");
//Connect to SQL Server
//if (databaseType == DatabaseType.SQLServer)
//{
//builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(connectionString.getConnectionString()));
//}
//else if (databaseType == DatabaseType.PostgreSQL)
//{
// builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(connectionString1.getConnectionString()));
//}
//else
//{

//}


//var package = new ExcelPackage(new FileStream(@"C:\Users\kalp.mehta\Desktop\ConnectionStringParameters.xlsx", FileMode.Open, FileAccess.Read));


//var firstSheet = package.Workbook.Worksheets[0];
//string server = (string)firstSheet.Cells["A2"].Value;
////Debug.WriteLine(server);
//string database = (string)firstSheet.Cells["B2"].Value;
////Debug.WriteLine(database);
//string password = (string)firstSheet.Cells["D2"].Value;
////Debug.WriteLine(password);
//string username = (string)firstSheet.Cells["C2"].Value;
////  Debug.WriteLine(username);







//ConnectionString connectionString2 = new ConnectionString(server, database, username, password);
//    builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(connectionString2.getConnectionString()));
    //string constr = connectionString2.getConnectionString();
    //builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(constr));

//Console.Read();
builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
builder.Services.AddScoped<IEmployeeSrv, EmployeeSrv>();
//builder.Services.AddScoped(typeof(IEmployeeRepo<,>), typeof(EmployeeRepo<,>));
//builder.Services.AddScoped(typeof(IEmployeeSrv<,>), typeof(EmployeeSrv<,>));



//string[] rows;
//string[] column;

//string path = @"C:\Users\kalp.mehta\Desktop\Dhruvit.csv";
//int index = 0;

//rows = File.ReadAllLines(path);
//while (index < rows.Length)
//{
//    column = rows[index].Split(',');

//    Debug.WriteLine("Sr: " + index + "\nName: " + column[0] + "\n\n\n");

//    index++;
//}

//column = File.ReadAllLines(path);
//while (index < column.Length)
//{
//    column = column[index].Split(',');

//    Debug.WriteLine("Sr: " + index + "\nName: " + rows[0] + "\n\n\n");

//    index++;
//}
//Debug.WriteLine(index);












//builder.Services.AddScoped<IPSQLSrv, PSQLSrv>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
