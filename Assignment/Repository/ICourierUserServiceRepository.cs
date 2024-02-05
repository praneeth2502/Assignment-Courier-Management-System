using Assignment.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repository
{
    internal interface ICourierUserServiceRepository
    {
        List<User> GetAllUsers();
        string getOrderStatus(string TrackingNumber);
        bool CancelOrder(string TrackingNumber);

        List<Courier> GetAssignedOrder(int EmployeeId);

        List<Courier> GetCourierById(int CourierId);
        int AddCourier(Courier courier);
        int UpdateCourier(Courier courier);
        string  PlaceOrder(Courier courier);
    }
}
