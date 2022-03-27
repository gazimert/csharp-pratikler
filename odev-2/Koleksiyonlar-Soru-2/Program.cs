using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            // her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını
            // console'a yazdıran programı yazınız.

            int[] dizi = new int[20];
            int[] buyukler = new int[3];
            int[] kucukler = new int[3];
            int n;
            int kucukToplam = 0;
            int buyukToplam = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                try
                {
                    Console.Write("{0}. Sayıyı Giriniz: ", i+1);
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    dizi[i] = n;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Boş Değer Girdiniz");
                    Console.WriteLine(ex);
                    i--;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Veri Tipi Uygun Değil!");
                    Console.WriteLine(ex);
                    i--;
                }
            }

            Console.WriteLine("Girilen Değerler: ");

            foreach (int item in dizi)
                Console.Write(item + " - ");
            
            Console.WriteLine();
            Console.WriteLine();

            Array.Sort(dizi);

            Console.WriteLine("Sıralı Hali: ");

            foreach (int item in dizi)
                Console.Write(item + " - ");
            
            Console.WriteLine();
            Console.WriteLine();

            kucukler[0] = dizi[0];
            buyukler[2] = dizi[dizi.Length-1];


            for (int i = 1; i < dizi.Length-1; i++)
            {
                if (dizi[0] != dizi[i]){
                    kucukler[1] = dizi[i];

                    if (dizi[i] != dizi[i+1]){
                        kucukler[2] = dizi[i+1];
                        break;
                    }
                }
            }

            Console.WriteLine("En Küçük Üç Değer:");

            foreach (int item in kucukler)
            {
                Console.Write(item + " - ");
                kucukToplam += item;
            }

            Console.WriteLine();

            Console.WriteLine("Küçüklerin Ortalaması: " + (kucukToplam/3));


            for (int i = dizi.Length-2; i > 0; i--)
            {
                if (dizi[dizi.Length-1] != dizi[i]){
                    buyukler[1] = dizi[i];

                    if (dizi[i] != dizi[i-1]){
                        buyukler[0] = dizi[i-1];
                        break;
                    }
                }
            }

            Console.WriteLine("En Büyük Üç Değer:");

            foreach (int item in buyukler)
            {
                Console.Write(item + " - ");
                buyukToplam += item;
            }
            Console.WriteLine();

            Console.WriteLine("Büyüklerin Ortalaması: " + (buyukToplam/3));

            Console.WriteLine("Ortalama Toplamları: " + ((buyukToplam/3) + (kucukToplam/3)));
        }
    }
}
