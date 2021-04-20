using System;

namespace Line_Comparison
{
    class Program
    {/// <summary>
    /// Line Comparison
    /// </summary>
    /// <param name="args"></param>
            static void LineComparision()
            {
                int x1, x2, y1, y2;//Initialized 4 Variables

                Console.WriteLine("Enter co-ordinates of First Line ");//WriteLine
                Console.WriteLine("Enter the value of x1:");      //Enter the input x1
                x1 = Convert.ToInt32(Console.ReadLine());         //Convert into Int with the help of convert.ToInt32() 
                Console.WriteLine("Enter the value of x2:");      //ENter The Inputs
                x2 = Convert.ToInt32(Console.ReadLine());         //Convert into Int with the help of convert.ToInt32() 
                Console.WriteLine("Enter the value of y1:");      //Enter the value y1
                y1 = Convert.ToInt32(Console.ReadLine());          //Convert into Int with the help of convert.ToInt32() 
                Console.WriteLine("Enter the value of y2:");      //Enter the Inputs
                y2 = Convert.ToInt32(Console.ReadLine());          //Convert into Int with the help of convert.ToInt32() 

              double Length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); //Math Square and Math Power are 2 Functions inbuild in libraries

                Console.WriteLine("Enter co-ordinates of Second Line ");//WriteLine
                Console.WriteLine("Enter the value of x1:");      //enter the input x1
                x1 = Convert.ToInt32(Console.ReadLine());         //Convert into Int with the help of convert.ToInt32() 
                Console.WriteLine("Enter the value of x2:");      //Enter the Inputs
                x2 = Convert.ToInt32(Console.ReadLine());         //Convert into Int with the help of convert.ToInt32() 
                Console.WriteLine("Enter the value of y1:");      //Enter the value y1
                y1 = Convert.ToInt32(Console.ReadLine());         //Convert into Int with the help of convert.ToInt32() 
                Console.WriteLine("Enter the value of y2:");      //Enter The Inputs
                y2 = Convert.ToInt32(Console.ReadLine());         //Convert into Int with the help of convert.ToInt32() 

                double Length2 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));//Math Square and Math Power are 2 Functions inbuild in libraries applya that 
                //Initialized if Loop for finding length of Cordinates
                if (Length1.Equals(Length2))
                {
                    //If line1=line2 then print
                    Console.WriteLine("Length of Line1 = Length of Line2 ");
                }
                  //If Length1 is greater than length2 then print this
                else if (Length1 > Length2)
                { 
                    //if length1 is greater print 
                    Console.WriteLine("Length of Line1  is Greater Than Length of Line2");
                }
                else
                {  
                    //if length2 is greater then print
                    Console.WriteLine("Length of Line1  is Less Than Length of Line2");
                }
                //End of If Loop
                Console.WriteLine("The Length of Line1 is  " + Length1);  //finally print output
                Console.WriteLine("The Length of Line2 is  " + Length2);  //finally print output
                Console.Read();
            } 
       //Declaring Main method
       static void Main(string[] args)
       {
         Program.LineComparision();//Call method LineComparision
       } 
        //End of Main Method
    }    
}
