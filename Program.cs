using System;

namespace day7
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeFactors primeFactors = new PrimeFactors();
            primeFactors.findingPrimeFactors();

            SecondLargestAndSmallest secondLargest = new SecondLargestAndSmallest();
            secondLargest.FindSecondLargest();


            Binary binary = new Binary();
            binary.findingBinary();
        }
    }
}
