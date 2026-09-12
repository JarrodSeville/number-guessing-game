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

            string input_difficulty = "";

            while (input_difficulty != "5")
            {
                // This asks the user for a difficulty level
                Console.Write("Select a difficulty level (super easy (1), easy (2), normal (3), hard (4) or exit (5)): ");
                input_difficulty = Console.ReadLine();
    
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
                            Console.WriteLine("That input is invalid. Please choose a valid input next time.");
                    }

                    // This is the easy mode
                    else if (result_input_difficulty == 2)
                    {
                        Console.Write("You have chosen the easy mode, select a number from 1-5: ");
                        string input_easy = Console.ReadLine();
                        if (int.TryParse(input_easy, out int result_input_easy) && result_input_easy >= 1 && result_input_easy <= 5)
                        {
                            Random rnd = new Random();
                            int random_num = rnd.Next(1, 5);
                            if (result_input_easy == random_num)
                                Console.WriteLine($"That's correct! The number I was thinking of was {random_num}");
                            else
                                Console.WriteLine($"Sorry, that's wrong. The number I was thinking of was {random_num}");
                        }
                        else
                            Console.WriteLine("That input is invalid. Please choose a valid input next time.");
                    }

                    // This is the normal mode
                    else if (result_input_difficulty == 3)
                    {
                        Console.Write("You have chosen the normal mode, select a number from 1-10: ");
                        string input_normal = Console.ReadLine();
                        if (int.TryParse(input_normal, out int result_input_normal) && result_input_normal >= 1 && result_input_normal <= 10)
                        {
                            Random rnd = new Random();
                            int random_num = rnd.Next(1, 10);
                            if (result_input_normal == random_num)
                                Console.WriteLine($"That's correct! The number I was thinking of was {random_num}");
                            else
                                Console.WriteLine($"Sorry, that's wrong. The number I was thinking of was {random_num}");
                        }
                        else
                            Console.WriteLine("That input is invalid. Please choose a valid input next time.");
                    }

                    // This is the hard mode
                    else if (result_input_difficulty == 4)
                    {
                        Console.Write("You have chosen the hard mode, select a number from 1-20: ");
                        string input_hard = Console.ReadLine();
                        if (int.TryParse(input_hard, out int result_input_hard) && result_input_hard >= 1 && result_input_hard <= 20)
                        {
                            Random rnd = new Random();
                            int random_num = rnd.Next(1, 20);
                            if (result_input_hard == random_num)
                                Console.WriteLine($"That's correct! The number I was thinking of was {random_num}");
                            else
                                Console.WriteLine($"Sorry, that's wrong. The number I was thinking of was {random_num}");
                        }
                        else
                            Console.WriteLine("That input is invalid. Please choose a valid input next time.");
                    }
                }
            }
            Console.WriteLine("Game over");
            Console.ReadKey();
        }
    }
}
