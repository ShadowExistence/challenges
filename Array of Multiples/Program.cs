using System;

namespace Array_of_Multiples
{
    class Program
    {
        public static void ArrayOfMultiples(int multiplayer, int lenght)
        {
            int[] array = new int[lenght];
            for (int i = 1; i < lenght+1; i++)
            {
                array.SetValue(i * multiplayer, i-1);
            }
            string output = "[";
            
            for (int i = 0; i < lenght; i++)
            {
                if (i == lenght - 1)
                {
                    output += $"{array[i]}]";
                }
                else
                {
                    output += $"{array[i]}, ";
                }
            }
            Console.WriteLine($"{output}");
        }
        static void Main(string[] args)
        {
            ArrayOfMultiples(7, 5);
            ArrayOfMultiples(12, 10);
            ArrayOfMultiples(17, 6);

        }
    }
}
