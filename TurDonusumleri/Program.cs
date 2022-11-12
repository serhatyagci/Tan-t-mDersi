using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 500;

            byte b = (byte)a;

            Console.WriteLine(b.GetTypeCode());
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
