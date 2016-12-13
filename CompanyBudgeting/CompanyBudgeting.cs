using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees;
using Ticketing;
using Events;

namespace CompanyBudgeting
{
    class CompanyBudgeting
    {
        private double ZooProfit; 


        Event e1 = new Event();
        Ticket t1 = new Ticket();

        public double ZooProfit1
        {
            get
            {
                return ZooProfit;
            }

            set
            {
                if (e1.TotalEventCost != null && t1.TotalTicketsAmount!=null)
                {
                    ZooProfit1 =  e1.TotalEventCost + t1.TotalTicketsAmount;
                }
                
            }
        }
    }
}
