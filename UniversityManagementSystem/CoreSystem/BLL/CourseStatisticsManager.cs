using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystem.CoreSystem.DAL;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.BLL
{
    public class CourseStatisticsManager
    {
        CourseStatisticsGetway aGetway = new CourseStatisticsGetway();

        public List<CourseStatistics> GetAllCourseStatistics()
        {
            return aGetway.GetAllCourseStatistics();
        }
    }
}