using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseUrl
{
    class ParseUrl
    {
        static void Main()
        {
            Console.WriteLine("write your url ");
            string url = Console.ReadLine();
            string[] sep={"://"};
            string[] twoParts = url.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("[protocol]= {0}",twoParts[0]);
            
            string server = twoParts[1].Substring(0, twoParts[1].IndexOf("/"));
            string resource = twoParts[1].Substring( twoParts[1].IndexOf("/"));
            Console.WriteLine("[server]= {0}" , server);
            Console.WriteLine("[resource] =  {0}",resource);
        }
    }
}
