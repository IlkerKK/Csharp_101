using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Hayvanlar:Canlılar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar Adaptasyon Kurabilir.");
        }
    }

    public class Sürüngenler:Hayvanlar
    {
        public Sürüngenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void SürünerekHareketEtmek()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
        }
    }

    public class Kuslar:Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar Uçarlar");
        }
    }
}
