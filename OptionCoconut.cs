using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eindopdracht_native_text_based_adventure_game
{
    internal class OptionCoconut
    {
        List<string> itemsInInventory = ["Knife", "Bandages"];

        public void ShowOptionCoconut(List<string> list)
        {
            Console.WriteLine("Choose an option:\n");
            Console.WriteLine("1.You you go looking for liquid");
            Console.WriteLine("2.You wait here but you are very thirsty");

            string choiceFood = Console.ReadLine();
            if (int.TryParse(choiceFood, out int choiceFoodNew))
            {
                if (choiceFoodNew == 1)
                {
                    Console.WriteLine("you see a big tree with some kind of coconuts on it");
                    Console.WriteLine("You start shaking the three and the coconuts are falling off the three\n");
                    Console.WriteLine("1. Eat the coconuts");
                    Console.WriteLine("2. Dont eat the coconuts");
                    Console.WriteLine("3. Drink the coconuts but not all and save these coconuts for another time");

                    string choiceCoconuts = Console.ReadLine();

                    if (int.TryParse(choiceCoconuts, out int choiceCoconutsNew))
                    {
                        if (choiceCoconutsNew == 1)
                        {
                            Console.WriteLine("You start eating the sort of coconuts but one of them is toxic");
                            Console.WriteLine("And a few moments later you died\n");

                            Console.WriteLine("PRESS ENTER TO CONTINUE");
                            Console.ReadLine();
                            Console.Clear();


                        }
                        else if (choiceCoconutsNew == 2)
                        {
                            Console.WriteLine("You decided not to eat the coconuts and continue looking for something to drink");
                            Console.WriteLine("you don't encounter anything anymore and hours pass and you get very thirsty and you faint on the ground \n and eventually after a day you are dehydrated\n");

                            Console.WriteLine("PRESS ENTER TO CONTINUE");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (choiceCoconutsNew == 3)
                        {
                            Console.WriteLine("You decide to drink some of the coconut water and save the rest for later.");
                            Console.WriteLine("The refreshing taste of the coconut water revitalizes you, giving you a surge of energy.");
                            Console.WriteLine("You carefully store the remaining coconuts in your bag, knowing they might be crucial for your survival.");

                            itemsInInventory.Add("Coconut");
                            Console.WriteLine("\nThis is what you now have in your inventory:\n");

                            foreach (string item in itemsInInventory)
                            {
                                Console.WriteLine(item);
                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("Choose another option!");
                    }

                }
                else if (choiceFoodNew == 2)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("You waited behind the rock to long and you got very thirsty and you dehydrated");
                    Console.Clear();
                    
                }
            }
        }
    }
}
