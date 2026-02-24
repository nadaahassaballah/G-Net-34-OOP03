using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.childs
{
    internal class IMAXTicket:Ticket
    {
        public bool Is3D { get; set; }
        public IMAXTicket(string mn, decimal price, bool is3d) : base(mn, price) {
            if (is3d)
                price += 30;
        }
        public override string ToString()
        {
            return base.ToString() +$" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
        }
    }
}
