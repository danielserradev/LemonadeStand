using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemStand
{
    public class Wallet 
    {
        //member variables(Has a)
        private double money = 20;

        //constructor(Spawner)

        //member methods(Can Do)
        public double Money 
        {
            set
            {
                if(value <= 0)
                {
                    money = 0;
                }
                else
                {
                    money = value;
                }
            }
            get
            {
                return money;
            }

            
        }
        
    }
}
