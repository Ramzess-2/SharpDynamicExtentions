using System;

/*
Created by Ramzess (ravillion@mail.ru) 
*/

namespace SharpExtentions.Dynamic.Utility {
    public static class IntegerUtility {

        /// <summary>
        /// mathematical factorial function
        /// </summary>
        /// <param name="_n"></param>
        /// <returns>factorial from number</returns>
        public static long Factorial(this int _n) {
            if (_n < 0) return 0;
            if (_n == 0) return 1;

            else {
                return _n * Factorial(_n - 1);
            }

        }

    }
}
