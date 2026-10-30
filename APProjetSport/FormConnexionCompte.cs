using GestionSportif;
using System;
using System.Windows.Forms;

namespace APProjetSport
{
    public partial class FormConnexionCompte : Form
    {
        public FormConnexionCompte()
        {
            InitializeComponent();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string erreurs = "";

            if (login.Length < 3)
            {
                erreurs += "- Le login doit contenir au moins 3 caractères.\n";
            }
            if (txtMdp.Text.Length < 6)
            {
                erreurs += "- Le mot de passe doit contenir au moins 6 caractères.\n";
            }
            if (txtMdp.Text != txtConfirmation.Text)
            {
                erreurs += "- Les deux mots de passe sont différents.\n";
            }

            try
            {
                // On ne vérifie le login en base que si le reste est correct
                if (erreurs == "" && GUtilisateur.LoginExiste(login))
                {
                    erreurs += "- Ce login est déjà utilisé.\n";
                }

                if (erreurs != "")
                {
                    MessageBox.Show("Veuillez corriger les erreurs suivantes :\n\n" + erreurs,
                                    "Création de compte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GUtilisateur.CreerUtilisateur(login, txtMdp.Text);
                MessageBox.Show("Le compte a bien été créé, vous pouvez vous connecter.",
                                "Création de compte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
