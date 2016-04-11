using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DAOModule
{
    public class CommonDatabase
    {
        public static string ClubName;

        protected static SQLiteConnection sql_con;
        protected SQLiteCommand sql_cmd;
        protected SQLiteDataAdapter DB;

        protected void ExecuteNonQuery(string txtQuery)
        {
            lock (sql_con)
            {        
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = txtQuery;
                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
        }

        protected List<Object> ExecuteReader(string txtQuery)
        {
            List<Object> result = new List<object>();
            lock (sql_con)
            {
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = txtQuery;
                var resultReader = sql_cmd.ExecuteReader();
                while (resultReader.Read())
                {
                    for (int i = 0; i < resultReader.FieldCount; ++i)
                    {
                        result.Add(resultReader.GetValue(i));
                    }
                }
                sql_con.Close();
            }
            return result;
        }
    }
}
