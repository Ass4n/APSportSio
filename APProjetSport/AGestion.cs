using BiblioSportif;
using GestionSportif;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace APProjetSport
{
    public partial class AGestion : Form
    {
        // Liste de tous les sportifs lus dans la base (avec leurs pratiques)
        private List<Sportif> tousLesSportifs = new List<Sportif>();

        // Sportif actuellement sélectionné dans l'onglet "Gestion" (null si aucun)
        private Sportif sportifSelectionne = null;

        // Login de l'utilisateur connecté
        private string loginConnecte;

        public AGestion()
        {
            InitializeComponent();
        }

        public AGestion(string login)
        {
            InitializeComponent();
            loginConnecte = login;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mise en forme des ListView
            ConfigurerListView(listResultat);
            ConfigurerListView(listGestion);
            ConfigurerListPratiques();

            CbListeDeroulante.SelectedIndex = 0;   // "Ville" par défaut

            // Les listes déroulantes sont maintenant remplies depuis la base
            try
            {
                List<Sport> sports = GSportif.GetSports();
                for (int i = 0; i < sports.Count; i++)
                {
                    cbSport.Items.Add(sports[i]);
                }

                List<Niveau> niveaux = GSportif.GetNiveaux();
                for (int i = 0; i < niveaux.Count; i++)
                {
                    cbNiveau.Items.Add(niveaux[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la lecture des sports et des niveaux :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // La date de naissance ne peut pas être dans le futur
            dtpDateNais.MinDate = new DateTime(1900, 1, 1);
            dtpDateNais.MaxDate = DateTime.Today;

            ChargerSportifs();
            AfficherPratiques();
        }

        // Crée les colonnes d'une ListView de sportifs
        private void ConfigurerListView(ListView liste)
        {
            liste.View = View.Details;
            liste.FullRowSelect = true;
            liste.GridLines = true;
            liste.MultiSelect = false;

            liste.Columns.Clear();
            liste.Columns.Add("Nom", 90);
            liste.Columns.Add("Prénom", 90);
            liste.Columns.Add("Date de naissance", 100);
            liste.Columns.Add("Rue", 130);
            liste.Columns.Add("Code Postal", 70);
            liste.Columns.Add("Ville", 100);
            liste.Columns.Add("Sports pratiqués", 270);
        }

        // Crée les colonnes de la liste des sports pratiqués
        private void ConfigurerListPratiques()
        {
            listPratiques.View = View.Details;
            listPratiques.FullRowSelect = true;
            listPratiques.GridLines = true;
            listPratiques.MultiSelect = false;

            listPratiques.Columns.Clear();
            listPratiques.Columns.Add("Sport", 200);
            listPratiques.Columns.Add("Niveau", 170);
        }

        // Relit la base de données et rafraîchit les deux onglets
        private void ChargerSportifs()
        {
            try
            {
                tousLesSportifs = GSportif.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la lecture de la base de données :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AfficherResultats(listGestion, tousLesSportifs);
            Rechercher();   // réapplique la recherche en cours dans l'onglet Consultation
        }

        // Remplit une ListView avec une liste de sportifs
        // Le sportif est mémorisé dans item.Tag pour le retrouver facilement à la sélection
        private void AfficherResultats(ListView liste, List<Sportif> sportifs)
        {
            liste.Items.Clear();
            for (int i = 0; i < sportifs.Count; i++)
            {
                Sportif sportif = sportifs[i];

                ListViewItem item = new ListViewItem(sportif.Nom);
                item.SubItems.Add(sportif.Prenom);
                item.SubItems.Add(sportif.DateNais.ToShortDateString());
                item.SubItems.Add(sportif.Rue);
                item.SubItems.Add(sportif.CodePostal);
                item.SubItems.Add(sportif.Ville);
                item.SubItems.Add(sportif.ResumeSports());

                item.Tag = sportif;

                liste.Items.Add(item);
            }
        }

        

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            Rechercher();
        }

        // Filtre la liste selon le critère choisi et la valeur saisie
        private void Rechercher()
        {
            string motRecherche = textZoneRecherchee.Text.Trim().ToLower();

            // Si le champ est vide, on affiche tous les sportifs
            if (motRecherche == "")
            {
                AfficherResultats(listResultat, tousLesSportifs);
                return;
            }

            List<Sportif> resultats = new List<Sportif>();

            for (int i = 0; i < tousLesSportifs.Count; i++)
            {
                Sportif sportif = tousLesSportifs[i];
                bool correspond = false;

                switch (CbListeDeroulante.SelectedIndex)
                {
                    case 0:     // Ville
                        correspond = sportif.Ville.ToLower().Contains(motRecherche);
                        break;
                    case 1:     // Niveau d'expérience : au moins une pratique avec ce niveau
                        for (int j = 0; j < sportif.Pratiques.Count; j++)
                        {
                            if (sportif.Pratiques[j].Niveau.Nom.ToLower().Contains(motRecherche))
                            {
                                correspond = true;
                            }
                        }
                        break;
                    case 2:     // Nom du sport : au moins une pratique de ce sport
                        for (int j = 0; j < sportif.Pratiques.Count; j++)
                        {
                            if (sportif.Pratiques[j].Sport.Nom.ToLower().Contains(motRecherche))
                            {
                                correspond = true;
                            }
                        }
                        break;
                }

                if (correspond)
                {
                    resultats.Add(sportif);
                }
            }

            AfficherResultats(listResultat, resultats);
        }

        // Affiche le détail du sportif sélectionné : informations + tous ses sports et niveaux
        private void listResultat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listResultat.SelectedItems.Count > 0)
            {
                Sportif sportif = (Sportif)listResultat.SelectedItems[0].Tag;

                string message = $"Informations du sportif :\n\n" +
                                 $"Nom : {sportif.Nom}\n" +
                                 $"Prénom : {sportif.Prenom}\n" +
                                 $"Date de naissance : {sportif.DateNais.ToShortDateString()}\n" +
                                 $"Rue : {sportif.Rue}\n" +
                                 $"Ville : {sportif.Ville}\n" +
                                 $"Code postal : {sportif.CodePostal}\n\n" +
                                 $"Sports pratiqués :\n";

                if (sportif.Pratiques.Count == 0)
                {
                    message += "  (aucun sport enregistré)";
                }
                for (int i = 0; i < sportif.Pratiques.Count; i++)
                {
                    message += "  - " + sportif.Pratiques[i].Sport.Nom + " : " + sportif.Pratiques[i].Niveau.Nom + "\n";
                }

                MessageBox.Show(message, "Détails du sportif");
            }
        }

       

        // Quand on sélectionne un sportif, ses informations remplissent le formulaire
        private void listGestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGestion.SelectedItems.Count > 0)
            {
                sportifSelectionne = (Sportif)listGestion.SelectedItems[0].Tag;

                txtNom.Text = sportifSelectionne.Nom;
                txtPrenom.Text = sportifSelectionne.Prenom;
                dtpDateNais.Value = sportifSelectionne.DateNais;
                txtRue.Text = sportifSelectionne.Rue;
                txtCP.Text = sportifSelectionne.CodePostal;
                txtVille.Text = sportifSelectionne.Ville;

                cbSport.SelectedIndex = -1;
                cbNiveau.SelectedIndex = -1;
                AfficherPratiques();
            }
        }

        // Vide tous les champs du formulaire
        private void ViderFormulaire()
        {
            sportifSelectionne = null;
            listGestion.SelectedItems.Clear();

            txtNom.Text = "";
            txtPrenom.Text = "";
            dtpDateNais.Value = DateTime.Today;
            txtRue.Text = "";
            txtCP.Text = "";
            txtVille.Text = "";
            cbNiveau.SelectedIndex = -1;
            cbSport.SelectedIndex = -1;
            AfficherPratiques();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            ViderFormulaire();
        }

        // Contrôle des données saisies : retourne true si tout est correct
        private bool ControlerSaisie()
        {
            string erreurs = "";

            if (txtNom.Text.Trim() == "")
            {
                erreurs += "- Le nom est obligatoire.\n";
            }
            if (txtPrenom.Text.Trim() == "")
            {
                erreurs += "- Le prénom est obligatoire.\n";
            }
            if (dtpDateNais.Value.Date >= DateTime.Today)
            {
                erreurs += "- La date de naissance doit être antérieure à aujourd'hui.\n";
            }
            if (txtRue.Text.Trim() == "")
            {
                erreurs += "- La rue est obligatoire.\n";
            }
            // Un code postal français = exactement 5 chiffres
            if (!Regex.IsMatch(txtCP.Text.Trim(), @"^\d{5}$"))
            {
                erreurs += "- Le code postal doit contenir exactement 5 chiffres.\n";
            }
            if (txtVille.Text.Trim() == "")
            {
                erreurs += "- La ville est obligatoire.\n";
            }

            if (erreurs != "")
            {
                MessageBox.Show("Veuillez corriger les erreurs suivantes :\n\n" + erreurs,
                                "Saisie incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

       
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ControlerSaisie())
            {
                return;
            }

            // L'id vaut 0 : il sera généré par la base (auto_increment)
            Sportif nouveau = new Sportif(0,
                                          txtNom.Text.Trim(),
                                          txtPrenom.Text.Trim(),
                                          dtpDateNais.Value.Date,
                                          txtRue.Text.Trim(),
                                          txtVille.Text.Trim(),
                                          txtCP.Text.Trim());
            try
            {
                GSportif.AjouterSportif(nouveau);
                MessageBox.Show("Le sportif a bien été ajouté.\nSélectionnez-le dans la liste pour lui associer des sports.",
                                "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViderFormulaire();
                ChargerSportifs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (sportifSelectionne == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un sportif dans la liste.",
                                "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!ControlerSaisie())
            {
                return;
            }

            // On met à jour l'objet sélectionné avec les nouvelles valeurs (son id ne change pas)
            sportifSelectionne.Nom = txtNom.Text.Trim();
            sportifSelectionne.Prenom = txtPrenom.Text.Trim();
            sportifSelectionne.DateNais = dtpDateNais.Value.Date;
            sportifSelectionne.Rue = txtRue.Text.Trim();
            sportifSelectionne.CodePostal = txtCP.Text.Trim();
            sportifSelectionne.Ville = txtVille.Text.Trim();

            try
            {
                GSportif.ModifierSportif(sportifSelectionne);
                MessageBox.Show("Le sportif a bien été modifié.", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViderFormulaire();
                ChargerSportifs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (sportifSelectionne == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un sportif dans la liste.",
                                "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirmation obligatoire avant la suppression définitive
            DialogResult reponse = MessageBox.Show(
                "Voulez-vous vraiment supprimer " + sportifSelectionne.Prenom + " " + sportifSelectionne.Nom + " ?\n" +
                "Ses sports pratiqués seront également supprimés.\n" +
                "Cette action est définitive.",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (reponse == DialogResult.Yes)
            {
                try
                {
                    GSportif.SupprimerSportif(sportifSelectionne.Id);
                    MessageBox.Show("Le sportif a bien été supprimé.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViderFormulaire();
                    ChargerSportifs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression :\n" + ex.Message,
                                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        // Remplit la liste des sports pratiqués du sportif sélectionné
        // Le bloc est grisé tant qu'aucun sportif n'est sélectionné
        private void AfficherPratiques()
        {
            listPratiques.Items.Clear();

            if (sportifSelectionne == null)
            {
                grpPratiques.Enabled = false;
                return;
            }

            grpPratiques.Enabled = true;
            for (int i = 0; i < sportifSelectionne.Pratiques.Count; i++)
            {
                Pratique pratique = sportifSelectionne.Pratiques[i];

                ListViewItem item = new ListViewItem(pratique.Sport.Nom);
                item.SubItems.Add(pratique.Niveau.Nom);
                item.Tag = pratique;

                listPratiques.Items.Add(item);
            }
        }

        // Recharge la base puis resélectionne le même sportif (pour voir ses sports à jour)
        private void RechargerEtReselectionner(int idSportif)
        {
            ChargerSportifs();
            for (int i = 0; i < listGestion.Items.Count; i++)
            {
                Sportif s = (Sportif)listGestion.Items[i].Tag;
                if (s.Id == idSportif)
                {
                    listGestion.Items[i].Selected = true;
                    listGestion.Items[i].EnsureVisible();
                    break;
                }
            }
        }

        // Quand on sélectionne un sport pratiqué, on affiche ses valeurs dans les listes déroulantes
        private void listPratiques_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPratiques.SelectedItems.Count > 0)
            {
                Pratique pratique = (Pratique)listPratiques.SelectedItems[0].Tag;

                for (int i = 0; i < cbSport.Items.Count; i++)
                {
                    if (((Sport)cbSport.Items[i]).Id == pratique.Sport.Id)
                    {
                        cbSport.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cbNiveau.Items.Count; i++)
                {
                    if (((Niveau)cbNiveau.Items[i]).Id == pratique.Niveau.Id)
                    {
                        cbNiveau.SelectedIndex = i;
                    }
                }
            }
        }

       
        private void btnAjouterPratique_Click(object sender, EventArgs e)
        {
            if (sportifSelectionne == null)
            {
                return;
            }
            if (cbSport.SelectedIndex == -1 || cbNiveau.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir un sport et un niveau.",
                                "Ajout d'un sport", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Sport sport = (Sport)cbSport.SelectedItem;
            Niveau niveau = (Niveau)cbNiveau.SelectedItem;

            // Règle de gestion : un sportif ne peut pas avoir deux fois le même sport
            if (sportifSelectionne.PratiqueSport(sport.Id))
            {
                MessageBox.Show(sportifSelectionne.Prenom + " pratique déjà " + sport.Nom + ".\n" +
                                "Pour changer son niveau, utilisez « Modifier le niveau ».",
                                "Ajout d'un sport", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idSportif = sportifSelectionne.Id;
                GSportif.AjouterPratique(idSportif, sport.Id, niveau.Id);
                RechargerEtReselectionner(idSportif);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du sport :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void btnModifierNiveau_Click(object sender, EventArgs e)
        {
            if (sportifSelectionne == null)
            {
                return;
            }
            if (listPratiques.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un sport dans la liste des sports pratiqués.",
                                "Modification du niveau", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbNiveau.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir le nouveau niveau.",
                                "Modification du niveau", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Le sport modifié est celui sélectionné dans la liste (pas dans la liste déroulante)
            Pratique pratique = (Pratique)listPratiques.SelectedItems[0].Tag;
            Niveau niveau = (Niveau)cbNiveau.SelectedItem;

            try
            {
                int idSportif = sportifSelectionne.Id;
                GSportif.ModifierNiveau(idSportif, pratique.Sport.Id, niveau.Id);
                RechargerEtReselectionner(idSportif);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification du niveau :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnSupprimerPratique_Click(object sender, EventArgs e)
        {
            if (sportifSelectionne == null)
            {
                return;
            }
            if (listPratiques.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un sport dans la liste des sports pratiqués.",
                                "Suppression d'un sport", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Pratique pratique = (Pratique)listPratiques.SelectedItems[0].Tag;

            DialogResult reponse = MessageBox.Show(
                "Retirer " + pratique.Sport.Nom + " des sports pratiqués par " +
                sportifSelectionne.Prenom + " " + sportifSelectionne.Nom + " ?\n" +
                "Le sportif et le sport ne seront pas supprimés.",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (reponse == DialogResult.Yes)
            {
                try
                {
                    int idSportif = sportifSelectionne.Id;
                    GSportif.SupprimerPratique(idSportif, pratique.Sport.Id);
                    RechargerEtReselectionner(idSportif);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression du sport :\n" + ex.Message,
                                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

        private void btnChangerMdp_Click(object sender, EventArgs e)
        {
            using (FormChangementMdp f = new FormChangementMdp(loginConnecte))
            {
                f.ShowDialog();
            }
        }
    }
}
