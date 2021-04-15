using System;

namespace Line_Comparison
{
    class Program
    {/// <summary>
    /// Line Comparison
    /// </summary>
    /// <param name="args"></param>
            static void Main(string[] args)
            {
                int x1, x2, y1, y2;

                Console.WriteLine("Enter co-ordinates of First Line ");
                Console.WriteLine("Enter the value of x1:");      //Enter the input x1
                x1 = Convert.ToInt32(Console.ReadLine());         //Convert into Int with the help of convert.ToInt32() 
                Console.WriteLine("Enter the value of x2:");
                x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of y1:");      //Enter the value y1
                y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of y2:");
                y2 = Convert.ToInt32(Console.ReadLine());

                double Length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); //apply formula

                Console.WriteLine("Enter co-ordinates of Second Line ");
                Console.WriteLine("Enter the value of x1:");      //enter the input x1
                x1 = Convert.ToInt32(Console.ReadLine());         //Convert into Int with the help of convert.ToInt32() 
                Console.WriteLine("Enter the value of x2:");
                x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of y1:");      //Enter the value y1
                y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of y2:");
                y2 = Convert.ToInt32(Console.ReadLine());

                double Length2 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); //apply formula

                if (Length1.Equals(Length2))
                {
                    Console.WriteLine("Length of Line1 = Length of Line2 ");
                }

                else if (Length1 > Length2)
                {
                    Console.WriteLine("Length of Line1  is Greater Than Length of Line2");
                }
                else
                {
                    Console.WriteLine("Length of Line1  is Less Than Length of Line2");
                }

                Console.WriteLine("The Length of Line1 is  " + Length1);  //finaly print output
                Console.WriteLine("The Length of Line2 is  " + Length2);  //finaly print output
                Console.Read();
            }
    }
}
