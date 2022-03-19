using System;

namespace datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            //---DateTime---//
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.DayOfWeek);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime Format 
            Console.WriteLine(DateTime.Now.ToString("dd")); //09
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Çar
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Çarşamba

            Console.WriteLine(DateTime.Now.ToString("MM")); //03
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Mar
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //Mart

            Console.WriteLine(DateTime.Now.ToString("yy")); //22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

            //---Math---//
            Console.WriteLine(Math.Abs(-25)); //Mutlak alır --> 25 döner
            Console.WriteLine(Math.Sin(30)); //Sinüs alır 
            Console.WriteLine(Math.Cos(30)); //Cosinüs
            Console.WriteLine(Math.Tan(30)); //Tanjant
                                                   //bu üçü Double üzerinde çalışır             
            Console.WriteLine(Math.Ceiling(22.3)); // yukarı yuvarlar  -->23 
            Console.WriteLine(Math.Round(22.3)); // en yakına yuvarlar -->23
            Console.WriteLine(Math.Floor(22.7)); // aşağıya yuvarlar -->22

            Console.WriteLine(Math.Max(2, 6)); 
            Console.WriteLine(Math.Min(2, 6)); 

            Console.WriteLine(Math.Pow(3, 4)); // 3 üzeri 4 = 81
            Console.WriteLine(Math.Sqrt(9)); // karekök alır 
            Console.WriteLine(Math.Log(9)); // e tabanında logaritma hesaplar
            Console.WriteLine(Math.Exp(3)); // e üzeri 3
            Console.WriteLine(Math.Log10(10)); // 10 tabanında log karşılığı 



        }

    }
}