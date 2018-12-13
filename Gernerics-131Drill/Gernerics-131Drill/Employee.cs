using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gernerics_131Drill
{
    public class Employee<T> : Person
    {
        //int id { get; set; }
        public List<T> things { get; set; }

        public override void SayName()
        {
            throw new NotImplementedException();
        }

      

        //public void Quit()
        //{
        //    throw new NotImplementedException();
        //}

        //public static Employee<T> operator ==(Employee<T> employee, Employee<T> id)
        //{
        //    employee.id.Equals(id);
        //    return employee;
        //}

        //public static Employee<T> operator !=(Employee<T> employee, Employee<T> id)
        //{
        //    employee.id.CompareTo(id);
        //    return employee;
        //}


    }
}