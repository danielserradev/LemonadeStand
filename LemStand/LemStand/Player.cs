using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemStand
{
    class Player 
    {
        //member variables(Has a)
        public string name;
        public Inventory inventory;

        //constructor(Spawner)
        public Player()
        {
            inventory = new Inventory();
        }

        //member methods(Can Do)
        public void ChoosePlayerName()
        {
            Console.WriteLine("Please enter your name? ");
            name = Console.ReadLine();
        }
       
        public void GoTotheStore()
        {

        }
    }
}
