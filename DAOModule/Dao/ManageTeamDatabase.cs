using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOModule
{
    class ManageTeamDatabase : CommonDatabase, IManageTeamDatabase
    {
        public object GetTeam(int teamId)
        {
            return ExecuteReader("SELECT * FROM team WHERE id = '" + teamId +"'").First();
        }

        public List<object> GetTeams(int clubId)
        {
            return ExecuteReader("SELECT * FROM team WHERE club_id = '" + clubId + "'");
        }
    }
}
