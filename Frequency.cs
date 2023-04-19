using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4B_Practice_Problem
{
    internal class Frequency
    {
        public static void FrequencyOfIntElement()
        {
            Console.WriteLine("Enter how many element you want to Put in Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[size];
            Console.WriteLine("Enter one by one element ");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Your Enter Element is \n");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < intArray.Length; j++)
                {
                    if (intArray[i] == intArray[j])
                    {
                        count++;

                    }
                }
                Console.WriteLine("\n The Frequency of {0} is {1}", intArray[i], count);
            }

        }
    }
}
