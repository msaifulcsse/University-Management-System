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
    public class TeacherGetway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["UniversityManagementDBConnectionString"].ConnectionString;

        public int SaveTeacher(Teacher aTeacher)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Teachers (Name,Address,Email,ContactNo,DesignationId,DepartmentId,CreditTobeTaken,RemainingCredit) VALUES (@Name,@Address,@Email,@ContactNo,@DesignationId,@DepartmentId,@CreditTobeTaken,@RemainingCredit) ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", aTeacher.Name);
            command.Parameters.AddWithValue("@Address", aTeacher.Address);
            command.Parameters.AddWithValue("@Email", aTeacher.Email);
            command.Parameters.AddWithValue("@ContactNo", aTeacher.ContactNo);
            command.Parameters.AddWithValue("@DesignationId", aTeacher.DesignationId);
            command.Parameters.AddWithValue("@DepartmentId", aTeacher.DepartmentId);
            command.Parameters.AddWithValue("@CreditTobeTaken", aTeacher.CreditTobeTaken);
            command.Parameters.AddWithValue("@RemainingCredit", aTeacher.RemainingCredit);

            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }

        public List<Teacher> GetAllTeachers()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Teachers";
            SqlCommand command = new SqlCommand(query, connection);
            List<Teacher> aList = new List<Teacher>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Teacher aTeacher = new Teacher();
                    aTeacher.Id = Convert.ToInt32(reader["Id"].ToString());
                    aTeacher.Name = reader["Name"].ToString();
                    aTeacher.Address = reader["Address"].ToString();
                    aTeacher.Email = reader["Email"].ToString();
                    aTeacher.ContactNo = reader["ContactNo"].ToString();
                    aTeacher.DesignationId = Convert.ToInt32(reader["DesignationId"].ToString());
                    aTeacher.DepartmentId = Convert.ToInt32(reader["DepartmentId"].ToString());
                    aTeacher.CreditTobeTaken = Convert.ToDouble(reader["CreditTobeTaken"].ToString());
                    aTeacher.RemainingCredit = Convert.ToDouble(reader["RemainingCredit"].ToString());
                    aList.Add(aTeacher);
                }
                reader.Close();
            }
            connection.Close();
            return aList;
        }
    }
}