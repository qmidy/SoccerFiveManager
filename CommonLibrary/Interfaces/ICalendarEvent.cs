using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary
{
    public interface ICalendarEvent
    {
        void LaunchEvent();

        string EventName { get; set; }
    }
}
