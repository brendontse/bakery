using System;
using System.Collections.Generic;
using Bakery.Deals;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Welcome to Pierre's Bakery! Our loaves of bread are $5 and our pastries are only $2!");
            Console.WriteLine("We have a couple specials going on at the moment:");
            Console.WriteLine("Buy 2 any loaves of bread, get 1 free!");
            Console.WriteLine("Buy any pastry for $2 or 3 for $5!");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Please enter the number of loaves of bread you'd like to order today:");            
            Console.WriteLine("---------------------------------------------------------");
            int UserBreadInput = int.Parse(Console.ReadLine());
            Bread userBread = new Bread(UserBreadInput, 0);
            Console.WriteLine("Please enter the number of patries you'd like to order today:");
            Console.WriteLine("---------------------------------------------------------");
            int UserPastryInput = int.Parse(Console.ReadLine());
            Pastry userPastry = new Pastry(UserPastryInput, 0);
            userBread.BreadDeal(UserBreadInput);
            userPastry.PastryDeal(UserPastryInput);
            int Total = userPastry.PastryCost + userBread.BreadCost;
            Console.WriteLine("Your total today will be $" + Total + "! Thank you for your order of " + userBread.BreadLoaves + " loaves of bread and " + userPastry.PastryNumber + " pastries today, we hope to see you again soon!");
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
