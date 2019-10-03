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
        public Weather weather;
        Customer customer;
        public int numberOfPlayers;
        
        public int fullPitcher;
        public int ingredients = 0;

        


        //constructor(Spawner)
        public Game()
        {
            //customer = new Customer();
            

        }

        //member methods(Can Do)
        public void RunGame()
        {
            weather = new Weather();
            customer = new Customer();
            weather.WeatherConditions();
            weather.RandomWeatherCondition();
            weather.RandomTemerature();
            weather.DisplayWeather();
            customer.DecisionToBuy(weather);
            //UserInterface.DiplayInfo();
            int numberOfPlayers = GetNumberOfPlayers();
            CreatePlayer(numberOfPlayers);
            playerOne.ChoosePlayerName();
            playerOne.recipe.CreateLemonade();            
            store = new Store(playerOne);            
            store.StoreMenu();
            playerOne.MakePitcher();
            playerOne.DisplayPitcherContents();
            
            customer.TakeCup(playerOne);
            SellTillEmpty();
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
        public void SellTillEmpty()
        {
            if (customer.decision == true)
            {
                if (playerOne.FullPitcher >= 2 && playerOne.inventory.cups.Count >= 1 && playerOne.inventory.iceCubes.Count >= playerOne.recipe.amountOfIceCubes)
                {
                    customer.TakeCup(playerOne);
                    SellTillEmpty();
                    playerOne.wallet.netIncome = playerOne.wallet.Money;
                    
                }
                else
                {
                    Console.WriteLine("You ran out of materials.");
                }
            }
            else
            {
                Console.WriteLine("The weather was shitty");
            }
            
        }
        

        
        



    }
}
