using System;

namespace soru_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Bir cümle giriniz: ");

            string cumle = Console.ReadLine();
            
            Console.WriteLine();

            int harfSayac = 0, kelimeSayac = 1;

            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == ' '){
                    kelimeSayac++;
                    continue;
                }
                harfSayac++;
            }

            Console.WriteLine("Kelime Sayısı: " + kelimeSayac);
            Console.WriteLine("Harf Sayısı: " + harfSayac);
        }
    }
}
