﻿using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using CreditSio.Tools;

namespace CreditSio.DataAccess
{
    /// <summary>
    /// Auteur : B. Chataing.
    /// Date de création : 8/12/2022.
    /// Date de modification : 26/12/2022.
    /// Gère la connexion à la base de données, par un singleton (une seule instance d'une classe).
    /// </summary>
    public class Connection
    {
        /// <summary>
        /// Instance SqlConnection : persiste la connexion au serveur.
        /// </summary>
        private static SqlConnection sqlConnection;

        /// <summary>
        /// Singleton : instance unique de la classe Connexion.
        /// </summary>
        private static Connection instance;

        /// <summary>
        /// Constructeur privé, pour créer le singleton.
        /// </summary>
        private Connection() { }

        /// <summary>
        /// Connexion à SQL Server.
        /// </summary>
        /// <returns>Un SqlConnection non null si connexion réussie.</returns>
        public SqlConnection GetConnection()
        {
            string connectionString;
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["sqlserver_creditsio"].ConnectionString;
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return sqlConnection;

            }
            catch (SqlException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("Connection : erreur de connexion au serveur", w);
                }
            }
            return sqlConnection;
        }

        /// <summary>
        /// Crée le singleton s'il n'existe pas.
        /// </summary>
        /// <returns>L'instance de Connection</returns>
        public static Connection getInstance()
        {
            if (Connection.instance == null)
                Connection.instance = new Connection();
            return Connection.instance;
        }
    }
}