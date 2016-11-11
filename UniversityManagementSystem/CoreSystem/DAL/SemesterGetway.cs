using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.DAL
{
    public class SemesterGetway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["UniversityManagementDBConnectionString"].ConnectionString;

        public List<Semester> GetAllSemester()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Semesters";
            SqlCommand command = new SqlCommand(query, connection);
            List<Semester> aList = new List<Semester>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Semester aSemesterClass = new Semester();
                    aSemesterClass.Id = Convert.ToInt32(reader["Id"].ToString());
                    aSemesterClass.Name = reader["Name"].ToString();
                    aList.Add(aSemesterClass);
                }
                reader.Close();
            }
            connection.Close();
            return aList;
        }
    }
}