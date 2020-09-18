using System;
using System.Linq;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User. Please create a password with the following requirements:");
            Console.WriteLine("-At least one lowercase letter");
            Console.WriteLine("-At least one uppercase letter");
            Console.WriteLine("-A minimum of 7 characters");
            Console.WriteLine("-A maximum of 12 characters");
            Console.WriteLine("-At least 1 exclamation point");
            Console.WriteLine("");

            Console.WriteLine("Enter your Password:");

            string pass = Console.ReadLine();
            
            bool length = pass.Length <= 12 && pass.Length >=7;
            bool upper = pass.Any(char.IsUpper);
            bool lower = pass.Any(char.IsLower);
            bool exclaim = pass.Contains("!");

            if ((length == true) && (upper == true) && (lower == true) && (exclaim == true))
                {
                    Console.WriteLine("Password valid and accepted");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            

        }
    }
}
