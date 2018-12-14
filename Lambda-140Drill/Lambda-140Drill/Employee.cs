using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_140Drill
{
    public class Employee
    {
      public string fname { get; set; }
        public string lname { get; set; }
      public int id { get; set; }

        public Employee(string firstName, string lastName, int ID)
        {
            fname = firstName;
            lname = lastName;
            id = ID;
        }
    }
   
}
