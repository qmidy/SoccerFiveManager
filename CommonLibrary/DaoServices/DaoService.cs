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
            IManageGameDatabase manageGameDatabase = new ManageGameDatabase();
            manageGameDatabase.CreateGameDatabase();
        }

        public static List<IPlayer> GetPlayers()
        {
            List<IPlayer> result = new List<IPlayer>();

            IManagePlayerDatabase managePlayerDatabase = new ManagePlayerDatabase();

            // On récupère un tableau qui renvoie une donnée par case
            // IE => [0] : Id du joueur / [1] : Nom du joueur / [2] : Club Id / [3] : Area / [4] : Number / [5] : Attack / [6] : Defense
            var playerObjects = managePlayerDatabase.GetPlayers(CommonDatabase.ClubName);
            var playersNumber = playerObjects.Count / 7;
            var playerShift = 7;

            for (int i = 0; i < playersNumber; ++i)
            {
                IPlayer player = new Player();
                player.Name = (string)playerObjects[i * playerShift + 1];
                // player.Club = ...
                player.Area = (EnumArea)Enum.Parse(typeof(EnumArea), playerObjects[i * playerShift + 3].ToString());
                player.Number = int.Parse(playerObjects[i * playerShift + 4].ToString());
                player.Attack = int.Parse(playerObjects[i * playerShift + 5].ToString());
                player.Defense = int.Parse(playerObjects[i * playerShift + 6].ToString());
                result.Add(player);
            }

            return result;
        }
    }
}
