using System;

namespace Lab_2___Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator. \nTo find the area, perimeter, and volume of a room, enter the following:");
            
            bool run = true;

            while (run)

            {
                Console.WriteLine("\nEnter Length:");
                double len = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width:");
                double wid = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Height:");
                double hgt = double.Parse(Console.ReadLine());

                Console.WriteLine($"\nArea: {len * wid} \nPerimeter: {(2 * len) + (2 * wid)}\nVolume: {len * wid * hgt} \n \nContinue? y/n");
                //Console.WriteLine("Continue? y/n");

                string cont = Console.ReadLine();

                if (cont == "n") 
                {
                    run = false;
                }


            }
        }
    }
}
