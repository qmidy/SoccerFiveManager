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

        public void CreateGameDatabase()
        {
            var sqlcon = new SQLiteConnection("Data Source=" + ClubName + ".db;New=True;Version=3;Compress=True;");
            var sqlcommand = new SQLiteCommand();
            sqlcon.Open();
            sqlcon.Close();

            SetConnection();
            sql_con.Open();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = string.Format(System.IO.File.ReadAllText("SqlScripts\\CreateGameScript.sql"), ClubName);
            sqlcommand.ExecuteNonQuery();
            sql_con.Close();
        }
    }
}
