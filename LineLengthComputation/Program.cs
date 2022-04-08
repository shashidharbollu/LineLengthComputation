using System;
namespace LineLengthComputation { 
    public class Program
    {
        public static void Main(String[] args)
        {
        LineComputationn lineComparison = new LineComputationn(2, 5, 6, 8);
            lineComparison.calculateLength();
        LineComputationn line1 = new LineComputationn(2, 5, 6, 8);
            line1.calculateLength();
        LineComputationn line2 = new LineComputationn(2, 5, 6, 8);
            line2.calculateLength();
            if (line1.Equals(line2))
            {
                Console.WriteLine("Both Lines are equals ");
            }
            else
            {
                Console.WriteLine("Both Lines are not equals ");
            }
        }
    }
}
