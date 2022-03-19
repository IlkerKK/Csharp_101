
using Inheritance;
using System;
namespace inheritance  //miras alma miras verme 
{
    class program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumlubitki1 = new TohumluBitkiler();
           /* tohumlubitki1.Beslenme();
            tohumlubitki1.Solunum();
            tohumlubitki1.Boşaltım();*/
            tohumlubitki1.TohumlaCogalma();
            
            Console.WriteLine("--------------");
            Kuslar serçe =new Kuslar();
           /* serçe.Solunum();
            serçe.Boşaltım();
            serçe.Beslenme();*/
            serçe.Ucmak();
            

        }
    }

}