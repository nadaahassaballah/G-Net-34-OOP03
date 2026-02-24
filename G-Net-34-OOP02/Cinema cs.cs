using helper_1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02
{
    internal class Cinema_cs
    {
        public string CinemaName;
        private Projector projector;       
        private Ticket[] tickets = new Ticket[20];
        private int count = 0;
        public Cinema_cs(string name)
        {
            CinemaName = name;
            projector = new Projector();
        }

        public void AddTicket(Ticket t)
        {
            if (count < tickets.Length)
            {
                tickets[count++] = t;
            }
            else
            {
                Console.WriteLine("Cinema is full!");
            }
        }

        public void PrintAllTickets()
        {
            Console.WriteLine();
            Console.WriteLine("========== All Tickets ==========");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(tickets[i]);
            }

            Console.WriteLine();
            Console.WriteLine("========== Statistics ==========");
            Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");
        }

        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            projector.start();
        }

        public void CloseCinema()
        {
            Console.WriteLine("========== Cinema Closed ==========");
            projector.stop();
        }
        //public decimal CalcGroupDiscount()
        //{
        //    if (Ticket.GetTotalTickets() > 4)
        //    {
        //        decimal total = 0;
        //        for (int i = 0; i < count; i++)
        //        {
        //            total += tickets[i].prices;
        //        }
        //        return total - (total * 10 / 100);
        //    }
        //    else if (count > 0)
        //    {
        //        return tickets[0].prices;
        //    }
        //    return 0;
        //}
    }

}

