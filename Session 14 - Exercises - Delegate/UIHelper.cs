using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Opret en metode i program.cs der modtager en List<int> og udskriver alle tal i denne.
Opret Ulhelper.cs der har en metode. 
Denne skal modtage et tal og hvis tallet er lige skal den udskrive alle lige tal og hvis tallet er ulige skal disse 
udskrives(fra O til og med tallet). 
Derudover skal den modtage en delegate der håndtere udskrivning. 
*/

namespace Session_14___Exercises___Delegate
{
    internal class UIHelper
    {


        public List<int> PrintNumbers(int a)
        {
            List<int> equalNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            if (a % 2 == 0)
            {
                equalNumbers.Add(a);

            } else {

            }

        }
    }
}
