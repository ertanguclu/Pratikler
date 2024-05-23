namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collection.Generic
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(10, "Ertan Güçlü");
            kullanıcılar.Add(12, "Ahmet Yılmaz");
            kullanıcılar.Add(18, "Deniz Arda");
            kullanıcılar.Add(20, "Özcan Coşar");

            //Dizinin elemanalrına erişim
            Console.WriteLine("***** Elemanlara Erişim *****");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("***** Count *****");
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(kullanıcılar.ContainsKey(12));//12 keyine sahip eleman var mı
            Console.WriteLine(kullanıcılar.ContainsValue("Ertan Güçlü"));//Ertan Güçlü value'suna sahip eleman var mı

            //Remove
            Console.WriteLine("***** Remove *****");
            kullanıcılar.Remove(12);//12 keyine sahip elemanı sil
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);// item.key ve item.value yazılırsa keyleri veya valueleri yazdırır
            }

            //Keys
            Console.WriteLine("***** Keys *****");
            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("***** Values *****");
            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }


        }
    }
}
