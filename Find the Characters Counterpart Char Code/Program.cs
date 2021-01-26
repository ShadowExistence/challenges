using System;

namespace Find_the_Characters_Counterpart_Char_Code
{
    class Program
    {
        public static int CounterpartCharCode(char character)
        {
            char[] alpha = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm".ToCharArray();

            bool doContain = false;

            foreach (char letter in alpha)
            {
                if (letter == character)
                {
                    doContain = true;
                }
            }

            if (doContain == true)
            {
                if (char.IsUpper(character))
                {
                    return Convert.ToInt32(char.ToLower(character));
                }
                else if (char.IsLower(character))
                {
                    return Convert.ToInt32(char.ToUpper(character));
                }
            }
            return Convert.ToInt32(character);
        }
    
    
        static void Main(string[] args)
        {

            Console.WriteLine(CounterpartCharCode('a'));
            Console.WriteLine(CounterpartCharCode('A'));
            Console.WriteLine(CounterpartCharCode('1'));
            Console.WriteLine(CounterpartCharCode('{'));
        }
    }
}
