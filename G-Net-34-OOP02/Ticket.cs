using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02
{
    internal class Ticket

    { 
        public string MovieName {set;get;
         
        }
        private decimal price;
        public decimal prices
        {
            get { return price; }
            set { if (value > 0) price = value; }
        }
            private static int ticketid = 1;


     public   Ticket(string moviename, decimal price)
        {
            MovieName = moviename;
            prices = price;
            ticketid++;
        }

      
        public decimal PriceAfterTax
        {
            get { return price * 14 / 100; }
        }
        public override string ToString()
        {
            return $" Ticket #{ticketid} | {MovieName}|price : {price} | after tax: {PriceAfterTax} ";
        }
       public static int GetTotalTickets()
        {
            return ticketid - 1;
        }
    }


}
