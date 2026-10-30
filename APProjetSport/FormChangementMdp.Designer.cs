namespace APProjetSport
{
    partial class FormChangementMdp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangementMdp));
            this.lblAncien = new System.Windows.Forms.Label();
            this.lblNouveau = new System.Windows.Forms.Label();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.txtAncien = new System.Windows.Forms.TextBox();
            this.txtNouveau = new System.Windows.Forms.TextBox();
            this.txtConfirmation = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAncien
            // 
            this.lblAncien.AutoSize = true;
            this.lblAncien.Location = new System.Drawing.Point(17, 22);
            this.lblAncien.Name = "lblAncien";
            this.lblAncien.Size = new System.Drawing.Size(112, 13);
            this.lblAncien.TabIndex = 0;
            this.lblAncien.Text = "Ancien mot de passe :";
            // 
            // lblNouveau
            // 
            this.lblNouveau.AutoSize = true;
            this.lblNouveau.Location = new System.Drawing.Point(17, 56);
            this.lblNouveau.Name = "lblNouveau";
            this.lblNouveau.Size = new System.Drawing.Size(123, 13);
            this.lblNouveau.TabIndex = 1;
            this.lblNouveau.Text = "Nouveau mot de passe :";
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
            // txtAncien
            // 
            this.txtAncien.Location = new System.Drawing.Point(163, 19);
            this.txtAncien.Name = "txtAncien";
            this.txtAncien.Size = new System.Drawing.Size(155, 20);
            this.txtAncien.TabIndex = 3;
            this.txtAncien.UseSystemPasswordChar = true;
            // 
            // txtNouveau
            // 
            this.txtNouveau.Location = new System.Drawing.Point(163, 54);
            this.txtNouveau.Name = "txtNouveau";
            this.txtNouveau.Size = new System.Drawing.Size(155, 20);
            this.txtNouveau.TabIndex = 4;
            this.txtNouveau.UseSystemPasswordChar = true;
            // 
            // txtConfirmation
            // 
            this.txtConfirmation.Location = new System.Drawing.Point(163, 88);
            this.txtConfirmation.Name = "txtConfirmation";
            this.txtConfirmation.Size = new System.Drawing.Size(155, 20);
            this.txtConfirmation.TabIndex = 5;
            this.txtConfirmation.UseSystemPasswordChar = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(129, 139);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(90, 28);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(227, 139);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(90, 28);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormChangementMdp
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(339, 186);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtConfirmation);
            this.Controls.Add(this.txtNouveau);
            this.Controls.Add(this.txtAncien);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.lblNouveau);
            this.Controls.Add(this.lblAncien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangementMdp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Changer mon mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAncien;
        private System.Windows.Forms.Label lblNouveau;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.TextBox txtAncien;
        private System.Windows.Forms.TextBox txtNouveau;
        private System.Windows.Forms.TextBox txtConfirmation;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
