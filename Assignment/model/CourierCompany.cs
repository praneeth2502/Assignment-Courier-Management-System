using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.model
{
    internal class CourierCompany
    {
        public string CompanyName { get; set; }
        public List<Courier> CourierDetails { get; set; }
        public List<Employee> EmployeeDetails { get; set; }
        public List<Location> LocationDetails { get; set; }

        public override string ToString()
        {
            return $"CompanyName :: {CompanyName}\t  CourierDetails :: {CourierDetails}\t  EmployeeDetails :: {EmployeeDetails}\t  LocationDetails :: {LocationDetails}";
        }
        public CourierCompany()
        {
        
        }
        public CourierCompany(string companyName, List<Courier> courierDetails, List<Employee> employeeDetails,
                      List<Location> locationDetails)
        {
            CompanyName = companyName;
            CourierDetails = courierDetails;
            EmployeeDetails = employeeDetails;
            LocationDetails = locationDetails;
        }
    }
}
