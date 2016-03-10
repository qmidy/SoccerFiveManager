using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOModule
{
    public interface IManageTeamDatabase
    {
        List<object> GetTeams(int clubId);

        List<object> GetTeam(int teamId);
    }
}
