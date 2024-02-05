using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.model
{
    internal class Courier
    {
        private static int nextTrackingNumber = new Random().Next(567823, 999999);
        public int CourierId {  get; set; }
        public string SenderName { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverAddress { get; set; }
        public decimal Weight { get; set; }
        public string Status { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime DeliveryDate { get; set; }
       
        public int ServiceID { get; set; }
        public int EmployeeID { get; set; }
        public int UserId { get; set; }
        public override string ToString()
        {
            return $"CourierId::{CourierId}\t SenderName::{SenderName}\t ReceiverName::{ReceiverName}\t ReceiverAddress::{ReceiverAddress}\t Weight::{Weight}\t Status::{ Status}\t TrackingNo:{TrackingNumber}\t Deliverydate:{DeliveryDate}\t ServiceID::{ ServiceID}\t EmployeeID::{ EmployeeID}\t UserID::{UserId}";
        }
        public Courier()
        { 
        
        }
        public Courier(int courierId, string senderName, string senderAddress, string receiverName, string receiverAddress, decimal weight, string status, string trackingNumber, DateTime deliveryDate,int serviceID, int employeeID, int userId)
        {
            CourierId = courierId;
            SenderName = senderName;
            SenderAddress = senderAddress;
            ReceiverName = receiverName;
            ReceiverAddress = receiverAddress;
            Weight = weight;
            Status = status;
            TrackingNumber = GenerateTrackingNumber();
            DeliveryDate = deliveryDate;
            ServiceID = serviceID;
            EmployeeID = employeeID;
            UserId = userId;
        }
        public static string GenerateTrackingNumber()
        {
            return $"TN{nextTrackingNumber++}";
        }
    }
}
