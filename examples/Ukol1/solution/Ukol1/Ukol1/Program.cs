using System;
using System.Collections.Generic;
using System.Text;

namespace Ukol1
{
    class Program
    {
        static void Main(string[] args)
        {

            Bod a = new Bod2D(1, 1);
            Bod b = new Bod2D(1, 2);
            Bod c = new Bod2D(2, 2);
            Bod d = new Bod2D(2 ,1);
            Tvar ctverec = new Ctverec(a,b,c,d);
            Tvar trojuhelnik = new Trojuhelnik(a, b, c);
            ctverec.VratObsah();
            trojuhelnik.VratObsah();

            Bod x = new Bod2D(1, 2);
            Bod y = x;

            x.VypisBod();
            y.VypisBod();

            Bod[] pole=new Bod[10];
            for(int i=0;i<10;i++) {
                if (i%2==0) pole[i]=new Bod3D(i,i+1,i*i);
                else pole[i]=new Bod2D(i*i,i);
            }
            foreach (Bod bod in pole) bod.VypisBod();

        }
    }
}
