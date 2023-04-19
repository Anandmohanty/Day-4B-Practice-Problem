using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4B_Practice_Problem
{
    public class ReverseWord
    {
        public static void ReverseString()
        {
            Console.WriteLine("Enter Sting For Reverse");
            string inputData = Console.ReadLine();
            char[] charArray = inputData.ToCharArray();
            string reversedString = String.Empty;

            for (int i = charArray.Length - 1; i > -1; i--)
            {

                reversedString += charArray[i];
            }
            Console.WriteLine(reversedString);
            Console.ReadLine();
        }

    }

}
