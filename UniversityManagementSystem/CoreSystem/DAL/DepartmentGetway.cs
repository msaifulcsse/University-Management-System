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
    public class DepartmentGetway
    {
        private string connectionString =
    WebConfigurationManager.ConnectionStrings["UniversityManagementDBConnectionString"].ConnectionString;
        public int SaveDepartment(Department aDepartmentClass)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Departments (Code,Name) VALUES(@Code,@Name)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Code", aDepartmentClass.Code);
            command.Parameters.AddWithValue("@Name", aDepartmentClass.Name);

            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }

        public List<Department> GetAllDepartmentInfo()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT Id,Code,Name FROM Departments";
            SqlCommand command = new SqlCommand(query, connection);
            List<Department> aList = new List<Department>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Department aDepartment = new Department();
                    aDepartment.Id = Convert.ToInt32(reader["Id"].ToString());
                    aDepartment.Code = reader["Code"].ToString();
                    aDepartment.Name = reader["Name"].ToString();
                    aList.Add(aDepartment);
                }
            }
            return aList;
        }
    }
}