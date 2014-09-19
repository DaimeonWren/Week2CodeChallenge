using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekDosCodeChallenge
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
             for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }
            LetterCounter('r',"I love biscuits and gravy. It's the best breakfast ever.\n");
            LetterCounter('n',"Never gonna give you up.Never gonna let you down.\n");
            LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.\n");
            Console.ReadKey();
        }
        static void FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0) 
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else 
            {
                Console.WriteLine(number);
            }
        }
        static void LetterCounter(char letter, string inString)
        {
            int numLetter = 0;
            int upLetter = 0;
            int lowLetter = 0;

            for (int i = 0; i < inString.Length; i++)
            {
                if (inString.Contains(letter.ToString().ToLower()))
                {
                    lowLetter++;

                }
                if (inString.Contains(letter.ToString().ToUpper()))
                {
                    upLetter++;

                }

            }
            numLetter = lowLetter + upLetter;
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase " + lowLetter);
            Console.WriteLine("Number of uppercase " + upLetter);
            Console.WriteLine("Total number of " + numLetter);
        }

    }
}
