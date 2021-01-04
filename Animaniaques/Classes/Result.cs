using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaniaques.Classes
{
     class Result
    {
        private int score;
        private string name;

        public string Name    // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        public int Score   // property
        {
            get { return score; }   // get method
            set { score = value; }  // set method
        }

        public Result()
        {
        }

        public void ResetScore()
        {
            Score = 0;
        }

        public String ResultMessage()
        {
            if(this.score <= 2 )
            {
                return $"Oups! Tu n'as pas la moyenne, tu as {this.score} sur 5 points possibles... Tu feras mieux la prochaine fois c'est sûr !";
            } else
            {
                return $"Houra! T'es au-dessus de la moyenne ! Tu as {this.score} sur 5 points possibles, continue comme ça !";
            }
        }
    }
}
