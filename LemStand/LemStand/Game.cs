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
            DayCounter();
            store.DisplayStoreInventory();
            store.StoreMenu();
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
        public int DayCounter()
        {
            dayCounter++;
            Console.WriteLine("Day " + dayCounter + " out of 7.");
            return dayCounter;
        }
        
        



    }
}
