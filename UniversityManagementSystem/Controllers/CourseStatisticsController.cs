using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.CoreSystem.BLL;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Controllers
{
    public class CourseStatisticsController : Controller
    {
        public ActionResult CourseStatistics()
        {
            DepartmentManager aDepartmentManager = new DepartmentManager();
            CourseStatisticsManager aCourseStaticManager = new CourseStatisticsManager();
            ViewBag.departments = aDepartmentManager.GetAllDepartmentInfo();
            ViewBag.Coursestatistics = aCourseStaticManager.GetAllCourseStatistics();
            return View();
        }
        [HttpPost]
        public ActionResult CourseStatistics(CourseStatistics aCourseStatics)
        {
            DepartmentManager aDepartmentManager = new DepartmentManager();
            CourseStatisticsManager aCourseStaticManager = new CourseStatisticsManager();
            ViewBag.departments = aDepartmentManager.GetAllDepartmentInfo();
            ViewBag.Coursestatistics = aCourseStaticManager.GetAllCourseStatistics();
            return View();
        }
    }
}