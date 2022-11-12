using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıdanVeriAlma3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("birinci sayiyi gir:");
            string sayi1 = Console.ReadLine();
            
            Console.WriteLine("ikinci sayiyi gir:");
            string sayi2 = Console.ReadLine();

            int a = Convert.ToInt32(sayi1);
            int b = Convert.ToInt32(sayi2);

            Console.WriteLine("iki sayının çarpımı " +a*b);
            Console.ReadLine();

        }
    }
}
