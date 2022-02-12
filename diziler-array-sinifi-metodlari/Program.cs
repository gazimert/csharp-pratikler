using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort

            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            Console.WriteLine("*** Sırasız Dizi ***");
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi + " ");
            }

            Console.WriteLine();

            Array.Sort(sayiDizisi);

            Console.WriteLine("*** Sıralı Dizi ***");
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi + " ");
            }
            
            Console.WriteLine();


            // Clear

            Console.WriteLine("*** Array Clear ***");

            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi + " ");
            }

            Console.WriteLine();


            // Reverse

            Array.Reverse(sayiDizisi);

            Console.WriteLine("*** Array Reverse ***");
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi + " ");
            }

            Console.WriteLine();


            // indexOf

            Console.WriteLine("*** Array indexOf ***");

            Console.WriteLine(Array.IndexOf(sayiDizisi,23));


            // Resize

            Console.WriteLine("*** Array Resize ***");

            Array.Resize<int>(ref sayiDizisi,9);

            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi + " ");
            }

            Console.WriteLine();
        }
    }
}
