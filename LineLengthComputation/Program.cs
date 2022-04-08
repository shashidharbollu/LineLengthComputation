using System;
namespace LineLengthComputation
{
    class Program
    {
        public static void Main(String[] args)
        {
            LineComputationn lineComparison = new LineComputationn(2, 5, 6, 8);
            lineComparison.calculateLength();
            LineComputationn line1 = new LineComputationn(2, 5, 51, 8);
            double l1 = line1.calculateLength();
            LineComputationn line2 = new LineComputationn(2, 50, 6, 8);

            double l2 = line2.calculateLength();
            if (l1.CompareTo(l2) == 0)
            {
                Console.WriteLine("Both Lines are equals ");
            }
            else if (l2.CompareTo(l1) > 0)
            {
                Console.WriteLine("Both Lines are not equals ");
            }

        }
    }
}
