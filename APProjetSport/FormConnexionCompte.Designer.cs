namespace APProjetSport
{
    partial class FormConnexionCompte
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexionCompte));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtConfirmation = new System.Windows.Forms.TextBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(17, 22);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(17, 56);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(77, 13);
            this.lblMdp.TabIndex = 1;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Location = new System.Drawing.Point(17, 91);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(71, 13);
            this.lblConfirmation.TabIndex = 2;
            this.lblConfirmation.Text = "Confirmation :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(137, 19);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(155, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(137, 54);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(155, 20);
            this.txtMdp.TabIndex = 4;
            this.txtMdp.UseSystemPasswordChar = true;
            // 
            // txtConfirmation
            // 
            this.txtConfirmation.Location = new System.Drawing.Point(137, 88);
            this.txtConfirmation.Name = "txtConfirmation";
            this.txtConfirmation.Size = new System.Drawing.Size(155, 20);
            this.txtConfirmation.TabIndex = 5;
            this.txtConfirmation.UseSystemPasswordChar = true;
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(86, 139);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(94, 28);
            this.btnCreer.TabIndex = 6;
            this.btnCreer.Text = "Créer le compte";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(197, 139);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(94, 28);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormConnexionCompte
            // 
            this.AcceptButton = this.btnCreer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(309, 186);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.txtConfirmation);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConnexionCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Création d\'un compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtConfirmation;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
