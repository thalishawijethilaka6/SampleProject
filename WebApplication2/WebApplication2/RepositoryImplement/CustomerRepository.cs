using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleProject.IRepository;

namespace SampleProject.RepositoryImplement
{
    public class CustomerRepository : ICustomerRepository
    {
        public string GetCustomer()
        {
            return "Thalisha";
        }
    }
}
