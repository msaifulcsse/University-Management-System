using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.DAL
{
    public class ClassAllocationGetway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["UniversityManagementDBConnectionString"].ConnectionString;


        public int CLassroomAllocation(ClassAllocation aClassAllocation)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //string query = "INSERT INTO ClassAllocation (DepartmentId,CourseId,RoomId,DayId,FromTime,ToTime) VALUES (@DepartmentId,@CourseId,@RoomId,@DayId,@FromTime,@ToTime)";
            string query = "INSERT INTO ClassAllocation (DepartmentId,CourseId,RoomId,DayId,FromTimeHour,FromTimeMinute,FromTimeFormat,ToTimeHour,ToTimeMinute,ToTimeFormat) VALUES ('" + aClassAllocation.DepartmentId + "','" + aClassAllocation.CourseId + "','" + aClassAllocation.RoomId + "','" + aClassAllocation.DayId + "','" + aClassAllocation.FromTimeHour+ "','"+aClassAllocation.FromTimeMinute+"','"+aClassAllocation.FromTimeFormat+"','"+aClassAllocation.ToTimeHour+"','"+aClassAllocation.ToTimeMinute+"','"+aClassAllocation.ToTimeFormat+"')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }


        public List<ClassAllocation> GetAllocatedClassInfo()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM ClassAllocation";
            SqlCommand command = new SqlCommand(query, connection);
            List<ClassAllocation> aList = new List<ClassAllocation>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ClassAllocation aClassAllocationClass = new ClassAllocation();
                    aClassAllocationClass.Id = Convert.ToInt32(reader["Id"].ToString());
                    aClassAllocationClass.DepartmentId = Convert.ToInt32(reader["DepartmentId"].ToString());
                    aClassAllocationClass.CourseId = Convert.ToInt32(reader["CourseId"].ToString());
                    aClassAllocationClass.RoomId = Convert.ToInt32(reader["RoomId"].ToString());
                    aClassAllocationClass.DayId = Convert.ToInt32(reader["DayId"].ToString());
                    aClassAllocationClass.FromTimeHour = reader["FromTimeHour"].ToString();
                    aClassAllocationClass.FromTimeMinute = reader["FromTimeMinute"].ToString();
                    aClassAllocationClass.FromTimeFormat = reader["FromTimeFormat"].ToString();
                    aClassAllocationClass.ToTimeHour = reader["ToTimeHour"].ToString();
                    aClassAllocationClass.ToTimeMinute = reader["ToTimeMinute"].ToString();
                    aClassAllocationClass.ToTimeFormat = reader["ToTimeFormat"].ToString();
                    aList.Add(aClassAllocationClass);
                }
                reader.Close();
            }
            connection.Close();
            return aList;
        }
    }
}