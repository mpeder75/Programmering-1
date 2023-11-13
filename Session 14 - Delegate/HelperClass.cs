using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_14___Delegate
{
    internal class HelperClass
    {
        // 4. metode der tager en delegate RefToPrint print som argument
        public void PrintSum(int t1, int t2, RefToPrint printSum)
        {
            int sum = t1 + t2;
            Console.WriteLine(sum.ToString());
        }
    }
}
