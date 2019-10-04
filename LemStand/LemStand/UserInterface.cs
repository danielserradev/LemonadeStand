using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemStand
{
    static class UserInterface
    {
        //member variables(Has a)


        //constructor(Spawner)
        

        //member methods(Can Do)
        public static void DiplayStepsOfGame()
        {
            Console.WriteLine("Lemonade Stand has 4 steps. " +
                "\n1: Make a lemonade recipe based on the weather. " +
                "\n2: Buy the ingredients of the recipe at the store. " +
                "\n3: sell the lemonade. " +
                "\n4: Repeat for 7 days.");
            Console.WriteLine();

        }
        public static int GenerateRandomNumber(int maxValue)
        {
            Random random = new Random();
            return random.Next(maxValue);
        }
        //public static int GetUserInput(string message)
        //{
        //    Console.WriteLine(message);
        //    return Console.ReadLine();
        //}

        public static void DisplayGameInfo(Player playerOne, Day day, Weather weather)
        {
            Console.Clear();
            string[] items = { "Lemons", "Sugar Cubes", "Ice Cubes", "Cups", "Wallet" };          
            double[] quantity = { playerOne.inventory.lemons.Count, playerOne.inventory.sugarCubes.Count, playerOne.inventory.iceCubes.Count, playerOne.inventory.cups.Count, playerOne.wallet.Money };
            string[] recipeItems = { "Lemons", "Sugar Cubes", "Ice Cubes", "Price per cup" };
            double[] quantityOfRecipeItem = { playerOne.recipe.amountOfLemons, playerOne.recipe.amountOfSugarCubes, playerOne.recipe.amountOfIceCubes, playerOne.recipe.pricePerCup, };
            Console.WriteLine("{0,-20}{1,5}", "Player Inventory", "Quantity");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("{0,-20}{1,5:N2}", items[i], quantity[i]);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("{0,-20}{1,5}", "Recipe Amount", "Quantity");
            for (int i = 0; i < recipeItems.Length; i++)
            {
                Console.WriteLine("{0,-20}{1,5:N2}", recipeItems[i], quantityOfRecipeItem[i]);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Today is " + day.dayName + ", the weather is " + weather.condition + " with a temperature of " + weather.temperature + " degrees outside.");
        }
        public static void DisplayGameInfoMinusWeather(Player playerOne)
        {
            Console.Clear();
            string[] items = { "Lemons", "Sugar Cubes", "Ice Cubes", "Cups", "Wallet" };
            double[] quantity = { playerOne.inventory.lemons.Count, playerOne.inventory.sugarCubes.Count, playerOne.inventory.iceCubes.Count, playerOne.inventory.cups.Count, playerOne.wallet.Money };
            string[] recipeItems = { "Lemons", "Sugar Cubes", "Ice Cubes", "Price per cup" };
            double[] quantityOfRecipeItem = { playerOne.recipe.amountOfLemons, playerOne.recipe.amountOfSugarCubes, playerOne.recipe.amountOfIceCubes, playerOne.recipe.pricePerCup, };
            Console.WriteLine("{0,-20}{1,5}", "Player Inventory", "Quantity");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("{0,-20}{1,5:N2}", items[i], quantity[i]);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("{0,-20}{1,5}", "Recipe Amount", "Quantity");
            for (int i = 0; i < recipeItems.Length; i++)
            {
                Console.WriteLine("{0,-20}{1,5:N2}", recipeItems[i], quantityOfRecipeItem[i]);
            }
            Console.WriteLine("----------------------------");
            
        }
        public static void DisplayGameInfoMinusClear(Player playerOne, Day day, Weather weather)
        {
            
            string[] items = { "Lemons", "Sugar Cubes", "Ice Cubes", "Cups", "Wallet" };
            double[] quantity = { playerOne.inventory.lemons.Count, playerOne.inventory.sugarCubes.Count, playerOne.inventory.iceCubes.Count, playerOne.inventory.cups.Count, playerOne.wallet.Money };
            string[] recipeItems = { "Lemons", "Sugar Cubes", "Ice Cubes", "Price per cup" };
            double[] quantityOfRecipeItem = { playerOne.recipe.amountOfLemons, playerOne.recipe.amountOfSugarCubes, playerOne.recipe.amountOfIceCubes, playerOne.recipe.pricePerCup, };
            Console.WriteLine("{0,-20}{1,5}", "Player Inventory", "Quantity");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("{0,-20}{1,5:N2}", items[i], quantity[i]);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("{0,-20}{1,5}", "Recipe Amount", "Quantity");
            for (int i = 0; i < recipeItems.Length; i++)
            {
                Console.WriteLine("{0,-20}{1,5:N2}", recipeItems[i], quantityOfRecipeItem[i]);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Today is " + day.dayName + ", the weather is " + weather.condition + " with a temperature of " + weather.temperature + " degrees outside.");
        }

    }
}
