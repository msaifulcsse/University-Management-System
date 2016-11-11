using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystem.CoreSystem.DAL;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.CoreSystem.BLL
{
    public class ClassAllocationManager
    {
        ClassAllocationGetway aClassAllocationGetway = new ClassAllocationGetway();

        public int CLassroomAllocation(ClassAllocation aClassAllocation)
        {
            return aClassAllocationGetway.CLassroomAllocation(aClassAllocation);
        }

        public List<ClassAllocation> GetAllocatedClassInfo()
        {
            return aClassAllocationGetway.GetAllocatedClassInfo();
        }
    }
}