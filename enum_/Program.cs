﻿using System;

namespace enum_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 25;

            if (sicaklik <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
            else if (sicaklik >= (int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak.");
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik <= (int)HavaDurumu.CokSıcak)
                Console.WriteLine("Dışarıya çıkmak için sıcaklık uygun.");
        }
    }

    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSıcak = 30
    }
}
