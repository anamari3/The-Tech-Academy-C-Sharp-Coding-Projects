using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_124Drill
{
    class Employee : Person, IQuittable
    {
        int id { get; set; }

        public override void SayName()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public static Employee operator== (Employee employee, Employee id)
        {
            employee.id.Equals(id);
            return employee;
        }

        public static Employee operator!=(Employee employee, Employee id)
        {
            employee.id.CompareTo (id);
            return employee;
        }


    }
}