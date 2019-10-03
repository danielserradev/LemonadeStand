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
        public Day day;
        Customer customer;
        public int numberOfPlayers;
        
        public int fullPitcher;
        public int ingredients = 0;
        public List<string> days;



        //constructor(Spawner)
        public Game()
        {
            //customer = new Customer();
            days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        }

        //member methods(Can Do)
        public void LoopThroughDays()
        {
            
        }
        public void RunGame()
        {
            
            UserInterface.DiplayInfo();
            int numberOfPlayers = GetNumberOfPlayers();
            CreatePlayer(numberOfPlayers);
            playerOne.ChoosePlayerName();
            foreach (string individualDay in days)
            {
                Console.WriteLine("Today is " + individualDay);
                day = new Day();
                weather = new Weather();
                customer = new Customer();
                weather.DisplayWeather();
                customer.DecisionToBuy(weather);
                playerOne.recipe.CreateLemonade();
                store = new Store(playerOne);
                store.StoreMenu();
                playerOne.MakePitcher();
                playerOne.DisplayPitcherContents();

                customer.TakeCup(playerOne);
                SellTillEmpty();

            }
            
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
