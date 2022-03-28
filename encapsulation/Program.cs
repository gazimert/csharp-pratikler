using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;

            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz","Arda",256,1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { 
            get {return isim;}
            set {isim = value;} 
        }

        
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get => sinif; 
            set
            {
                if (value < 1){
                    Console.WriteLine("Sınıf 1 den küçük olamaz");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }


        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){

        }

        public void OgrenciBilgileriniGetir(){
            Console.WriteLine("***** Öğrenci Bilgileri *****");
            Console.WriteLine("Öğrenci Adı: {0}", this.isim);
            Console.WriteLine("Öğrenci Soyadı: {0}", this.soyisim);
            Console.WriteLine("Öğrenci Numarası: {0}", this.ogrenciNo);
            Console.WriteLine("Öğrenci Sınıfı: {0}", this.sinif);
        }

        public void SinifAtlat(){
            this.Sinif++;
        }

        public void SinifDusur(){
            this.Sinif--;
        }
    }
}
