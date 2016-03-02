using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Finisar.SQLite;
using System.Data;

namespace DAOModule
{
    public class ManageGameDatabase : IManageGameDatabase
    {
        #region constructor

        public ManageGameDatabase(string clubName)
        {
            this.clubNameClass = clubName;
        }

        #endregion

        #region private

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private string clubNameClass;

        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=" + clubNameClass + ".db;Version=3;Compress=True;");
        }

        private void ExecuteNonQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private List<Object> ExecuteReader(string txtQuery)
        {
            List<Object> result = new List<object>();
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            var resultReader = sql_cmd.ExecuteReader();
            while (resultReader.Read())
            {
                for(int i = 0; i < resultReader.FieldCount; ++i)
                {
                    result.Add(resultReader.GetValue(i));
                }
            }
            sql_con.Close();
            return result;
        }

        #endregion

        public void CreateGameDatabase(string clubName)
        {
            var sqlcon = new SQLiteConnection("Data Source=" + clubNameClass + ".db;New=True;Version=3;Compress=True;");
            var sqlcommand = new SQLiteCommand();
            // Création des tables pour le club et l'équipe
            sqlcon.Open();
            // On rend disponible l'utilisation de clés étrangères
            sqlcommand = sqlcon.CreateCommand();
            sqlcommand.CommandText = "PRAGMA foreign_keys=ON";
            sqlcommand.ExecuteNonQuery();

            // Déclaration de la table Club
            sqlcommand = sqlcon.CreateCommand();
            sqlcommand.CommandText = "CREATE TABLE club (id INT NOT NULL PRIMARY KEY, name VARCHAR(20))";
            sqlcommand.ExecuteNonQuery();
            
            // Déclaration de la table Player
            sqlcommand = sqlcon.CreateCommand();
            sqlcommand.CommandText = "CREATE TABLE player (id INT NOT NULL PRIMARY KEY, name VARCHAR(20), club_id INT, area INT, number INT, attack INT, defense INT, FOREIGN KEY (club_id) REFERENCES club(id))";
            sqlcommand.ExecuteNonQuery();

            // Ajout de la ligne correspondant au Club
            sqlcommand = sqlcon.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO club VALUES ('1','"+clubName+"')";
            sqlcommand.ExecuteNonQuery();

            // Ajout des lignes correspondant aux Joueurs
            sqlcommand = sqlcon.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('1','Tom','1','0','1','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sqlcon.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('2','Dédé','1','0','2','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sqlcon.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('3','Fanch','1','0','3','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sqlcon.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('4','Eric','1','0','4','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sqlcon.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('5','Pierre','1','0','5','10','10')";
            sqlcommand.ExecuteNonQuery();

            GenerateOtherClubs();

            sqlcon.Close();
        }

        private void GenerateOtherClubs()
        {
            SetConnection();
            var sqlcommand = new SQLiteCommand();
            // Création des tables pour le club et l'équipe
            sql_con.Open();
            // On rend disponible l'utilisation de clés étrangères
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "PRAGMA foreign_keys=ON";
            sqlcommand.ExecuteNonQuery();

            // Insertions des clubs
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO club VALUES ('2','" + "Club2" + "')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO club VALUES ('3','" + "Club3" + "')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO club VALUES ('4','" + "Club4" + "')";
            sqlcommand.ExecuteNonQuery();

            // Insertions des joueurs
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('6','Player1','2','0','1','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('7','Player2','2','0','2','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('8','Player3','2','0','3','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('9','Player4','2','0','4','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('10','Player5','2','0','5','10','10')";
            sqlcommand.ExecuteNonQuery();

            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('11','Player1','3','0','1','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('12','Player2','3','0','2','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('13','Player3','3','0','3','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('14','Player4','3','0','4','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('15','Player5','3','0','5','10','10')";
            sqlcommand.ExecuteNonQuery();

            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('16','Player1','4','0','1','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('17','Player2','4','0','2','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('18','Player3','4','0','3','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('19','Player4','4','0','4','10','10')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO player VALUES ('20','Player5','4','0','5','10','10')";
            sqlcommand.ExecuteNonQuery();

            sql_con.Close();
        }

        public List<object> GetPlayers(string clubName)
        {
            var clubId = ExecuteReader("SELECT * FROM club WHERE name = '" + clubName + "'").First();
            return ExecuteReader("SELECT * FROM player WHERE club_id = " + clubId);
        }
    }
}
