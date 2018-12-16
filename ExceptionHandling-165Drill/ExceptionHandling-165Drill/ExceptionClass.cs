using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_165Drill
{
    public class ExceptionClass : Exception
    {
        //public ExceptionClass()
        ////:base(){ }
        public ExceptionClass(string message)
            : base(message) { }
        
    }
}
