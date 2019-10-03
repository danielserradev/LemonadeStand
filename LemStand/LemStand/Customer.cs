using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemStand
{
    public class Customer 
    {
        //member variables(Has a)
        private List<string> names;
        public string name;
        public bool decision;
        
        



        //constructor(Spawner)
        public Customer()
        {
            
        }

        //member methods(Can Do)
        public void TakeCup(Player player)
        {          
            if (player.FullPitcher >= 2 && player.inventory.cups.Count >= 1 && player.inventory.iceCubes.Count >= player.recipe.amountOfIceCubes)
            {
                
                player.FullPitcher -= 2;
                player.inventory.cups.RemoveAt(0);
                player.inventory.iceCubes.RemoveRange(0, player.recipe.amountOfIceCubes);
                player.wallet.Money += player.recipe.pricePerCup;
                Console.WriteLine(player.FullPitcher);
                Console.WriteLine(player.wallet.Money);
            }
            else
            {
                Console.WriteLine("You ran out of materials.");
            } 
        }
        public bool DecisionToBuy(Weather weather)
        {
            if (weather.condition == "Sunny" && weather.temperature >= 55)
            {
                decision = true;
                return decision;
            }
            else if (weather.condition == "Rainy" && weather.temperature > 85)
            {
                decision = true;
                return decision;
            }
            else if (weather.condition == "Cloudy" && weather.temperature > 65)
            {
                decision = true;
                return decision;
            }
            else
            {
                return false;
            }
            
        }
    }
    
}
