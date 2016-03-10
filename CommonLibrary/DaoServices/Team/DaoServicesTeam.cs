using DAOModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public static class DaoServicesTeam
    {
        public static ITeam ConstructTeamFromDAO(List<object> teamFromDao)
        {
            if (teamFromDao == null)
                return null;

            ITeam result = new Team();

            // [0] = ID, [1] = Club_id
            result.Id = (int)teamFromDao[0];
            result.ClubId = (int)teamFromDao[1];

            // On ajoute les joueurs correspondant au TeamId au result
            IManagePlayerDatabase managePlayerDatabase = DatabaseSingleton<ManagePlayerDatabase>.Instance;

            result.Players = DaoServicesPlayer.ConstructPlayersFromDAO(managePlayerDatabase.GetPlayersByTeamId(result.Id));

            return result;
        }

        public static List<ITeam> ConstructTeamsFromDAO(List<object> teamsFromDao)
        {
            if (teamsFromDao == null)
                return null;

            List<ITeam> result = new List<ITeam>();

            var teamShift = 2;
            var teamsNumber = teamsFromDao.Count / teamShift;

            for (int i = 0; i < teamsNumber; ++i)
            {
                result.Add(ConstructTeamFromDAO(teamsFromDao.GetRange(i * teamShift, teamShift)));
            }

            return result;
        }
    }
}
