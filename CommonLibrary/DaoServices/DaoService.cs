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
            // ManaePlayerDatabase doit être un singleton !
            IManageGameDatabase manageGameDatabase = new ManageGameDatabase();
            manageGameDatabase.CreateGameDatabase();
        }

        public static List<IPlayer> GetPlayers(string clubName)
        {
            // ManaePlayerDatabase doit être un singleton !
            IManagePlayerDatabase managePlayerDatabase = new ManagePlayerDatabase();

            return DaoServicesPlayer.ConstructPlayersFromDAO(managePlayerDatabase.GetPlayers(clubName));
        }

        public static ITeam GetTeam(int teamId)
        {
            // A refaire, uniquement pour tests !
            return new Team() { Players = GetPlayers(PersistedItems.clubName) };
        }

        public static IClub GetClub(int clubId)
        {
            // A refaire, uniquement pour tests !
            return new Club() { Name = PersistedItems.clubName, Team = GetTeam(0) };
        }
    }
}
