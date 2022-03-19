using System;
using System.Collections;
using System.Collections.Generic;
namespace arrayList
{
    class program
    {
        static void Main(string[] args)
        {
            //arraylis = kolleksiyon tipi 

            ArrayList Liste = new ArrayList();
            Liste.Add("Ayşe");
            Liste.Add(2);
            Liste.Add(true);
            Liste.Add('A');

            foreach (var item in Liste)
            Console.WriteLine(item);

            //AddRange -> birden fazla elemanı eklemek
            Console.WriteLine("****ADD RANGE****");
            string[] renkler = { "kırmızı", "sarı", "yeşil" };
            Liste.AddRange(renkler);

            List<int> sayılar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };

            Liste.AddRange(renkler);
            Liste.AddRange(sayılar);

            foreach (var item in Liste)
            Console.WriteLine(item);

            //sort 
            Console.WriteLine("****Sort****");
            Liste.Sort(); //içerisinde string olduğu için düzenli sıralayamaz stringleri yorum satırı yapıncaçalışır

            foreach (var item in Liste)
            Console.WriteLine(item);

            //binarysearch 
            Console.WriteLine("****Binary search****");
            Console.WriteLine(Liste.BinarySearch(9));


            //reverse ortadan ayna gibi tersi şekilinde sıralar
            Console.WriteLine("****Reverse****");
            Liste.Reverse();

            foreach (var item in Liste)
            Console.WriteLine(item);


            //clear listeyi temizler
            Console.WriteLine("****Clear****");
            Liste.Clear();
            foreach (var item in Liste)
            Console.WriteLine(item);

        }
    }
}
