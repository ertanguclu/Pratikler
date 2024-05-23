namespace StructKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.UzunKenar = 4;
            dikdortgen.KisaKenar = 3;

            Console.WriteLine("Class Dikdörtgen Alanı: {0}", dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();
            dikdortgen_Struct.UzunKenar = 4;
            dikdortgen_Struct.KisaKenar = 3;
            Console.WriteLine("Struct Dikdörtgen Alanı: {0}", dikdortgen_Struct.AlanHesapla());
        }
    }

    class Dikdortgen
    {
        public int UzunKenar;
        public int KisaKenar;


        public Dikdortgen()
        {
            UzunKenar = 4;
            KisaKenar = 3;
        }

        public long AlanHesapla()
        {
            return this.UzunKenar * this.KisaKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int UzunKenar;
        public int KisaKenar;

        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            UzunKenar = uzunKenar;
            KisaKenar = kisaKenar;
        }

        public long AlanHesapla()
        {
            return this.UzunKenar * this.KisaKenar;
        }
    }
}
