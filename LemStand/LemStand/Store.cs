using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemStand
{
    class Store 
    {
        //member variables(Has a)
        //inventory of stuff
        Player player;
        public string playersChoice;
        public int amountOfItem;
        
        //constructor(Spawner)
        
        public Store(Player playerValueBeingPassedIn)
        {
            player = playerValueBeingPassedIn;                     
        }

        //member methods(Can Do)
        public int UserInput()
        {
            Console.WriteLine("please enter the amount you would like to purchase");
            amountOfItem = int.Parse(Console.ReadLine());
            return amountOfItem;
        }
        public void DisplayPrices()
        {
            UserInterface.DisplayGameInfoMinusWeather(player);
            Console.WriteLine("Prices are listed below. " +
                "\nLemons: $0.50 " +
                "\nSugarCubes: $0.20 " +
                "\nIceCubes: $0.05 " +
                "\nCups: $0.05 \n");
            StoreMenu();
        }                
        public void StoreMenu()
        {
            UserInterface.DisplayGameInfoMinusWeather(player);
            Console.WriteLine("Please enter the number that corrisponds with the option you would like to choose. \n" +
                "\n1. Inventory prices " +
                "\n2. Buy lemons " +
                "\n3. Buy sugar cubes " +
                "\n4. Buy ice cubes " +
                "\n5. Buy cups " +
                "\n6. Leave the store to make and sell lemonade\n");
            playersChoice = Console.ReadLine();
            switch (playersChoice)
            {
                case "1":
                    DisplayPrices();
                    break;
                case "2":
                    SellLemons();
                    break;
                case "3":
                    SellSugarCubes();
                    break;
                case "4":
                    SellIceCubes();
                    break;
                case "5":
                    SellCups();
                    break;
                case "6":
                    //make and sell lemonade
                    break;
                default:
                    StoreMenu();
                    break;
            }
            
        }
        public void SellLemons()
        {
            UserInterface.DisplayGameInfoMinusWeather(player);          
            int amountOfItem = UserInput();
            if(amountOfItem >= 1)
            {
                if (player.wallet.Money >= .50 * amountOfItem)
                {
                    player.wallet.Money -= .50 * amountOfItem;
                    for(int i = 0; i < amountOfItem; i++)
                    {
                        player.inventory.lemons.Add(new Lemon());
                    }
                    StoreMenu();                      
                }
                else
                {
                    Console.WriteLine("You have insufficent funds.");
                    StoreMenu();
                }               
            }
            else if(amountOfItem == 0)
            {
                StoreMenu();
            }
        }
        public void SellSugarCubes()
        {
            UserInterface.DisplayGameInfoMinusWeather(player);
            int amountOfItem = UserInput();
            if (amountOfItem >= 1)
            {
                if (player.wallet.Money >= .20 * amountOfItem)
                {
                    player.wallet.Money -= .20 * amountOfItem;
                    for (int i = 0; i < amountOfItem; i++)
                    {
                        player.inventory.sugarCubes.Add(new SugarCube());
                    }
                    StoreMenu();
                }
                else
                {
                    Console.WriteLine("You have insufficent funds.");
                    StoreMenu();
                }
            }
            else if (amountOfItem == 0)
            {
                StoreMenu();
            }
        }
        public void SellIceCubes()
        {
            UserInterface.DisplayGameInfoMinusWeather(player);
            int amountOfItem = UserInput();
            if (amountOfItem >= 1)
            {
                if (player.wallet.Money >= .05 * amountOfItem)
                {
                    player.wallet.Money -= .05 * amountOfItem;
                    for (int i = 0; i < amountOfItem; i++)
                    {
                        player.inventory.iceCubes.Add(new IceCube());
                    }
                    StoreMenu();
                }
                else
                {
                    Console.WriteLine("You have insufficent funds.");
                    StoreMenu();
                }
            }
            else if (amountOfItem == 0)
            {
                StoreMenu();
            }
        }
        public void SellCups()
        {
            UserInterface.DisplayGameInfoMinusWeather(player);
            int amountOfItem = UserInput();
            if (amountOfItem >= 1)
            {
                if (player.wallet.Money >= .05 * amountOfItem)
                {
                    player.wallet.Money -= .05 * amountOfItem;
                    for (int i = 0; i < amountOfItem; i++)
                    {
                        player.inventory.cups.Add(new Cup());
                    }
                    StoreMenu();
                }
                else
                {
                    Console.WriteLine("You have insufficent funds.");
                    StoreMenu();
                }
            }
            else if (amountOfItem == 0)
            {
                StoreMenu();
            }
        }
    }
}
