using System;
namespace Encapsulation_Property
{
        class program
    {
        static void Main(string[] args)
        {
            //kapsülleme bir nesnenin bazı özelliklerini işlevlerini classlarını diğer nesnelerden korumak için 
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isım = "İlker";
            ogrenci1.Soyisim = "kocaogly";
            ogrenci1.OgrenciNo = 167540;
            ogrenci1.Sinif = 11;

            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Deniz", "Kara", 246875, 1);
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.SinifDüşür();
            ogrenci2.OgrenciBilgileriniGetir();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isım { get => isim ; set => isim = value; } 
        public string Soyisim { get => soyisim ; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get => sinif; 
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olmalıdır");
                    sinif = 1;
                }
                else
                sinif = value;   
            } 
        }  
        
        public Ogrenci(string isim,string soyisim,int ogrenciNo,int sinif) {
            Isım = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci() { }
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***Öğrenci Bilgileri***");
            Console.WriteLine("Öğenci Adı       :{0}",this.Isım);
            Console.WriteLine("Öğenci SoyAdı       :{0}", this.Soyisim);
            Console.WriteLine("Öğenci No       :{0}", this.OgrenciNo);
            Console.WriteLine("Öğenci Sınıfı       :{0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDüşür()
        {
            this.Sinif = this.Sinif - 1;
        }


    }
}