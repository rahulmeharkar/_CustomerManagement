using _DataCustomerManagement.Models;
using System.Collections.Generic;

namespace _DataCustomerManagement.Interfases
{
    public interface ICustomerActions
    {
        IEnumerable<CustomerModel> GetAll();
        int Add(CustomerViewModel _cutomers);
        bool SignInCheck(UserViewModel userModel);
        int UpdateCustomer(CustomerViewModel _customerViewModel);

        int DeleteCustomer(int customerid);
    }
}
