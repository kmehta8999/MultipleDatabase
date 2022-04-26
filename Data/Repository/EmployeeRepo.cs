using Data.Connection_String;
using Data.Context;
using Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.WindowsAzure.MediaServices.Client;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
 public class EmployeeRepo:IEmployeeRepo
     {
       

        //private readonly EmployeeContext _context;

        // public EmployeeRepo(EmployeeContext context)
        // {
        //     _context = context;
        // }
            public List<int> DBIds = new List<int>();
            public List<Employee> Employees=new List<Employee>();

        public List<Employee> Get()
        {
            DBIds.Add(1);
            DBIds.Add(2);

         
          
            for (int i = 0; i < DBIds.Count; i++)
            {
                //Employees.Add(new Employee { id = 6, name = "Test" });
                ConnectionString connectionString = new ConnectionString(DBIds[i]);
                EmployeeContext _context = new EmployeeContext(connectionString.getConnectionString());
                var empList = from emp in _context.employee select emp;

                Employees.AddRange(empList.ToList());
            }

            //var TempEmployees = Employees;

           // var str = from temp in TempEmployees where (temp.id && temp.) select Temp

            return Employees.DistinctBy(i=> new{i.id,i.name}).ToList();
         }
     }

    /*
    public class EmployeeRepo<TContext, T> : IEmployeeRepo<TContext, T>
    where TContext : DbContext
    where T : class
    {

        private readonly TContext _context;
        private DbSet<T> entities;


        public EmployeeRepo(TContext context)
        {
            _context = context;
            entities = context.Set<T>();
        }
        public List<T> GetAll()
        {
            Debug.WriteLine(entities.AsNoTracking().ToList());
            return entities.AsNoTracking().ToList();
        }
    }*/

}
