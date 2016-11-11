using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class ClassAllocation
    {
        public int Id { set; get; }
        public int DepartmentId { get; set; }
        public int CourseId { get; set; }
        public int RoomId { get; set; }
        public int DayId { get; set; }
        public string FromTimeHour { get; set; }
        public string FromTimeMinute { get; set; }
        public string FromTimeFormat { get; set; }
        public string ToTimeHour { get; set; }
        public string ToTimeMinute { get; set; }
        public string ToTimeFormat { get; set; }

        //public string FromTime (string FromTimeHour,string FromTimeMinute)
        //{
        //    //this.FromTimeHour= FromTimeHour;
        //    //this.FromTimeMinute = FromTimeMinute;
        //    return FromTimeHour + FromTimeMinute;
        //}
        //public string ToTime(string toTimeHour, string toTimeMinute)
        //{
        //    toTimeHour = ToTimeHour;
        //    toTimeMinute = ToTimeHour;
        //    return toTimeHour + toTimeMinute;
        //}

    }
}