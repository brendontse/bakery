using System;
using System.Collections.Generic;


namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Welcome to Pierre's Bakery! Our loaves of bread are $5 and our pastries are only $2!");
            Console.WriteLine("We have a couple specials going on at the moment:");
            Console.WriteLine("Buy 2 any loaves of bread, get 1 free!");
            Console.WriteLine("Buy any pastry for $2 or 3 for $5!");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Please enter the number of loaves of bread you'd like to order today:");            
            int UserBreadInput = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Please enter the number of patries you'd like to order today:");
            int UserPastryInput = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------");

        }
    }
}
