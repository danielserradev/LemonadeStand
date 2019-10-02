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
        public Wallet wallet;
        public Pitcher pitcher;
        public Customer customer;
        private double fullPitcher = 100;

        //constructor(Spawner)
        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
            wallet = new Wallet();
            pitcher = new Pitcher();
            
            
            
        }

        //member methods(Can Do)
        public void ChoosePlayerName()
        {
            Console.WriteLine("Please enter your name? ");
            name = Console.ReadLine();
        }
        
        public void MakePitcher()
        {
            pitcher.lemonsInPitcher = inventory.lemons.Count;
            pitcher.sugarCubesInPitcher = inventory.sugarCubes.Count;

        }
        public void DisplayPitcherContents()
        {
            Console.WriteLine("You currently have 1 pitcher of lemonade with the ingredients of:" +
                "\n" + pitcher.lemonsInPitcher  + " Lemons" +
                "\n" + pitcher.sugarCubesInPitcher + " Sugar Cubes");
        }
        public double FullPitcher
        {
            set
            {
                if(value <= 0)
                {
                    fullPitcher = 0;
                }
                else
                {
                    fullPitcher = value;
                }
            }
            get
            {
                return fullPitcher;
            }

               
        }
    }
}
