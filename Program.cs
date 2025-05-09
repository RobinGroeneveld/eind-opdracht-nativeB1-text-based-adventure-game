using eindopdracht_native_text_based_adventure_game;

namespace eindopdrachttextbasedadventuregame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsRunning = true;

            Story story = new Story();
            Inventory inventory = new Inventory();
            OptionCoconut optionCoconut = new OptionCoconut();
            StoryShip storyShip = new StoryShip();


            while (IsRunning)
            {
                Console.WriteLine("Enter your username");
                string userName = Console.ReadLine();
                Console.WriteLine($"Welcome {userName} by this game\n");

                story.ShowStory();

                Console.WriteLine("Choose an option:\n");

                Console.WriteLine("1.Walk to the alien man");
                Console.WriteLine("2.You ignore him and walk to the right");
                Console.WriteLine("3.Quit game");

                string choice = Console.ReadLine();

                if (int.TryParse(choice, out int choiceNew))
                {
                    switch (choiceNew)
                    {
                        case 1:
                            Console.WriteLine("You walk towards the alien man and you say hello to the alien man and and he says hello in an alien language.");
                            Console.WriteLine("You can`t understand him and he says with a hand gesture follow me.");
                            Console.WriteLine("You guys are walking for an our but suddenly there comes a sort of motorcycle towards us and this motercycle stops and the motorcycle man takes the alien man with him.");
                            Console.WriteLine("And you are running away and hiding behind an stone.");
                            


                            optionCoconut.ShowOptionCoconut(inventory.itemsInInventory);
                            Console.WriteLine("You see a building in the distance you go there and you see an alien man and you try to say in sign language that you crashed on this planet and that your rocket is broken");

                            storyShip.StoryAlienMan();

                            string inputUserStoryShip = Console.ReadLine();
                            if (int.TryParse(inputUserStoryShip, out int inputUserStoryShipnew))
                            {
                                if(inputUserStoryShipnew == 1)
                                {
                                    Console.WriteLine("You give the coconut and the alien man is happy that you give something to him the man walks away and shoots the gun again and another portal appears.\n" +
                                        " He walks into it and he dissapears in the portal.\n" +
                                        "you go to your spaceship and start it up and it works! and you fly back to earth");

                                    Console.WriteLine("PRESS ENTER TO CONTINUE");

                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else if(inputUserStoryShipnew == 2)
                                {
                                    Console.WriteLine("you shake hands with the alien man but suddenly you feel nothing anymore and everything goes black before your eyes.\n" +
                                        "You fall on the ground");
                                    Console.WriteLine("PRESS ENTER TO CONINUE");
                                    Console.ReadLine();
                                    Console.Clear();

                                }
                                else
                                {
                                    Console.WriteLine("Choose an valid option!");
                                }
                            }


                            break;

                     
                        case 2:

                            break;
                        case 3:
                            Console.WriteLine("See you next time!");
                            System.Environment.Exit(0);

                            break;
                        default:
                            Console.WriteLine("Invalid choice choose another option!");

                            continue;
                          
                    }

                }

            }
        }
    }
}
