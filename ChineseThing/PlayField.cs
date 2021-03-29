using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseThing
{
    class PlayField
    {

        public PlayField()
        {
            gameOver = false;
            //LoadFieldFromFile("easy");
            GenerateField();

            
        }

        private void LoadFieldFromFile(string filename)
        {
            // Open file + read file
            string[] lines = System.IO.File.ReadAllLines($"D:/Szkola/Introduction to programming/csharp-practical-ShadowExistence/Class Program/ChineseThing/Fields/{filename}.txt");

            // New field
            field = new Ball[lines.Length, lines.Length];

            // for in for

            for(int row = 0; row < Rows; row++)
            {
                string[] symbols = lines[row].Trim().Split(" ");

                for(int col =0; col < Cols; col++)
                {
                    if (symbols[col] == "*")
                    {
                        field[row, col] = new Ball();
                    }
                }
            }
        }

        private void GenerateField()
        {
            field[0, 1] = new Ball('R');
            field[0, 3] = new Ball('R');



            
        }


        public bool Move(Location from, Location to, Location dissolveTarget)
        {

            ///     When one of the arrows is pressed:
            ///     ← = col -1,       →  = col +1,
            ///     ↑ = row -1,       ↓  = row +1   >>>> For UI
            ///     enter to confirm selected ball
            ///     
            
            
            //Check if in playfield
            if (!insideField(from))  return false; 
            if (!insideField(to))  return false;
            if (!insideField(dissolveTarget)) return false;
            
            if (!ContainBall(from))  return false;
            if (ContainBall(to))  return false;


            //Max 1 field
            if (from.StepsAwayFrom(to) != 1) return false;
            //Not diagonal and can't dissolve the same ball
            if (to.StepsAwayFrom(dissolveTarget) != 1) return false;

            

            //Move the ball
            field[to.Row, to.Col] = field[from.Row, from.Col];
            field[from.Row, from.Col] = null;

            // GameOver if all balls gone               <<<< HomeWork
            // GameOver if after move there are no balls 1 step away from each other.
            

            //Dissolve Balls
            if (!ContainBall(dissolveTarget))
            {
                return false;
            }

            RemoveBall(to);
            RemoveBall(dissolveTarget);

            return true;
        }

        public override string ToString()
        {
            string output = "";             //Try to make ToString() better

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    if (field[row, col] != null)
                    {
                        output += field[row, col] + " ";
                    }
                    else
                    {
                        output += "O ";
                    }

                }
                output += "\n";
            }

            return output;
        }

        
        //Private Methods
        private Ball GetBll(int row, int col)
        {
            if(row < 0 || row >= field.GetLength(0)) { return null; }
            if(col < 0 || col >= field.GetLength(1)) { return null; }

            return field[row, col];
        }
        private bool insideField(Location place)
        {
            //if (place.Row < 0 || place.Row >= field.GetLength(0)) { return false; } 
            //if (place.Col < 0 || place.Col >= field.GetLength(1)) { return false; }
            // return true;

            //Other possibility

            return ((place.Row >= 0) && (place.Row < Rows))
                && ((place.Col >= 0) && (place.Col < Cols));
        }
        
        public void GameOver()
        {
            int ballCounter = 0;
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                   
                    if (field[row, col] != null)
                    {

                        break;
                    }
                }
            }
            gameOver = true;
            
        }


        private bool ContainBall(Location location) { return GetBll(location.Row, location.Col) != null; }

        private void RemoveBall(Location location) { field[location.Row, location.Col] = null; }
        // Attributes
        // 2D Array
        //private int[,] field = new int[2, 3] //2 = row, 3 = col!!
        //{ 
        //    {1, 2, 3},
        //    {1, 2, 3}

        //};

        private Ball[,] field = new Ball[3, 4];


        public int Rows
        {
            get { return field.GetLength(0); }
        }

        public int Cols
        {
            get { return field.GetLength(1); }
        }

        public bool gameOver { get; private set; }
    }
}
