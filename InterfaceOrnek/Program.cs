namespace InterfaceOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Interface*************");
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Console.WriteLine("***********Abstract*************");
            NewFocus focus1 = new NewFocus();
            Console.WriteLine(focus1.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus1.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus1.StandartRengiNe().ToString());

            NewCivic civic1 = new NewCivic();
            Console.WriteLine(civic1.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic1.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic1.StandartRengiNe().ToString());
        }
    }
}
