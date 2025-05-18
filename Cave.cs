using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using eindopdrachttextbasedadventuregame;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace eindopdracht_native_text_based_adventure_game
{
    internal class Cave
    {
        InventorySecondOption inventorysecondoption = new InventorySecondOption();
        StoryCave StoryCave = new StoryCave();

        public void StoryShowCave()
        {
            Console.WriteLine("You decided that you are not going to the alien man.");
            Console.WriteLine("After walking for about 20 minutes, you discover a small cave entrance hidden behind some strange, glowing vegetation.");
            Console.WriteLine("The cave looks dark, but you can see a faint blue light coming from deep inside.\n");

            bool isrunning = false;

            while (!isrunning)
            {
                Console.WriteLine("Choose an option\n");
                Console.WriteLine("1. You start investigating the blue light");
                Console.WriteLine("2. Quit game");

                // Asks for the user input for the userInputCave 
                string userInputCave = Console.ReadLine();

                // The userInputCave is converted to an int
                if (int.TryParse(userInputCave, out int userInputCaveNew))
                {
                    // If userInputCave is equal to 1
                    if (userInputCaveNew == 1)
                    {
                        isrunning = true;

                       
                        bool isrunningCaveSelected = false;

                        //Inner while loop  
                        while (!isrunningCaveSelected)
                        {
                            StoryCave.ShowStoryOption();

                            string inputUserCaveInnerLoop = Console.ReadLine();

                            // The inputUserCaveInnerLoop is converted to an int
                            if (int.TryParse(inputUserCaveInnerLoop, out int inputUserCaveInnerLoopNew))
                            {
                                // If inputUserCaveInnerLoopNew is equal to 1
                                if (inputUserCaveInnerLoopNew == 1)
                                {
                                    isrunningCaveSelected = true;

                                    // Shows the inventory items in the file InventorySecondOption
                                    inventorysecondoption.ShowinventorySecondOption(inventorysecondoption.itemsInInventorysecondstory);

                                    // This code checks if there are any items in the inventory 
                                    // If the number is bigger then 0 then the program will ask again for a input from the user
                                    // This is in the inventorysecondoption file
                                    if (inventorysecondoption.itemsInInventorysecondstory.Count > 0)
                                    {
                                        Console.WriteLine("Choose another tool to use ");
                                        inventorysecondoption.ShowinventorySecondOption(inventorysecondoption.itemsInInventorysecondstory);
                                    }
                                }

                                // If inputUserCaveInnerLoopNew is equal to 2
                                else if (inputUserCaveInnerLoopNew == 2)
                                {
                                    Console.WriteLine("See you next time!");

                                    // Stops the program
                                    isrunningCaveSelected = true;
                                }

                                // Invalid number option
                                else
                                {
                                    Console.WriteLine("Choose a valid option!");
                                    continue;
                                }
                            }

                            // Input is not a number
                            else
                            {
                                Console.WriteLine("Choose a valid option!");
                                continue;
                            }
                        }
                    }

                    // If userInputCaveNew is equal to 2
                    else if (userInputCaveNew == 2)
                    {
                        Console.WriteLine("See you next time!");

                        // Stops the program
                        isrunning = true;
                    }

                    // Invalid number input
                    else
                    {
                        Console.WriteLine("Choose a valid option!");
                    }
                }

                // Input is not a number
                else
                {
                    Console.WriteLine("Choose a valid option!");
                }
            }
        }
    }
}