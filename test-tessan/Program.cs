using System;

namespace test_tessan
{
    class Program
    {
        static void Main(string[] args)
        {

            // Combination cmb = new Combination(26, 1, 2);
            // var totalPossibilities = cmb.CountPossibilities();           
            // Console.WriteLine(totalPossibilities);


            //1, 1, 2, 3, 5, 6, 12, 13, 15, 15, 16, 18, 20, 27, 29
            // int[] values = new[] {1, 1, 2, 3, 5, 6, 12, 13, 15, 15, 16, 18, 20, 27, 29};
            int[] values = new[] {1, 1, 2, 3, 5};          
            AdditionToGetN additionToGetN = new AdditionToGetN(values, 8);
            var result = additionToGetN.CanObtainTarge();
            Console.WriteLine(result);
        }
    }
}
