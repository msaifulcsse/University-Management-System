using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystem.CoreSystem.DAL;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.BLL
{
    public class RoomManager
    {
        RoomGetway aRoomGetWay = new RoomGetway();
        public List<Room> GetAllRoom()
        {
            return aRoomGetWay.GetAllRoom();
        }
    }
}