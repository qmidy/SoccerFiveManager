using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary
{
    public class CommonCalendarEvent : ICalendarEvent
    {
        public void LaunchEvent()
        {
            // La fonction commune ne lance rien
        }

        private string eventName;
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
    }
}
