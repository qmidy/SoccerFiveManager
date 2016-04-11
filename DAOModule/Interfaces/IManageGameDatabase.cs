using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAOModule
{
    public interface IManageGameDatabase
    {
        void Initialize(string filePath);

        void CreateCampaignDatabase(string filePath);
    }
}
