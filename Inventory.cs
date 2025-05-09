using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eindopdracht_native_text_based_adventure_game
{
    internal class Inventory
    {
        public List<string> itemsInInventory = ["Knife", "Bandages"];
        public void ShowInventory()
        {
            Console.WriteLine("Inventory:");
            foreach (string item in itemsInInventory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
