using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary
{
    public class Club : IClub
    {
        public string Name { get; set; }

        public ITeam Team { get; set; }
    }
}
