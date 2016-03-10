using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary
{
    public interface ITeam
    {
        int Id { get; set; }

        List<IPlayer> Players { get; set; }

        int ClubId { get; set; }
    }
}
