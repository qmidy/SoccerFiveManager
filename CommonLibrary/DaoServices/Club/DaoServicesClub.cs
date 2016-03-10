using DAOModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public static class DaoServicesClub
    {
        public static IClub ConstructClubFromDAO(List<object> clubFromDao)
        {
            if (clubFromDao == null)
                return null;

            IClub result = new Club();

            IManageTeamDatabase manageTeamDatabase = DatabaseSingleton<ManageTeamDatabase>.Instance;

            // [0] => ID, [1] => Name
            result.Id = (int)clubFromDao[0];
            result.Name = (string)clubFromDao[1];
            result.Teams = DaoServicesTeam.ConstructTeamsFromDAO(manageTeamDatabase.GetTeams(result.Id));

            return result;
        }
    }
}
