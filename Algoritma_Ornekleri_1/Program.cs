using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Ornekleri_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bir = 0;
            int on = 0;
            int yüz = 0;
            int sayi = 0;

            Console.Write("Üç Basamaklı Bir Sayı Giriniz = ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");     

            yüz = sayi / 100;
            Console.WriteLine("Yüzler Basamağındaki Sayı : {0}", yüz);

            sayi = sayi - (yüz * 100);
            on = sayi / 10;
            Console.WriteLine("Onlar Basamağındaki Sayı : {0}", on);

            sayi = sayi - (on * 10);
            bir = sayi;
            Console.WriteLine("Birler Basamağındaki Sayı : {0}", bir);

            Console.ReadKey();
        }
    }
}
