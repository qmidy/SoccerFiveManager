using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOModule
{
    public interface IManagePlayerDatabase
    {
        List<object> GetPlayers(string clubName);

        List<object> GetPlayersByClubId(int clubId);

        List<object> GetPlayersByTeamId(int teamId);

        object GetPlayer(int playerId);
    }
}
