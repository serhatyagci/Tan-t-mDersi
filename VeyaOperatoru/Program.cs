﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeyaOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 3;
            int sayi2 = 3;
            int sayi3 = 6;

            bool kontrolet = sayi1 == sayi2 || sayi2 > sayi3;

            Console.WriteLine(kontrolet);
            Console.ReadLine();

        }
    }
}
