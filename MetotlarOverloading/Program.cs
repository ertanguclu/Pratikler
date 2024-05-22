namespace MetotlarOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                System.Console.WriteLine("Başarısız!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(2, 3, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot Overloading - Aşırı Yükleme
            //Metotlar aynı isimde olabilirler fakat parametre sayıları ve tipleri farklı olmalıdır.
            //Bu durumda metotlar aşırı yüklenmiş olur.

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Ertan", "Güçlü");

            //Metot imzası - Metot adı + parametre sayısı + parametre tipleri

        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
