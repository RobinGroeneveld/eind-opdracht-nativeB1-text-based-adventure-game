using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace eindopdracht_native_text_based_adventure_game
{
    internal class InventorySecondOption
    {
        public List<string> itemsInInventorysecondstory = ["Screwdriver", "Hammer", "screws"];
        public void ShowinventorySecondOption(List<string> list)
        {
            int count = 0;
            Console.WriteLine("which tool do you want to use?\n");
            foreach (string items in itemsInInventorysecondstory)
            {
                count++;
                Console.WriteLine($"{count}: {items}");
            }

            // Asks for the user input for the userInput 
            string userInput = Console.ReadLine();

            // Convert input to number
            if (int.TryParse(userInput, out int userChoice))
            {
                // Check if the selection is within range
                if (userChoice >= 1 && userChoice <= itemsInInventorysecondstory.Count)
                {
                    // Convert from user index
                    int indexToRemove = userChoice - 1;
                    string chosenItem = itemsInInventorysecondstory[indexToRemove];

                    // Different stories based on the ITEM chosen, not the number


                    switch (chosenItem)
                    {
                        case "Screwdriver":
                            Console.WriteLine("You use the screwdriver to carefully pry out the crystal.");
                            Console.WriteLine("You breaked the crystal and a toxic substance is coming out of the crystal and a few moments later you are poisoned to death.");
                            Environment.Exit(0);

                            break;
                        case "Hammer":
                            Console.WriteLine("The top part of the hammer flew off when you hit the stone.");
                            break;
                        case "screws":
                            Console.WriteLine("You try to use the screws but they are not very effective.");
                            Console.WriteLine("Suddenly you hear rocks falling down and the rocks close the exit of the cave eventually you die because you ran out of water.");
                            Environment.Exit(0);
                            break;
                          
                        default:
                            Console.WriteLine("You use the " + chosenItem);
                            break;
                    }

                    // delete the item
                    itemsInInventorysecondstory.RemoveAt(indexToRemove);
                }
                // If the user enters a number that not exits or a string
                // Then the program will give the user a error message
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and " + itemsInInventorysecondstory.Count);
                    ShowinventorySecondOption(list); 
                }
            }
            // If the user enters a number that not exits or a string
            // Then the program will give the user a error message
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                ShowinventorySecondOption(list); 
            }
        }
    }
}