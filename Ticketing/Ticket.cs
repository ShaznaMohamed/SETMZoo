using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing
{
    public class Ticket
    {
        private double ticketPrice;
        private int totalTicketsAmount;
        private int soldTicketsAmount;

        #region Getters and Setters
        public double TicketPrice
        {
            get
            {
                return ticketPrice;
            }

            set
            {
                ticketPrice = value;
            }
        }

        public int TotalTicketsAmount
        {
            get
            {
                return totalTicketsAmount;
            }

            set
            {
                totalTicketsAmount = value;
            }
        }

        public int SoldTicketsAmount
        {
            get
            {
                return soldTicketsAmount;
            }

            set
            {
                soldTicketsAmount = value;
            }
        }
        #endregion

        private int RemainingNumberOfTickets()
        {
            return TotalTicketsAmount - SoldTicketsAmount;
        }

        public double GetTicketProfit()
        {
            if(TicketPrice != null && TotalTicketsAmount != null && SoldTicketsAmount != null)
            {
                return TicketPrice * RemainingNumberOfTickets();
            }
            return 0;
        }
    }
}
