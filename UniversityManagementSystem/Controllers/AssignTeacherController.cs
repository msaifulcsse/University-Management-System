using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityManagementSystem.Controllers
{
    public class AssignTeacherController : Controller
    {
        // GET: AssignTeacher
        public ActionResult CourseAssignTeacher()
        {
            return View();
        }
    }
}