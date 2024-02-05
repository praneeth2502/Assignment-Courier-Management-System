using Assignment.model;
using Assignment.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Utility;
namespace Assignment.Repository
{
    internal class CourierAdminServiceRepository: ICourierAdminServiceRepository
    {
        public string connectionString;
        //sql connection class
        SqlConnection sqlconnection = null;
        SqlCommand cmd = null;
        public CourierAdminServiceRepository()
        {
            connectionString = DBConnUtil.GetConnectionString();
            cmd = new SqlCommand();
        }
        public int AddCourierStaff(Employee employee)
        {
            using (SqlConnection sqlconnection = new SqlConnection(connectionString))
            {
                cmd.CommandText = "insert into Employee values(@EmployeeID,@Name,@Email,@ContactNumber,@Role,@Salary)";
                cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                cmd.Parameters.AddWithValue("@Name", employee.EmployeeName);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@ContactNumber", employee.ContactNumber);
                cmd.Parameters.AddWithValue("@Role", employee.Role);
                cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                int addCourierStaffStatus = cmd.ExecuteNonQuery();
                sqlconnection.Close();
                return addCourierStaffStatus;
            }
        }

    }
}
