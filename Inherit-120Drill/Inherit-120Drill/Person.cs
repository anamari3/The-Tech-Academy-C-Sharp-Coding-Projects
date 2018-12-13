using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_120Drill
{
    public class Person
    {
        string FirstName { get; set; }
        string LastName { get; set; }
      
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }
    }
}
