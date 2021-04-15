using System;

namespace Line_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int x1, x2, y1, y2;
                Console.WriteLine("Enter the value of x1:");      //enter the input x1
                x1 = Convert.ToInt32(Console.ReadLine());     //Convert into Int with the help of convert.ToInt32() 
                Console.WriteLine("Enter the value of x2:");
                x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of y1:");      //Enter the value y1
                y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of y2:");
                y2 = Convert.ToInt32(Console.ReadLine());

                double Lenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); //apply formula

                Console.WriteLine("the length of a line is  " + Lenght);  //finally print output
                Console.Read();
        }
    }
}

