using System;
using System.Collections.Generic;
namespace dictionary
{
    class program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(10, "Ayşe Yılmaz");
            kullanıcılar.Add(12, "ahmet yılmaz");
            kullanıcılar.Add(18, "deniz arda");
            kullanıcılar.Add(23, "ilker kocaoglu");

            // dictionarynin elemanlarına erişim
            Console.WriteLine(kullanıcılar[12]);

            foreach (var item in kullanıcılar)
            Console.WriteLine(item);

            //count
            Console.WriteLine(kullanıcılar.Count);

            //contains -> true yada false dönderir 
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Zikriye Ürkmez"));

            //remove eleman çıkarma 
            Console.WriteLine(kullanıcılar.Remove(12)); //12 key olanı çıkart 
            foreach (var item in kullanıcılar)
            Console.WriteLine(item);

            //keys 
            foreach (var item in kullanıcılar)
            Console.WriteLine(item.Key);

            //values
            foreach (var item in kullanıcılar)
            Console.WriteLine(item.Value);
        }
    }                   
}