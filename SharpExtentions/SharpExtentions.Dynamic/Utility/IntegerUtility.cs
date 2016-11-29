using System;
using System.Diagnostics;

/*
Created by Ramzess (ravillion@mail.ru) 
*/

namespace SharpExtentions.Dynamic.Utility {
    public static class IntegerUtility {

        /// <summary>
        /// mathematic factorial function
        /// </summary>
        /// <param name="n"></param>
        /// <returns>factorial from number</returns>
        public static int Factorial(this int n) {
            if (n < 0) return 0;
            if (n == 0) return 1;

            else {
                return n * Factorial(n - 1);
            }

        }
        
        public static bool IsPrime(this int n) {

            for (int i = 2; i < Math.Sqrt(n); i++) {

                if (n % i == 0) {
                    return false;
                }
            }

            return true;
        }



    }
}