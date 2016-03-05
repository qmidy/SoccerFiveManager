using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOModule
{
    public class ManagePlayerDatabase : CommonDatabase, IManagePlayerDatabase
    {
        public object GetPlayer(int playerId)
        {
            return ExecuteReader("SELECT * FROM player WHERE id = '" + playerId + "'").First();
        }

        public List<object> GetPlayers(string clubName)
        {
            return ExecuteReader("SELECT p.id, p.name, p.team_id, p.area, p.number, p.attack, p.defense FROM player p "
                                 + "INNER JOIN team t ON p.team_id = t.id "
                                 + "INNER JOIN club c ON t.club_id = c.id "
                                 + "AND c.name = '" + clubName +"'");
        }

        public List<object> GetPlayersByClubId(int clubId)
        {
            return ExecuteReader("SELECT p.id, p.name, p.team_id, p.area, p.number, p.attack, p.defense FROM player p "
                                 + "INNER JOIN team t ON p.team_id = t.id "
                                 + "INNER JOIN club c ON t.club_id = c.id "
                                 + "AND c.id = '" + clubId + "'");
        }

        public List<object> GetPlayersByTeamId(int teamId)
        {
            return ExecuteReader("SELECT p.id, p.name, p.team_id, p.area, p.number, p.attack, p.defense FROM player p "
                                 + "INNER JOIN team t ON p.team_id = t.id "
                                 + "AND t.id = '" + teamId + "'");
        }
    }
}
