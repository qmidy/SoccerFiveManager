using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOModule
{
    public class ManageTeamDatabase : CommonDatabase, IManageTeamDatabase
    {
        public List<object> GetTeam(int teamId)
        {
            return ExecuteReader("SELECT * FROM team WHERE id = '" + teamId +"'");
        }

        public List<object> GetTeams(int clubId)
        {
            return ExecuteReader("SELECT * FROM team WHERE club_id = '" + clubId + "'");
        }
    }
}
