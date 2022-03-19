using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bitkiler:Canlılar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler Fotosentez Yapar.");
        }
    }
    public class TohumluBitkiler:Bitkiler{
        public TohumluBitkiler()
        {
            base.FotosentezYapmak(); // protected lara erişme şansı verir
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu Bitkiler Tohumla Çoğalır");
        }  
    }

    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapmak(); // protected lara erişme şansı verir
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("TohumSUZ Bitkiler Sporla Çoğalır0");
        }
    }
}
