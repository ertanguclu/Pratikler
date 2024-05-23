using System.Collections;
using System;
namespace ArrayListt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            //İçerisindeki elemanlara erişim
            //Console.WriteLine(liste[1]);

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            //AddRange //Birden fazla eleman eklemek için
            Console.WriteLine("***** Add RAnge *****");
            //string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
            List<int> sayılar = new List<int>() { 1, 8, 3, 7, 9, 92, 5, 6 };
            //liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("***** Sort *****");
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Binary Search
            Console.WriteLine("***** Binary Search *****");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("***** Reverse *****");
            liste.Reverse();//Diziyi ters çevirir
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("***** Clear *****");
            liste.Clear();//Tüm elemanları temizler
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }



        }
    }
}
