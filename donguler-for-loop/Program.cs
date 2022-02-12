using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yaz

            Console.WriteLine("Bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                    Console.Write(i + "-");
            }
            Console.WriteLine();

            
            // 1-1000 arasındaki tek ve çift sayıların kendi içlerinde toplamını ekrana yaz

            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                    ciftToplam += i;
                else
                    tekToplam += i;
            }

            Console.WriteLine("Teklerin Toplamı: " + tekToplam);
            Console.WriteLine("Çiftlerin Toplamı: " + ciftToplam);


            // break , continue

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------------------------");

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            } 
        }
    }
}
