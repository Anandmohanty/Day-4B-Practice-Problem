namespace Day_4B_Practice_Problem
{
    
      
            
            class Program
        {
            static void Main(string[] args)
            {
            Console.WriteLine("Welcome to Day-4B-Practice Problem");
            Console.WriteLine("Please Select any one option \n 1. Count of total number of duplicate elements\n" +
                    " 2. To find Unique Element\n 3.count the frequency of each element \n 4. maximum and minimum element \n " +
                    "5. Right Angle Star Pattern \n 6. Rectangle Star Pattern \n 7. Reverse Each Word in a Given String \n" +
                    " 8. Sum of Each Digit \n 9. Sum of Each row in Given matrix");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        DuplicateElement.DuplicateIntElement();
                        break;

                    case 2:
                        UniqueElements.UniqueIntElement();
                        break;
                    case 3:
                        DuplicateElement.FrequencyOfIntElement();
                        break;
                    case 4:
                        MaxMin.IntMaxMin();
                        break;
                    case 5:
                        StarPattern.RightAngleTrangle();
                        break;
                    case 6:
                        StarPattern.RectangleStarPattern();
                        break;
                    case 7:
                        ReverseWord.ReverseString();
                        break;
                    case 8:
                        Sum.SumOfDigit();
                        break;
                    case 9:
                        Sum.SumOfMatrix();
                        break;
                    default:
                        Console.WriteLine("Please Select Right option from Given");
                        break;
                }
            }
        }
    }
}