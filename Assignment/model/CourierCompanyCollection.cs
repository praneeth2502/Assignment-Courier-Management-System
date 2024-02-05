using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.model
{
    internal class CourierCompanyCollection
    {
        public List<CourierCompany> CourierCompanies {  get; set; }
        public CourierCompanyCollection() 
        {
        
        }
        public CourierCompanyCollection(List<CourierCompany> courierCompanies)
        {
           CourierCompanies = courierCompanies;
        }
    }
}
