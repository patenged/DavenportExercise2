using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavenportExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run == true)
            {
                Split();
                run = Continue();
            }

        }

        static void Split()
        {
            Console.WriteLine("Enter a word");
            string input = Console.ReadLine();
            string output;

            //finds whether the input is odd or even and splits it accordingly
            if (input.Length % 2 == 0)
            {
                output = input.Substring((input.Count() / 2) - 1, 2);
            }
            else
            {
                output = input.Substring((input.Count() / 2), 1);
            }

            Console.WriteLine(output);
        }

        private static bool Continue()
        {
            Console.WriteLine("Would you like to enter another word? Y/N");
            string input = Console.ReadLine();
            bool run = false;
            input = input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Good bye");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("Unknown input");
                run = Continue();
            }

            return run;
        }
    }
}
