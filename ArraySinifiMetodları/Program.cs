namespace ArraySinifiMetodları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("***** Sırasız Dizi *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("***** Sıralı Dizi *****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Clear
            Console.WriteLine("***** Array Clear Metodu *****");
            Array.Clear(sayiDizisi, 2, 2); //2.indexten itibaren 2 elemanı sıfırlar.
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //Reverse
            Console.WriteLine("***** Array Reverse Metodu *****");
            Array.Reverse(sayiDizisi);//Diziyi ters çevirir.İlk elamanı son son elemanı ilk eleman yapar.
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //IndexOf
            Console.WriteLine("***** Array IndexOf Metodu *****");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));//23 elemanının indexini döner.
            //Resize
            Console.WriteLine("***** Array Resize Metodu *****");
            Array.Resize<int>(ref sayiDizisi, 9);//Dizinin boyutunu 9 yapar ve elemanları korur.
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

        }
    }
}
