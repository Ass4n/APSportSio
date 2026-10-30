using GestionSportif;
using System;
using System.Windows.Forms;

namespace APProjetSport
{
    public partial class FormConnexion : Form
    {
        private string login;

        public string Login { get => login; private set => login = value; }

        public FormConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                if (GUtilisateur.Connecter(txtLogin.Text.Trim(), txtMdp.Text))
                {
                    Login = txtLogin.Text.Trim();
                    DialogResult = DialogResult.OK;   // ferme le formulaire
                }
                else
                {
                    MessageBox.Show("Login ou mot de passe incorrect.", "Connexion",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            using (FormConnexionCompte f = new FormConnexionCompte())
            {
                f.ShowDialog();
            }
        }
    }
}
