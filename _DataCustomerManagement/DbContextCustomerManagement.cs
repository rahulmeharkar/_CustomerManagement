using _DataCustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataCustomerManagement
{
    public class DbContextCustomerManagement : DbContext
    {
        public DbContextCustomerManagement() : base(nameOrConnectionString: "_customerManagement") 
        {
            //Database.SetInitializer<DbContextCustomerManagement>(null);
        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
    }
}
