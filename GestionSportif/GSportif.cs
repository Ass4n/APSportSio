using BiblioSportif;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GestionSportif
{
    public class GSportif
    {
        // Lit la ligne courante du reader et construit un objet Sportif (sans ses pratiques)
        private static Sportif LireSportif(MySqlDataReader rdr)
        {
            int id = rdr.GetInt32("id");
            string nom = rdr.GetString("nom");
            string prenom = rdr.GetString("prenom");
            DateTime dateNais = rdr.GetDateTime("dateNais");
            string rue = rdr.GetString("rue");
            string codePostal = rdr.GetString("CP");
            string ville = rdr.GetString("ville");

            return new Sportif(id, nom, prenom, dateNais, rue, ville, codePostal);
        }

        

        public static List<Sportif> GetAll()
        {
            List<Sportif> sportifs = new List<Sportif>();
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Sportif ORDER BY nom, prenom", cnx);
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        sportifs.Add(LireSportif(rdr));
                    }
                }
            }

            // Une fois la première lecture terminée, on charge les sports de chaque sportif
            for (int i = 0; i < sportifs.Count; i++)
            {
                sportifs[i].Pratiques = GetPratiques(sportifs[i].Id);
            }
            return sportifs;
        }

        public static Sportif GetById(int id)
        {
            Sportif unSportif = null;
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Sportif WHERE id = @id", cnx);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        unSportif = LireSportif(rdr);
                    }
                }
            }

            if (unSportif != null)
            {
                unSportif.Pratiques = GetPratiques(unSportif.Id);
            }
            return unSportif;
        }

        public static void AjouterSportif(Sportif unSportif)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Sportif (nom, prenom, dateNais, rue, CP, ville) VALUES (@nom, @prenom, @dateNais, @rue, @CP, @ville)", cnx);
                cmd.Parameters.AddWithValue("@nom", unSportif.Nom);
                cmd.Parameters.AddWithValue("@prenom", unSportif.Prenom);
                cmd.Parameters.AddWithValue("@dateNais", unSportif.DateNais);
                cmd.Parameters.AddWithValue("@rue", unSportif.Rue);
                cmd.Parameters.AddWithValue("@CP", unSportif.CodePostal);
                cmd.Parameters.AddWithValue("@ville", unSportif.Ville);
                cmd.ExecuteNonQuery();
            }
        }

        public static void ModifierSportif(Sportif unSportif)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Sportif SET nom = @nom, prenom = @prenom, dateNais = @dateNais, rue = @rue, CP = @CP, ville = @ville WHERE id = @id", cnx);
                cmd.Parameters.AddWithValue("@id", unSportif.Id);
                cmd.Parameters.AddWithValue("@nom", unSportif.Nom);
                cmd.Parameters.AddWithValue("@prenom", unSportif.Prenom);
                cmd.Parameters.AddWithValue("@dateNais", unSportif.DateNais);
                cmd.Parameters.AddWithValue("@rue", unSportif.Rue);
                cmd.Parameters.AddWithValue("@CP", unSportif.CodePostal);
                cmd.Parameters.AddWithValue("@ville", unSportif.Ville);
                cmd.ExecuteNonQuery();
            }
        }

        // Les pratiques du sportif sont supprimées automatiquement 
        public static void SupprimerSportif(int id)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Sportif WHERE id = @id", cnx);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        

        public static List<Sport> GetSports()
        {
            List<Sport> sports = new List<Sport>();
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT id, nom FROM Sports ORDER BY nom", cnx);
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        sports.Add(new Sport(rdr.GetInt32("id"), rdr.GetString("nom")));
                    }
                }
            }
            return sports;
        }

        public static List<Niveau> GetNiveaux()
        {
            List<Niveau> niveaux = new List<Niveau>();
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                // Tri par id : Débutant, Confirmé, Avancé, Professionnel (ordre de saisie)
                MySqlCommand cmd = new MySqlCommand("SELECT id, nom FROM Experience ORDER BY id", cnx);
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        niveaux.Add(new Niveau(rdr.GetInt32("id"), rdr.GetString("nom")));
                    }
                }
            }
            return niveaux;
        }

        

        public static List<Pratique> GetPratiques(int idSportif)
        {
            List<Pratique> pratiques = new List<Pratique>();
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT sp.id AS idSport, sp.nom AS nomSport, ex.id AS idNiveau, ex.nom AS nomNiveau " +
                    "FROM Pratique p " +
                    "JOIN Sports sp ON sp.id = p.idSport " +
                    "JOIN Experience ex ON ex.id = p.idNiveau " +
                    "WHERE p.idSportif = @id " +
                    "ORDER BY sp.nom", cnx);
                cmd.Parameters.AddWithValue("@id", idSportif);
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Sport sport = new Sport(rdr.GetInt32("idSport"), rdr.GetString("nomSport"));
                        Niveau niveau = new Niveau(rdr.GetInt32("idNiveau"), rdr.GetString("nomNiveau"));
                        pratiques.Add(new Pratique(sport, niveau));
                    }
                }
            }
            return pratiques;
        }

        public static void AjouterPratique(int idSportif, int idSport, int idNiveau)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Pratique (idSportif, idSport, idNiveau) VALUES (@idSportif, @idSport, @idNiveau)", cnx);
                cmd.Parameters.AddWithValue("@idSportif", idSportif);
                cmd.Parameters.AddWithValue("@idSport", idSport);
                cmd.Parameters.AddWithValue("@idNiveau", idNiveau);
                cmd.ExecuteNonQuery();   
            }
        }

        public static void ModifierNiveau(int idSportif, int idSport, int idNiveau)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Pratique SET idNiveau = @idNiveau WHERE idSportif = @idSportif AND idSport = @idSport", cnx);
                cmd.Parameters.AddWithValue("@idNiveau", idNiveau);
                cmd.Parameters.AddWithValue("@idSportif", idSportif);
                cmd.Parameters.AddWithValue("@idSport", idSport);
                cmd.ExecuteNonQuery();
            }
        }

        // Ne supprime que la ligne de Pratique : ni le sportif, ni le sport
        public static void SupprimerPratique(int idSportif, int idSport)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Pratique WHERE idSportif = @idSportif AND idSport = @idSport", cnx);
                cmd.Parameters.AddWithValue("@idSportif", idSportif);
                cmd.Parameters.AddWithValue("@idSport", idSport);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
