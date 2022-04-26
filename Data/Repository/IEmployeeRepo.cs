using Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.WindowsAzure.MediaServices.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
   public interface IEmployeeRepo
     {
         public List<Employee> Get();
     }

            /*
        public interface IEmployeeRepo<TContext, T>
        where TContext : DbContext
        where T : class
        {
         public List<T> GetAll();
        }*/


}
