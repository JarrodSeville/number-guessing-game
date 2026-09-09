using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This asks the user for a difficulty level
            Console.WriteLine("Select a difficulty level (super easy (1), easy (2), normal (3), hard (4))");
            string input_difficulty = Console.ReadLine();

            // The if is when the input is valid
            if (int.TryParse(input_difficulty, out int result_input_difficulty) && result_input_difficulty >= 1 && result_input_difficulty <= 4)
            {
               
            }

            // The else is when the input is invalid
            else
            {
                Console.WriteLine("Invalid input. Please select a valid difficulty level.");
            }

            Console.ReadKey();

            
        }
    }
}
