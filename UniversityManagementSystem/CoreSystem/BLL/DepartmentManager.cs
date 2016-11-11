using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystem.Models;
using UniversityManagementSystem.CoreSystem.DAL; 

namespace UniversityManagementSystem.CoreSystem.BLL
{
    public class DepartmentManager
    {
        DepartmentGetway aDepartmentGetway = new DepartmentGetway();
        public List<Department> GetAllDepartmentInfo()
        {
            return aDepartmentGetway.GetAllDepartmentInfo();
        }

        public int SaveDepartment(Department aDepartmentClass)
        {
            return aDepartmentGetway.SaveDepartment(aDepartmentClass);
        }
    }
}