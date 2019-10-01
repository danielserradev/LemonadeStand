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
        
        
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;
        

        //constructor(Spawner)
        public Recipe()
        {
            
        }

        //member methods(Can Do)
        public void CreateLemonade()
        {
            Console.WriteLine("Please enter the amount of lemons you would like to put into the lemonade.");
            amountOfLemons = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the amount of Sugar Cubes you would like to put into the lemonade.");
            amountOfSugarCubes = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the amount of Ice Cubes you would like to put into each cup.");
            amountOfIceCubes = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the amount you would like to charge per cup.");
            pricePerCup = double.Parse(Console.ReadLine());
        }
        public void DisplayRecipeIngredients()
        {
            Console.WriteLine("Your current recipe is:" +
                "\n Lemons per pitcher: " + amountOfLemons +
                "\n Sugar Cubes per pitcher: " + amountOfSugarCubes +
                "\n Ice Cubes per pitcher: " + amountOfIceCubes +
                "\n Price per cup: " + pricePerCup +
                "\n");
        }
    }
}
