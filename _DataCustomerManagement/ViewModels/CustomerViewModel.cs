using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _DataCustomerManagement.Models
{
    public class CustomerViewModel
    {
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public string customer_phone { get; set; }
        public string customer_address { get; set; }
        public DateTime customer_dob { get; set; }
    }
}