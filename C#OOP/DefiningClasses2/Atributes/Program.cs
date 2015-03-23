using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Atributes
{
    [assembly: AssemblyVersionAttribute("1.0.0.0")]

    public class Example1
    {
        public static void Main()
        {
            Assembly thisAssem = typeof(Example1).Assembly;
            AssemblyName thisAssemName = thisAssem.GetName();

            Version ver = thisAssemName.Version;

            Console.WriteLine("This is version {0} of {1}.", ver, thisAssemName.Name);
        }
    }
}
