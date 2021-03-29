using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grid = new int[10];

            grid[1] = 1;
            grid[0] = 1;
            grid[2] = 1;

            bool row1 = grid[1] == grid[2] == grid[0];

            Console.WriteLine(row1);
        }
    }
}
