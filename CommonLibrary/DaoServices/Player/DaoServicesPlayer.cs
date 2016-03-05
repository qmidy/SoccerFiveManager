using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public static class DaoServicesPlayer
    {
        public static IPlayer ConstructPlayerFromDAO(List<object> playerFromDao)
        {
            if (playerFromDao == null)
                return null;

            IPlayer playerResult = new Player();
            
            // IE => [0] : Id du joueur / [1] : Nom du joueur / [2] : Team Id / [3] : Area / [4] : Number / [5] : Attack / [6] : Defense
            playerResult.Id = (int)playerFromDao[0];
            playerResult.Name = (string)playerFromDao[1];
            playerResult.TeamId = (int)playerFromDao[2];
            playerResult.Area = (EnumArea)(int)playerFromDao[3];
            playerResult.Number = (int)playerFromDao[4];
            playerResult.Attack = (int)playerFromDao[5];
            playerResult.Defense = (int)playerFromDao[6];

            return playerResult;
        }

        public static List<IPlayer> ConstructPlayersFromDAO(List<object> playersFromDao)
        {
            List<IPlayer> result = new List<IPlayer>();

            var playersNumber = playersFromDao.Count / 7;
            var playerShift = 7;

            for (int i = 0; i < playersNumber; ++i)
            {
                result.Add(DaoServicesPlayer.ConstructPlayerFromDAO(playersFromDao.GetRange(i * playerShift, playerShift)));
            }

            return result;
        }
    }
}
