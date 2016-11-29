using System;
using System.Text;

/*
Created by Ramzess (ravillion@mail.ru)    
*/

namespace SharpExtentions.Dynamic.Utility {

    public static class BinaryUtility {

        public static string toBase64(this byte[] _bytes, Encoding encoding = null) {
            encoding = encoding ?? Encoding.UTF8;

            return Convert.ToBase64String(_bytes);

        }



    }
}
