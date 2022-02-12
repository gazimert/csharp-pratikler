using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            // 1 den başlayarak konsoldan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp ekrana yaz

            Console.WriteLine("Bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int toplam = 0;

            while (a <= n)
            {
                Console.Write(a + " - ");
                toplam += a;
                a++;
            }

            Console.WriteLine();
            Console.WriteLine("Sayıların Ortalaması: " + (toplam/n));
            Console.WriteLine("------------------------------------------------");
            
            // 'a' dan 'z' ye kadar tüm harfleri konsola yaz

            char ch = 'a';

            while (ch <= 'z')
            {
                Console.Write(ch + " ");
                ch++;
            }
            Console.WriteLine();

            Console.WriteLine("***** Foreach *****");

            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
