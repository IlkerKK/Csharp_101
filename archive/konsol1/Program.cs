using System;

namespace konsol1
{
    class deneme
    {
        public static void Main(string[] args)
        {
            //-----------------------------//
            try
            {
                Console.WriteLine("Bir Sayı Gİriniz");
                //System.Console.WriteLine("using system kullanmadan bu şekildede yazılabilir ama önerilmez")
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("10 fazlası: " + (sayi + 10));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hatalı Giriş" + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı");
            }

            //kesinlikle boş değer girilemez//
            try
            {
                //int a = int.Parse(null);  boş değer girilmesi 
                //int a = int.Parse("test");  yanlış veri tipinde değer girilmesi
                int a = int.Parse("-20000000000000"); //değişken aralığından çok fazla veya çok küçük değer girilirse 
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("boş değer giriniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi Uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Sayı miktarı çok yüksek");
                Console.WriteLine(ex);
            }

            //-----------------------------//
            int time = DateTime.Now.Hour;
            if (time < 12)
            {
                Console.WriteLine("Öğlenden Önce");
            } else if (time > 12)
            {
                Console.WriteLine("Öğlenden Sonra");
            }

            string sonuc = time <= 18 ? "iyi günler " : "iyi geceler";
            Console.WriteLine("Sonuç" + sonuc);

            //-----------------------------//

            int mount = DateTime.Now.Month;
            switch (mount)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış");
                    break;
                case 5:
                    Console.WriteLine("şubat");
                    break;
                case 3:
                    Console.WriteLine("mart");
                    break;
                default:
                    Console.WriteLine("deafult");
                    break;

            }

            //-----------------------------//

            int sayac = int.Parse(Console.ReadLine()); // ekrana girilen sayıya kadar olan tek sayılar
            for (int b = 0; b < sayac; b++)
            {
                if (b % 2 == 1)
                {
                    Console.WriteLine(b);
                }

            }

            //break: bir döngüyü sonlandırmak için 
            //continue: mevcut döngünün içinde olduğu küçük döngüden çıkmak için 

            for (int u = 0; u < sayac; u++)
            {
                if (u == 4)
                {
                    break; // bu şekilde ekrana 1-2-3 yazar // // continue yazarksa 1-2-3-5-6-7-8-9-10 -- yani 4 yok //
                    Console.WriteLine(u);
                }

            }

            //-----------------------------// while
            int i = 1, sayi1, toplam1 = 0;
            Console.WriteLine("Bir Sayı Giriniz");
            sayi1 = int.Parse(Console.ReadLine());
            while (i <= sayi1)
            {
                toplam1 += i;
                i++;
            }
            Console.WriteLine("Ortalamaları = " + toplam1 / sayi1);

            //-----------------------------// foreach
            Console.WriteLine("FOREACH");
            string[] arabalar = { "BMW", "FORD", "FIAT", "TOYOTA", "MERCEDES" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

            //-----------------------------// diziler
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            int[] dizi = new int[5];
            int toplam = 0;

            renkler[0] = "mavi";
            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(renkler[0]);
            dizi[3] = 321;

            Console.WriteLine("Eleman sayısını giriniz");
            int elemansayısı = int.Parse(Console.ReadLine());
            int[] ortlm = new int[5];
            ;
            for (int a = 0; a < elemansayısı; a++)
            {
                Console.WriteLine((a + 1) + ". elemanı giriniz");
                ortlm[a] = int.Parse(Console.ReadLine());
            }
            for (int o = 0; o < elemansayısı; o++)
            {
                toplam += ortlm[o];
            }
            Console.WriteLine("Ortalamaları = " + toplam / elemansayısı);

            //-----------------------------// array methotlar

            //sort -- sıralam yapar
            int[] sayılar = { 23, 12, 86, 72, 3, 11, 17 };
            for (int w = 0; w < 7; w++)
            {
                Console.WriteLine(sayılar[w]); //sırasız dizi
            }

            Array.Sort(sayılar);
            for (int w = 0; w < 7; w++)
            {
                Console.WriteLine(sayılar[w]); //sıralı dizi
            }

            //clear -- verilen eleman sayısı akdar değeri 0 yapar 

            Array.Clear(sayılar, 2, 2); // sayılar dizisinde 2. elemandan sonra 2 sayısı temizle (yani 2. ve 3. eleman)
            for (int w = 0; w < 7; w++)
            {
                Console.WriteLine(sayılar[w]); //dizi içerisinden eleman temizleme
            }

            //reverse -- tersine çevirme

            Array.Reverse(sayılar);
            for (int w = 0; w < 7; w++)
            {
                Console.WriteLine(sayılar[w]); //diziyi tersine çevirir
            }

            //indexof -- söylenen elemanın indexini döner 
            Console.WriteLine(Array.IndexOf(sayılar, 72));


            //resize -- yeniden boyutlandırma
            Array.Resize<int>(ref sayılar, 9);
            sayılar[8] = 99;
            for (int w = 0; w < 9; w++)
            {
                Console.WriteLine(sayılar[w]); //diziyi tersine çevirir
            }

            //-----------------------------// methot tanımlama ayrıntılı
            /* fonksiyonlar küçük parçalara ayırarak yazma -> daha okunabilir , kod tekrarından kaçınma */
            /* aynı class içerisindeki metodu direk çekebilirsiniz ancak farklı classların içerisindeki methotları çekmek için o classın bir örneğini yaratılması lazım */
            







        }

    }
}