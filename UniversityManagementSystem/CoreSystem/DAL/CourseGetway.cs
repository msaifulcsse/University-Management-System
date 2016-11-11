using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.DAL
{
    public class CourseGetway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["UniversityManagementDBConnectionString"].ConnectionString;


        public int SaveCourse(Course aCourse)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Courses (Code,Name,Credit,Description,DepartmentId,SemesterId) VALUES (@Code,@Name,@Credit,@Description,@DepartmentId,@SemesterId)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Code", aCourse.Code);
            command.Parameters.AddWithValue("@Name", aCourse.Name);
            command.Parameters.AddWithValue("@Credit", aCourse.Credit);
            command.Parameters.AddWithValue("@Description", aCourse.Description);
            command.Parameters.AddWithValue("@DepartmentId", aCourse.DepartmentId);
            command.Parameters.AddWithValue("@SemesterId", aCourse.SemesterId);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }


        public List<Course> GetAllCourse()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Courses";
            SqlCommand command = new SqlCommand(query, connection);
            List<Course> aList = new List<Course>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Course aCourseClass = new Course();
                    aCourseClass.Id = Convert.ToInt32(reader["Id"].ToString());
                    aCourseClass.Code = reader["Code"].ToString();
                    aCourseClass.Name = reader["Name"].ToString();
                    aCourseClass.Credit = Convert.ToDouble(reader["Credit"].ToString());
                    aCourseClass.Description = reader["Description"].ToString();
                    aCourseClass.DepartmentId = Convert.ToInt32(reader["DepartmentId"].ToString());
                    aCourseClass.SemesterId = Convert.ToInt32(reader["SemesterId"].ToString());
                    aList.Add(aCourseClass);
                }
                reader.Close();
            }
            connection.Close();
            return aList;
        }
    }
}