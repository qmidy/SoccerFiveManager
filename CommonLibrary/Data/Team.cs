using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary
{
    public class Team : ITeam
    {
        public List<IPlayer> Players { get; set; }
    }
}
