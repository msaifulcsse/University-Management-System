using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.DAL
{
    public class DesignationGetway
    {
        private string connectionString =
            WebConfigurationManager.ConnectionStrings["UniversityManagementDBConnectionString"].ConnectionString;

        public List<Designation> GetAllDesignations()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Designations";
            SqlCommand command = new SqlCommand(query, connection);
            List<Designation> aList = new List<Designation>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Designation aDesignation = new Designation();
                    //aDesignation.Id = Convert.ToInt32(reader["Id"].ToString());
                    aDesignation.Name = reader["Name"].ToString();
                    aList.Add(aDesignation);
                }
                reader.Close();
            }
            connection.Close();
            return aList;
        }

    }
}