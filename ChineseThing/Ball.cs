using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseThing
{
    public class Ball
    {

        public Ball()
        {
            
        }
        public Ball(char color)
        {
            this.color = color;
        }
        public void SetColor(char color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return "" + color;
        }

        //Attributes
        private char color = 'R'; // later color class!
    }
}
