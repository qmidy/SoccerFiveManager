using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOModule
{
    public class ManageClubDatabase : CommonDatabase, IManageClubDatabase
    {
        public List<object> GetAllClubs()
        {
            return ExecuteReader("SELECT * FROM club");
        }

        public List<object> GetClubs(string clubName)
        {
            return ExecuteReader("SELECT * FROM club WHERE name = " + clubName);
        }

        public List<object> GetClub(int clubId)
        {
            return ExecuteReader("SELECT * FROM club WHERE id = " + clubId);
        }
    }
}
