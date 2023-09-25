using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6___Exercise_1.UiHelper
{
    internal class MyCalc
    {

        public int AddNumbers (int a, int b)
        {
            if(a < 0 || b < 0)
            {
                return 0;
            } else
            {
                return a + b;
            }                      
        }
        
        internal int Num1MinusNum2 (int num1, int num2)
        {
            if(num1 < 0 && num2 <0)
            {
                return 0;
            } else
            {
                return num1 - num2;
            }
        }

        internal bool IsEvenOrOdd (int a)
        {
            if(a % 2 != 0)
            {
                return false;
            } else
            {
                return true;
            }

        }

        internal int MultiplyNum1Num2 (int a, int b)
        {
            if(a < 0 || b < 0)
            {
                return 0;
            } else
            {
                return a * b;
            }
        }
    }
}
