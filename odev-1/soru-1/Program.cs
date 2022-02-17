using System;

namespace soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu 
            // sayılardan çift olanlar console'a yazdırın.

            
            int n;

            do
            {
                Console.Write("Bir sayı giriniz: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (n < 1);

            int[] dizi = new int[n];

            Console.WriteLine(n + " Adet sayı giriniz: ");

            for (int i = 0; i < n; i++)
            {
                dizi[i] = int.Parse(Console.ReadLine());
            }

            foreach (int sayi in dizi)
            {
                if (sayi % 2 == 0)
                    Console.Write(sayi + " ");
            }
            Console.WriteLine();
        }
    }
}
