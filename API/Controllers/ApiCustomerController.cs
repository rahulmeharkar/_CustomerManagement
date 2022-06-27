using _DataCustomerManagement.Interfases;
using _DataCustomerManagement.Models;
using _DataCustomerManagement.Repositorys;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ApiCustomerController : ApiController
    {
        private RepositoryCustomerActions customerAction = null;

        public ApiCustomerController()
        {
            customerAction = new RepositoryCustomerActions();
        }

        [HttpGet]
        [Route("api/listallcustomer")]
        public IHttpActionResult GetAllEmployeeRecord()
        {
             return Ok(customerAction.GetAll());
        }

        [HttpPost]
        [Route("api/addcustomerrecord")]
        public IHttpActionResult AddCustomerRecord(JObject obj)
        {
            var s = JsonConvert.DeserializeObject<List<CustomerViewModel>>(obj["models"].ToString());
            int j = 0;
            j = customerAction.Add(s[0]);
            if (j >= 1)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("api/updatecustomer")]
        public IHttpActionResult UpdateCustomer(JObject obj)
        {
            var s = JsonConvert.DeserializeObject<List<CustomerViewModel>>(obj["models"].ToString());
            if (customerAction.UpdateCustomer(s[0]) >= 1)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("api/deletecustomer")]
        public IHttpActionResult DeleteCustomer(JObject obj)
        {
            var s = JsonConvert.DeserializeObject<List<CustomerViewModel>>(obj["models"].ToString());
            if (customerAction.DeleteCustomer(s[0].customer_id) >= 1)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
