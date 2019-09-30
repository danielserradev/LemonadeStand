using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemStand 
{
    class Inventory 
    {
        //member variables(Has a)
        public List<Lemon> lemons;
        public List<IceCube> iceCubes;
        public List<SugarCube> sugarCubes;
        public List<Cup> cups;


        //constructor(Spawner)
        public Inventory()
        {
            lemons = new List<Lemon>();
        }

        //member methods(Can Do)
    }
}
