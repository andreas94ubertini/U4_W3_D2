using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema
{
    public class Room
    {
        private const int maxCapacity = 120;
        private int FullPriceTicket = 0;
        private int ReductedPriceTicket = 0;
        public  List<Customer> CustomerList = new List<Customer>();

        public int GetAvailable()
        {
            return maxCapacity - (FullPriceTicket + ReductedPriceTicket);
        }
        public int[] GetSold()
        {
            return new[] { FullPriceTicket, ReductedPriceTicket };
        }
        public void newTicket(bool Isreducted)
        {
            if (FullPriceTicket + ReductedPriceTicket < maxCapacity)
            {
                if (Isreducted)
                {
               
                    ReductedPriceTicket += 1;
                
                }
                else
                {
                    
                    FullPriceTicket += 1;
                  
                }
            }
            else
            {

            }
          
        }


    }
}
