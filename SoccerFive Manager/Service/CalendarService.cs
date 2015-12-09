using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    public class CalendarService
    {
        // Dictionnaire avec :
        // - en clé la valeur de la date dans la saison
        // - en valeur la liste de CalendarEvent associée à la date en question
        public Dictionary<int, List<ICalendarEvent>> CalendarEvents { get; set; }

        // Numéro de saison (en private set)
        public int SeasonNumber { get; private set; }

        // Numéro de date courant
        public int CurrentDate { get; private set; }

        // Termine la saison en cours seulement si CurrentDate est égal à la valeur maximale des clés du dictionnaire
        public void FinishSeason()
        {
            if(CurrentDate == CalendarEvents.Keys.Max())
            {
                CalendarEvents.Clear();
                SeasonNumber++;
            }
        }

        // Retourne la liste des évènements correspondants à la date passée en paramêtre
        public List<ICalendarEvent> GetNextDate()
        {
            List<ICalendarEvent> result = null;
            CalendarEvents.TryGetValue(CurrentDate, out result);
            CurrentDate++;
            return result;
        }

        // Ajoute un évènement à la liste correspondant à la date passée en paramêtre dans le dictionnaire
        public void AddEvent(ICalendarEvent calendarEvent, int date)
        {
            List<ICalendarEvent> result = null;
            CalendarEvents.TryGetValue(date, out result);
            // Si la date n'existe pas dans le dictionnaire, on ajoute la clé correspondante avec l'événement
            if (result != null)
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
