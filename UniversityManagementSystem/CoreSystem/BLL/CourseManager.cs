using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystem.CoreSystem.DAL;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.BLL
{
    public class CourseManager
    {
        CourseGetway aCourseGetway = new CourseGetway();

        public int SaveCourse(Course aCourse)
        {
            return aCourseGetway.SaveCourse(aCourse);
        }

        public  List<Course> GetAllCourse()
        {
            return aCourseGetway.GetAllCourse();
        }
    }
}