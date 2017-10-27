using System;
using System.Collections.Generic;
using System.Linq;
using Nelibur.ObjectMapper;
using Dapper;
using MySql.Data.MySqlClient;
using FluentValidation;
using FluentValidation.Results;

namespace DaltehyonXUnity
{
    public class PartyDao
    {
        private DBManager manager;

        public PartyDao()
        {
            this.manager = DBManager.getInstance();
        }

        public Message SelectAll()
        {
            string query = "SELECT * from party";

            return ExecuteQuery(query, null);
        }

        public Message SelectByHostName(string HostName)
        {
            string query = "SELECT * from party WHERE PseudoHost = @PseudoHost";

            return ExecuteQuery(query, new { PseudoHost = HostName });
        }

        public Message Insert(Party party)
        {
            List<Party> parties = new List<Party> { party };

            return Insert(parties);
        }

        public Message Insert(List<Party> parties)
        {
            string query = "INSERT INTO `party`(`PseudoHost`, `MdP`) VALUES (@PseudoHost, @MdP)";

            foreach (var party in parties)
            {
                party.MotDePasse = BCrypt.Net.BCrypt.HashPassword(party.MotDePasse);
            }

            return ExecuteMultipleQueries(query, parties);
        }

        private Message ExecuteMultipleQueries(string query, List<Party> parties)
        {
            List<Party> dtos = new List<Party>();

            foreach (var party in parties)
            {
                dtos.Add(TinyMapper.Map<Party>(party));
            }

            return ExecuteNonQuery(query, dtos);
        }

        private Message ExecuteNonQuery(string query, object param)
        {
            MySqlConnection connection = manager.GetConnection();

            Message message = new Message();

            try
            {
                connection.Execute(query, param);
                message.Success = true;
            }
            catch (Exception e)
            {
                message.Success = false;
                message.Data = e.Message;
            }

            return message;
        }

        private Message ExecuteQuery(string query, object param)
        {
            MySqlConnection connection = manager.GetConnection();

            Message message = new Message();

            try
            {
                var dto = connection.Query<Party>(query, param);

                List<Party> parties = new List<Party>();

                foreach (var party in dto)
                {
                    parties.Add(TinyMapper.Map<Party>(party));
                }

                message.Success = true;
                message.Data = parties;
            }
            catch (Exception e)
            {
                message.Success = false;
                message.Data = e.Message;
            }

            return message;
        }
    }
}
