using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemStand
{
    public class Recipe 
    {
        //member variables(Has a)
        Inventory inventory;
        
        //public int amountOfLemons;
        //public int amountOfSugarCubes;
        //public int amountOfIceCubes;
        //public double pricePerCup;
        public int cupOfLemonade;

        //constructor(Spawner)
        public Recipe()
        {
            
        }


        //member methods(Can Do)
        //public int LemonadeRecipe(Player player)
        //{
        //    if(player.inventory.lemons.Count >= 1 &&  player.inventory.sugarCubes.Count >= 1 && player.inventory.iceCubes.Count >= 1 && player.inventory.cups.Count >= 1)
        //    {
        //        cupOfLemonade = 1;
        //    }       
        //    return cupOfLemonade;    
        //}
        public void CheckLemonadeInventory()
        {
            Console.WriteLine("You have " + "cups of lemonate");
        }
        
    }
}
