using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CalendarModule
{
    public class CalendarModuleFactory : IModuleFactory<ICalendarModuleViewModel> 
    {
        public UserControl CreateView(object obj)
        {
            var calendarView = new CalendarView();
            calendarView.DataContext = new CalendarViewModel();
            return calendarView;
        }
    }
}
