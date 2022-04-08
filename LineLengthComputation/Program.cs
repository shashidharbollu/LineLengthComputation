using LineLengthComputation;
using System;
namespace LineLengthComputation
{
    class Program
    {
        public static void Main(String[] args)
        {
            LineComputationn lineComparison = new LineComputationn(2, 5, 6, 8);
            lineComparison.calculateLength();
        }
    }
}
