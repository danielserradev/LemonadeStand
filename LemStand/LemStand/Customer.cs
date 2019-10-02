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
        Player player;

        //constructor(Spawner)
        public Customer(Player playerBeingPassedIn)
        {
            player = playerBeingPassedIn;
        }

        //member methods(Can Do)
        public void TakeCup()
        {
            if(player.FullPitcher >= 0)
            {
                player.FullPitcher -= 2;
                Console.WriteLine(player.FullPitcher);
            }
            else
            {
                Console.WriteLine("Your pitcher is empty");
            }
            

        }
    }
    
}
