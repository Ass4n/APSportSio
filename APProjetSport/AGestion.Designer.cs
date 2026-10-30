namespace APProjetSport
{
    partial class AGestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AGestion));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConsultation = new System.Windows.Forms.TabPage();
            this.btnChangerMdp = new System.Windows.Forms.Button();
            this.lblCritere = new System.Windows.Forms.Label();
            this.lblValeur = new System.Windows.Forms.Label();
            this.CbListeDeroulante = new System.Windows.Forms.ComboBox();
            this.textZoneRecherchee = new System.Windows.Forms.TextBox();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.listResultat = new System.Windows.Forms.ListView();
            this.tabGestion = new System.Windows.Forms.TabPage();
            this.listGestion = new System.Windows.Forms.ListView();
            this.grpFiche = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblDateNais = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.dtpDateNais = new System.Windows.Forms.DateTimePicker();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.grpPratiques = new System.Windows.Forms.GroupBox();
            this.listPratiques = new System.Windows.Forms.ListView();
            this.lblSport = new System.Windows.Forms.Label();
            this.lblNiveau = new System.Windows.Forms.Label();
            this.cbSport = new System.Windows.Forms.ComboBox();
            this.cbNiveau = new System.Windows.Forms.ComboBox();
            this.btnAjouterPratique = new System.Windows.Forms.Button();
            this.btnModifierNiveau = new System.Windows.Forms.Button();
            this.btnSupprimerPratique = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabConsultation.SuspendLayout();
            this.tabGestion.SuspendLayout();
            this.grpFiche.SuspendLayout();
            this.grpPratiques.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConsultation);
            this.tabControl1.Controls.Add(this.tabGestion);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // tabConsultation
            // 
            this.tabConsultation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabConsultation.BackgroundImage")));
            this.tabConsultation.Controls.Add(this.btnChangerMdp);
            this.tabConsultation.Controls.Add(this.lblCritere);
            this.tabConsultation.Controls.Add(this.lblValeur);
            this.tabConsultation.Controls.Add(this.CbListeDeroulante);
            this.tabConsultation.Controls.Add(this.textZoneRecherchee);
            this.tabConsultation.Controls.Add(this.BtnRechercher);
            this.tabConsultation.Controls.Add(this.listResultat);
            this.tabConsultation.Location = new System.Drawing.Point(4, 22);
            this.tabConsultation.Name = "tabConsultation";
            this.tabConsultation.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultation.Size = new System.Drawing.Size(876, 554);
            this.tabConsultation.TabIndex = 0;
            this.tabConsultation.Text = "Consultation";
            this.tabConsultation.UseVisualStyleBackColor = true;
            // 
            // btnChangerMdp
            // 
            this.btnChangerMdp.Location = new System.Drawing.Point(739, 12);
            this.btnChangerMdp.Name = "btnChangerMdp";
            this.btnChangerMdp.Size = new System.Drawing.Size(105, 37);
            this.btnChangerMdp.TabIndex = 6;
            this.btnChangerMdp.Text = "Changer Mot de passe ?";
            this.btnChangerMdp.UseVisualStyleBackColor = true;
            this.btnChangerMdp.Click += new System.EventHandler(this.btnChangerMdp_Click);
            // 
            // lblCritere
            // 
            this.lblCritere.AutoSize = true;
            this.lblCritere.Location = new System.Drawing.Point(15, 23);
            this.lblCritere.Name = "lblCritere";
            this.lblCritere.Size = new System.Drawing.Size(43, 13);
            this.lblCritere.TabIndex = 0;
            this.lblCritere.Text = "Critère :";
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Location = new System.Drawing.Point(235, 23);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(43, 13);
            this.lblValeur.TabIndex = 1;
            this.lblValeur.Text = "Valeur :";
            // 
            // CbListeDeroulante
            // 
            this.CbListeDeroulante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbListeDeroulante.FormattingEnabled = true;
            this.CbListeDeroulante.Items.AddRange(new object[] {
            "Ville",
            "Niveau d\'expérience",
            "Nom du sport"});
            this.CbListeDeroulante.Location = new System.Drawing.Point(70, 20);
            this.CbListeDeroulante.Name = "CbListeDeroulante";
            this.CbListeDeroulante.Size = new System.Drawing.Size(150, 21);
            this.CbListeDeroulante.TabIndex = 2;
            // 
            // textZoneRecherchee
            // 
            this.textZoneRecherchee.Location = new System.Drawing.Point(285, 20);
            this.textZoneRecherchee.Name = "textZoneRecherchee";
            this.textZoneRecherchee.Size = new System.Drawing.Size(180, 20);
            this.textZoneRecherchee.TabIndex = 3;
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.Location = new System.Drawing.Point(485, 18);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(90, 25);
            this.BtnRechercher.TabIndex = 4;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.UseVisualStyleBackColor = true;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // listResultat
            // 
            this.listResultat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResultat.HideSelection = false;
            this.listResultat.Location = new System.Drawing.Point(10, 60);
            this.listResultat.Name = "listResultat";
            this.listResultat.Size = new System.Drawing.Size(856, 484);
            this.listResultat.TabIndex = 5;
            this.listResultat.UseCompatibleStateImageBehavior = false;
            this.listResultat.SelectedIndexChanged += new System.EventHandler(this.listResultat_SelectedIndexChanged);
            // 
            // tabGestion
            // 
            this.tabGestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabGestion.BackgroundImage")));
            this.tabGestion.Controls.Add(this.listGestion);
            this.tabGestion.Controls.Add(this.grpFiche);
            this.tabGestion.Controls.Add(this.grpPratiques);
            this.tabGestion.Location = new System.Drawing.Point(4, 22);
            this.tabGestion.Name = "tabGestion";
            this.tabGestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestion.Size = new System.Drawing.Size(876, 554);
            this.tabGestion.TabIndex = 1;
            this.tabGestion.Text = "Gestion des sportifs";
            this.tabGestion.UseVisualStyleBackColor = true;
            // 
            // listGestion
            // 
            this.listGestion.HideSelection = false;
            this.listGestion.Location = new System.Drawing.Point(10, 10);
            this.listGestion.MultiSelect = false;
            this.listGestion.Name = "listGestion";
            this.listGestion.Size = new System.Drawing.Size(856, 170);
            this.listGestion.TabIndex = 0;
            this.listGestion.UseCompatibleStateImageBehavior = false;
            this.listGestion.SelectedIndexChanged += new System.EventHandler(this.listGestion_SelectedIndexChanged);
            // 
            // grpFiche
            // 
            this.grpFiche.Controls.Add(this.lblNom);
            this.grpFiche.Controls.Add(this.lblPrenom);
            this.grpFiche.Controls.Add(this.lblDateNais);
            this.grpFiche.Controls.Add(this.lblRue);
            this.grpFiche.Controls.Add(this.lblCP);
            this.grpFiche.Controls.Add(this.lblVille);
            this.grpFiche.Controls.Add(this.txtNom);
            this.grpFiche.Controls.Add(this.txtPrenom);
            this.grpFiche.Controls.Add(this.dtpDateNais);
            this.grpFiche.Controls.Add(this.txtRue);
            this.grpFiche.Controls.Add(this.txtCP);
            this.grpFiche.Controls.Add(this.txtVille);
            this.grpFiche.Controls.Add(this.btnAjouter);
            this.grpFiche.Controls.Add(this.btnModifier);
            this.grpFiche.Controls.Add(this.btnSupprimer);
            this.grpFiche.Controls.Add(this.btnNouveau);
            this.grpFiche.Location = new System.Drawing.Point(10, 190);
            this.grpFiche.Name = "grpFiche";
            this.grpFiche.Size = new System.Drawing.Size(856, 165);
            this.grpFiche.TabIndex = 1;
            this.grpFiche.TabStop = false;
            this.grpFiche.Text = "Fiche du sportif";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(20, 33);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(330, 33);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblDateNais
            // 
            this.lblDateNais.AutoSize = true;
            this.lblDateNais.Location = new System.Drawing.Point(20, 73);
            this.lblDateNais.Name = "lblDateNais";
            this.lblDateNais.Size = new System.Drawing.Size(102, 13);
            this.lblDateNais.TabIndex = 2;
            this.lblDateNais.Text = "Date de naissance :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(330, 73);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(33, 13);
            this.lblRue.TabIndex = 3;
            this.lblRue.Text = "Rue :";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(20, 113);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(69, 13);
            this.lblCP.TabIndex = 4;
            this.lblCP.Text = "Code postal :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(330, 113);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "Ville :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(140, 30);
            this.txtNom.MaxLength = 25;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(170, 20);
            this.txtNom.TabIndex = 0;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(450, 30);
            this.txtPrenom.MaxLength = 25;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(170, 20);
            this.txtPrenom.TabIndex = 1;
            // 
            // dtpDateNais
            // 
            this.dtpDateNais.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateNais.Location = new System.Drawing.Point(140, 70);
            this.dtpDateNais.Name = "dtpDateNais";
            this.dtpDateNais.Size = new System.Drawing.Size(170, 20);
            this.dtpDateNais.TabIndex = 2;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(450, 70);
            this.txtRue.MaxLength = 25;
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(170, 20);
            this.txtRue.TabIndex = 3;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(140, 110);
            this.txtCP.MaxLength = 5;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(170, 20);
            this.txtCP.TabIndex = 4;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(450, 110);
            this.txtVille.MaxLength = 25;
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(170, 20);
            this.txtVille.TabIndex = 5;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(720, 20);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(110, 30);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(720, 55);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(110, 30);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(720, 90);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(110, 30);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(720, 125);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(110, 30);
            this.btnNouveau.TabIndex = 9;
            this.btnNouveau.Text = "Vider le formulaire";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // grpPratiques
            // 
            this.grpPratiques.Controls.Add(this.listPratiques);
            this.grpPratiques.Controls.Add(this.lblSport);
            this.grpPratiques.Controls.Add(this.lblNiveau);
            this.grpPratiques.Controls.Add(this.cbSport);
            this.grpPratiques.Controls.Add(this.cbNiveau);
            this.grpPratiques.Controls.Add(this.btnAjouterPratique);
            this.grpPratiques.Controls.Add(this.btnModifierNiveau);
            this.grpPratiques.Controls.Add(this.btnSupprimerPratique);
            this.grpPratiques.Location = new System.Drawing.Point(10, 365);
            this.grpPratiques.Name = "grpPratiques";
            this.grpPratiques.Size = new System.Drawing.Size(856, 175);
            this.grpPratiques.TabIndex = 2;
            this.grpPratiques.TabStop = false;
            this.grpPratiques.Text = "Sports pratiqués par le sportif sélectionné";
            // 
            // listPratiques
            // 
            this.listPratiques.HideSelection = false;
            this.listPratiques.Location = new System.Drawing.Point(15, 22);
            this.listPratiques.MultiSelect = false;
            this.listPratiques.Name = "listPratiques";
            this.listPratiques.Size = new System.Drawing.Size(400, 140);
            this.listPratiques.TabIndex = 0;
            this.listPratiques.UseCompatibleStateImageBehavior = false;
            this.listPratiques.SelectedIndexChanged += new System.EventHandler(this.listPratiques_SelectedIndexChanged);
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Location = new System.Drawing.Point(440, 32);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(38, 13);
            this.lblSport.TabIndex = 1;
            this.lblSport.Text = "Sport :";
            // 
            // lblNiveau
            // 
            this.lblNiveau.AutoSize = true;
            this.lblNiveau.Location = new System.Drawing.Point(440, 72);
            this.lblNiveau.Name = "lblNiveau";
            this.lblNiveau.Size = new System.Drawing.Size(47, 13);
            this.lblNiveau.TabIndex = 3;
            this.lblNiveau.Text = "Niveau :";
            // 
            // cbSport
            // 
            this.cbSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSport.FormattingEnabled = true;
            this.cbSport.Location = new System.Drawing.Point(520, 28);
            this.cbSport.Name = "cbSport";
            this.cbSport.Size = new System.Drawing.Size(170, 21);
            this.cbSport.TabIndex = 2;
            // 
            // cbNiveau
            // 
            this.cbNiveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNiveau.FormattingEnabled = true;
            this.cbNiveau.Location = new System.Drawing.Point(520, 68);
            this.cbNiveau.Name = "cbNiveau";
            this.cbNiveau.Size = new System.Drawing.Size(170, 21);
            this.cbNiveau.TabIndex = 4;
            // 
            // btnAjouterPratique
            // 
            this.btnAjouterPratique.Location = new System.Drawing.Point(710, 22);
            this.btnAjouterPratique.Name = "btnAjouterPratique";
            this.btnAjouterPratique.Size = new System.Drawing.Size(130, 30);
            this.btnAjouterPratique.TabIndex = 5;
            this.btnAjouterPratique.Text = "Ajouter le sport";
            this.btnAjouterPratique.UseVisualStyleBackColor = true;
            this.btnAjouterPratique.Click += new System.EventHandler(this.btnAjouterPratique_Click);
            // 
            // btnModifierNiveau
            // 
            this.btnModifierNiveau.Location = new System.Drawing.Point(710, 62);
            this.btnModifierNiveau.Name = "btnModifierNiveau";
            this.btnModifierNiveau.Size = new System.Drawing.Size(130, 30);
            this.btnModifierNiveau.TabIndex = 6;
            this.btnModifierNiveau.Text = "Modifier le niveau";
            this.btnModifierNiveau.UseVisualStyleBackColor = true;
            this.btnModifierNiveau.Click += new System.EventHandler(this.btnModifierNiveau_Click);
            // 
            // btnSupprimerPratique
            // 
            this.btnSupprimerPratique.Location = new System.Drawing.Point(710, 102);
            this.btnSupprimerPratique.Name = "btnSupprimerPratique";
            this.btnSupprimerPratique.Size = new System.Drawing.Size(130, 30);
            this.btnSupprimerPratique.TabIndex = 7;
            this.btnSupprimerPratique.Text = "Retirer le sport";
            this.btnSupprimerPratique.UseVisualStyleBackColor = true;
            this.btnSupprimerPratique.Click += new System.EventHandler(this.btnSupprimerPratique_Click);
            // 
            // AGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 580);
            this.Controls.Add(this.tabControl1);
            this.Name = "AGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPORT\'SIO - Gestion des sportifs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabConsultation.ResumeLayout(false);
            this.tabConsultation.PerformLayout();
            this.tabGestion.ResumeLayout(false);
            this.grpFiche.ResumeLayout(false);
            this.grpFiche.PerformLayout();
            this.grpPratiques.ResumeLayout(false);
            this.grpPratiques.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConsultation;
        private System.Windows.Forms.TabPage tabGestion;
        private System.Windows.Forms.Button btnChangerMdp;
        private System.Windows.Forms.Label lblCritere;
        private System.Windows.Forms.Label lblValeur;
        private System.Windows.Forms.ComboBox CbListeDeroulante;
        private System.Windows.Forms.TextBox textZoneRecherchee;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.ListView listResultat;
        private System.Windows.Forms.ListView listGestion;
        private System.Windows.Forms.GroupBox grpFiche;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblDateNais;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.DateTimePicker dtpDateNais;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.GroupBox grpPratiques;
        private System.Windows.Forms.ListView listPratiques;
        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.Label lblNiveau;
        private System.Windows.Forms.ComboBox cbSport;
        private System.Windows.Forms.ComboBox cbNiveau;
        private System.Windows.Forms.Button btnAjouterPratique;
        private System.Windows.Forms.Button btnModifierNiveau;
        private System.Windows.Forms.Button btnSupprimerPratique;
    }
}
