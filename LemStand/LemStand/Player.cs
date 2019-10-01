using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemStand
{
    public class Player 
    {
        //member variables(Has a)
        public string name;
        public Inventory inventory;
        public Recipe recipe;

        //constructor(Spawner)
        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
            
        }

        //member methods(Can Do)
        public void ChoosePlayerName()
        {
            Console.WriteLine("Please enter your name? ");
            name = Console.ReadLine();
        }
    }
}
