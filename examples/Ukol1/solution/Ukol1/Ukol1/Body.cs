using System;
using System.Collections.Generic;
using System.Text;

namespace Ukol1
{
    public abstract class Bod
    {
        #region Properties
        #endregion

        #region Methods
        public void VypisBod()
        {
            Console.WriteLine("Toto je bod.");
        }
        #endregion
    }

    public sealed class Bod2D : Bod
    {
        #region Fields
        private float x;
        private float y;
        #endregion

        #region Constructors


        public Bod2D(float x, float y)
            : base()
        {
            this.x = x;
            this.y = y;
        }
        #endregion

        #region Properties
        public float X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public float Y
        {
            get { return this.y; }
            set { this.y=value;}
        }
        #endregion

        #region Methods
        public new void VypisBod()
        {
            Console.WriteLine("Toto je Bod2D " + x + ", " + y);
        }
        #endregion
    }
    public class Bod3D : Bod
    {
        #region Fields
        private float x;
        private float y;
        private float z;
        #endregion

        #region Constructors


        public Bod3D(float x, float y, float z)
            : base()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        #endregion

        #region Properties
        public float X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public float Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public float Z
        {
            get { return this.z; }
            set { this.z = value; }
        }
        #endregion

        #region Methods
        public new void VypisBod()
        {
            Console.WriteLine("Toto je Bod3D " + x + ", " + y + ", " + z);
        }
        #endregion
    }
}
