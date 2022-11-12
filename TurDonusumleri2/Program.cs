using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sayi1 = "1";
            string sayi2 = "3";

            //int a = int.Parse(sayi1);
            //int b = int.Parse(sayi2);

            int a = Convert.ToInt32(sayi1);
            int b = Convert.ToInt32(sayi2);

            Console.WriteLine(a+b);
            Console.ReadLine();

        }
    }
}
