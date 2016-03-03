using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

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
            var sqlcon = new SQLiteConnection("Data Source=" + CommonDatabase.ClubName + ".db;New=True;Version=3;Compress=True;");
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

            // Déclaration de la table Team
            sqlcommand = sqlcon.CreateCommand();
            sqlcommand.CommandText = "CREATE TABLE team (id INT NOT NULL PRIMARY KEY, club_id INT,  FOREIGN KEY (club_id) REFERENCES club(id))";
            sqlcommand.ExecuteNonQuery();

            // Déclaration de la table Player
            sqlcommand = sqlcon.CreateCommand();
            sqlcommand.CommandText = "CREATE TABLE player (id INT NOT NULL PRIMARY KEY, name VARCHAR(20), team_id INT, area INT, number INT, attack INT, defense INT, FOREIGN KEY (team_id) REFERENCES team(id))";
            sqlcommand.ExecuteNonQuery();

            // Ajout de la ligne correspondant au Club
            sqlcommand = sqlcon.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO club VALUES ('1','" + CommonDatabase.ClubName + "')";
            sqlcommand.ExecuteNonQuery();

            // Ajout de la ligne correspondant à la Team qui référence le club précédemment créé
            sqlcommand = sqlcon.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO team VALUES ('1','1')";
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
            sqlcommand.CommandText = "INSERT INTO team VALUES ('2','2')";
            sqlcommand.ExecuteNonQuery();

            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO club VALUES ('3','" + "Club3" + "')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO team VALUES ('3','3')";
            sqlcommand.ExecuteNonQuery();

            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO club VALUES ('4','" + "Club4" + "')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand = sql_con.CreateCommand();
            sqlcommand.CommandText = "INSERT INTO team VALUES ('4','4')";
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
    }
}
