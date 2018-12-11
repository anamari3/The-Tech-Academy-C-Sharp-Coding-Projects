using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Drill
{
    class NumbersManipulator
    {
        public int FindMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }

        public int Adding(int num1, int num2)
        {
            int addResult;
            if (num1 != num2)
                addResult = num1 + num2;
            else
                addResult = num1 + num1;
            return addResult;
        }

        public int Multiplication(int num1, int num2)
        {
            int multiplyResult;
                multiplyResult = num1 * num2;
            return multiplyResult;
        }
    }

  
    }

    


