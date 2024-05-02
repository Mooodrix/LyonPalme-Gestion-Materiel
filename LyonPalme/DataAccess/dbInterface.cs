using System;
using System.Collections.Generic;
using LyonPalme.classe;
using System.Data;
using System.Data.SqlClient;
using LyonPalme.Model;
using CreditSio.Tools;
using System.IO;
using LyonPalme.form;
using System.Windows.Forms;


namespace CreditSio.DataAccess
{
    /// <summary>
    /// Gère l'interface entre la base de données et la couche présentation.
    /// </summary>
    public class DBInterface
    {
        public static List<ListMaterielModel> GetMateriel()
        {
            //La liste créée est une liste de Compte (et non de CompteCourant ou de CompteEpargne)
            List<ListMaterielModel> materiels = new List<ListMaterielModel>();
            SqlConnection connection = null;
            //SqlDataReader sqlDataReader = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("MaterielRecup", connection)) //appel de la procédure materielrecup
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                              ListMaterielModel mat = new ListMaterielModel();
                            mat.setmaterielId(sqlDataReader.GetString(0));
                            mat.setmaterielMarque (sqlDataReader.GetString(1));
                            mat.setmaterielLibelle(sqlDataReader.GetString(2));
                            mat.setmaterielEtat(sqlDataReader.GetString(3));
                            if(sqlDataReader.IsDBNull(4) && sqlDataReader.IsDBNull(5))
                            {
                                //on fait rien
                            }
                            else if(sqlDataReader.IsDBNull(5))
                            {
                                mat.setmaterielPointure(sqlDataReader.GetInt32(4));
                            }
                            else
                            {
                                mat.setmaterielTaille(sqlDataReader.GetString(5));
                            }
                            materiels.Add(mat);
                        }
                    }

                }

            }
            catch (InvalidOperationException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("DBInterface : erreur SQL", w);
                }

            }
            finally
            {
                connection.Close();
            }
            return materiels;
        }

        public static List<ListMaterielModel> GetMaterielDisponible()
        {
            //La liste créée est une liste de Compte (et non de CompteCourant ou de CompteEpargne)
            List<ListMaterielModel> materiels = new List<ListMaterielModel>();
            SqlConnection connection = null;
            //SqlDataReader sqlDataReader = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("GetMaterielDisponible", connection)) //appel de la procédure materielrecup
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            ListMaterielModel mat = new ListMaterielModel();
                            mat.setmaterielId(sqlDataReader.GetString(0));
                            mat.setmaterielMarque(sqlDataReader.GetString(1));
                            mat.setmaterielLibelle(sqlDataReader.GetString(2));
                            mat.setmaterielEtat(sqlDataReader.GetString(3));
                            if (sqlDataReader.IsDBNull(4) && sqlDataReader.IsDBNull(5))
                            {
                                //on fait rien
                            }
                            else if (sqlDataReader.IsDBNull(5))
                            {
                                mat.setmaterielPointure(sqlDataReader.GetInt32(4));
                            }
                            else
                            {
                                mat.setmaterielTaille(sqlDataReader.GetString(5));
                            }
                            materiels.Add(mat);
                        }
                    }

                }

            }
            catch (InvalidOperationException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("DBInterface : erreur SQL", w);
                }

            }
            finally
            {
                connection.Close();
            }
            return materiels;
        }


        public static List<ListPretModel> GetPret()
        {
            //La liste créée est une liste de Compte (et non de CompteCourant ou de CompteEpargne)
            List<ListPretModel> prets = new List<ListPretModel>();
            SqlConnection connection = null;
            //SqlDataReader sqlDataReader = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("LYONPALME_pGetPrets", connection)) //appel de la procédure pretrecup
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            ListPretModel mat = new ListPretModel();
                            mat.setempId(sqlDataReader.GetString(0));

                            // Vérifier si la colonne EMP_Date n'est pas NULL avant de récupérer sa valeur
                            if (!sqlDataReader.IsDBNull(1))
                            {
                                mat.setempDate(sqlDataReader.GetDateTime(1));
                            }
                            else
                            {
                                // Si la colonne EMP_Date est NULL, affectez une valeur par défaut à mat.setempDate ou laissez-la vide selon votre logique.
                                // Exemple :
                                // mat.setempDate(DateTime.MinValue); // Valeur par défaut minimale pour DateTime
                                // mat.setempDate(null); // Laisser vide
                            }

                            // Faire de même pour EMP_DateRetour
                            if (!sqlDataReader.IsDBNull(2))
                            {
                                mat.setdateRetour(sqlDataReader.GetDateTime(2));
                            }
                            else
                            {
                                // Si la colonne EMP_DateRetour est NULL, affectez une valeur par défaut ou laissez-la vide
                            }


                            /*mat.setempDate(sqlDataReader.GetDateTime(1));
                            mat.setdateRetour(sqlDataReader.GetDateTime(2));*/
                            mat.setadhId(sqlDataReader.GetInt32(3));
                            mat.setmatId(sqlDataReader.GetString(4));

                            prets.Add(mat);
                        }
                    }

                }

            }
            catch (InvalidOperationException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("DBInterface : erreur SQL", w);
                }

            }
            finally
            {
                connection.Close();
            }
            return prets;
        }



        public static List<ListAdherentModel> GetAdherents()
        {
            List<ListAdherentModel> adherents = new List<ListAdherentModel>();
            SqlConnection connection = null;

            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("LYONPALME_pGetAdherent", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            ListAdherentModel adherent = new ListAdherentModel();
                            adherent.setadhId(sqlDataReader.GetInt32(0));
                            adherent.setadhNom(sqlDataReader.GetString(1));
                            adherent.setadhPrenom(sqlDataReader.GetString(2));
                            adherent.setadhMobile(sqlDataReader.GetString(3));
                            adherent.setadhMail(sqlDataReader.GetString(4));

                            adherents.Add(adherent);
                        }
                    }
                }
            }
            catch (InvalidOperationException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("DBInterface : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }

            return adherents;
        }


        public static void InsertMateriel(string matId, string marque, string libelle, string etat, int? pointure, string taille)
        {
            SqlConnection connection = null;

            try
            {
                connection = Connection.getInstance().GetConnection();

                // Appel de la procédure stockée InsertMaterielAll
                using (SqlCommand command = new SqlCommand("InsertMaterielAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Ajouter les paramètres
                    command.Parameters.AddWithValue("@MAT_Id", matId);
                    command.Parameters.AddWithValue("@MARQUE", marque);
                    command.Parameters.AddWithValue("@LIBELLE", libelle);
                    command.Parameters.AddWithValue("@ETAT", etat);
                    command.Parameters.AddWithValue("@POINTURE", pointure ?? (object)DBNull.Value); // Si pointure est null, passe DBNull.Value
                    command.Parameters.AddWithValue("@TAILLE", taille ?? (object)DBNull.Value); // Si taille est null, passe DBNull.Value

                    // Exécuter la commande
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Gérer l'exception
                Console.WriteLine("Une erreur s'est produite lors de l'insertion du matériel : " + ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public static void DeleteEmprunt(string empruntID)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("DeleteEmprunt", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@EmpruntID", empruntID);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (InvalidOperationException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("DBInterface : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
        }



        public static string AddEmprunt(string empId, string matId, DateTime empDate, DateTime empDateRetour, int adhId)
        {
            SqlConnection connection = null;
            string message = "";

            try
            {
                connection = Connection.getInstance().GetConnection();

               
                using (SqlCommand command = new SqlCommand("AddEmprunt", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

              
                    command.Parameters.AddWithValue("@EMP_Id", empId);
                    command.Parameters.AddWithValue("@MAT_Id", matId);
                    command.Parameters.AddWithValue("@EMP_Date", SqlDbType.Date).Value = empDate;
                    command.Parameters.AddWithValue("@EMP_DateRetour", SqlDbType.Date).Value = empDateRetour;
                    command.Parameters.AddWithValue("@ADH_Id", adhId);

                    SqlParameter messageParam = new SqlParameter("@Message", SqlDbType.VarChar, 100);
                    messageParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(messageParam);

                    // Exécuter la commande
                    command.ExecuteNonQuery();

                    // Récupérer le message retourné par la procédure stockée
                    message = messageParam.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                // Gérer l'exception
                Console.WriteLine("Une erreur s'est produite lors de l'ajout de l'emprunt : " + ex.Message);
                message = "Une erreur s'est produite lors de l'ajout de l'emprunt.";
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return message;
        }


    }
}

