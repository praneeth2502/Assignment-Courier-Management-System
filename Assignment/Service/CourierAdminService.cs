using Assignment.Exceptions;
using Assignment.model;
using Assignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service
{
    internal class CourierAdminService:ICourierAdminService
    {
        readonly ICourierAdminServiceRepository _courierAdminServiceRepository;

        public CourierAdminService()
        {
            _courierAdminServiceRepository =new CourierAdminServiceRepository();
        }
        public void AddCourierStaff()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter EmployeeId::");
            employee.EmployeeID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employeename:");
            employee.EmployeeName= Console.ReadLine();
            Console.WriteLine("Enter Employeeemail");
            employee.Email = Console.ReadLine();
            Console.WriteLine("Enter Contact NUmber");
            employee.ContactNumber = Console.ReadLine();
            Console.WriteLine("Enter Role:");
            employee.Role= Console.ReadLine();
            Console.WriteLine("Enter Salary:");
            employee.Salary=decimal.Parse(Console.ReadLine());
            int addCourierStaffStatus = _courierAdminServiceRepository.AddCourierStaff(employee);
            if(addCourierStaffStatus >0)
            {
                Console.WriteLine("Details of new staff member addeded successfully and id is :"+employee.EmployeeID);
             }
            

        }
    }
}
