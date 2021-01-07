using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaniaques.Classes
{
    class Maths
    {
        private int chiffre1;
        private int chiffre2;
        private int result;

        public int Chiffre1
        {
            get { return chiffre1; }
            set { this.chiffre1 = value; }
        }

        public int Chiffre2
        {
            get { return chiffre2; }
            set { this.chiffre2 = value; }
        }
        public int Result
        {
            get { return result; }
            set { this.result = value; }
        }

        public Maths(int chiffre1, int chiffre2)
        {
            this.chiffre1 = chiffre1;
            this.chiffre2 = chiffre2;
        }

        override public String ToString()
        {
            return "Opération : " + chiffre1 + " x " + chiffre2 + " = " + "?";
        }
    }
}
