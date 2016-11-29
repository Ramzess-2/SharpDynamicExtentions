using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

/*

Created by Ramzess (ravillion@mail.ru) 

*/

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

        /// <summary>
        /// The method check for containing domain string
        /// </summary>
        /// <param name="_s">string to check for domain</param>
        /// <returns>true, if current string is domain</returns>
        public static bool isDomain(this string _s) {
            return _s.testRegex(DOMAIN_REGEX);
        }

        /// <summary>
        /// Converts string to binary array
        /// </summary>
        /// <param name="s">input string</param>
        /// <param name="encoding">Encoding, if needed. As default used utf-8</param>
        /// <returns>byte array</returns>
        public static byte[] toByteArray(this string s, Encoding encoding = null) {
            encoding = encoding ?? Encoding.UTF8;
            return encoding.GetBytes(s);
        }
        
        /// <summary>
        /// Compute md5 from string
        /// </summary>
        /// <returns>Computed string</returns>
        public static string toMd5(this string _s) {
            return Hash(_s, MD5.Create());
        }

        /// <summary>
        /// Converts string from base64 string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string fromBase64(this string s, Encoding encoding = null) {
            Encoding _used = encoding ?? Encoding.UTF8;
            return _used.GetString(Convert.FromBase64String(s));
        }

        /// <summary>
        /// Converts string to base64 string
        /// </summary>
        /// <param name="_s"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string toBase64(this string _s, Encoding encoding = null) {
            return _s.toByteArray().toBase64();
        }

        /// <summary>
        /// Formats string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string toFormat(this string s, params object[] args) {
            return string.Format(s, args);
        }

        /// <summary>
        /// Check string is null or empty or whitespace
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool isEmptyOrWhiteSpace(this string s) {
            if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }



        static string Hash(this string _s, HashAlgorithm hash, Encoding encoding = null) {

            encoding = encoding ?? Encoding.UTF8;
            StringBuilder bulder = new StringBuilder();

            foreach (byte i in hash.ComputeHash(_s.toByteArray())) bulder.Append(i.ToString("x2"));
            return bulder.ToString();
        }

    }
}
