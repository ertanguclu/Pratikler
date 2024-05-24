namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //              canlılar
            //                 |
            //     Bitkiler           Hayvanlar
            //   |         |        |            |
            // Tohumlu  Tohumsuz  Sürüngenler  Kuşlar

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("**************");

            Kuslar martı = new Kuslar();
            martı.Ucmak();

        }
    }
}
