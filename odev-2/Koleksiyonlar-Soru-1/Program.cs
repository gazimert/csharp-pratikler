using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.

            ArrayList liste = new ArrayList();
            ArrayList asalListe = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();

            int n = 0;
            Type t = typeof(int);
            int asalToplam = 0;
            int asalOlmayanToplam = 0;

            for (int i = 0; i < 20; i++)
            {
                try
                {
                    Console.Write("{0}. Sayıyı Giriniz: ", i+1);
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    liste.Add(n);
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

                // if (!n.Equals(t) || n < 0){
                //     liste.Remove(n);
                //     i--;
                // }
            }

            Console.WriteLine("***** Liste *****");

            foreach (int item in liste)
            {
                Console.Write(item + " - ");

                for (int j = 2; j < item; j++)
                {
                    if (item % j == 0){
                        asalOlmayan.Add(item);
                        break;
                    }
                }

                if (item == 1)
                    asalOlmayan.Add(item);

                if (!asalOlmayan.Contains(item))
                    asalListe.Add(item);
            }

            asalListe.Sort();
            asalOlmayan.Sort();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***** Asal Liste *****");

            foreach (int item in asalListe)
            {
                Console.Write(item + " - ");
                asalToplam += item;
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Asal Listenin Eleman Sayısı: " + asalListe.Count);
            Console.WriteLine("Asal Listenin Ortalaması: " + (asalToplam/asalListe.Count));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***** Asal Olmayan Liste *****");

            foreach (int item in asalOlmayan)
            {
                Console.Write(item + " - ");
                asalOlmayanToplam += item;
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Asal Olmayan Listenin Eleman Sayısı: " + asalOlmayan.Count);
            Console.WriteLine("Asal Olmayan Listenin Ortalaması: " + (asalOlmayanToplam/asalOlmayan.Count));
        }
    }
}
