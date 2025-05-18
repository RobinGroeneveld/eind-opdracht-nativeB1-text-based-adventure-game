using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using eindopdrachttextbasedadventuregame;

namespace eindopdracht_native_text_based_adventure_game
{
    internal class OptionCoconut
    {
        StoryAlienMan storyAlienMan = new StoryAlienMan();
        OptionShip OptionShip = new OptionShip();

        // Inventory list
        List<string> itemsInInventory = ["Knife", "Bandages"];

        public void ShowOptionCoconut(List<string> list)
        {
            Console.WriteLine("Choose an option:\n");
            Console.WriteLine("1.You go look for liquid");
            Console.WriteLine("2.You wait here but you are very thirsty");

            bool validChoice = false;

            // Loop until a valid input is given
            while (!validChoice)
            {
                string choiceFood = Console.ReadLine();

                // Convert input to number
                if (int.TryParse(choiceFood, out int choiceFoodNew))
                {
                    // If the choiceFoodNew is equal to 1
                    if (choiceFoodNew == 1)
                    {
                        Console.WriteLine("you see a big tree with some kind of coconuts on it.");
                        Console.WriteLine("You start shaking the three and the coconuts are falling off the three\n");

                        CoconutChoices();
                    }
                    // If the choiceFoodNew is equal to 2
                    else if (choiceFoodNew == 2)
                    {
                        Console.WriteLine("You waited to long behind the rock and eventuelly you died because of dehydration.");
                        Environment.Exit(0);
                    }

                    // Invalid input
                    else
                    {
                        Console.WriteLine("Invalid choice choose another option!");
                        Console.WriteLine("Choose an option:\n");
                        Console.WriteLine("1.You go looking for liquid");
                        Console.WriteLine("2.You wait here but you are very thirsty");
                    }
                }

                // Input is not a number
                else
                {
                    Console.WriteLine("Invalid choice choose another option!");
                    Console.WriteLine("Choose an option:\n");
                    Console.WriteLine("1.You go looking for liquid");
                    Console.WriteLine("2.You wait here but you are very thirsty");
                }
            }
        }
        private void CoconutChoices()
        {
            Console.WriteLine("Choose an option\n");
            Console.WriteLine("1. Eat the coconuts");
            Console.WriteLine("2. Dont eat the coconuts");
            Console.WriteLine("3. Drink the coconuts but not all and save these coconuts for another time");

            bool validChoice = false;

            // Loop until a valid choice is made
            while (!validChoice)
            {
                string choiceCoconuts = Console.ReadLine();

                // Convert input to number
                if (int.TryParse(choiceCoconuts, out int choiceCoconutsNew))
                {
                    validChoice = true;

                    // If the choiceCoconutsNew is equal to 1
                    if (choiceCoconutsNew == 1)
                    {
                        Console.WriteLine("You start eating the sort of coconuts but one of them is toxic.");
                        Console.WriteLine("And a few moments later you died.");
                        Environment.Exit(0);
                    }
                    // If the choiceCoconutsNew is equal to 2
                    else if (choiceCoconutsNew == 2)
                    {
                        Console.WriteLine("You decided not to eat the coconuts and continue looking for something to drink.");
                        Console.WriteLine("you don't encounter anything anymore and hours pass and you get very thirsty and you faint on the ground.");
                        Console.WriteLine("And eventually after a day you are dehydrated.");
                        Environment.Exit(0);
                    }
                    // If the choiceCoconutsNew is equal to 3
                    else if (choiceCoconutsNew == 3)
                    {
                   
                        Console.WriteLine("You decide to drink some of the coconut water and save the rest for later.");
                        Console.WriteLine("The refreshing taste of the coconut water revitalizes you, giving you a surge of energy.");
                        Console.WriteLine("You carefully store the remaining coconuts in your bag, knowing they might be crucial for your survival.");

                        // Ad the coconot to the list
                        itemsInInventory.Add("Coconut");
                        Console.WriteLine("\nThis is what you now have in your inventory:\n");

                        // Foreach loop to show the player the inventory
                        foreach (string item in itemsInInventory)
                        {
                            Console.WriteLine(item);
                        }

                        storyAlienMan.ShowStoryAlienMan();
                        OptionShip.ShowOptionShip();
                    }
                    // Invalid number choice
                    else
                    { 
                        validChoice = false;
                        Console.WriteLine("Invalid choice choose another option!");
                        Console.WriteLine("Choose an option:\n");
                        Console.WriteLine("1. Eat the coconuts");
                        Console.WriteLine("2. Dont eat the coconuts");
                        Console.WriteLine("3. Drink the coconuts but not all and save these coconuts for another time");
                    }
                }
                // Input is not a number
                else
                {
                    Console.WriteLine("Invalid choice choose another option!");
                    Console.WriteLine("Choose an option:\n");
                    Console.WriteLine("1. Eat the coconuts");
                    Console.WriteLine("2. Dont eat the coconuts");
                    Console.WriteLine("3. Drink the coconuts but not all and save these coconuts for another time");
                }
            }
        }
    }
}
