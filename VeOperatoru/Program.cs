﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 5;
            int sayi2 = 5;
            int sayi3 = 10;

            bool kontrolet = sayi1 == sayi2 && sayi1 < sayi3;

            Console.WriteLine(kontrolet);
            Console.ReadLine();

        }
    }
}
