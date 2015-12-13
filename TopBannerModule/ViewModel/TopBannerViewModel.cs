using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TopBannerModule
{
    public class TopBannerViewModel : CommonViewModel, ITopBannerModuleViewModel
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

        public void NextClickCallBack()
        {
            CalendarService.GetNextDate();
            EventDictionnary = CalendarService.CalendarEvents.Where(x => x.Key >= CalendarService.CurrentDate).ToDictionary(x => x.Key, x => x.Value);
        }

        public TopBannerViewModel()
        {
            EventDictionnary = CalendarService.CalendarEvents;
        }

    }
}
