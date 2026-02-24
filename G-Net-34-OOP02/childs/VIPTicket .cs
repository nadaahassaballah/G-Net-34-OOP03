using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.childs
{
    internal class VIPTicket: Ticket 
    {
        public  bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; }= 50;
        public VIPTicket(string mn, decimal price, bool _LoungeAccess) : base(mn, price)
        {
            LoungeAccess = _LoungeAccess;

        }
        public override string ToString()
        {
            return base.ToString() + $" | Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
        }
    }
}
