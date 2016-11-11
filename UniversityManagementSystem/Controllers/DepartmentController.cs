using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.CoreSystem.BLL;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentManager aDepartmentManager = new DepartmentManager();

        public ActionResult SaveDepartment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveDepartment(Department aDepartment)
        {
            List<Department> alist = aDepartmentManager.GetAllDepartmentInfo();
            var departmnetcode = alist.FirstOrDefault(c => c.Code == aDepartment.Code);
            var departmentname = alist.FirstOrDefault(n => n.Name == aDepartment.Name);

            //if (aDepartment.Code == " " && aDepartment.Name == " ")
            //{
            //    return ViewBag.message = "Insert Both Values";
            //}
            //else
            //{
                if (departmnetcode != null || departmentname != null)
                {
                    if (departmnetcode != null && departmentname != null)
                    {
                        ViewBag.message = "Code and Name Already Exist";
                    }
                    else if (departmnetcode != null)
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
                    if (aDepartmentManager.SaveDepartment(aDepartment) > 0)
                    {
                        ViewBag.message = "Department Saved Successfully";
                    }
                    else
                    {
                        ViewBag.message = "Save Failed";
                    }
                }
                return View();
            //}
        }

        public ActionResult ShowAllDepartment()
        {
            ViewBag.alldepartment = aDepartmentManager.GetAllDepartmentInfo();
            return View();
        }
    }
}