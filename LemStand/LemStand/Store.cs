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
        public int stockOfLemons;
        public int stockOfSugarCubes;
        public int stockOfIceCubes;
        public int stockOfCups;
        public string playersChoice;
        
        //constructor(Spawner)

        public Store(Player playerValueBeingPassedIn)
        {
            stockOfLemons = 500;
            stockOfSugarCubes = 500;
            stockOfIceCubes = 5000;
            stockOfCups = 1000;
            player = playerValueBeingPassedIn;
            
        }

        //member methods(Can Do)
        
        public void DisplayStoreInventory()
        {
            Console.WriteLine("The store has the following in stock: " + "\n" + stockOfLemons + 
                " Lemons, " + stockOfSugarCubes + " sugarCubes, " + stockOfIceCubes + " iceCubes, "
                + stockOfCups + " cups \n");
        }
        public void InventoryPrices()
        {
            Console.WriteLine("Prices are listed below. " +
                "\nLemons: $1 " +
                "\nSugarCubes: $2 " +
                "\nIceCubes: $3 " +
                "\nCups: $4 \n");
            StoreMenu();
        }
        

        public void TakingPlayerMoney()
        {

        }
        
        public void SendPlayerBackToGame()
        {

        }
        public void StoreMenu()
        {
            Console.WriteLine("Please enter the number that corrisponds with the option you would like to choose. \n" +
                "\n1. Inventory prices " +
                "\n2. Buy lemons " +
                "\n3. Buy sugar cubes " +
                "\n4. Buy ice cubes " +
                "\n5. Buy cups " +
                "\n6. Check your inventory" +
                "\n7. Leave the store \n");
            playersChoice = Console.ReadLine();
            switch (playersChoice)
            {
                case "1":
                    InventoryPrices();
                    break;
                case "2":
                    SellLemons();
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                default:
                    StoreMenu();
                    break;
            }
        }
        public void SellLemons()
        {
            Console.WriteLine("Please press 1 to buy a lemon. Press 2 to go back to the store menu." +
                "\n" +
                "\n" +
                "\nYour lemon inventory: " + player.inventory.lemons.Count);
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                player.inventory.lemons.Add(new Lemon());
                SellLemons();
            }
            else if(choice == 2)
            {
                StoreMenu();
            }
        }
        
    }
}
