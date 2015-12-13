﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public static class CommonEventAggregator
    {
        public static EventAggregator GetCommonEventAggregator()
        {
            return commonEventAggregator;
        }

        private static EventAggregator commonEventAggregator = new EventAggregator();
    }

    public class GoToMatchEngineEvent : CompositeWpfEvent<string> { }

    public class GoToCalendarEvent : CompositeWpfEvent<string> { }

    public class GoToClubEvent : CompositeWpfEvent<IClub> { }

    public class GoToTeamEvent : CompositeWpfEvent<ITeam> { }

    public class GoToTacticEvent : CompositeWpfEvent<ITeam> { }
}
