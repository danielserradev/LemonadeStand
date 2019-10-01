using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemStand
{
    class Game
    {
        //member variables(Has a)
        public Player playerOne;
        private Store store;
        
        public int numberOfPlayers;
        public int dayCounter;
        public int pitcher;
        public int cupOfLemonade;

        


        //constructor(Spawner)
        public Game()
        {
            dayCounter = 0;
            

        }

        //member methods(Can Do)
        public void RunGame()
        {
            Console.WriteLine("Hello");
            int numberOfPlayers = GetNumberOfPlayers();
            CreatePlayer(numberOfPlayers);
            playerOne.ChoosePlayerName();
            store = new Store(playerOne);
            store.DisplayStoreInventory();
            store.StoreMenu();
            MakeRecipe();
            
            

        }
        public int GetNumberOfPlayers()
        {
            Console.WriteLine("Are 1 or 2 players playing? ");
            try
            {
                numberOfPlayers = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Error: Must enter an integer");
            }
            switch (numberOfPlayers)
            {
                case 1:
                    numberOfPlayers = 1;
                    break;
                case 2:
                    numberOfPlayers = 2;
                    break;
                default:
                    GetNumberOfPlayers();
                    break;

            }
            return numberOfPlayers;
        }
        
        public void CreatePlayer(int numberOfPlayers)
        {
            if(numberOfPlayers == 1)
            {
                playerOne = new Player();
            }
        }
        public int LemonadeRecipe()
        {
            if (playerOne.inventory.lemons.Count >= 1 && playerOne.inventory.sugarCubes.Count >= 1 && playerOne.inventory.iceCubes.Count >= 1 && playerOne.inventory.cups.Count >= 1)
            {
                cupOfLemonade = 1;
            }
            return cupOfLemonade;
        }
        public void MakeRecipe()
        {
            pitcher = LemonadeRecipe();

            Console.WriteLine("Your Pitcher inventory: " + pitcher);

        }
        public int DayCounter()
        {
            dayCounter++;
            Console.WriteLine("Day " + dayCounter + " out of 7.");
            return dayCounter;
        }

        
        



    }
}
