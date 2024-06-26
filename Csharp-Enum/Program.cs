﻿namespace Csharp_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 32;
            if (sıcaklık <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
            }
            else if(sıcaklık >=(int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");
            }
            else if(sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.CokSıcak)
            {
                Console.WriteLine("Hadi dışarıya çıkalım.");
            }
        }
    }

    enum Gunler
    {
        Pazartesi = 1,
        Sali = 2,
        Carsamba = 3,
        Persembe = 4,
        Cuma = 5,
        Cumartesi = 6,
        Pazar = 7
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal=20 ,
        Sıcak = 25 ,
        CokSıcak = 30
    }
}
