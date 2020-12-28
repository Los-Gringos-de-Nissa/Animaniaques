﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaniaques.Classes
{
    class Result
    {
        private int score;

        public int Score   // property
        {
            get { return score; }   // get method
            set { score = value; }  // set method
        }

        public Result()
        {
        }

        public int AddPoint()
        {
           return this.score + 1;
        }

        public int NoPoint()
        {
            return this.score + 0;
        }

        public String ResultMessage()
        {
            if(this.score <= 2 )
            {
                return "Oups! Tu n'a pas la moyenne";
            } else
            {
                return "Houra! Tu es le meilleur, au dessus de la moyenne !";
            }
        }
    }
}
