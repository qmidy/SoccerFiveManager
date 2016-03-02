using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOModule
{
    public class ManagePlayerDatabase:CommonDatabase, IManagePlayerDatabase
    {
        public List<object> GetPlayers(string clubName)
        {
            var clubId = ExecuteReader("SELECT * FROM club WHERE name = '" + clubName + "'").First();
            return ExecuteReader("SELECT * FROM player WHERE club_id = " + clubId);
        }

        public List<object> GetPlayers(int clubId)
        {
            return ExecuteReader("SELECT * FROM player WHERE club_id = " + clubId);
        }
    }
}
