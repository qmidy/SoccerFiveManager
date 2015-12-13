using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary
{
    public static class CalendarService
    {
        // Setter des variables static
        public static void InitializeCalendarService()
        {
            SeasonNumber = 0;
            CurrentDate = 0;
            CalendarEvents = new Dictionary<int, List<ICalendarEvent>>();
        }

        // Dictionnaire avec :
        // - en clé la valeur de la date dans la saison
        // - en valeur la liste de CalendarEvent associée à la date en question
        public static Dictionary<int, List<ICalendarEvent>> CalendarEvents { get; private set; }

        // Numéro de saison (en private set)
        public static int SeasonNumber { get; private set; }

        // Numéro de date courant
        public static int CurrentDate { get; private set; }

        // Termine la saison en cours seulement si CurrentDate est égal à la valeur maximale des clés du dictionnaire
        public static void FinishSeason()
        {
            if(CurrentDate == CalendarEvents.Keys.Max())
            {
                CalendarEvents.Clear();
                CurrentDate = 0;
                SeasonNumber++;
            }
        }

        // Retourne la liste des évènements correspondants à la date passée en paramêtre
        public static List<ICalendarEvent> GetNextDate()
        {
            List<ICalendarEvent> result = null;
            CalendarEvents.TryGetValue(CurrentDate, out result);
            if(result != null)
            {
                foreach(var calendarEvent in result)
                {
                    calendarEvent.LaunchEvent();
                }
            }
            CurrentDate++;
            return result;
        }

        // Ajoute un évènement à la liste correspondant à la date passée en paramêtre dans le dictionnaire
        public static void AddEvent(ICalendarEvent calendarEvent, int date)
        {
            List<ICalendarEvent> result = null;
            CalendarEvents.TryGetValue(date, out result);
            // Si la date n'existe pas dans le dictionnaire, on ajoute la clé correspondante avec l'événement
            if (result == null)
            {
                List<ICalendarEvent> calendarEventsNewList = new List<ICalendarEvent>();
                calendarEventsNewList.Add(calendarEvent);
                CalendarEvents.Add(date, calendarEventsNewList);
            }
            // Sinon, on ajoute l'évènement à la liste correspondant à la date dans le dictionnaire 
            else
            {
                result.Add(calendarEvent);
            }
        }

    }
}
