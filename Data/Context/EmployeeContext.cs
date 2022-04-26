using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class EmployeeContext:DbContext
    {
        private readonly string _connectionString;

        public EmployeeContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        //  public EmployeeContext(DbContextOptions<EmployeeContext> options): base(options) { }


        public virtual DbSet<Employee> employee { get; set; }
    }
}
