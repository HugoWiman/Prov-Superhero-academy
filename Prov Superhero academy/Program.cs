using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Superhero_academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chose your type of hero.");
            Console.WriteLine("Fire");
            Console.WriteLine("Grass");
            Console.WriteLine("Earth");
            string choice = Console.ReadLine();


            if (choice =="Fire ")
            {
            Fire Hero = new Fire();
            }

            if (choice == "Grass")
            {
                grass Hero = new grass();
            }
            if (choice == "Earth")
            {
                Earth Hero = new Earth();
            }

            else
            {

                Console.WriteLine("chose one of the following.");
                Console.WriteLine("Fire");
                Console.WriteLine("Grass");
                Console.WriteLine("Earth");
                choice = Console.ReadLine();
            
            }
            
        }
    }//han inte göra så att man fick ändra namn men skulle göra det här.
}
