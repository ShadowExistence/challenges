using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseThing
{
    public class Color
    {
        public Color(string color) { this.color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color); }
        
        public ConsoleColor color { get; set; }
    }
}
