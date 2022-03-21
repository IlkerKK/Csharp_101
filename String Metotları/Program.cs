using System;
namespace hazir_metotlar_string
{
    class program
    {
        static void Main(string[] args)
        {
            //hazır string metotları kütüphaneleri 
            string degisken = "dersimiz c# hoşgeldiniz";
            string degisken2 = "dersimiz csharp";

            Console.WriteLine(degisken.Length); //verilen değişkenin karakter sayısı
            Console.WriteLine(degisken.ToLower()); // hepsini küçük yazma
            Console.WriteLine(degisken.ToUpper()); // hepsini büyük yazma
            Console.WriteLine(String.Concat(degisken, "selamlar ")); //stringe ekleme yapmak için 
            Console.WriteLine(degisken.CompareTo(degisken2)); // 1. değişken 2 den büyükse 1, eşitse 0, küçükse -1 dönderir
            Console.WriteLine(String.Compare(degisken, degisken2, true)); // true ise büyük 2 stringi karşılaştırırken büyük-küçük harfduyarlıdır falsa ise duyarsızdır(0 dönderir)
            Console.WriteLine(degisken.Contains(degisken2)); // 1.degisken içinde 2. değişkenden varmı. Varsa 1 yoksa 0 dönderir
            Console.WriteLine(degisken.EndsWith("hoşgeldiniz")); // degisken "hoşgeldiniz ile bitiyormu
            Console.WriteLine(degisken.StartsWith("Selam")); // degisken "Selam" ile başlıyormu 
            Console.WriteLine(degisken.IndexOf("CS")); // değişken içerisinde CS arar bulursa "C" nin indexini döner, bulmassa "-1" döner 
            Console.WriteLine(degisken.Insert(0, "hi!")); // 0 ıncı indexten başlayarak stringin başına "Hi!" ekler
            Console.WriteLine(degisken.LastIndexOf("i")); // degisken içerisinde son i ' nin indexini getirir
            Console.WriteLine(degisken + degisken2.PadLeft(30)); // degisken 2 nin karakter sayısını 30'a tamamlayarak boşluk ekler
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*')); // degisken 2 nin karakter sayısını 30'a tamamlayarak '*' ekler
            Console.WriteLine(degisken.PadRight(50) + degisken2); // degisken birin karakter sayısını 50'ye tamamlayarak boşluk bırakır ve en sonra değisken 2 yi yazar
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2); // degisken birin karakter sayısını 50'ye tamamlayarak '-' koyar ve en sonra değisken 2 yi yazar
            Console.WriteLine(degisken.Remove(10)); // 10uncu indexten başlayarak sonuna kadar siler 
            Console.WriteLine(degisken.Remove(5, 3)); // 5. indexten sonra 3 adet index siler 
            Console.WriteLine(degisken.Remove(0, 1)); // 0. indexten sonra 1 index siler yani ilk harf silindi
            Console.WriteLine(degisken.Replace("Csharp", "c#")); //"Csharp" yazan yerleri "c#" ile değiştir
            Console.WriteLine(degisken.Replace(" ", "-")); //" " yazan yerleri "-" ile değiştir  --> boşluklara * koy                                                 
            Console.WriteLine(degisken.Split(' ')[1]); // bunu ' ' göre parçana ve diziye ata ve bana [1] indexi getir
            Console.WriteLine(degisken.Substring(4)); // 4. indexten başlayarak stringin sonuna kadar getir
            Console.WriteLine(degisken.Substring(4, 6)); // 4. indexten başlayarak 6 karakter getir 
        }
    }
}