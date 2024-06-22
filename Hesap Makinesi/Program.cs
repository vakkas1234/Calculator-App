using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen ilk sayıyı Giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı Giriniz");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("İşlemiGiriniz");
            int islem = int.Parse(Console.ReadLine());//Carpma için 5 e  Bölme için 6 ya Toplama için 7 Cıkarma için 6 ya basınız.//
            if (islem == 5)
            { Console.WriteLine(sayi2 * sayi1); }
            else if (islem == 6)
            { Console.WriteLine(sayi2/sayi1); }
            else if (islem  == 7)
                { Console.WriteLine(sayi2+sayi1); }
            else
            {
                Console.WriteLine(sayi2-sayi1);
            }
            Console.ReadLine();





        }
    }
}
