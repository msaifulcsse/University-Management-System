using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystem.CoreSystem.DAL;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.BLL
{
    public class DesignationManager
    {
        DesignationGetway aDesignationGetWay = new DesignationGetway();
        public List<Designation> GetAllDesignations()
        {
            return aDesignationGetWay.GetAllDesignations();
        }
    }
}