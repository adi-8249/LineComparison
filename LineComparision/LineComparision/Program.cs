using System;

namespace LineComparision
{
    public  class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line Comparision Program");
            LengthComputation length = new LengthComputation();
            
            double FirstLine = length.Findlength(5, 6, 5, 2);
            double Secondline = length.Findlength(2, 5, 3, 5);

            Boolean check = FirstLine.Equals(Secondline);
            if (check == true)
            {
                Console.WriteLine("lines are equa as length");
            }
            else
            {
                Console.WriteLine("lines are not equal");
            }

            if (FirstLine == Secondline)
            {
                Console.WriteLine("both lines are same");
            }
            else if(FirstLine > Secondline)
            {
                Console.WriteLine("first line is greater than secondline");
            }
            else
            {
                Console.WriteLine("firstline is less than secondline ");
            }

          }

    }
}
