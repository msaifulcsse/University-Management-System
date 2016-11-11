using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystem.CoreSystem.DAL;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.BLL
{
    public class SemesterManager
    {
        SemesterGetway aSemesterGetWay = new SemesterGetway();
        public List<Semester> GetAllSemester()
        {
            return aSemesterGetWay.GetAllSemester();
        }
    }
}