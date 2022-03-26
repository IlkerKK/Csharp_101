namespace KoleksiyonlarSoru2
{
    class KoleksiyonlarSoru2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("20 Adet Sayı giriniz");
            int[] dizi = new int[20];
            for (int i = 0; i < 20; i++)
            {
                dizi[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(dizi);
            Ortalama(dizi[0], dizi[1], dizi[2]);
            Ortalama(dizi[19], dizi[18], dizi[17]);
        }
        public static void Ortalama(int b, int a, int c)
        {
            int sonuc = (a + b + c) / 3;
            int toplam = (a + b + c);
            Console.WriteLine(sonuc);
            Console.WriteLine(toplam);

        }
    }
}