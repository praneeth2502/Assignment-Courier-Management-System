using Assignment.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service
{
    internal interface ICourierUserService
    {
        void GetAllUsers();
        void getOrderStatus();
        void  CancelOrder();
        void GetAssignedOrder();
        void GetCourierById();
        void AddCourier();
        void UpdateCourier();
        void PlaceOrder();
    }

}
