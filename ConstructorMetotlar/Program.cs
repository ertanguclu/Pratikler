﻿namespace ConstructorMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            // class SinifAdi
            // {
            //     [Erişim Belirleyici] [Veri Türü] Özellik Adı;
            //     [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdı([Parametre Listesi])
            //     {
            //         //Metot içeriği
            //     }
            // }

            //Erişim Belirleyiciler
            // public: Her yerden erişilir
            // private: Sadece tanımlandığı sınıf içerisinden erişilebilir
            // protected: Sadece tanımlandığı sınıf ve bu sınıftan türetilen sınıflardan erişilebilir
            // internal: Sadece tanımlandığı proje içerisinden erişilebilir

            Calisan calisan1 = new Calisan("Ayşe","Kara", 23425624, "İnsan Kaynakları");

            calisan1.CalisanBilgileri();

            Console.WriteLine("******Çalışan 2*******");
            Calisan calisan2 = new Calisan();

            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 25646789;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri();

            Console.WriteLine("*****Çalışan 3******");
            Calisan calisan3 = new Calisan("Ertan", "Güçlü");
            calisan3.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan() { }
        

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
    }
}
