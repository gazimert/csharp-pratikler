using System;

namespace soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            // Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            int n;

            do
            {
                Console.Write("Bir sayı giriniz: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (n < 1);

            string[] dizi = new string[n];

            Console.WriteLine(n + " Adet kelime giriniz");

            for (int i = 0; i < n; i++)
            {
                dizi[i] = Console.ReadLine();
            }

            for (int i = (n - 1); i >= 0; i--)
            {
                Console.Write(dizi[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
