using System;
using System.Collections.Generic;
using System.Text;

namespace Ukol1
{
    public class Bod2D : Tvar
    {
        #region Fields
        private float x;
        private float y;
        #endregion

        #region Constructors
        public Bod2D(string jmeno)
            : base(jmeno)
        {
            x = 0;
            y = 0;
        }

        public Bod2D(float x, float y)
            : base()
        {
            this.x = x;
            this.y = y;
        }
        #endregion

        #region Properties
        #endregion
    }
}
