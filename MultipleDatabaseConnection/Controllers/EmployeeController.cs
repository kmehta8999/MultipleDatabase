using Data.Context;
using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Services.Service;
using System.Data.SqlClient;

namespace DatabaseConnectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
      private readonly IEmployeeSrv _SQLSrv;

         public EmployeeController(IEmployeeSrv sQLSrv)
         {
             _SQLSrv = sQLSrv;
         }
        
        /* private readonly IEmployeeRepo<EmployeeContext,Employee> _Srv;


         public EmployeeController(IEmployeeRepo<EmployeeContext, Employee> Srv)
         {
             _Srv = Srv;
         }*/
       [HttpGet]
       public IEnumerable<Employee> Get()
       {
            //string constring = @"Server=WIN-OG3UJ2VF6B5\SQLEXPRESS;Database=myDatabase;User Id=kalp.mehta;Password=Kmehta@2022";
            //using (SqlConnection con = new SqlConnection(constring))
            //{
                return _SQLSrv.Get();
            //} 
       }
       
    }
}
