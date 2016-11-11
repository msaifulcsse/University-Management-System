using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class CourseStatistics
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public double Credit { get; set; }
        public string SemesterName { get; set; }
        public int DepartmentId { get; set; }
        public string TeacherName { get; set; }
    }
}