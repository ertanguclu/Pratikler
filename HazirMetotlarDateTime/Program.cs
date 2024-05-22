namespace HazirMetotlarDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);//Haftanın günü
            Console.WriteLine(DateTime.Now.DayOfYear);//Yılın kaçıncı günü

            Console.WriteLine(DateTime.Now.ToLongDateString());//Tarih ve gün string olarak
            Console.WriteLine(DateTime.Now.ToShortDateString());//Tarih
            Console.WriteLine(DateTime.Now.ToLongTimeString());//Saat, dakika ve saniyeyi getiri
            Console.WriteLine(DateTime.Now.ToShortTimeString());//Saat ve dakikayi getirir

            Console.WriteLine(DateTime.Now.AddDays(2));// tarihine 2 gün ekler
            Console.WriteLine(DateTime.Now.AddHours(3));// tarihine 3 saat ekler
            Console.WriteLine(DateTime.Now.AddSeconds(3));// tarihine 3 saniye ekler
            Console.WriteLine(DateTime.Now.AddMonths(3));// tarihine 3 ay ekler
            Console.WriteLine(DateTime.Now.AddYears(3));// tarihine 3 yıl ekler
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));// tarihine 50 milisaniye ekler

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//sadece gün sayısal oalrak getirir
            Console.WriteLine(DateTime.Now.ToString("ddd"));//günün kısaltması getirir çarşamba çar olarak
            Console.WriteLine(DateTime.Now.ToString("dddd"));//günün tam adını getirir
            Console.WriteLine(DateTime.Now.ToString("MM"));//ayı sayısal olarak getirir 05
            Console.WriteLine(DateTime.Now.ToString("MMM"));//ayın kısaltmasını getirir May
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//ayın tam adını getirir Mayıs
            Console.WriteLine(DateTime.Now.ToString("yy"));//yılın son iki hanesini getirir
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//yılın tamamını getirir 24
            Console.WriteLine(DateTime.Now.ToString("HH"));//saati 24 saatlik olarak getirir 2024

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));//mutlak değer
            Console.WriteLine(Math.Sin(10));//sinüs
            Console.WriteLine(Math.Cos(10));//cosinüs
            Console.WriteLine(Math.Tan(10));//tanjant

            Console.WriteLine(Math.Ceiling(22.3));//yukarı yuvarlar
            Console.WriteLine(Math.Floor(22.7));//aşağı yuvarlar
            Console.WriteLine(Math.Round(22.3));//en yakın sayıya yuvarlar 22
            Console.WriteLine(Math.Round(22.7));//en yakın sayıya yuvarlar 23

            Console.WriteLine(Math.Max(2, 6));//en büyük sayıyı getirir
            Console.WriteLine(Math.Min(2, 6));//en küçük sayıyı getirir

            Console.WriteLine(Math.Pow(3, 4));//3 üzeri 4
            Console.WriteLine(Math.Sqrt(9));//karekök
            Console.WriteLine(Math.Log(9));//logaritma 9 un e tabanında karşılığını verir
            Console.WriteLine(Math.Exp(3));//e üzeri 3
            Console.WriteLine(Math.Log10(10));//10 un 10 tabanındaki karşılığı


        }
    }
}
