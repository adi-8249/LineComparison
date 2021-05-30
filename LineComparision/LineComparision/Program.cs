using System;

namespace LineComparision
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line Comparision Program");
            LengthComputation length = new LengthComputation();
            length.Findlength(2,20,2,20);

        }
    }
}
