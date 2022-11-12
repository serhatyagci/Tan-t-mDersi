using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ReadLine

            Console.WriteLine("Lütfen adınızı giriniz");

            string isim = Console.ReadLine();

            Console.WriteLine("Soyisminizi giriniz");

            string soyisim = Console.ReadLine();


            Console.WriteLine("kullanıcının ismi " + isim);
            Console.WriteLine("kullanıcının soyismi " + soyisim);
            Console.ReadLine();

        }
    }
}
