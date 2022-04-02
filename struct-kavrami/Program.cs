using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            // dikdortgen.kisaKenar = 3;
            // dikdortgen.uzunKenar = 4;

            Console.WriteLine("Class alan hesaplaması: {0}",dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct(3,4);
            Console.WriteLine("Struct alan hesaplaması: {0}",dikdortgen_Struct.AlanHesapla());
        }
    }

    class Dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;

        public Dikdortgen(){
            // kisaKenar = 3;
            // uzunKenar = 4;
        }

        public long AlanHesapla(){
            return this.kisaKenar * this.uzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int kisaKenar;
        public int uzunKenar;

        // Parametresiz Constructor olamaz

        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }

        public long AlanHesapla(){
            return this.kisaKenar * this.uzunKenar;
        }
    }
}
