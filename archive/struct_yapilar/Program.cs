using System;
namespace struck_yapilar
{
    class program
    {
        static void Main(string[] args)
        {
            dikdortgen dikdortgen = new dikdortgen();
            dikdortgen.kisaKenar = 5;
            dikdortgen.uzunKenar = 6;

            Console.WriteLine("Class alan hesaplama={0}",dikdortgen.ALanHesapla());

            dikdortgen_struct dikdortgen_struct = new dikdortgen_struct(3,4);
            //dikdortgen_struct.kisaKenar = 7;
            //dikdortgen_struct.uzunKenar = 8;
            Console.WriteLine("Struct alan hesaplama={0}", dikdortgen_struct.ALanHesapla());


            dikdortgen_struct dikdortgen_Struct1;
            dikdortgen_struct.kisaKenar = 10;
            dikdortgen_struct.uzunKenar = 21;   // bu şekilde alan hesaplama çağırılamaz 
            Console.WriteLine("Struct alan hesaplama={0}", dikdortgen_struct1.ALanHesapla(
        }
    }
    class dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;

        public dikdortgen(){  //bu ifade struct ta tanımlanamaz
            kisaKenar = 3;
            uzunKenar = 4;
            }
        public long ALanHesapla()
        {
            return this.kisaKenar*this.uzunKenar;
        }
    }

    struct dikdortgen_struct
    {
        public int kisaKenar;
        public int uzunKenar;

        public dikdortgen_struct(int KisaKenar,int UzunKenar)
        {
            kisaKenar = KisaKenar;
            uzunKenar = UzunKenar;
        }
        public long ALanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }

    }

}
// sonuç olarak class kullanın 