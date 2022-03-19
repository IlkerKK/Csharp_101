using System;
using System.Collections.Generic;

namespace Generic_list
{
    class Program
    {
        static void Main (string [] args)
        {
            //List<T> Class
            //System.Collections.Generic 
            // T-> object türündedir hangi tip olduğunu burda belirtmemiz gerekir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string> ();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            Console.WriteLine(sayiListesi.Count);  //listenin eleman sayıları gösterme
            Console.WriteLine(renkListesi.Count);

            foreach(var sayi in sayiListesi)   //foreach ile ekrana yazdırma
            {
                Console.WriteLine(sayi);   
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi =>Console.WriteLine(sayi));  //farklı türde foreach 
            renkListesi.ForEach(sayi => Console.WriteLine(sayi));

            sayiListesi.Remove(4);  //Sayı listesinden eleman çıkarma
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);  // index vererek listeden çıkarma
            renkListesi.RemoveAt(1);

            if (sayiListesi.Contains(10)) // liste içerisinde eleman arama
            {
                Console.WriteLine("10 liste içerisinde bulundu");
            }

            Console.WriteLine(renkListesi.BinarySearch("Kırmızı")); // eleman ile index'e erişme 

            string[] hayvanlar = { "Kedi", "köpek", "kuş" };  //hayvanlar dizisi
            List<string> listHayvanlar = new List<string>(hayvanlar); // hayvanlar dizisini list'e çeviri

            listHayvanlar.Clear(); //tüm listeyi temizler 

            //----Liste İçerisinde Elelman Tutmak---//
            //önce class oluşturduk 
            List<kullanıcılar> kullanıcılistesi = new List<kullanıcılar>();
            kullanıcılar kullanıcı1 = new kullanıcılar();
            kullanıcı1.Isim = "ilker";
            kullanıcı1.Soyisim = "kocaoğlu";
            kullanıcı1.Yas = 24;

            kullanıcılar kullanıcı2 = new kullanıcılar();
            kullanıcı2.Isim = "Ayşe";
            kullanıcı2.Soyisim = "Yılaz";
            kullanıcı2.Yas = 26;

            kullanıcılistesi.Add(kullanıcı1);
            kullanıcılistesi.Add(kullanıcı2);

            List<kullanıcılar> yeniListe = new List<kullanıcılar>(); //farklı bir yöntem ile ekleme
            yeniListe.Add(new kullanıcılar(){                
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 25
            });
            
            foreach (var kullanıcılar in kullanıcılistesi) //kullanıcılar classların ekrana yazdırma 
            {
                Console.WriteLine("Kullanıcı adı" + kullanıcılar.Isim);
                Console.WriteLine("Kullanıcı soyadı" + kullanıcılar.Soyisim);
                Console.WriteLine("Kullanıcı yaşı" + kullanıcılar.Yas);
            }
        }
    }
    public class kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get { return isim; } set { isim = value; } }
        public string Soyisim { get { return soyisim; } set { soyisim = value; } } 
        public int Yas { get { return yas; } set { yas = value; } } 
    }
}