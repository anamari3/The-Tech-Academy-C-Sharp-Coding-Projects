﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_124Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee();
            //employee.firstName = "Sample";
            //employee.lastName = "Student";
            //employee.SayName();
            employee.Quit();
        }
    }
}