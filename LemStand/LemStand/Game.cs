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
        public Weather weather;
        public Day day;        
        public int numberOfPlayers;           
        public int ingredients = 0;
        public List<string> days;
        PredictedWeather predictedWeather;


        //constructor(Spawner)
        public Game()
        {
            //customer = new Customer();
            days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            predictedWeather = new PredictedWeather();
        }

        //member methods(Can Do)
        public void WeatherForecast()
        {
            foreach (string individualDay in days)
            {
                Console.WriteLine(individualDay + " might be");
                weather = new Weather();
                weather.DisplayWeather();
                Console.WriteLine(weather.condition + " and " + weather.temperature);
                predictedWeather.predictedCondition = weather.condition;                


                //for (int i = 1; i < days.Count; i++)
                //{

                //}




                Console.ReadLine();
            }


        }
        public void RunGame()
        { 
            //WeatherForecast();
            UserInterface.DiplayStepsOfGame();
            int numberOfPlayers = GetPlayers();
            CreatePlayer(numberOfPlayers);
            playerOne.ChoosePlayerName();            
            foreach (string individualDay in days)
            {
                day = new Day(individualDay);
                day.SpawnCustomers();
                weather = new Weather();
                weather.DisplayWeather();
                UserInterface.DisplayGameInfo(playerOne, day, weather);
                playerOne.recipe.CreateLemonade();                
                store = new Store(playerOne);
                store.StoreMenu();
                UserInterface.DisplayGameInfoMinusClear(playerOne, day, weather);
                playerOne.MakePitcher();
                playerOne.DisplayPitcherContents();                
                SellTillEmpty(weather);

            }
            playerOne.wallet.DisplayNetIncome();
        }
        public int GetPlayers()
        {
            Console.WriteLine("Press 1 to start playing ");
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
                
                default:
                    GetPlayers();
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
        public void SellTillEmpty(Weather weather)
        {
            
            foreach (Customer individualCustomer in day.customers)
            {
                
                individualCustomer.DecisionToBuy(weather);
                if (individualCustomer.decision == true)
                {
                    if (playerOne.FullPitcher >= 2 && playerOne.inventory.cups.Count >= 1 && playerOne.inventory.iceCubes.Count >= playerOne.recipe.amountOfIceCubes)
                    {

                        individualCustomer.TakeCup(playerOne);
                        Console.WriteLine(individualCustomer.name + " bought a cup of lemonade.");
                        Console.WriteLine(individualCustomer.name + " gave you " + playerOne.recipe.pricePerCup + " cents, You know have a total of " + playerOne.wallet.Money);
                        Console.WriteLine("Your pitcher of lemonade is " + playerOne.FullPitcher + "% full.\n");
                        playerOne.wallet.netIncome = playerOne.wallet.Money;

                    }
                    else
                    {
                        Console.WriteLine(individualCustomer.name + " Wanted lemonade but you ran out of materials.\n");
                    }
                    

                }
                else
                {
                    Console.WriteLine(individualCustomer.name + " Didnt want lemonade beacuase the weather was bad.\n");
                }
                
            }

            Console.WriteLine("Press any key to continue to the next day");
            Console.ReadLine();
            


        }
        

        
        



    }
}
