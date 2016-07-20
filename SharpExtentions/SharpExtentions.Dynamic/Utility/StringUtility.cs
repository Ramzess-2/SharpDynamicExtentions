using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace SharpExtentions.Dynamic.Utility {
    /// <summary>
    /// Class with extention methods for string data type
    /// </summary>
    public static class StringUtility {

        /// <summary>
        /// email regex can't be invalid. Please test all variant if you can
        /// </summary>
        private const string EMAIL_REGEX = "^(([^<>()\\[\\]\\.,;:\\s@\"]+(\\.[^<>()\\[\\]\\.,;:\\s@\"]+)*)|(\".+\"))@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}])|(([a-zA-Z\\-0-9]+\\.)+[a-zA-Z]{2,}))$";
        private const string DOMAIN_REGEX = @"^[a-zA-Z0-9][a-zA-Z0-9-]{1,61}[a-zA-Z0-9](\.[a-zA-Z]{2,}){1,}$";


        public static bool testRegex(this string _s, string _regex) {
            return Regex.IsMatch(_s, _regex);
        }

        /// <summary>
        /// Checking the string for email format
        /// </summary>
        /// <param name="s">email string what need to be checked</param>
        /// <returns>true, if is illegal email format</returns>
        public static bool isEmail(this string s) {
            return s.testRegex(EMAIL_REGEX);
        }

        public static bool isDomain(this string _s) {
            return _s.testRegex(DOMAIN_REGEX);
        }




    }
}
