using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Event
    {
        private Guid eventID;
        private String eventName;
        private String eventType;
        private double totalEventCost;
        public List<Event> EventsList;

        #region Getters Setters
        public Guid EventID
        {
            get
            {
                return eventID;
            }

            set
            {
                eventID = value;
            }
        }

        public string EventName
        {
            get
            {
                return eventName;
            }

            set
            {
                eventName = value;
            }
        }

        public string EventType
        {
            get
            {
                return eventType;
            }

            set
            {
                eventType = value;
            }
        }

        public double TotalEventCost
        {
            get
            {
                return totalEventCost;
            }

            set
            {
                totalEventCost = value;
            }
        }
        #endregion

        public void CalculateTotalEventCost()
        {
            totalEventCost = Shows.internalCost + Circus.internalCost;
        }

        public double GetTotalCost()
        {
            return TotalEventCost;
        }

        public void DisplayTotalCost()
        {
            Console.WriteLine("Full events cost is " + TotalEventCost);
        }

        public void AddEventToList(Event e)
        {
            if(e != null)
            {
                EventsList.Add(e);
            }
        }

        public Event GetEvent(Guid eventID)
        {
            foreach(Event e in EventsList)
            {
                if(e.EventID == eventID)
                {
                    return e;
                }
            }

            return null;
        }
    }

}
