using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.DAL
{
    public class DayGetway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["UniversityManagementDBConnectionString"].ConnectionString;

        public List<Day> GetAllDay()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Day";
            SqlCommand command = new SqlCommand(query, connection);
            List<Day> aList = new List<Day>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Day aDayClass = new Day();
                    aDayClass.Id = Convert.ToInt32(reader["Id"].ToString());
                    aDayClass.DayName = reader["DayName"].ToString();
                    aList.Add(aDayClass);
                }
                reader.Close();
            }
            connection.Close();
            return aList;
        }
    }
}