using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class CourseAssign
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string TeacherName { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public double CourseCredit { get; set; }
    }
}