using System;
using static System.Console;

namespace Password_Validation
{
    class Program
    {
        // link to the challenge https://edabit.com/challenge/etT7orqDDXJF2zGYM

        public static bool ValidatePassword(string password)
        {
            Console.WriteLine("\n\n\n" + password);
            bool pasValid = false; // output
            char[] specialChar = "!@#$%^&*()+=_-{}[]:;\"'?<>,.".ToCharArray(); //Supported special char

            //List of all rules for password:
            bool pasLenght = false;
            bool pasUpper = false;
            bool pasLower = false;
            bool pasDigit = false;
            bool pasNotReapetChar = true; //Shows if there are 3 the same char next to each other. // True > There are not // False > There are
            
            //Special character is not mandatory
            bool isSpecialChar = false;
            bool pasSpecialCharValid = false;


            char firstLetter = password[0];
            if (password.Length > 6 && password.Length < 24) { pasLenght = true; }
            foreach (char letter in password)
            {
                if (char.IsUpper(letter)) { pasUpper = true; }
                if (char.IsLower(letter)) { pasLower = true; }
                if (char.IsDigit(letter)) { pasDigit = true; }
                if (!char.IsDigit(letter) && !char.IsLetter(letter))
                {
                    isSpecialChar = true;
                    pasSpecialCharValid = false;
                    for (int i = 0; i < specialChar.Length; i++)
                    {
                        if(letter == specialChar[i]) { pasSpecialCharValid = true; break; }
                    }
                }
            }
            for (int i = 0; i < password.Length-3; i++)
            {
                if (password[i] == password[i + 1] && password[i] == password[i + 2])
                {
                    pasNotReapetChar = false;
                }
            }

            bool[] validateRules = { pasLenght, pasUpper, pasLower, pasDigit, pasNotReapetChar };
            string[] validateRulesString = { "pasLenght", "pasUpper", "pasLower", "pasDigit", "pasNotReapetChar" };

            for (int i = 0; i < validateRules.Length; i++)
            {
                Console.WriteLine($"{validateRulesString[i]}: {validateRules[i]}\n");
                if (validateRules[i] == true)
                {
                    pasValid = true;
                }
                else { pasValid = false; break; }
            }

            if (isSpecialChar == true && pasValid == true)
            {

                if (pasSpecialCharValid == false) { pasValid = false; Console.WriteLine("pasSpecialCharValid = false"); }
                else { Console.WriteLine("pasSpecialCharValid = True\n"); }
            }
            
            return pasValid;
        }
        static void Main(string[] args)
        {
            WriteLine(ValidatePassword("Fddhg93j@")); //true
            WriteLine(ValidatePassword("P1zz@")); //false
            WriteLine(ValidatePassword("iLoveYou")); // false


        }
    }
}
