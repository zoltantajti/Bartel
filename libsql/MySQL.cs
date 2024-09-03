using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Windows.Forms;

namespace libsql
{
    public class MySQL
    {
        private string host = "**censored**";
        private string user = "**censored**";
        private string pass = "**censored**";
        private string db = "**censored**";
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

        public string[] getNapiTetelEladas(string bolt)
        {
            string[] ret = new String[2];
            string q = "SELECT SUM(ar) as napi, COUNT(id) as db FROM tetel_eladas WHERE bolt='"+bolt+"' AND nap = CURRENT_DATE";
            if (this.open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(q, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ret[0] = reader.GetValue(0).ToString();
                        ret[1] = reader.GetValue(1).ToString();
                    }
                };
            };
            return ret;
        }

        public string[] getNapiTelefonVetel(string bolt)
        {
            string[] ret = new String[2];
            string q = "SELECT COUNT(id) as tetel_db, SUM(beszerzesi_ar) as napi_forg FROM telefonok WHERE bolt='"+bolt+"' AND nap = CURRENT_DATE";
            if (this.open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(q, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ret[0] = reader.GetValue(0).ToString();
                        ret[1] = reader.GetValue(1).ToString();
                    }
                };
            };
            return ret;
        }
        public string[] getNapiTelefonElad(string bolt)
        {
            string[] ret = new String[2];
            string q = "SELECT COUNT(id) as tetel_db, SUM(teny_eladasi_ar) as napi_forg FROM telefonok WHERE eladva = 1 AND bolt='" + bolt + "' AND eladas_datum = CURRENT_DATE";
            if (this.open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(q, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ret[0] = reader.GetValue(0).ToString();
                        ret[1] = reader.GetValue(1).ToString();
                    }
                };
            };
            return ret;
        }
        public string[] getNapiSzerviz(string bolt)
        {
            string[] ret = new String[2];
            string q = "SELECT COUNT(id) as tetel_db, SUM(ar) as napi_forg FROM szerviz WHERE status = 'Fizetve' AND bolt='"+bolt+"' AND vissza_nap = CURRENT_DATE";
            if (this.open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(q, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ret[0] = reader.GetValue(0).ToString();
                        ret[1] = reader.GetValue(1).ToString();
                    }
                };
            };
            return ret;
        }
        public string[] getNapiKPKI(string bolt)
        {
            string[] ret = new String[2];
            string q = "SELECT COUNT(id) as tetel_db, SUM(mennyi) as napi_forg FROM kpki WHERE bolt='"+bolt+"' AND nap = CURRENT_DATE";
            if (this.open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(q, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ret[0] = reader.GetValue(0).ToString();
                        ret[1] = reader.GetValue(1).ToString();
                    }
                };
            };
            return ret;
        }

        public DataTable getDT(string table, string mit = "*", string cond = "")
        {
            DataTable ret = new DataTable();
            string q = "SELECT " + mit + " FROM `" + table + "` " + cond;
            if (this.open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ret);
            };
            return ret;
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
                        string tipus = reader.GetString("tipus");
                        string terv_elad = reader.GetString("terv_eladasi_ar");
                        string row = tipus + " - " + terv_elad;
                        ret.Add(row);
                    }
                }
            }
            return ret;
        }
        public List<string> getRanks(string table, string mit = "*", string cond = "")
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
                        string id = reader.GetString("id");
                        string nev = reader.GetString("nev");
                        string row = id + " - " + nev;
                        ret.Add(row);
                    }
                }
            }
            return ret;
        }
        public List<string> getEladToList(string table, string mit = "*", string cond = "")
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
                        string tetel = reader.GetString("tetel");
                        string ar = reader.GetString("ar");
                        string row = tetel + ";" + ar;
                        ret.Add(row);
                    }
                }
            }
            return ret;
        }
        public List<string> getTelVetelToList(string table, string mit = "*", string cond = "")
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
                        string tetel = reader.GetString("tipus");
                        string ar = reader.GetString("beszerzesi_ar");
                        string row = tetel + ";" + ar;
                        ret.Add(row);
                    }
                }
            }
            return ret;
        }
        public List<string> getTelEladToList(string table, string mit = "*", string cond = "")
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
                        string tetel = reader.GetString("tipus");
                        string ar = reader.GetString("teny_elad_ar");
                        string row = tetel + ";" + ar;
                        ret.Add(row);
                    }
                }
            }
            return ret;
        }
        public List<string> getSzervizToList(string table, string mit = "*", string cond = "")
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
                        string tetel = reader.GetString("tipus");
                        string ar = reader.GetString("ar");
                        string row = tetel + ";" + ar;
                        ret.Add(row);
                    }
                }
            }
            return ret;
        }
        public List<string> getKPKIToList(string table, string mit = "*", string cond = "")
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
                        string tetel = reader.GetString("ki");
                        string ar = reader.GetString("mennyi");
                        string row = tetel + ";" + ar;
                        ret.Add(row);
                    }
                }
            }
            return ret;
        }
    }
}
