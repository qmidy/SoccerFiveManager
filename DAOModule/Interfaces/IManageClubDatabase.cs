﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOModule
{
    public interface IManageClubDatabase
    {
        List<object> GetClub(int clubId);

        List<object> GetClubs(string clubName);

        List<object> GetAllClubs();
    }
}
