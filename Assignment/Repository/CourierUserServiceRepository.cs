using Assignment.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Utility;
using System.Net.NetworkInformation;
using System.Linq.Expressions;
using Assignment.Exceptions;
using System.Threading.Channels;
using System.Xml.XPath;
using System.Data;

namespace Assignment.Repository
{
    internal class CourierUserServiceRepository : ICourierUserServiceRepository
    {
        public string connectionString;
        SqlConnection sqlconnection = null;
        SqlCommand cmd = null;
        public CourierUserServiceRepository()
        {
            //sqlconnection = new SqlConnection("Server=LAPTOP-49SCBJN2;Database=CourierDb;Trusted_Connection=True");
            //sqlconnection = new SqlConnection(DBConnUtil.GetConnectionString());
            connectionString = DBConnUtil.GetConnectionString();
            cmd = new SqlCommand();

        }
        public List<User> GetAllUsers()
        {
            List<User> userList = new List<User>();
            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "select *from user_table";
                    cmd.Connection = sqlconnection;
                    sqlconnection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        User user = new User();
                        user.UserID = (int)reader["UserID"];
                        user.UserName = (string)reader["Name"];
                        user.Email = (string)reader["Email"];
                        user.Password = (string)reader["Password"];
                        user.ContactNumber = (string)reader["ContactNumber"];
                        user.Address = (string)reader["Address"];
                        userList.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return userList;
        }

        public string getOrderStatus(string TrackingNumber)
        {
            string Status = null;
            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "select Status from Courier where TrackingNumber=(@Trackingno)";
                    cmd.Parameters.AddWithValue("@Trackingno", TrackingNumber);
                    cmd.Connection = sqlconnection;
                    sqlconnection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        Status = result.ToString();
                    }
                    else
                    {
                        throw new TrackingNumberNotFoundException("Invalid Tracking Number is Found");
                    }
                }
            }
            catch(TrackingNumberNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Status;
        }
        public bool CancelOrder(string TrackingNumber)
        {
            bool Cancel = false;
            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "delete from Courier where TrackingNumber=(@Trackingno)";
                    cmd.Parameters.AddWithValue("@Trackingno", TrackingNumber);
                    cmd.Connection = sqlconnection;
                    sqlconnection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Rows were affected, indicating successful cancellation
                        Cancel = true;
                    
                    }
                    else
                    {
                        throw new TrackingNumberNotFoundException("Invalid Tracking Number is Found");
                    }
                }
            }
            catch(TrackingNumberNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Cancel;

        }

        public List<Courier> GetAssignedOrder(int EmployeeId)
        {
            List <Courier> courierlist = new List<Courier>();
            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "select Courier.* from Courier join Employee on Courier.EmployeeID = Employee.EmployeeID where Employee.EmployeeID = @EmployeeId";
                    cmd.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                    cmd.Connection = sqlconnection;
                    sqlconnection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        while (reader.Read())
                        {
                            Courier courier = new Courier();
                            courier.CourierId = (int)reader["CourierID"];
                            courier.SenderName = (string)reader["SenderName"];
                            courier.SenderAddress = (string)reader["SenderAddress"];
                            courier.ReceiverName = (string)reader["ReceiverName"];
                            courier.ReceiverAddress = (string)reader["ReceiverAddress"];
                            courier.Weight = (decimal)reader["Weight"];
                            courier.Status = (string)reader["Status"];
                            courier.TrackingNumber = (string)reader["TrackingNumber"];
                            courier.DeliveryDate = (DateTime)reader["DeliveryDate"];
                            courier.ServiceID = (int)reader["ServiceID"];
                            courier.EmployeeID = (int)reader["EmployeeID"];
                            courier.UserId = (int)reader["UserID"];
                            courierlist.Add(courier);
                        }
                    }
                    else
                    {
                        throw new InvalidEmployeeIdException("Invalid EmployeeID is found");
                    }
                }
                
            }
            catch(InvalidEmployeeIdException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return courierlist;

        }
        //
        public List<Courier> GetCourierById(int CourierId)
        {
            List<Courier> courierlist = new List<Courier>();
            using (SqlConnection sqlconnection = new SqlConnection(connectionString))
            {
                cmd.CommandText = "select *from Courier where CourierID=@CourierID";
                cmd.Parameters.AddWithValue("@CourierID", CourierId);
                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    Courier courier = new Courier();
                    courier.CourierId = (int)reader["CourierID"];
                    courier.SenderName = (string)reader["SenderName"];
                    courier.SenderAddress = (string)reader["SenderAddress"];
                    courier.ReceiverName = (string)reader["ReceiverName"];
                    courier.ReceiverAddress = (string)reader["ReceiverAddress"];
                    courier.Weight = (decimal)reader["Weight"];
                    courier.Status = (string)reader["Status"];
                    courier.TrackingNumber = (string)reader["TrackingNumber"];
                    courier.DeliveryDate = (DateTime)reader["DeliveryDate"];
                    courier.ServiceID = (int)reader["ServiceID"];
                    courier.EmployeeID = (int)reader["EmployeeID"];
                    courier.UserId = (int)reader["UserID"];
                    courierlist.Add(courier);

                }

            }
            return courierlist;
        }
        public int AddCourier(Courier courier)
        {
            int addCourierStatus = 0;
            using (SqlConnection sqlconnection = new SqlConnection(connectionString))
            {
                cmd.CommandText = "INSERT INTO Courier (CourierId, SenderName, SenderAddress, ReceiverName, ReceiverAddress, Weight, Status, TrackingNumber, DeliveryDate) " +
                      "VALUES (@CourierId, @SenderName, @SenderAddress, @ReceiverName, @ReceiverAddress, @Weight, @Status, @TrackingNumber, @DeliveryDate)";
                cmd.Parameters.AddWithValue("@CourierId", courier.CourierId);
                cmd.Parameters.AddWithValue("@SenderName", courier.SenderName);
                cmd.Parameters.AddWithValue("@SenderAddress", courier.SenderAddress);
                cmd.Parameters.AddWithValue("@ReceiverName", courier.ReceiverName);
                cmd.Parameters.AddWithValue("@ReceiverAddress", courier.ReceiverAddress);
                cmd.Parameters.AddWithValue("@Weight", courier.Weight);
                cmd.Parameters.AddWithValue("@Status", courier.Status);
                cmd.Parameters.AddWithValue("@TrackingNumber", courier.TrackingNumber);
                cmd.Parameters.AddWithValue("@DeliveryDate", courier.DeliveryDate);
                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                addCourierStatus = cmd.ExecuteNonQuery();
            }
            return addCourierStatus;
        }
        public int UpdateCourier(Courier courier)
        {
            int updateCourierStatus = 0;
            using (SqlConnection sqlconnection = new SqlConnection(connectionString))
            {
                cmd.CommandText = "UPDATE Courier SET Status=@Status where CourierID=@CourierID";
                cmd.Parameters.AddWithValue("@Status", courier.Status);
                cmd.Parameters.AddWithValue("@CourierID", courier.CourierId);
                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                updateCourierStatus = cmd.ExecuteNonQuery();
            }
            return updateCourierStatus;
        }
        public string PlaceOrder(Courier courier)
        {
            courier.TrackingNumber=Courier.GenerateTrackingNumber();
            return courier.TrackingNumber;
        }

    }
}
