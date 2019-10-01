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
        public Store store;
        public Recipe recipe;        
        public int numberOfPlayers;
        public int dayCounter;
        public int fullPitcher;
        public int ingredients = 0;

        


        //constructor(Spawner)
        public Game()
        {
            dayCounter = 0;
            

        }

        //member methods(Can Do)
        public void RunGame()
        {
            UserInterface.DiplayInfo();
            int numberOfPlayers = GetNumberOfPlayers();
            CreatePlayer(numberOfPlayers);
            playerOne.ChoosePlayerName();
            playerOne.recipe.CreateLemonade();
            store = new Store(playerOne);
            
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
            if(playerOne.inventory.lemons.Count >= 1 && playerOne.inventory.sugarCubes.Count >= 1)
            {
                ingredients++;
                playerOne.inventory.lemons.RemoveRange(0,1);
                playerOne.inventory.sugarCubes.RemoveRange(0,1);
            }
            
            
            if(playerOne.inventory.lemons.Count != 0)
            {
                
                return LemonadeRecipe();
                
            }
            

            return ingredients;


        }
        public void MakeRecipe()
        {
            fullPitcher = LemonadeRecipe();

            Console.WriteLine("Your Pitcher inventory: " + fullPitcher);
            Console.WriteLine("Your Lemon inventory: " + playerOne.inventory.lemons.Count);
            Console.WriteLine("Your Sugar Cube inventory: " + playerOne.inventory.sugarCubes.Count);
            //Console.WriteLine("Your Ice Cube inventory: " + playerOne.inventory.iceCubes.Count);
            //Console.WriteLine("Your Cup inventory: " + playerOne.inventory.cups.Count);
            


        }
        public int DayCounter()
        {
            dayCounter++;
            Console.WriteLine("Day " + dayCounter + " out of 7.");
            return dayCounter;
        }

        
        



    }
}
