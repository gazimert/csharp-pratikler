using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
            // ve dizinin elemanlarını sıralayan programı yazınız.

            ArrayList sesliHarfListe = new ArrayList();

            Console.WriteLine("Bir Cümle Giriniz: ");
            string cumle = Console.ReadLine();

            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == 'a' || cumle[i] == 'A' || cumle[i] == 'e' || cumle[i] == 'E'
                || cumle[i] == 'ı' || cumle[i] == 'I' || cumle[i] == 'i' || cumle[i] == 'İ'
                || cumle[i] == 'o' || cumle[i] == 'O' || cumle[i] == 'Ö' || cumle[i] == 'Ö'
                || cumle[i] == 'u' || cumle[i] == 'U' || cumle[i] == 'ü' || cumle[i] == 'Ü'){

                    if (!sesliHarfListe.Contains(cumle[i]))
                    {
                        sesliHarfListe.Add(cumle[i]);
                    }
                }
            }

            Console.WriteLine("Sesli Harfler: ");
            foreach (var item in sesliHarfListe)
            {
                Console.Write(item + " - ");
            }
            Console.WriteLine();
        }
    }
}
