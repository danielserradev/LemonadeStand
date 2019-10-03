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
        Wallet wallet;
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
            Console.WriteLine("Prices are listed below. " +
                "\nLemons: $1 " +
                "\nSugarCubes: $2 " +
                "\nIceCubes: $3 " +
                "\nCups: $4 \n");
            StoreMenu();
        }
        

        public void CheckInventory()
        {
            Console.WriteLine("Your current inventory is:" +
                "\n Lemons: " + player.inventory.lemons.Count +
                "\n Sugar Cubes: " + player.inventory.sugarCubes.Count +
                "\n Ice Cubes: " + player.inventory.iceCubes.Count +
                "\n Cups: " + player.inventory.cups.Count);
            StoreMenu();
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
                    CheckInventory();
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
                "\nYour current recipe is:" +
                "\nLemons per pitcher: " + player.recipe.amountOfLemons +
                "\nSugar Cubes per pitcher: " + player.recipe.amountOfSugarCubes +
                "\nIce Cubes per pitcher: " + player.recipe.amountOfIceCubes +
                "\nPrice per cup: " + player.recipe.pricePerCup +
                "\n"+
                "\nYour lemon inventory: " + player.inventory.lemons.Count +
                "\nYour current balance is " + player.wallet.Money);


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
            Console.WriteLine("Please press 1 to buy a Sugar Cube. Press 2 to go back to the store menu." +
                "\n" +
                "\n" +
                "\nYour current recipe is:" +
                "\nLemons per pitcher: " + player.recipe.amountOfLemons +
                "\nSugar Cubes per pitcher: " + player.recipe.amountOfSugarCubes +
                "\nIce Cubes per pitcher: " + player.recipe.amountOfIceCubes +
                "\nPrice per cup: " + player.recipe.pricePerCup +
                "\n" +
                "\nYour Sugar Cube inventory: " + player.inventory.sugarCubes.Count +
                "\nYour current balance is " + player.wallet.Money);
            
            int amountOfItem = UserInput();
            if (amountOfItem >= 1)
            {
                if (player.wallet.Money >= .50 * amountOfItem)
                {
                    player.wallet.Money -= .50 * amountOfItem;
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
            Console.WriteLine("Please press 1 to buy Ice Cubes. Press 2 to go back to the store menu." +
                "\n" +
                "\n" +
                "\nYour current recipe is:" +
                "\nLemons per pitcher: " + player.recipe.amountOfLemons +
                "\nSugar Cubes per pitcher: " + player.recipe.amountOfSugarCubes +
                "\nIce Cubes per pitcher: " + player.recipe.amountOfIceCubes +
                "\nPrice per cup: " + player.recipe.pricePerCup +
                "\n" +
                "\nYour Ice Cube inventory: " + player.inventory.iceCubes.Count +
                "\nYour current balance is " + player.wallet.Money);
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
            Console.WriteLine("Please press 1 to buy Cups. Press 2 to go back to the store menu." +
                "\n" +
                "\n" +
                "\nYour current recipe is:" +
                "\nLemons per pitcher: " + player.recipe.amountOfLemons +
                "\nSugar Cubes per pitcher: " + player.recipe.amountOfSugarCubes +
                "\nIce Cubes per pitcher: " + player.recipe.amountOfIceCubes +
                "\nPrice per cup: " + player.recipe.pricePerCup +
                "\n" +
                "\nYour Cup inventory: " + player.inventory.cups.Count +
                "\nYour current balance is " + player.wallet.Money);

            int amountOfItem = UserInput();
            if (amountOfItem >= 1)
            {
                if (player.wallet.Money >= .50 * amountOfItem)
                {
                    player.wallet.Money -= .50 * amountOfItem;
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
