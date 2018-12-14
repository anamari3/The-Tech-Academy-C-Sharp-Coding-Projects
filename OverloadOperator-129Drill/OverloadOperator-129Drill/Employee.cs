using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_124Drill
{
    class Employee : Person, IQuittable
    {
        public Person employee1 { get; set; }
        public Person emmployee2 { get; set; }
        public int id { get; set; }

        public override void SayName()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }
        
        public static bool operator== (Employee employee1, Employee employee2) //bool is the return type
        {
            if (employee1.id == employee2.id)
            {

            }
                return true;
        }

        public static bool operator!=(Employee employee1, Employee employee2)
        {
            if (employee1.id != employee2.id)
            {
                
            }
                return false;
         }


    }
}