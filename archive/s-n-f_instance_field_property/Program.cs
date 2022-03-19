using System;
namespace sınıf_instance_field_property
{
    class program
    {
        static void Main(string[] args)
        {
            /*
            erişim belirleyiciler
             * public -> heryerden erişilebilir 
             * prıvate -> sadece tanımlandığı sınıf içerisinde erişilebilen metotlar
             * ınternal -> sadece kendi bulunduğu proje içerisinde erişilebilen değişkenler ve metotlara
             * Protected -> sadece tanımlandığı sınıfta veya o sınıftan miras(kalıtım) alan diğer sınıftan erişilebilir
            */
            calısan calısan1 = new calısan();
            calısan1.Ad = "Ayşe";
            calısan1.SoyAd = "Kara";
            calısan1.No = 234234234;
            calısan1.Departman = "İnsan Kaybakları";
            calısan1.CanlısanBilgileri();
            Console.WriteLine("-------------");
            calısan calısan2 =new calısan();
            calısan2.Ad = "ilker";
            calısan2.SoyAd = "Kocaoglu";
            calısan2.No = 167540;
            calısan2.Departman = "Yazılım";
            calısan2.CanlısanBilgileri();

        }
    }
    class calısan
    {
        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;
        public void CanlısanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan SoyAdı:{0}", SoyAd);
            Console.WriteLine("Çalışan Numarası:{0}", No);
            Console.WriteLine("Çalışan Departmanı:{0}", Departman);
        }
    }
}