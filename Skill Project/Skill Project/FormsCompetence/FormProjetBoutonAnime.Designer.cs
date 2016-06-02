namespace Skill_Project.FormsCompetence
{
    partial class FormProjetBoutonAnime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjetBoutonAnime));
            this.lblTitre = new System.Windows.Forms.Label();
            this.pbRetour = new System.Windows.Forms.PictureBox();
            this.pbRetourForm = new System.Windows.Forms.PictureBox();
            this.pbCode = new System.Windows.Forms.PictureBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lblCreateur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetourForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            resources.ApplyResources(this.lblTitre, "lblTitre");
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Name = "lblTitre";
            // 
            // pbRetour
            // 
            this.pbRetour.BackColor = System.Drawing.Color.Transparent;
            this.pbRetour.BackgroundImage = global::Skill_Project.Properties.Resources.retour;
            resources.ApplyResources(this.pbRetour, "pbRetour");
            this.pbRetour.Name = "pbRetour";
            this.pbRetour.TabStop = false;
            this.pbRetour.Click += new System.EventHandler(this.pbRetour_Click);
            // 
            // pbRetourForm
            // 
            this.pbRetourForm.BackColor = System.Drawing.Color.Transparent;
            this.pbRetourForm.BackgroundImage = global::Skill_Project.Properties.Resources.coin_replie_retour;
            resources.ApplyResources(this.pbRetourForm, "pbRetourForm");
            this.pbRetourForm.Name = "pbRetourForm";
            this.pbRetourForm.TabStop = false;
            this.pbRetourForm.Click += new System.EventHandler(this.pbRetourForm_Click);
            // 
            // pbCode
            // 
            this.pbCode.BackColor = System.Drawing.Color.Transparent;
            this.pbCode.BackgroundImage = global::Skill_Project.Properties.Resources.coin_replie2;
            resources.ApplyResources(this.pbCode, "pbCode");
            this.pbCode.Name = "pbCode";
            this.pbCode.TabStop = false;
            this.pbCode.Click += new System.EventHandler(this.pbCode_Click);
            // 
            // tbCode
            // 
            resources.ApplyResources(this.tbCode, "tbCode");
            this.tbCode.Name = "tbCode";
            // 
            // lblCreateur
            // 
            resources.ApplyResources(this.lblCreateur, "lblCreateur");
            this.lblCreateur.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateur.Name = "lblCreateur";
            // 
            // FormProjetBoutonAnime
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Skill_Project.Properties.Resources.yuyukyuk;
            this.ControlBox = false;
            this.Controls.Add(this.lblCreateur);
            this.Controls.Add(this.pbCode);
            this.Controls.Add(this.pbRetourForm);
            this.Controls.Add(this.pbRetour);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.tbCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormProjetBoutonAnime";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormProjetBoutonAnime_Load);
            this.Leave += new System.EventHandler(this.FormProjetBoutonAnime_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pbRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetourForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pbRetour;
        private System.Windows.Forms.PictureBox pbRetourForm;
        private System.Windows.Forms.PictureBox pbCode;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lblCreateur;
    }
}