using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary
{
    public interface ITeam
    {
        List<IPlayer> Players { get; set; }
    }
}
