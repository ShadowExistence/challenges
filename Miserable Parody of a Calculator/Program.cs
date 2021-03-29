using System;
using System.Collections.Generic;

namespace Miserable_Parody_of_a_Calculator
{
    class Program
    {
        //link to challenge https://edabit.com/challenge/u2j86CBJibQA5KzQp

        public static int Calculator(string equation)
        {
            string[] numberSplit = equation.Split(new char[] { '*', '/', '+', '-' });

            string[] symbols = equation.Split(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });

            List<string> symbolsOrdered = new List<string>();
            

            //Removes empety elements
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] != string.Empty)
                {
                    symbolsOrdered.Insert(symbolsOrdered.Count, symbols[i]);
                }
            }


            int numberLeft = Convert.ToInt32(numberSplit[0]); //After all math is done numberLeft = output


            int a = 0;
            for(int i = 1; i < numberSplit.Length; i++)
            {
                
                int numberRight = Convert.ToInt32(numberSplit[i]);
                
                if (symbolsOrdered[a] == "*") { numberLeft = numberLeft * numberRight; continue; }
                else if(symbolsOrdered[a] == "/") { numberLeft = numberLeft / numberRight; continue; }
                else if (symbolsOrdered[a] == "+") { numberLeft = numberLeft + numberRight; continue; }
                else if (symbolsOrdered[a] == "-") { numberLeft = numberLeft - numberRight; }
                a++;
            }
            return numberLeft;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Calculator("2+2*2/2-2"));
        }
    }
}
