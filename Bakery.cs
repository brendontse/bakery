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
        public void BreadDeal(int breadLoaves)
        {
            BreadCost = breadLoaves * 5;
            
            if (breadLoaves >= 2)
            {
                breadLoaves += breadLoaves / 2;
            }       
        }
    }
}
