using System;
namespace csharp_enum
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);
            int sıcaklık=0;
            Console.WriteLine("Sıcaklık Değeri Giriniz");
            sıcaklık=int.Parse(Console.ReadLine());

            if (sıcaklık <= (int)HavaDurumu.soguk)
                Console.WriteLine("Hava Soğuktur.");
            else if (sıcaklık <= (int)HavaDurumu.ılık)
                Console.WriteLine("Hava Ilıktır");
            else if (sıcaklık <= (int)HavaDurumu.sıcak)
                Console.WriteLine("Hava Sıcaktır");
            else if (sıcaklık <= (int)HavaDurumu.çoksıcak)
                Console.WriteLine("Hava COk Sıcaktır");
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        soguk=5,
        ılık=20,
        sıcak=30,
        çoksıcak=40
    }
}
