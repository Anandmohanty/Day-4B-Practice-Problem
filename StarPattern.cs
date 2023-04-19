using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4B_Practice_Problem
{
    
        public class StarPattern
        {
            public static void RightAngleTrangle()
            {
                Console.WriteLine("Please Enter Number for How much lines you want in Pattern");
                int rows = Convert.ToInt32(Console.ReadLine());

                for (int i = rows; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }

                    Console.WriteLine();
                }
            }

            public static void RectangleStarPattern()
            {
                Console.WriteLine("Please Enter Number for How much lines you want in Pattern");
                int rows = Convert.ToInt32(Console.ReadLine());
                for (int i = rows; i >= 1; i--)
                {
                    if (i == rows || i == 1)
                    {
                        for (int j = 0; j <= rows; j++)
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                    for (int j = 1; j <= rows; j++)
                    {

                        if (j == 1 || j == rows)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }

                    Console.WriteLine();
                }


            }
        }
}
