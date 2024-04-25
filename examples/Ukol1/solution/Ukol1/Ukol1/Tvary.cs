using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Ukol1
{
    public abstract class Tvar
    {
        #region Fields
        protected string jmeno;
        protected Color barva;
        #endregion

        #region Constructors
       
        protected Tvar(string jmeno)
        {
            this.jmeno = jmeno;
            Console.WriteLine("Vznikl novy tvar - volal se konstruktor s parametrem jmeno.");
            ZakladniCharakteristika();
        }
        #endregion

        #region Properties
        public string Jmeno
        {
          get { return jmeno; }
          set { jmeno = value; }
        }
      
        #endregion

        #region Methods
        public void ZakladniCharakteristika()
        {
            Console.WriteLine("Vlastnoti Tvaru:");
            Console.WriteLine("\tTyp: " + this.GetType() +"\t" + "jmeno: " + jmeno);
        }

        public abstract float VratObsah();
        #endregion

    }
    public class Trojuhelnik : Tvar
    {
        #region Fields
        Bod a,b,c;
        #endregion

        #region Constructors
        public Trojuhelnik(Bod a, Bod b, Bod c) : base("Trojuhelnik")
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        #endregion

        #region Methods
        public Bod GetBodA() { return this.a; }
        public Bod GetBodB() { return this.b; }
        public Bod GetBodC() { return this.c; }
        public override float VratObsah()
        {
            Console.WriteLine("Vrat obsah: trojuhelnik");
            return 0;

        }
        #endregion
    }
    public class Ctverec : Tvar
    {
        #region Fields
        Bod[] body;
        #endregion

        #region Constructors
        public Ctverec()
            : base("Ctverec")
        {
        }

        public Ctverec(Bod a, Bod b, Bod c, Bod d) : this()
        {

            body = new Bod[4];
            body[0] = a;
            body[1] = b;
            body[2] = c;
            body[3] = d;
        }
        public Ctverec(Bod[] body)
            : base("Ctverec")
        {
            this.body = body;
        }
        #endregion

        #region Methods
        public Bod[] GetBody()
        {
            return this.body;
        }
        public override float VratObsah()
        {
            Console.WriteLine("Vrat obsah: ctverec");
            
            return 0;

        }
        #endregion
    }
}
