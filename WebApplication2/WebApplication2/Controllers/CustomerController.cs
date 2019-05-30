using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleProject.IRepository;

namespace SampleProject.Controllers
{
    [Route("api/Customer")]
 

    public class CustomerController : ControllerBase
    {
        private ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;

        }
        [HttpGet]
        public string GetName()
        {
            string name = customerRepository.GetCustomer();
            return name;
        }
    }
}