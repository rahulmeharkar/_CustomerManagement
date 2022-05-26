using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataCustomerManagement.Models
{
    [Table("customers", Schema = "dbo")]
    public class CustomerModel
    {
        [Key]
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public string customer_phone { get; set; }
        public string customer_address { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> customer_dob { get; set; }
    }
}
