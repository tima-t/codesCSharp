using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsB

{
    class StrBuildTest
    {
        public static void Main()
        {
        StringBuilder str = new StringBuilder("hi C# OOP");
        Console.WriteLine(str.Substring(3,6).ToString());
        }

    }
}
