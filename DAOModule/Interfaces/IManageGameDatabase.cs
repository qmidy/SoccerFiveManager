using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAOModule
{
    public interface IManageGameDatabase
    {
        void CreateGameDatabase(string clubName);

        List<object> GetPlayers(string clubName);
    }
}
