using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
namespace eindopdracht_native_text_based_adventure_game
{
    internal class OptionShip
    {
        public void ShowOptionShip()
        {
            // Variable for the while loop
            bool isrunning = true;

            // While loop 
            while (isrunning)
            {
                Console.WriteLine("He has fixed our space ship! and he asks for something in return\n");

                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("1. Give him the coconut as a thank you gift");
                Console.WriteLine("2. Shake his hand and thank him");

                // Get user input for their choice
                string inputUserOptionShip = Console.ReadLine();

                // The mainchoice is converted to an int
                if (int.TryParse(inputUserOptionShip, out int inputUserOptionShipnew))
                {
                    // If the inputUserOptionShipnew is equal to 1
                    if (inputUserOptionShipnew == 1)
                    {
                        Console.WriteLine("You give the coconut and the alien man is happy that you give something to him the man walks away and shoots the gun again and another portal appears.");
                        Console.WriteLine("He walks into it and he dissapears in the portal.");
                        Console.WriteLine("you go to your spaceship and start it up and it works! and you fly back to earth.");
                        Environment.Exit(0);
                    }
                    // If the inputUserOptionShipnew is equal to 2
                    else if (inputUserOptionShipnew == 2)
                    {
                        Console.WriteLine("You shake hands with the alien man but suddenly you feel nothing anymore and everything goes black before your eyes.\n");
                        Environment.Exit(0);
                    }
                    // If the user enters a number that not exits or a string
                    else
                    {
                        Console.WriteLine("Choose an valid option!");
                    }
                }
                // Invalid input 
                else
                {
                    Console.WriteLine("Choose an valid option!");
                    Console.WriteLine("Choose an option\n");
                    Console.WriteLine("1. Give him the coconut as a thank you gift");
                    Console.WriteLine("2. Shake his hand and thank him");
                }
            }
        }
    }
}