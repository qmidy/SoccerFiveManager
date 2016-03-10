using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary
{
    public interface IClub
    {
        int Id { get; set; }

        string Name { get; set; }

        List<ITeam> Teams { get; set; }
    }
}
