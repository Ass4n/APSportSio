using GestionSportif;
using System;
using System.Windows.Forms;

namespace APProjetSport
{
    public partial class FormChangementMdp : Form
    {
        // Login de l'utilisateur actuellement connecté
        private string login;

        public FormChangementMdp(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string erreurs = "";

            if (txtAncien.Text == "")
            {
                erreurs += "- Veuillez saisir votre ancien mot de passe.\n";
            }
            if (txtNouveau.Text.Length < 6)
            {
                erreurs += "- Le nouveau mot de passe doit contenir au moins 6 caractères.\n";
            }
            if (txtNouveau.Text != txtConfirmation.Text)
            {
                erreurs += "- La confirmation ne correspond pas au nouveau mot de passe.\n";
            }

            if (erreurs != "")
            {
                MessageBox.Show("Veuillez corriger les erreurs suivantes :\n\n" + erreurs,
                                "Changement de mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (GUtilisateur.ChangerMotDePasse(login, txtAncien.Text, txtNouveau.Text))
                {
                    MessageBox.Show("Votre mot de passe a bien été modifié.",
                                    "Changement de mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("L'ancien mot de passe est incorrect.",
                                    "Changement de mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
