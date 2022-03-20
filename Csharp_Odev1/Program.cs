using System;
namespace odevbir
{
    class odev1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ÖDEV 1. SEÇENEK");
            int sayi = 0, sayi1 = 0;
            Console.WriteLine("Bir pozitif sayı giriniz");
            sayi=int.Parse(Console.ReadLine());
            Console.WriteLine(sayi + " tane sayi giriniz");
            int[] dizi = new int[sayi];
            for (int i = 0; i <= sayi-1; i++)
            {
                dizi[i]=int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < dizi.Length; j++)
            {
                if (dizi[j] % 2 == 0)
                {
                    Console.Write(dizi[j] + "-");
                }
            }
            Console.WriteLine("ÖDEV 2. SEÇENEK");
            Console.WriteLine("İki pozitif sayı giriniz");
            int n = 0, m = 0;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Console.WriteLine(n + " tane pozitif sayi giriniz");
            int[] dizi = new int[n];
            for (int i = 0; i <= n - 1; i++)
            {
                dizi[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < dizi.Length; j++)
            {
                if(dizi[j] == m || dizi[j] % m == 0)
                {
                    Console.Write(dizi[j]+"-");
                }
            }
            Console.WriteLine("ÖDEV 3. SEÇENEK");
            Console.WriteLine("1 adet pozitif sayı giriniz");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + "Adet kelime giriniz");
            string[] dizi = new string[n];
            for (int i = 0; i <= n - 1; i++)
            {
                dizi[i]=Console.ReadLine();
            }
            for(int j = n - 1; j >= 0; j--)
            {
                Console.Write(dizi[j] + " ");

            }
            Console.WriteLine("ÖDEV 4. SEÇENEK");
            Console.WriteLine("1 adet cümle giriniz");
            int bosluk=0;
            string cumle;
            cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Kelime Sayısı :" + kelimeler.Length);
            Console.WriteLine("Toplam Kelime=" +(kelimeler.Length-1)+ "Toplam harf=" + (cumle.Length-(kelimeler.Length - 1)));

            
        }
    }
}
