using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSportif
{
    public class GUtilisateur
    {
        public static bool Connecter(string login, string mdp)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM Utilisateur WHERE login = @login AND mdp = SHA2(@mdp, 256)", cnx);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@mdp", mdp);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // Vrai si le login est déjà pris
        public static bool LoginExiste(string login)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Utilisateur WHERE login = @login", cnx);
                cmd.Parameters.AddWithValue("@login", login);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public static void CreerUtilisateur(string login, string mdp)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO Utilisateur (login, mdp) VALUES (@login, SHA2(@mdp, 256))", cnx);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@mdp", mdp);
                cmd.ExecuteNonQuery();
            }
        }

        // Vrai si le changement a eu lieu (ancien mot de passe correct)
        public static bool ChangerMotDePasse(string login, string ancienMdp, string nouveauMdp)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE Utilisateur SET mdp = SHA2(@nouveau, 256) WHERE login = @login AND mdp = SHA2(@ancien, 256)", cnx);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@ancien", ancienMdp);
                cmd.Parameters.AddWithValue("@nouveau", nouveauMdp);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
    

