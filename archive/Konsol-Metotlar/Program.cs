namespace metotlar
{
    class program
    {
        static void Main(string[] args)
        {
            /* 
               Rekürsif ve Extension Metotlar
               Rekürsif - Öz yinelemeli           
            */
            int result=1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Islemler ınstance = new();
            Console.WriteLine(ınstance.Expo(3,4));

            // Extension Metotlar

            string ifade = "ilker kocaglu";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            //Sayısal dizisi sıralayan extension metot
            int[] dizi1 = { 10, 2, 37, 7, 5, 6, 3 };
            dizi1.SortArray();
            dizi1.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFırstCharacter());
        }
    }
    public class Islemler
    {
        public int Expo(int sayi,int üs)
        {
            if (üs < 2){
                return sayi;
            }
            return Expo(sayi, üs - 1)*sayi;
        }
    }
    public static class extension
    {
        public static bool CheckSpaces(this string param)  // boşluk varmı 
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces (this string param) //boşluklara "*" koy
        {
            string[] dizi = param.Split(" ");
            return string.Join("*", dizi);
        }

        public static string MakeUpperCase(this string param)  //hepsini büyük harf yap
        { 
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)  //hepsini küçük harf yap
        {
            return param.ToLower();
        }
        public static int[] SortArray (this int[] param)  //büyükten küçüğe sıralama
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)  //ekrana yazdırma
        {
            for(int i = 0; i < param.Length; i++)
            {
                Console.WriteLine(param[i]);
            }
        }
        public static bool IsEvenNumber(this int param) //çift sayımı 
        {
            return param % 2 == 0;
        }

        public static string GetFırstCharacter (this string param)  //verilen stringin ilk karakterini almak
        {
            return param.Substring(0,1); //0 dan başlayıp kaçıncı karaktere kadar gidecei 1
        }


    }
    
}