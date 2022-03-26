using System;
using System.Linq;
namespace KoleksiyonlarSoru3
{
    class KoleksiyonlarSoru3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bir CÜmle Giriniz");
            List<char> liste = new List<char>();
            string cumle = Console.ReadLine();
            for (int i = 0; i < cumle.Length - 1; i++)
            {
                if (cumle[i] == 'a' || cumle[i] == 'e' || cumle[i] == 'ı' || cumle[i] == 'i' || cumle[i] == 'o' || cumle[i] == 'ö' || cumle[i] == 'u' || cumle[i] == 'ü')
                {
                    liste.Add(cumle[i]);
                }
            }
            liste = liste.OrderBy(x => x).ToList();
            for (int j = 0; j < liste.Count; j++)
            {
                Console.Write(liste[j] + "-");
            }

        }
    }
}