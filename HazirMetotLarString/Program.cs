namespace HazirMetotLarString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Charp, Hoşgeldiniz!";
            string degisken2 = "Charp";

            //Lenght
            Console.WriteLine(degisken.Length);

            //ToUpper - ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            //Compare - CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //0, 1,-1
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Ertan"));
            Console.WriteLine(degisken.LastIndexOf("i"));//en son i harfinin indexini verir

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));//0. indexe Merhaba! ekler

            //PadLeft - PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));//30 karakterlik bir alan oluşturur ve sağa yaslar
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));//30 karakterlik bir alan oluşturur ve sağa yaslar kelimeyi aradaki boşluğa yıldız yazar
            Console.WriteLine(degisken.PadRight(50) + degisken2);//50 karakterlik bir alan oluşturur ve sola yaslar
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);//50 karakterlik bir alan oluşturur ve sola yaslar kelimeyi aradaki boşluğa tire yazar

            //Remove
            Console.WriteLine(degisken.Remove(10));//10. indexten sonrasını siler
            Console.WriteLine(degisken.Remove(5, 3));//5. indexten başlayarak 3 karakter siler
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("Csharp", "C#"));//Csharp kelimesini C# ile değiştirir
            Console.WriteLine(degisken.Replace(" ", "*"));//boşlukları * ile değiştirir

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);//boşluklara göre ayırır ve 1. indexi yazar

            //Substring
            Console.WriteLine(degisken.Substring(4));//4. indexten başlayarak sonuna kadar yazar
            Console.WriteLine(degisken.Substring(4, 6));//4. indexten başlayarak 6 karakter yazar




        }
    }
}
