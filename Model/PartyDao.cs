using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DaltehyonXUnity
{
    public class PartyDao
    {
        private DBManager manager;
        private static PartyDao instance;
        private MySqlCommand cmd;

        public static PartyDao getInstance()
        {
            if(instance != null)
            {
                return instance;
            }
            else
            {
                return instance = new PartyDao();
            }
        }

        public PartyDao()
        {
            this.manager = DBManager.getInstance();
        }

        public List<Party> SelectAll()
        {
            string query = "SELECT * from party";

            cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Prepare();

            return ExecuteQuery(query, cmd);
        }

        public List<Party> SelectByHostName(string HostName)
        {
            string query = "SELECT * from party WHERE PseudoHost = @PseudoHost";

            cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@PseudoHost", HostName);

            return ExecuteQuery(query, cmd);
        }

        public List<Party> SelectById(int id)
        {
            string query = "SELECT * from party WHERE IdParty = @IdParty";

            cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@IdParty", id);

            return ExecuteQuery(query, cmd);
        }

        public int Insert(Party party)
        {
            string query = "INSERT INTO `party`(`PseudoHost`, `MdP`) VALUES (@PseudoHost, @MdP)";

            cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@PseudoHost", party.PseudoHost);
            byte[] data = System.Text.Encoding.ASCII.GetBytes(party.MdP);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            cmd.Parameters.AddWithValue("@MdP", hash);

            return ExecuteNonQuery(query, cmd);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM `party` WHERE `IdParty`=@Id";

            cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Id", id);

            ExecuteNonQuery(query, cmd);
        }

        private int ExecuteNonQuery(string query, MySqlCommand cmd)
        {
            MySqlConnection connection = manager.GetConnection();
            connection.Open();
            cmd.Connection = connection;

            try
            {
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("SELECT LAST_INSERT_ID();", connection);
                object ores = cmd.ExecuteScalar();

                if (ores != null)
                {
                    // Odd, I got ulong here.
                    ulong qkwl = (ulong)ores;
                    int Id = (int)qkwl;
                    return Id;
                }
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("erreur : " + e.Message);
                return 0;
            }
        }

        private List<Party> ExecuteQuery(string query, MySqlCommand cmd)
        {
            MySqlDataReader rdr = null;
            MySqlConnection connection = manager.GetConnection();
            connection.Open();
            cmd.Connection = connection;


            try
            {
                rdr = cmd.ExecuteReader();

                List<Party> parties = new List<Party>();

                while (rdr.Read())
                {
                    Party party = new Party();
                    party.IdParty = rdr.GetInt32(0);
                    party.PseudoHost = rdr.GetString(1);
                    party.PseudoPlayerTwo = rdr.GetString(2);
                    party.MdP = rdr.GetString(3);
                    parties.Add(party);
                }
                
                foreach (Party party in parties)
                {
                    if(party.MdP == null || party.MdP == "")
                    {
                        party.MdP = "Non";
                    }
                    else
                    {
                        party.MdP = "Oui";
                    }
                    parties.Add(party);
                }

                return parties;
            }
            catch (Exception e)
            {
                Console.WriteLine("erreur : " + e.Message);
                return null;
            }
        }
    }
}
