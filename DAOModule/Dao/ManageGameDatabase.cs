using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Reflection;

namespace DAOModule
{
    public class ManageGameDatabase : CommonDatabase, IManageGameDatabase
    {
        #region constructor

        public ManageGameDatabase()
        {
            DS = new DataSet();
            DT = new DataTable();
        }

        #endregion

        private DataSet DS;
        private DataTable DT;

        public void Initialize(string filePath)
        {
            var sqlcon = new SQLiteConnection("Data Source=" + filePath + ".db;New=True;Version=3;Compress=True;");
            sqlcon.Open();
            sqlcon.Close();
        }

        public void CreateCampaignDatabase(string filePath)
        {
            SQLiteConnection.CreateFile(filePath);
            SQLiteConnection createConnection = new SQLiteConnection("Data Source=" + filePath + ";New=True;Version=3;Compress=True;");
            SQLiteCommand sqlCommand = new SQLiteCommand();

            createConnection.Open();
            sqlCommand = createConnection.CreateCommand();
            sqlCommand.CommandText = System.IO.File.ReadAllText("SqlScripts\\CreateDatabaseScript.sql");
            sqlCommand.ExecuteNonQuery();
            createConnection.Close();
        }
    }
}
