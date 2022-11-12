using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakpointveTooltipOnemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //breakpoint: kodları tek tek çalıştırarak derleyicinin adım adım çalışması gözlemlenir. (en soldaki kırmızı yuvarlağa basıp start diyip devam edilir.)
            //Tooltip: yazarken açılan açıklama kutuları.

            int a = 3;
            int b = 5;
            int c = 10;

            int sonuc = a + b + c;

            Console.WriteLine(sonuc);
            Console.ReadLine();
            
        }
    }
}
