using System;
using System.Data.Entity;
using System.Linq;

namespace Web_API_Servics.Models
{
    public class myDbContext : DbContext
    {
        public myDbContext()
            : base(@"Data source = SABER ; User Id = saber ; Password = 123456789;Initial catalog = DBaseCompany;")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

    }


}