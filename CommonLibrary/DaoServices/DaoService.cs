using DAOModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary
{
    public static class DaoService
    {
        #region Initialization

        public static void Initialize(string filePath)
        {
            IManageGameDatabase manageGameDatabase = DatabaseSingleton<ManageGameDatabase>.Instance;
            manageGameDatabase.Initialize(filePath);
        }

        #endregion

        #region Campagin Management
        public static void CreateCampaignDatabase(string filePath)
        {
            IManageGameDatabase manageGameDatabase = DatabaseSingleton<ManageGameDatabase>.Instance;
            manageGameDatabase.CreateCampaignDatabase(filePath);
        }

        #endregion

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
