using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace libsql
{
    public class MySQL
    {
        private string host = "s1.clanweb.hu";
        private string user = "ztajti";
        private string pass = "Kyocera13";
        private string db = "Bartel";
        private MySqlConnection conn;

        public bool open()
        {
            string cs = "SERVER=" + host + ";" + "DATABASE=" + db + ";" + "UID=" + user + ";" + "PASSWORD=" + pass + ";";
            conn = new MySqlConnection(cs);
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        //log.make("mysqlError", "Cannot connect to server.  Contact administrator");
                        MessageBox.Show("MySQL Not found!");
                        break;
                    case 1045:
                        //log.make("mysqlError", "Invalid mysql username/password, please try again");
                        MessageBox.Show("Invalid SQL Credentials!");
                        break;
                };
                return false;
            }
        }
        public bool close()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //log.make("mysqlError", ex.Message);
                return false;
            };
        }
        public int count(string table, string mit = "*", string cond = "")
        {
            string q = "SELECT COUNT(" + mit + ") FROM `" + table + "` " + cond;
            if (this.open() == true)
            {
                using (var cmd = new MySqlCommand(q, conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count;
                }
            }
            else return 0;
        }

        public string[] get(string table, string mit = "*", string cond = "")
        {
            string[] ret = new String[99];
            string q = "SELECT " + mit + " FROM `" + table + "` " + cond;
            if (this.open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(q, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    var count = reader.FieldCount;
                    while (reader.Read())
                    {
                        for (var i = 0; i < count; i++)
                        {
                            ret[i] = reader.GetValue(i).ToString();
                        };
                    };
                };
                this.close();
            };
            return ret;
        }

        public void insert(string table, string values)
        {
            string q = "INSERT INTO `" + table + "` SET " + values;
            if (this.open() == true)
            {
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = q;
                comm.ExecuteNonQuery();
                this.close();
            }
        }
        public void update(string table, string values, string cond)
        {
            string q = "UPDATE `" + table + "` SET " + values + " " + cond;
            if (this.open() == true)
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                this.close();
            }
        }
        public void delete(string table, string cond)
        {
            string q = "DELETE FROM `" + table + "` " + cond;
            if (this.open() == true)
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                this.close();
            }
        }

        public List<string> getList(string table, string mit = "*", string cond = "")
        {
            List<string> ret = new List<string>();
            string q = "SELECT " + mit + " FROM `" + table + "` " + cond;
            if (this.open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(q, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    var count = reader.FieldCount;
                    while (reader.Read())
                    {
                        string jarat = reader.GetString("planeID");
                        string ind = reader.GetString("ind");
                        string erk = reader.GetString("erk");
                        string tipus = reader.GetString("tipus");
                        string pax = reader.GetString("pax");
                        string cargo = reader.GetString("cargo");
                        string row = jarat + ";" + ind + ";" + erk + ";" + tipus + ";" + pax + ";" + cargo;
                        ret.Add(row);
                    }
                }
            }
            return ret;
        }
    }
}
