using System;
namespace statiksınıf_üyeler
{
    class program
    {
        static void Main(string[] args)
        {
            /*Calisan calisan1 = new Calisan("ilker","kocaoglu","yazılım");

            foreach (var item in calisan1)
            Console.WriteLine(item);*/
            Console.WriteLine("Çalışan Sayısı:{0}",Calisan.CalisanSayisi);
            Calisan calısan1 = new Calisan("ilker", "kocaoglu", "yazılım");
            Console.WriteLine("Çalışan Sayısı:{0}", Calisan.CalisanSayisi);


            Console.WriteLine("Toplama isleminin sonucu:"+Islemler.Topla(5, 3));
            Console.WriteLine("Çıkarma isleminin sonucu:{0}",Islemler.Cıkar(5, 3));

        }
    }
    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }
        public Calisan(string ısim, string soyisim, string departman)
        {
            Isim = ısim;
            Soyisim = soyisim;
            Departman = departman;
            calisanSayisi++;
        }

    }
    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }



}