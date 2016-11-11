using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.CoreSystem.BLL;
using UniversityManagementSystem.CoreSystem.DAL;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Controllers
{
    public class ClassAllocateController : Controller
    {
        CourseManager aCourseManager = new CourseManager();
        //
        // GET: /ClassAllocate/
        public ActionResult CLassroomAllocation()
        {
            DepartmentManager aDepartmentManager = new DepartmentManager();
            //CourseManager aCourseManager = new CourseManager();
            RoomManager aRoomManager = new RoomManager();
            DayManager aDayManager = new DayManager();
            ViewBag.departments = aDepartmentManager.GetAllDepartmentInfo();
            ViewBag.courses = aCourseManager.GetAllCourse();
            ViewBag.rooms = aRoomManager.GetAllRoom();
            ViewBag.days = aDayManager.GetAllDay();
            return View();
        }
         [HttpPost]
        public ActionResult CLassroomAllocation(ClassAllocation aClassAllocation)
        {
            DepartmentManager aDepartmentManager = new DepartmentManager();
            CourseManager aCourseManager = new CourseManager();
            RoomManager aRoomManager = new RoomManager();
            DayManager aDayManager = new DayManager();
            ViewBag.departments = aDepartmentManager.GetAllDepartmentInfo();
            ViewBag.courses = aCourseManager.GetAllCourse();
            ViewBag.rooms = aRoomManager.GetAllRoom();
            ViewBag.days = aDayManager.GetAllDay();
            ClassAllocationManager aClassAllocationManager = new ClassAllocationManager();

            List<ClassAllocation> alist = aClassAllocationManager.GetAllocatedClassInfo();
            if (aClassAllocationManager.CLassroomAllocation(aClassAllocation) > 0)
            {
                ViewBag.message = "Classrooms are Successfully allocated";
            }
            else
            {
                ViewBag.message = "Allocation Failed";
            }
             return View();
        }

        
       
         public JsonResult GetCourseByDepartment(int? departmentId)
         {
             List<Course> courses = aCourseManager.GetAllCourse();
             List<Course> courseList = courses.Where(a => a.DepartmentId == departmentId).ToList();
            return Json(courseList, JsonRequestBehavior.AllowGet);
        }
	}
}