﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemStand
{
    public class Wallet 
    {
        //member variables(Has a)
        private double money;
        public double netIncome;

        //constructor(Spawner)
        public Wallet()
        {
            money = 20.00;
        }

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
        public void DisplayNetIncome()
        {
            Console.WriteLine(netIncome);
        }
    }
}
