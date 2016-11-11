using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.CoreSystem.BLL;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult SaveCourse()
        {
            DepartmentManager aDepartmentManager = new DepartmentManager();
            SemesterManager aSemesterManager = new SemesterManager();
            ViewBag.departments = aDepartmentManager.GetAllDepartmentInfo();
            ViewBag.semesters = aSemesterManager.GetAllSemester();
            return View();
        }
        [HttpPost]
        public ActionResult SaveCourse(Course aCourse)
        {
            DepartmentManager aDepartmentManager = new DepartmentManager();
            SemesterManager aSemesterManager = new SemesterManager();
            ViewBag.departments = aDepartmentManager.GetAllDepartmentInfo();
            ViewBag.semesters = aSemesterManager.GetAllSemester();
            CourseManager aCourseManager = new CourseManager();

            List<Course> alist = aCourseManager.GetAllCourse();
            var coursecode = alist.FirstOrDefault(c => c.Code == aCourse.Code);
            var coursename = alist.FirstOrDefault(n => n.Name == aCourse.Name);

            if (coursecode != null || coursename != null)
            {
                if (coursecode != null && coursename != null)
                {
                    ViewBag.message = "Code and Name Already Exist";
                }
                else if (coursecode != null)
                {
                    ViewBag.message = "Code Already Exist";
                }
                else
                {
                    ViewBag.message = "Name Already Exist";
                }
            }
            else
            {
                if (aCourseManager.SaveCourse(aCourse) > 0)
                {
                    ViewBag.message = "Course Saved Successfully";
                }
                else
                {
                    ViewBag.message = "Save Failed";
                }
            }
            return View();
        }
    }
}