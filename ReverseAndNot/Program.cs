using System;

namespace ReverseAndNot
{
    class Program
    {
        public static string ReverseAndNot(int number)
        {
            string output = $"{number}";

            for (int i = output.Length-1; i >= 0; i--)
            {
                output += output[i];
            }
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseAndNot(123));
            Console.WriteLine(ReverseAndNot(1525));
            Console.WriteLine(ReverseAndNot(12334567));
        }
    }
}
