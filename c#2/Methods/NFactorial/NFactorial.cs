using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class NFactorial
{
    public static BigInteger NFact(int n, BigInteger nfact)
    {
        if (n > 0)
        {
            nfact *= n;
            n--;
          return  NFact(n,nfact);

        }
        return nfact;
    }
    public static void Main()
    {
        BigInteger nFact = 1;
        Console.Write("write n and we will find the factorial  , n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The factroial of you number is {0}", NFact(n,nFact));

    }

}

