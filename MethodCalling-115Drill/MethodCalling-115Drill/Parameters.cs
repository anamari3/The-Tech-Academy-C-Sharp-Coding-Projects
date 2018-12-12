using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCalling_115Drill
{
    public class Parameters
    {
        public int Math(int num1, int num2 = 5)
        {
            int result = num1 + num2;
            return result;

        }
    }
}
