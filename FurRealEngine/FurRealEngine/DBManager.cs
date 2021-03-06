﻿using System;
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
            try
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
            catch
            {
                return false;
            }
        }

        static public bool updatePassword(User u, string newPass)
        {
            try
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
            catch
            {
                return false;
            }
        }

        static public bool updateUsername(User u, string newUname)
        {
            try
            {
                Regex r = new Regex("^[a-zA-Z0-9_]*$");
                if (r.IsMatch(newUname))
                {

                    //connection to the database
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\furreal.mdf;Integrated Security=True");
                    connection.Open();
                    //query
                    SqlCommand command = new SqlCommand("UPDATE [User] SET username='" + newUname + "' WHERE username='" + u.getUsername() + "'", connection);

                    command.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        static public bool updateType(User u, bool admin)
        {
            try
            {

                //connection to the database
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\furreal.mdf;Integrated Security=True");
                connection.Open();
                //query
                SqlCommand command;
                if (admin)
                {
                    command = new SqlCommand("UPDATE [User] SET isAdmin=1 WHERE username='" + u.getUsername() + "'", connection);
                }
                else
                {
                    command = new SqlCommand("UPDATE [User] SET isAdmin=0 WHERE username='" + u.getUsername() + "'", connection);
                }

                command.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public List<User> getUsers()
        {
            try
            {
                //connection to the database
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\furreal.mdf;Integrated Security=True");

                //query
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [User]", connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                connection.Close();

                List<User> users = new List<User>();

                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    string name = (string)dt.Rows[i]["username"];
                    string pass = (string)dt.Rows[i]["password"];
                    bool isAdmin = dt.Rows[i]["isAdmin"].Equals(1);
                    users.Add(new User(name, pass, isAdmin));
                }

                return users;
            }
            catch
            {
                return new List<User>();
            }
		}

        static public Preset getPreset(User u)
        {
            try
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
            catch
            {
                return new Preset(0, false, PROFESSION.SOLDIER, 5, HEAL_OPTION.NEVER, 0, DIFFICULTY.NOVICE, 1, 1, ENVIRONMENT.DUNGEON, 1);
            }
        }

        static public void savePreset(User u, Preset p)
        {
            try
            {
                //connection to the database
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\furreal.mdf;Integrated Security=True");
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [User] WHERE username='" + u.getUsername() + "' AND password = '" + u.getPassword() + "'", connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    int id = (int)dt.Rows[0]["id"];

                    adapter = new SqlDataAdapter("SELECT * FROM [Preset] WHERE [user] IN (SELECT id FROM [User] WHERE username='" + u.getUsername() + "')", connection);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    if (dt.Rows.Count > 0)
                    {
                        command.CommandText = @"UPDATE [Preset] SET profession = @profession, professionLevel = @professionLevel, reviveOpt = @reviveOpt, 
                                            playability = @playability, challengeDifficulty = @challengeDifficulty, difficulty = @difficulty, startLevel = @startLevel, 
                                            maxLevel = @maxLevel, replays = @replays, environment = @environment, numCharacters = @numCharacters 
                                            WHERE [user] = @id";
                    }
                    else
                    {
                        command.CommandText = @"INSERT INTO [Preset] VALUES (@id, @profession, @professionLevel, @reviveOpt, 
                                            @playability, @challengeDifficulty, @difficulty, @startLevel, @maxLevel, 
                                            @replays, @environment, @numCharacters)";
                    }
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@profession", p.defaultProfessionPreset);
                    command.Parameters.AddWithValue("@professionLevel", p.defaultProfessionLevelPreset);
                    command.Parameters.AddWithValue("@reviveOpt", p.defaultReviveOptionPreset);
                    command.Parameters.AddWithValue("@playability", p.areCharsPlayablePreset);
                    command.Parameters.AddWithValue("@challengeDifficulty", p.defaultCdPreset);
                    command.Parameters.AddWithValue("@difficulty", p.defaultStartingDifficultyPreset);
                    command.Parameters.AddWithValue("@startLevel", p.defaultStartingLevelPreset);
                    command.Parameters.AddWithValue("@maxLevel", p.defaultMaxLevelPreset);
                    command.Parameters.AddWithValue("@replays", p.defaultRepeatScenarioPreset);
                    command.Parameters.AddWithValue("@environment", p.defaultEnvironmentPreset);
                    command.Parameters.AddWithValue("@numCharacters", p.numberOfCharacters);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            catch
            {

            }
        }

        static public List<Report> loadReports(User u)
        {
            try
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
                    r.setIndex((int)dt.Rows[i]["index"]);
                    reports.Add(r);
                }

                return reports;
            }
            catch
            {
                return new List<Report>();
            }
        }
        
        static public void saveReport(User u, Report r)
        {
            try
            {
                //connection to the database
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\furreal.mdf;Integrated Security=True");
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [User] WHERE username='" + u.getUsername() + "' AND password = '" + u.getPassword() + "'", connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    int id = (int)dt.Rows[0]["id"];

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO [Report] (levels, replays, difficulty, numCharacters, charactersDefeated, 
                                        environment, numMonsters, monstersDefeated, challengeDifficulty, damageGiven, damageTaken, 
                                        treasure, [user]) VALUES (@levels, @replays, @difficulty, @numCharacters, 
                                        @charactersDefeated, @environment, @numMonsters, @monstersDefeated, @challengeDifficulty, 
                                        @damageGiven, @damageTaken, @treasure, @id)";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@levels", r.getNumOfLevelsProgressed());
                    command.Parameters.AddWithValue("@replays", r.getNumOfTimesSimRan());
                    command.Parameters.AddWithValue("@difficulty", r.getSimulationDifficulty());
                    command.Parameters.AddWithValue("@numCharacters", r.getTotalNumOfChars());
                    command.Parameters.AddWithValue("@charactersDefeated", r.getNumOfCharDefeated());
                    command.Parameters.AddWithValue("@environment", r.getEnvironmentOfBattle());
                    command.Parameters.AddWithValue("@numMonsters", r.getTotalNumOfMonsters());
                    command.Parameters.AddWithValue("@monstersDefeated", r.getNumOfMonstersDefeated());
                    command.Parameters.AddWithValue("@challengeDifficulty", r.getTotalCD());
                    command.Parameters.AddWithValue("@damageGiven", r.getTotalDamageGiven());
                    command.Parameters.AddWithValue("@damageTaken", r.getTotalDamageTaken());
                    command.Parameters.AddWithValue("@treasure", r.getTreasure());
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            catch
            {

            }
        }
    }
}
