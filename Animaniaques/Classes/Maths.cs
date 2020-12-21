using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaniaques.Classes
{
    class Maths
    {
        private string prenom;
        private int chiffre1;
        private int chiffre2;
        private int result;
        //private int reponse;

        public string Prenom
        {
            get { return prenom; }
            set { this.prenom = value; }
        }
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

        /*public int Reponse
        {
            get { return reponse; }
            set { this.reponse = value; }
        }*/

        public Maths(string prenom, int chiffre1, int chiffre2, int result)
        {
            this.prenom = prenom;
            this.chiffre1 = chiffre1;
            this.chiffre2 = chiffre2;
            this.result = result;
        }

        override public String ToString()
        {
            return "Opération : " + chiffre1 + " x " + chiffre2 + " = " + result;

            /*if (reponse == result)
            {
                return "Opération n°=1 : " + chiffre1 + " x " + chiffre2 + " = " + result;
            }*/
        }
    }
}
