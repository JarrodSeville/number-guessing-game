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
                // This is the super easy mode
                if (result_input_difficulty == 1)
                {
                    Console.Write("You have chosen super easy mode, select a number from 1-3: ");
                    string input_supereasy = Console.ReadLine();
                    if (int.TryParse(input_supereasy, out int result_input_supereasy) && result_input_supereasy >= 1 && result_input_supereasy <= 3)
                    {
                        Random rnd = new Random();
                        int random_num = rnd.Next(1, 3);
                        if (result_input_supereasy == random_num)
                            Console.WriteLine($"That's correct! The number I was thinking of was {random_num}");
                        else
                            Console.WriteLine($"Sorry, that's wrong. The number I was thinking of was {random_num}");
                    }
                    else
                        Console.WriteLine("That input is invalid. Please choose a valid input.");

                }
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
