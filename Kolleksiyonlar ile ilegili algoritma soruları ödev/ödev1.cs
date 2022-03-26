namespace KoleksiyonlarSoru1
{
    class Koleksiyonlarsoru1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("20 adet sayı giriniz");
            List<int> liste = new List<int>();
            int a = 0;
            for (int i = 0; i < 5; i++)
            {
                a = int.Parse(Console.ReadLine());
                liste.Add(a);
            }
            List<int> asalList = new List<int>();
            List<int> asalolmayanList = new List<int>();
            for (int j = 0; j < 5; j++)
            {
                if (Asalmi(liste[j]) == 0)
                {
                    Console.WriteLine("sayı asal değildir");
                    asalolmayanList.Add(liste[j]);
                }
                else if (Asalmi(liste[j]) == 1)
                {
                    Console.WriteLine("sayı asaldır");
                    asalList.Add(liste[j]);
                }
            }
            asalList.Sort();
            asalolmayanList.Sort();
            for (int b = 0; b < 5; b++)
            {
                Console.Write(asalList[b] + "-");
            }
            Console.WriteLine(" ");

            for (int b = 0; b < 5; b++)
            {
                Console.Write(asalolmayanList[b] + "-");
            }

            int asalolmayanToplam = 0, asalToplam = 0;
            for (int b = 0; b < 5; b++)
            {
                Console.Write(asalolmayanList[b]);
                asalolmayanToplam = asalolmayanList[b] + asalolmayanToplam;
            }
            Console.WriteLine(" ");
            for (int b = 0; b < 5; b++)
            {
                Console.Write(asalList[b]);
                asalToplam = asalList[b] + asalToplam;
            }

            Console.WriteLine("Asal olmayan sayıların ortalamaları= " + (asalolmayanToplam / 20) + "Asalların Toplammı" + (asalToplam / 20));

        }
        private static int Asalmi(int sayi)
        {
            int i;
            if (sayi == 1)
            {
                return 1;
            }
            else
            {
                for (i = 2; i <= sayi - 1; i++)
                {
                    if (sayi % i == 0)
                    {
                        return 0;
                    }
                }
                if (i == sayi)
                {
                    return 1;
                }
                return 0;
            }
        }
    }
}