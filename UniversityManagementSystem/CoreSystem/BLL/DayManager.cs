using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystem.CoreSystem.DAL;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.BLL
{
    public class DayManager
    {
        DayGetway aDayGetWay = new DayGetway();
        public List<Day> GetAllDay()
        {
            return aDayGetWay.GetAllDay();
        }
    }
}