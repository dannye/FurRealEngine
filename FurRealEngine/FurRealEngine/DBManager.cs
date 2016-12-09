using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace FurRealEngine
{
    static class DBManager
    {
        static public bool getUser(User u)
        {
            //connection to the database
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\furreal.mdf;Integrated Security=True");

            //query
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [User] WHERE username='" + u.getUsername() + "' AND password = '" + u.getPassword() + "'", connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            if (dt.Rows.Count > 0)
            {
                u.setAdminStatus(dt.Rows[0]["isAdmin"].Equals(1));
                return true;
            }
            return false;
        }

        static public bool updatePassword(User u, string newPass)
        {
            Regex r = new Regex("^[a-zA-Z0-9_]*$");
            if (r.IsMatch(newPass))
            {

                //connection to the database
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\furreal.mdf;Integrated Security=True");
                connection.Open();
                //query
                SqlCommand command = new SqlCommand("UPDATE [User] SET password='" + newPass + "' WHERE username='" + u.getUsername() + "'", connection);

                command.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            return false;
        }

        static public Preset getPreset(User u)
        {
            //connection to the database
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\furreal.mdf;Integrated Security=True");

            //query
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Preset] WHERE [user] IN (SELECT id FROM [User] WHERE username='" + u.getUsername() + "')", connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            if (dt.Rows.Count > 0)
            {
                Preset p = new Preset();
                p.defaultProfessionPreset = (PROFESSION)dt.Rows[0]["profession"];
                p.defaultProfessionLevelPreset = (int)dt.Rows[0]["professionLevel"];
                p.defaultReviveOptionPreset = (HEAL_OPTION)dt.Rows[0]["reviveOpt"];
                p.areCharsPlayablePreset = dt.Rows[0]["playability"].Equals(1);
                p.defaultCdPreset = (int)dt.Rows[0]["challengeDifficulty"];
                p.defaultStartingDifficultyPreset = (DIFFICULTY)dt.Rows[0]["difficulty"];
                p.defaultStartingLevelPreset = (int)dt.Rows[0]["startLevel"];
                p.defaultMaxLevelPreset = (int)dt.Rows[0]["maxLevel"];
                p.defaultRepeatScenarioPreset = (int)dt.Rows[0]["replays"];
                p.defaultEnvironmentPreset = (ENVIRONMENT)dt.Rows[0]["environment"];
                p.numberOfCharacters = (int)dt.Rows[0]["numCharacters"];
                return p;
            }
            return new Preset(0, false, PROFESSION.SOLDIER, 5, HEAL_OPTION.NEVER, 0, DIFFICULTY.NOVICE, 1, 1, ENVIRONMENT.DUNGEON, 1);
        }

        static public void savePreset(User u, Preset p)
        {

        }

        static public List<Report> loadReports(User u)
        {
            //connection to the database
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\furreal.mdf;Integrated Security=True");

            //query
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Report] WHERE [user] IN (SELECT id FROM [User] WHERE username='" + u.getUsername() + "')", connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            List<Report> reports = new List<Report>();

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                Report r = new Report();
                r.setTotalNumOfChars((int)dt.Rows[i]["numCharacters"]);
                r.setTotalNumOfMonsters((int)dt.Rows[i]["numMonsters"]);
                r.setTotalCD((int)dt.Rows[i]["challengeDifficulty"]);
                r.setNumOfCharDefeated((int)dt.Rows[i]["charactersDefeated"]);
                r.setNumOfMonstersDefeated((int)dt.Rows[i]["monstersDefeated"]);
                r.setTotalDamageTaken((int)dt.Rows[i]["damageTaken"]);
                r.setTotalDamageGiven((int)dt.Rows[i]["damageGiven"]);
                r.setNumOfLevelsProgressed((int)dt.Rows[i]["levels"]);
                r.setNumOfTimesSimRan((int)dt.Rows[i]["replays"]);
                r.setSimulationDifficulty((DIFFICULTY)dt.Rows[i]["difficulty"]);
                r.setEnvironmentOfBattle((ENVIRONMENT)dt.Rows[i]["environment"]);
                r.setTreasure((int)dt.Rows[i]["treasure"]);
                reports.Add(r);
            }

            return reports;
        }
        
        static public void saveReport(User u, Report r)
        {

        }
    }
}
