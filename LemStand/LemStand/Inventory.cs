using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemStand 
{
    public class Inventory 
    {
        //member variables(Has a)
        public Player player;
        public Recipe recipe;
        public List<Lemon> lemons;
        public List<IceCube> iceCubes;
        public List<SugarCube> sugarCubes;
        public List<Cup> cups;


        //constructor(Spawner)
        public Inventory()
        {
            lemons = new List<Lemon>();
            iceCubes = new List<IceCube>();
            sugarCubes = new List<SugarCube>();
            cups = new List<Cup>();
        }

        //member methods(Can Do)
    }
}
