using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burak_CoreEntityCodeFirst.Entity
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public List<Course> Courses { get; set; }
    }
}
