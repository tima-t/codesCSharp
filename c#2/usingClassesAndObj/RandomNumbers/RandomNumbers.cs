﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class RandomNumbers
    {
        static void Main()
        {
            Random rand = new Random();
            int down = 100;
            int up = 201;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rand.Next(down,up));
            }
            Console.WriteLine();
        }
    }
}
