using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystem.CoreSystem.DAL;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.BLL
{
    public class TeacherManager
    {
        TeacherGetway aTeacherGetway = new TeacherGetway();

        public int SaveTeacher(Teacher aTeacher)
        {
            return aTeacherGetway.SaveTeacher(aTeacher);
        }

        public List<Teacher> GetAllTeachers()
        {
            return aTeacherGetway.GetAllTeachers();
        }
    }
}