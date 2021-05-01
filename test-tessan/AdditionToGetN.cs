using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace test_tessan
{
    public class AdditionToGetN {

        private readonly int[] _values;
        private readonly int _target;

        public AdditionToGetN(int[] values, int target) {
            _values = values;
            _target = target;
        }

        public bool CanObtainTarge() {

            //1, 1, 2, 3, 5

            /* for performance raison, we should filter the aray in order to keep
             only values lennthan or eual to 8;
            */

            int [] filter = _values.Where(x=> x <= _target).ToArray();
            Console.WriteLine("Filter :"+ string.Join(',', filter));

            HashSet<int> visited = new HashSet<int>();

            for(int i = 0; i< filter.Length; i++) {

                int k = filter[i];

                if(visited.Contains(k)) continue;
                visited.Add(k);

                /*we should avoid use the same number to compared with othors
                So, we save the visited number into temp arrap
                in order to optimize the performance, I use HashSet, is faster than List and Dictionary
                wehn we use operation like contain, Remove, Add
                */

                int[] subFilter = SubArray<int>(filter, i+1, filter.Length - (i+1));
                Console.WriteLine("SubFilter :"+ string.Join(',', subFilter));

                for(int j = 0; j < subFilter.Length; j++) {
                    if((k + subFilter[j]) == _target) {
                        Console.WriteLine("First match :({0}, {1})", k, subFilter[j]);
                        return true;
                    }
                }
                // foreach(int sub in subFilter) {
                //     if((k + sub) == _target) {
                //         Console.WriteLine("First match :({0}, {1})", k, sub);
                //         return true;
                //     }
                // }
            }

            return false;
        }
        
        private T[] SubArray<T>(T[] array, int offset, int length) {
            T[] result = new T[length];
            Array.Copy(array, offset, result, 0, length);
            return result;
        }
        
    }

}