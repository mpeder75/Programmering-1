using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLibrary
{
    public class DemoCode
    {
        // 1. GrandParentMethod får passet en int position
        // og kalder ParentMethod(med den position den har fået)
        public int GrandParentMethod(int position)
        {
            return ParentMethod(position);

        }
 

        // 2. ParentMethod kalder metode GetNumber, som returnere
        // position fra Getnumber til ParentMethod 
        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }


        // 3. GetNumber kaldes fra ParentMethod med en passed int position,
        // den vil derefter slå position op i array og returnere det index 
        public int GetNumber(int position)
        {            
            int[] numbers = new int[] { 1, 4, 7, 2 };

            return numbers[position];

            // hvad sker der hvis man passer position 10?
            // man vil få en 'outofbounds exception'


        }


    }
}


