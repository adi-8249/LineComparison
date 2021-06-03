using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    public abstract class length
    {
        public abstract double Findlength(int x1, int x2, int y1, int y2);
    }
  public  class LengthComputation : length
    {
        double Distance;

        public override double Findlength(int x1, int x2, int y1, int y2)
        {
            Distance = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));

            Console.WriteLine("Line length is " +Distance);
            return Distance;
        } 

    }
}
