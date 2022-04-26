using Data.Context;
using Data.Model;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.WindowsAzure.MediaServices.Client;
using Services.Interface;

namespace Services.Service
{
    public class EmployeeSrv : IEmployeeSrv
     {
         private readonly IEmployeeRepo _sRepo;

         public EmployeeSrv(IEmployeeRepo sRepo)
         {
             _sRepo = sRepo;
         }
        

        public List<Employee> Get()
        {
            return _sRepo.Get();
        }
    }

    /*
   public class EmployeeSrv<TContext, T> : IEmployeeRepo<TContext, T>
  where TContext : DbContext
  where T : class
   {

       private readonly IEmployeeRepo<TContext, T> _eRepo;
       private DbSet<T> entities;


       public EmployeeSrv(IEmployeeRepo<TContext, T> eRepo)
       {
           _eRepo = eRepo;
           //entities = context.Set<T>();
       }
       public List<T> GetAll()
       {
           return _eRepo.GetAll();
       }
    }*/

}