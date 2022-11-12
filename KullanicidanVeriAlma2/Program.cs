using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanVeriAlma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kaç yaşındasın lan");

            string kullanici_yas = Console.ReadLine();

            int yas = Convert.ToInt32(kullanici_yas);

            int yil = 2022;

            int sonuc = yil - yas;

            Console.WriteLine("kullanıcının dogum yili "+sonuc);
            Console.ReadLine();

        }
    }
}
