using System;

namespace metotlar_rekursif
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif - Öz yinelemeli

            // 3^4
            int result = 1;
            for (int i = 1; i < 5; i++)
                result *= 3;

            Console.WriteLine(result);

            Islemler instance = new Islemler();

            Console.WriteLine(instance.Expo(2,5));


            // Extension Metotlar

            string ifade = "Gazi Mert";

            bool sonuc = ifade.checkSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
                Console.WriteLine(ifade.removeWhiteSpaces());


            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());


            int[] dizi = {9,3,6,2,1,5,0};

            dizi.EkranaYazdir();
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());
        }   
    }

    public class Islemler
    {
        public int Expo(int sayi, int us){
            if (us < 2)
                return sayi;
            return Expo(sayi,us-1)*sayi;
        }
    }

    public static class Extension
    {
        public static bool checkSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string removeWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (int sayi in param)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
