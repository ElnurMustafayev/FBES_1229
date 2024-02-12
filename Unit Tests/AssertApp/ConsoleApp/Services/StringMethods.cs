using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    public class StringMethods
    {
        public static int GetLength(string str) {
            if(str is null)
                return 0;

            return str.Length;
        }
    }
}