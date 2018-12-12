using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_120Drill
{
    public class Person
    {
        string FirstName;
        string LastName;
      
        public void SayName(string FirstName, string LastName)
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }
    }
}
