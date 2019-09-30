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
    
    class Pastry
    {
        public int PastryNumber { get; set; }
        public int PastryCost { get; set; }
        public Pastry(int pastryNumber, int pastryCost)
        {
            PastryNumber = pastryNumber;
            PastryCost = pastryCost;
        }

        public void PastryDeal(int pastryNumber)
        {
            PastryCost = pastryNumber * 2;
            
            if (pastryNumber >= 3)
            {
                PastryCost -= pastryNumber / 3;
            }        
        }
    }
}
