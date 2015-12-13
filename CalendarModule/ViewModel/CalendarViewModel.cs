using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CalendarModule
{
    public class CalendarViewModel : CommonViewModel, ICalendarModuleViewModel
    {
        private Dictionary<int, List<ICalendarEvent>> eventDictionnary;
        public Dictionary<int, List<ICalendarEvent>> EventDictionnary 
        { 
            get
            {
                return eventDictionnary;
            }
            set
            {
                eventDictionnary = value;
                OnPropertyChanged("EventDictionnary");
            }
        }

        public CalendarViewModel()
        {
            EventDictionnary = CalendarService.CalendarEvents;
        }

    }
}
