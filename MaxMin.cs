using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4B_Practice_Problem
{
    public class MaxMin
    {
        public static void IntMaxMin()
        {
            int min, max;

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

            min = intArray[0];
            max = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                // if the current element is less than the current minimum, update the minimum value
                if (intArray[i] < min)
                {
                    min = intArray[i];
                }

                // if the current element is greater than the current maximum, update the maximum value
                if (intArray[i] > max)
                {
                    max = intArray[i];
                }
            }
            Console.WriteLine("Minimum element: " + min);
            Console.WriteLine("Maximum element: " + max);
        }
    }
}