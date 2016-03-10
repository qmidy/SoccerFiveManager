using DAOModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary
{
    public static class DaoService
    {
        public static void CreateGameDatabase(string clubName)
        {
            CommonDatabase.ClubName = clubName;
            IManageGameDatabase manageGameDatabase = DatabaseSingleton<ManageGameDatabase>.Instance;
            manageGameDatabase.CreateGameDatabase();
        }

        public static List<IPlayer> GetPlayers(string clubName)
        {
            IManagePlayerDatabase managePlayerDatabase = DatabaseSingleton<ManagePlayerDatabase>.Instance;
            return DaoServicesPlayer.ConstructPlayersFromDAO(managePlayerDatabase.GetPlayers(clubName));
        }

        public static ITeam GetTeam(int teamId)
        {
            IManageTeamDatabase manageTeamDatabase = DatabaseSingleton<ManageTeamDatabase>.Instance;
            return DaoServicesTeam.ConstructTeamFromDAO(manageTeamDatabase.GetTeam(teamId));
        }

        public static IClub GetClub(int clubId)
        {
            IManageClubDatabase manageClubDatabase = DatabaseSingleton<ManageClubDatabase>.Instance;
            return DaoServicesClub.ConstructClubFromDAO(manageClubDatabase.GetClub(clubId));
        }
    }
}
