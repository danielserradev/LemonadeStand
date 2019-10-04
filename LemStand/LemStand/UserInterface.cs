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
        public static void DiplayInfo()
        {
            Console.WriteLine("hello game");
            Console.WriteLine();

        }
        public static void StoreMenu()
        {

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
    }
}
