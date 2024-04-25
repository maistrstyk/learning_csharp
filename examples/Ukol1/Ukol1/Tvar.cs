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
        protected Tvar()
        {
            jmeno = "";
            Console.WriteLine("Vznikl novy tvar - volal se prazdny konstruktor.");
            ZakladniCharakteristika();
        }
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
        public Color Barva
        {
            get { return barva; }
            protected set { barva = value; }
        }
        #endregion

        #region Methods
        public void ZakladniCharakteristika()
        {
            Console.WriteLine("Vlastnoti Tvaru:");
            Console.WriteLine("\tTyp: " + this.GetType() +"\t" + "jmeno: " + jmeno);
        }

        #endregion
    }
}
