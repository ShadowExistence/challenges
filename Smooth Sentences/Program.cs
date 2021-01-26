using System;

namespace Smooth_Sentences
{
    class Program
    {
        public static bool IsSmooth(string text)
        {
            text = text.Trim();
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == ' ')
                {
                    if (char.ToLower(text[i-1]) != char.ToLower(text[i + 1]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsSmooth("Marta appreciated deep perpendicular right trapezoids"));//Should be true
            Console.WriteLine(IsSmooth("Someone is outside the doorway"));//false
            Console.WriteLine(IsSmooth("She eats super righteously")); //true
        }
    }
}
