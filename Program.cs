using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using eindopdracht_native_text_based_adventure_game;
using static System.Formats.Asn1.AsnWriter;

namespace eindopdrachttextbasedadventuregame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsRunning = true;

            IntroductionStory introductionstory = new IntroductionStory();
            Inventory inventory = new Inventory();
            OptionCoconut optionCoconut = new OptionCoconut();
            StoryAlienMan storyAlien = new StoryAlienMan();
            OptionShip OptionShip = new OptionShip();
            Cave storyCave = new Cave();

            // Ask for a user input to enter their username in
            // And shows the user a welcome message
            Console.WriteLine("Enter your username in");
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName} by this game\n");


            // Show the introduction of the story
            introductionstory.ShowIntroductionStory();

            // Ask for a user input to make a main choice 
            Console.WriteLine("Choose an option:\n");

            Console.WriteLine("1.Walk to the alien man");
            Console.WriteLine("2.You ignore him and walk to the right");
            Console.WriteLine("3.Quit game");

            // Main game loop
            while (IsRunning)
            {
                // Asks for the user input for the main choice 
                // This choice determines the story
                string mainChoice = Console.ReadLine();

                // The mainchoice is converted to an int
                if (int.TryParse(mainChoice, out int mainChoiceNew))
                {
                    //
                    switch (mainChoiceNew)
                    {
                        // If the mainChoice new is equal to 1
                        case 1:
                            Console.WriteLine("You walk towards the alien man and you say hello to the alien man and and he says hello in an alien language.");
                            Console.WriteLine("You can`t understand him and he says with a hand gesture follow me.");
                            Console.WriteLine("You guys are walking for an our but suddenly there comes a sort of motorcycle towards us and this motercycle stops and the motorcycle man takes the alien man with him.");
                            Console.WriteLine("And you are running away and hiding behind an stone.");

                            optionCoconut.ShowOptionCoconut(inventory.itemsInInventory);

                            storyAlien.ShowStoryAlienMan();
                            Console.WriteLine("1. you give us your coconut that we found earlier");
                            Console.WriteLine("2. You give nothing and you want to shake hands with the alien man");

                            OptionShip.ShowOptionShip();
                            IsRunning = false;
                            break;

                        //If the mainChoice new is equal to 2
                        case 2:
                            storyCave.StoryShowCave();

                            // Stops the program
                            IsRunning=false;

                            break;

                        // If the mainChoice new is equal to 3
                        case 3:
                            Console.WriteLine("See you next time!");
                            IsRunning = false;
                            
                            break;

                        // Invalid number
                        // The program will give the user a error message
                        default:

                            Console.WriteLine("Invalid choice choose another option in!");
                            Console.Clear();

                            continue;

                    }
                }
                // Invalid input
                // The program will give the user a error message
                else
                {
                    Console.WriteLine("Invalid choise choose antother option");

                    Console.WriteLine("Choose an option:\n");

                    Console.WriteLine("1.Walk to the alien man");
                    Console.WriteLine("2.You ignore him and walk to the right");
                    Console.WriteLine("3.Quit game");
                }
            }
        }
    }
}


