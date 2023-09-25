using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6___Exercise_1
{
    public class MainHelper
    {
        public void Print()
        {
            Console.WriteLine("Hallo world");
        }


        public string AddTwoNumbers(int a, int b)
        {

            if (a == b)
            {
                return $"Num1: {a} is equal to Num2: {b}";
            }
            else
            {
                return $"Num1: {a} is NOT equal to Num2: {b}";
            }
        }


        public int DivideTwoNumbers(int a, int b)
        {
            if ((a > 0 && b > 0) && a > b)
            {
                return a / b;
            }
            else
            {
                return -1;
            }
        }


        public string InAgeRange(int a)
        {
            if (a < 13)
            {
                return $"age = {a}, you are a child";
            }
            else if (a >= 12 && a < 20)
            {
                return $"age = {a}, you are a teen";
            }
            else if (a >= 20 && a <= 67)
            {
                return $"age = {a}, you are a adult";
            }
            else if (a > 67)
            {
                return $"age = {a}, you are a pensioner";
            }
            else
                return "not in age range";
        }


        public List<string> ReturnStringAsList(string text)
        {
            // split text ved HVER ' ' mellemrum og gem i variabel splitString
            string[] splitString = text.Split(' ');

            // array til en List<string>
            List<string> convertedString = new List<string>(splitString);

            // returner den nyoprettede convertedString til invoker
            return convertedString;
        }


        public double AvgMyNumbers(int[] myArray)
        {

            double result = myArray.Sum() / myArray.Length;
            return result;
        }


        public string ConcenateMyStrings(string[] myArray)
        {

            string result = "";
            for (int i = 0; i < myArray.Length; i++)
            {
                result += myArray[i] + " ";
            }

            return result;
        }


        public void AddValue1(int a)
        {
            int result = a + 10;
            AddValue2(result);
        }


        public void AddValue2(int result)
        {
            result = result + 10;
            Console.WriteLine(result);
        }


        public List<int> NumToValidate(List<int> myList)
        {
            int lastNumber = myList.Last();
            List<int> matchingNumbers = new List<int>();

            if (lastNumber % 2 != 0)
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i] % 2 != 0)
                    {
                        matchingNumbers.Add(myList[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i] % 2 == 0)
                    {
                        matchingNumbers.Add(myList[i]);
                    }
                }
            }
            return matchingNumbers;
        }


        public void PrintExtraLine()
        {
            Console.WriteLine();
        }

    }
}
