using _DataCustomerManagement.Interfases;
using _DataCustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataCustomerManagement.Repositorys
{
    public class RepositoryCustomerActions : ICustomerActions
    {
        private readonly DbContextCustomerManagement dbContextCustomerManagement;
        public RepositoryCustomerActions(DbContextCustomerManagement _dbContextCustomerManagement)
        {
            dbContextCustomerManagement = _dbContextCustomerManagement;
        }
        public int Add(CustomerViewModel _cutomers)
        {
            try
            {
                CustomerModel mod = new CustomerModel()
                {
                    customer_name = _cutomers.customer_name,
                    customer_phone = _cutomers.customer_phone,
                    customer_address = _cutomers.customer_address,
                    customer_dob = _cutomers.customer_dob
                };

                dbContextCustomerManagement.Customers.Add(mod);
                dbContextCustomerManagement.SaveChanges();
                return mod.customer_id;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
                return 0;
            }
        }

        public IEnumerable<CustomerModel> GetAll()
        {
           return dbContextCustomerManagement.Customers.ToList();
        }

        public bool SignInCheck(UserViewModel userModel)
        {
            bool isvalid = dbContextCustomerManagement.Users.Any(x => x.user_email == userModel.user_email && x.user_password == userModel.user_password);
            if (isvalid == true)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
