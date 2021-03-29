using System;
using static System.Console;

namespace ChineseThing
{
    class Program
    {
        static void GameOverScreen()
        {
            WriteLine("\n\nGame is finnioto");
            WriteLine("Press any button to finish the game");
        }
        static Location RequestLocation(string message)
        {
            Write(message);
            string locationsString = ReadLine(); //Ex 0 1
            string[] locations = locationsString.Split(' ');
            int row = Convert.ToInt32(locations[0]);
            int col = Convert.ToInt32(locations[1]);

            return new Location(row, col);
        }
        static void Main(string[] args)
        {
            PlayField playfield = new PlayField();

            WriteLine(playfield);

          

            do
            {

                Location from = RequestLocation("Please enter the from location: ");
                Location to = RequestLocation("Please enter the to location: ");
                Location target = RequestLocation("Please enter the target location: ");

                if (Convert.ToBoolean(playfield.Move(from, to, target)))
                {
                    WriteLine(playfield);
                }
                else
                {
                    WriteLine("\n\nInvalid move");
                }

                playfield.GameOver();

            } while (playfield.gameOver == false);

            GameOverScreen();
            
        }
    }
}
