namespace APProjetSport
{
    partial class FormConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnCreerCompte = new System.Windows.Forms.Button();
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
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(120, 19);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(163, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(120, 54);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(163, 20);
            this.txtMdp.TabIndex = 3;
            this.txtMdp.UseSystemPasswordChar = true;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(120, 95);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(163, 28);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btnCreerCompte
            // 
            this.btnCreerCompte.Location = new System.Drawing.Point(120, 130);
            this.btnCreerCompte.Name = "btnCreerCompte";
            this.btnCreerCompte.Size = new System.Drawing.Size(163, 26);
            this.btnCreerCompte.TabIndex = 5;
            this.btnCreerCompte.Text = "Créer un compte";
            this.btnCreerCompte.UseVisualStyleBackColor = true;
            this.btnCreerCompte.Click += new System.EventHandler(this.btnCreerCompte_Click);
            // 
            // FormConnexion
            // 
            this.AcceptButton = this.btnConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 173);
            this.Controls.Add(this.btnCreerCompte);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sport\'SIO - Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnCreerCompte;
    }
}
