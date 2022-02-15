using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // erisim_belirteci geri_donus_tipi metot_adi(parametreListesi/arguman)
            // {
            //     komutlar
            // }


            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);

            int sonuc = topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.ekranaYazdir(sonuc.ToString());


            int sonuc2 = ornek.arttirVeTopla(ref a,ref b);
            ornek.ekranaYazdir(sonuc2.ToString());
            ornek.ekranaYazdir((a+b).ToString());            
        }

        static int topla(int deger1, int deger2){
            return deger1 + deger2;
        }
    }

    class Metotlar
    {
        public void ekranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int arttirVeTopla(ref int deger1,ref int deger2)
        {
            deger1++;
            deger2++;
            return deger1 + deger2;
        }
    }
}
