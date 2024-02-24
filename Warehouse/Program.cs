using System;

namespace Warehouse
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to warehouse app!");
            Console.WriteLine("Please let me know what you want to do:");
            Console.WriteLine("1. Add item");
            Console.WriteLine("2. Remove item");
            Console.WriteLine("3. Check item");
            Console.WriteLine("Press 1, 2 or 3...");

            string choice = Console.ReadLine();

            Console.WriteLine($"You have chosen option number: {choice}");

            // zmiena
            int chosenOption = 0;

            Int32.TryParse(choice, out chosenOption );

            Console.WriteLine("Please  choose another option...");

            choice = Console.ReadLine();

            Int32.TryParse(choice, out chosenOption);
        }
    }
   
}
