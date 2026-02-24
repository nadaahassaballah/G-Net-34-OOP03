using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.childs
{
    internal class StandardTicket : Ticket
    {
        public int SeatNumber { get; set; }

        public StandardTicket(string mn, decimal price, int seatNumber):base(mn, price) 
        {
            SeatNumber = seatNumber;
        }

        public override string ToString()
        {
            return base.ToString()+$"|seat {SeatNumber}";
        }
    }
}
