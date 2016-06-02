namespace Skill_Project.FormsCompetence
{
    partial class FormProjetCodeSourceSiteWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjetCodeSourceSiteWeb));
            this.pbRetour = new System.Windows.Forms.PictureBox();
            this.lblCreateur = new System.Windows.Forms.Label();
            this.pbCode = new System.Windows.Forms.PictureBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.pbRetourForm = new System.Windows.Forms.PictureBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btnCSSW = new System.Windows.Forms.Button();
            this.rtbCSSW = new System.Windows.Forms.RichTextBox();
            this.lblTitreCSSW = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetourForm)).BeginInit();
            this.SuspendLayout();
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
            // lblCreateur
            // 
            resources.ApplyResources(this.lblCreateur, "lblCreateur");
            this.lblCreateur.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateur.Name = "lblCreateur";
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
            // pbRetourForm
            // 
            this.pbRetourForm.BackColor = System.Drawing.Color.Transparent;
            this.pbRetourForm.BackgroundImage = global::Skill_Project.Properties.Resources.coin_replie_retour;
            resources.ApplyResources(this.pbRetourForm, "pbRetourForm");
            this.pbRetourForm.Name = "pbRetourForm";
            this.pbRetourForm.TabStop = false;
            this.pbRetourForm.Click += new System.EventHandler(this.pbRetourForm_Click);
            // 
            // tbURL
            // 
            this.tbURL.BackColor = System.Drawing.SystemColors.Window;
            this.tbURL.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.tbURL, "tbURL");
            this.tbURL.ForeColor = System.Drawing.Color.DarkGray;
            this.tbURL.Name = "tbURL";
            this.tbURL.Click += new System.EventHandler(this.tbURL_Click);
            this.tbURL.Enter += new System.EventHandler(this.tbURL_Enter);
            this.tbURL.Leave += new System.EventHandler(this.tbURL_Leave);
            // 
            // btnCSSW
            // 
            resources.ApplyResources(this.btnCSSW, "btnCSSW");
            this.btnCSSW.BackColor = System.Drawing.Color.Transparent;
            this.btnCSSW.Name = "btnCSSW";
            this.btnCSSW.UseVisualStyleBackColor = false;
            this.btnCSSW.Click += new System.EventHandler(this.btnCSSW_Click);
            // 
            // rtbCSSW
            // 
            this.rtbCSSW.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.rtbCSSW, "rtbCSSW");
            this.rtbCSSW.ForeColor = System.Drawing.Color.DarkGray;
            this.rtbCSSW.Name = "rtbCSSW";
            this.rtbCSSW.ReadOnly = true;
            // 
            // lblTitreCSSW
            // 
            resources.ApplyResources(this.lblTitreCSSW, "lblTitreCSSW");
            this.lblTitreCSSW.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreCSSW.Name = "lblTitreCSSW";
            // 
            // FormProjetCodeSourceSiteWeb
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Skill_Project.Properties.Resources.yuyukyuk;
            this.ControlBox = false;
            this.Controls.Add(this.lblTitreCSSW);
            this.Controls.Add(this.rtbCSSW);
            this.Controls.Add(this.btnCSSW);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.pbRetourForm);
            this.Controls.Add(this.pbCode);
            this.Controls.Add(this.lblCreateur);
            this.Controls.Add(this.pbRetour);
            this.Controls.Add(this.tbCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormProjetCodeSourceSiteWeb";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormProjetCodeSourceSiteWeb_Load);
            this.Leave += new System.EventHandler(this.FormProjetCodeSourceSiteWeb_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pbRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetourForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRetour;
        private System.Windows.Forms.Label lblCreateur;
        private System.Windows.Forms.PictureBox pbCode;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.PictureBox pbRetourForm;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnCSSW;
        private System.Windows.Forms.RichTextBox rtbCSSW;
        private System.Windows.Forms.Label lblTitreCSSW;
    }
}