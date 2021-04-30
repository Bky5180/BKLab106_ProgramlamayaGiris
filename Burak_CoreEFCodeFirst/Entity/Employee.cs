using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burak_CoreEntityCodeFirst.Entity
{
    // Table Splitting: Birden fazla entity'nin SQL uzerinde tek bir tabloda olmasini saglar.
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public EmployeeContactDetail EmployeeContactDetail { get; set; }
    }
}
