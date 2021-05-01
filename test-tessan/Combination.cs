using System;
using System.Numerics;

namespace test_tessan
{
    public class Combination {

        private readonly int _pointNumber;
        private readonly short _combinationOne;
        private readonly short _combinationTwo;
        public Combination(int pointNumber, short combinationOne, short combinationTwo) {
            _pointNumber = pointNumber;
            _combinationOne = combinationOne;
            _combinationTwo = combinationTwo;
        }

        public BigInteger CountPossibilities(){

            int n= _pointNumber, k = 0, sum = 0;
            BigInteger totalPossibilities = 0;
            int len = _pointNumber / 2;

            while(n >= 0 && k <= len) {
                sum = (n * _combinationOne) + (k * _combinationTwo);
                if(sum == _pointNumber) {
                    totalPossibilities += GetCombination(n, k);
                }

                k++;
                n -= 2;
            }

            return totalPossibilities;

        }

        private BigInteger GetCombination(int n, int k) {

            //The Combinations Calculator will find the number of possible combinations 
            //that can be obtained
            return Factorial (n + k) / (Factorial(n) * Factorial(k));
        }

        private BigInteger Factorial (int value) {

            BigInteger result = 1;
            for(int i = 1; i <= value; i++) {
                result *= (BigInteger)i;
            }
            return result;

        }
    }
}
