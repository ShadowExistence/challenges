using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseThing
{
    class Location
    {
        public Location() { Row = 0; Col = 0; }
        public Location(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public int StepsAwayFrom(Location location)
        {
            return Math.Abs(location.Row - Row) + Math.Abs(location.Col- Col);

        }
        public int Row { get; set; }
        public int Col { get; set; }
    }
}
