using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.DAL
{
    public class CourseStatisticsGetway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["UniversityManagementDBConnectionString"].ConnectionString;

        public List<CourseStatistics> GetAllCourseStatistics()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM course_statics";
            SqlCommand command = new SqlCommand(query, connection);
            List<CourseStatistics> aList = new List<CourseStatistics>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CourseStatistics aCourseStatics = new CourseStatistics();
                    aCourseStatics.CourseCode = reader["CourseCode"].ToString();
                    aCourseStatics.CourseName = reader["CourseName"].ToString();
                    aCourseStatics.Credit = Convert.ToDouble(reader["Credit"].ToString());
                    aCourseStatics.SemesterName = reader["SemesterName"].ToString();
                    aCourseStatics.DepartmentId = Convert.ToInt32(reader["DepartmentId"].ToString());
                    aCourseStatics.TeacherName = reader["Name"].ToString();
                    aList.Add(aCourseStatics);
                }
                reader.Close();
            }
            connection.Close();
            return aList;
        }
    }
}