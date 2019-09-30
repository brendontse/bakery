using System;

namespace Bakery.Deals
{
    class Bread
    {
        public int BreadLoaves { get; set; }
        public int BreadCost { get; set; }
        public Bread(int breadLoaves, int breadCost)
        {
            BreadLoaves = breadLoaves;
            BreadCost = breadCost;
        }
        
    }
}