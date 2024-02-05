using Assignment.model;
using Assignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service
{
    internal class CourierUserService : ICourierUserService
    {
        readonly ICourierUserServiceRepository _courierUserServiceRepository;
        //constructor
        public CourierUserService()
        {
            _courierUserServiceRepository = new CourierUserServiceRepository();
        }
    
        public void GetAllUsers()
        {
            List <User> allUsers = _courierUserServiceRepository.GetAllUsers();
            foreach (User user in allUsers) 
            {
                Console.WriteLine(user);
            }
        }
        public void getOrderStatus()
        {
            Console.WriteLine("Enter the Tracking number:");
            string trackingNumber = Console.ReadLine();
            string orderstatus = _courierUserServiceRepository.getOrderStatus(trackingNumber);
            Console.WriteLine(orderstatus);
        }
        public void CancelOrder()
        {
            Console.WriteLine("Enter the Tracking number:");
            string trackingNo =Console.ReadLine();
            bool CancelStatus = _courierUserServiceRepository.CancelOrder(trackingNo);
            Console.WriteLine(CancelStatus);
        }

        public void GetAssignedOrder()
        {
            Console.WriteLine("Enter The EmployeeID");
            int StaffId = int.Parse(Console.ReadLine());
            List<Courier> orderlist = _courierUserServiceRepository.GetAssignedOrder(StaffId);
            foreach(Courier order in orderlist)
            {
                Console.WriteLine(order);
            }
        }

        public void GetCourierById()
        {
            Console.WriteLine("Enter The CourierID");
            int courierId = int.Parse(Console.ReadLine());
            List<Courier> courierlist = _courierUserServiceRepository.GetCourierById(courierId);
            foreach (Courier order in courierlist)
            {
                Console.WriteLine(order);
            }
        }
        public void AddCourier()
        {
            Courier courier = new Courier();
            Console.WriteLine("Enter CourierId:");
            courier.CourierId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SenderName:");
            courier.SenderName = Console.ReadLine();
            Console.WriteLine("Enter SenderAddress:");
            courier.SenderAddress = Console.ReadLine();
            Console.WriteLine("Enter ReceiverName:");
            courier.ReceiverName = Console.ReadLine();
            Console.WriteLine("Enter ReceiverAddress:");
            courier.ReceiverAddress = Console.ReadLine();
            Console.WriteLine("Enter Weight:");
            courier.Weight = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Status:");
            courier.Status = Console.ReadLine();
            Console.WriteLine("Enter TrackingNumber:");
            courier.TrackingNumber = Console.ReadLine();
            Console.WriteLine("Enter DeliveryDate (YYYY-MM-DD):");
            courier.DeliveryDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter ServiceID:");
            courier.ServiceID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter EmployeeID:");
            courier.EmployeeID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter UserId:");
            courier.UserId = int.Parse(Console.ReadLine());
            int AddCourierStatus = _courierUserServiceRepository.AddCourier(courier);
            if(AddCourierStatus > 0 )
            {
                Console.WriteLine("Courier record is added suvvessfully");
            }

        }
        public void UpdateCourier()
        {
            Courier courier = new Courier();
            Console.WriteLine("Enter CourierId:");
            courier.CourierId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Status:");
            courier.Status = Console.ReadLine();
            int UpdateCourierStatus = _courierUserServiceRepository.UpdateCourier(courier);
            if(UpdateCourierStatus > 0 )
            {
                Console.WriteLine("Courier details updated Successfully");
            }
        }

        public void PlaceOrder()
        {
            Courier courier =new Courier();
            Console.WriteLine("Enter CourierId:");
            courier.CourierId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SenderName:");
            courier.SenderName = Console.ReadLine();
            Console.WriteLine("Enter SenderAddress:");
            courier.SenderAddress = Console.ReadLine();
            Console.WriteLine("Enter ReceiverName:");
            courier.ReceiverName = Console.ReadLine();
            Console.WriteLine("Enter ReceiverAddress:");
            courier.ReceiverAddress = Console.ReadLine();
            Console.WriteLine("Enter Weight:");
            courier.Weight = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Status:");
            courier.Status = Console.ReadLine();
            Console.WriteLine("Enter DeliveryDate (YYYY-MM-DD):");
            courier.DeliveryDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter ServiceID:");
            courier.ServiceID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter EmployeeID:");
            courier.EmployeeID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter UserId:");
            courier.UserId = int.Parse(Console.ReadLine());
            string trackingNumber = _courierUserServiceRepository.PlaceOrder(courier);

            Console.WriteLine($"Tracking Number: {trackingNumber}");

        }

    }
}
