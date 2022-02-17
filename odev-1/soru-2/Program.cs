using System;

namespace soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            int n,m;

            do
            {
                Console.WriteLine("İki sayı giriniz: ");
                n = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());
            } while (n < 1 || m < 1);

            int[] dizi = new int[n];

            Console.WriteLine(n + " Adet sayı giriniz: ");

            for (int i = 0; i < n; i++)
            {
                dizi[i] = int.Parse(Console.ReadLine());
            }

            foreach (int sayi in dizi)
            {
                if (sayi % m == 0)
                    Console.Write(sayi + " ");
            }
            Console.WriteLine();
        }
    }
}
