using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.DAL
{
    public class RoomGetway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["UniversityManagementDBConnectionString"].ConnectionString;

        public List<Room> GetAllRoom()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Rooms";
            SqlCommand command = new SqlCommand(query, connection);
            List<Room> aList = new List<Room>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Room aRoomClass = new Room();
                    aRoomClass.Id = Convert.ToInt32(reader["Id"].ToString());
                    aRoomClass.RoomNo = reader["RoomNo"].ToString();
                    aList.Add(aRoomClass);
                }
                reader.Close();
            }
            connection.Close();
            return aList;
        }
    }
}