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
        public UserControl CreateView()
        {
            var calendarView = new CalendarView();
            calendarView.DataContext = new CalendarViewModel();
            return calendarView;
        }

        public UserControl CreateViewFromViewModel(ICalendarModuleViewModel viewModel)
        {
            var calendarView = new CalendarView();
            calendarView.DataContext = viewModel;
            return calendarView;
        }

        public ICalendarModuleViewModel CreateViewModel()
        {
            return new CalendarViewModel();
        }
    }
}
