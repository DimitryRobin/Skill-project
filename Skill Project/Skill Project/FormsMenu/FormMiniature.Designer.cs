namespace Skill_Project
{
    partial class FormMiniature
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
            this.gbRecherche = new System.Windows.Forms.GroupBox();
            this.cbRecherche = new System.Windows.Forms.ComboBox();
            this.lblrecherche = new System.Windows.Forms.Label();
            this.gbTri = new System.Windows.Forms.GroupBox();
            this.rbZA = new System.Windows.Forms.RadioButton();
            this.rbAZ = new System.Windows.Forms.RadioButton();
            this.rbDateAjout = new System.Windows.Forms.RadioButton();
            this.gbRecent = new System.Windows.Forms.GroupBox();
            this.panelRecent = new System.Windows.Forms.Panel();
            this.recent3 = new System.Windows.Forms.Label();
            this.lblDate3 = new System.Windows.Forms.Label();
            this.recent2 = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.recent1 = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbRecherche.SuspendLayout();
            this.gbTri.SuspendLayout();
            this.gbRecent.SuspendLayout();
            this.panelRecent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRecherche
            // 
            this.gbRecherche.BackColor = System.Drawing.Color.Transparent;
            this.gbRecherche.Controls.Add(this.cbRecherche);
            this.gbRecherche.Controls.Add(this.lblrecherche);
            this.gbRecherche.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.gbRecherche.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbRecherche.Location = new System.Drawing.Point(269, 12);
            this.gbRecherche.Name = "gbRecherche";
            this.gbRecherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbRecherche.Size = new System.Drawing.Size(274, 70);
            this.gbRecherche.TabIndex = 59;
            this.gbRecherche.TabStop = false;
            this.gbRecherche.Text = "Recherche";
            // 
            // cbRecherche
            // 
            this.cbRecherche.Font = new System.Drawing.Font("Palatino Linotype", 9.5F, System.Drawing.FontStyle.Bold);
            this.cbRecherche.ForeColor = System.Drawing.Color.DarkGray;
            this.cbRecherche.FormattingEnabled = true;
            this.cbRecherche.Location = new System.Drawing.Point(82, 29);
            this.cbRecherche.Name = "cbRecherche";
            this.cbRecherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbRecherche.Size = new System.Drawing.Size(178, 26);
            this.cbRecherche.TabIndex = 56;
            this.cbRecherche.Text = "Recherchez..";
            // 
            // lblrecherche
            // 
            this.lblrecherche.AutoSize = true;
            this.lblrecherche.BackColor = System.Drawing.Color.Transparent;
            this.lblrecherche.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblrecherche.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblrecherche.Location = new System.Drawing.Point(6, 32);
            this.lblrecherche.Name = "lblrecherche";
            this.lblrecherche.Size = new System.Drawing.Size(70, 20);
            this.lblrecherche.TabIndex = 8;
            this.lblrecherche.Text = "Mot clé :";
            // 
            // gbTri
            // 
            this.gbTri.BackColor = System.Drawing.Color.Transparent;
            this.gbTri.Controls.Add(this.rbZA);
            this.gbTri.Controls.Add(this.rbAZ);
            this.gbTri.Controls.Add(this.rbDateAjout);
            this.gbTri.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.gbTri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbTri.Location = new System.Drawing.Point(17, 12);
            this.gbTri.Name = "gbTri";
            this.gbTri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbTri.Size = new System.Drawing.Size(246, 70);
            this.gbTri.TabIndex = 58;
            this.gbTri.TabStop = false;
            this.gbTri.Text = "Trier par";
            // 
            // rbZA
            // 
            this.rbZA.AutoSize = true;
            this.rbZA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbZA.Location = new System.Drawing.Point(181, 29);
            this.rbZA.Name = "rbZA";
            this.rbZA.Size = new System.Drawing.Size(52, 24);
            this.rbZA.TabIndex = 5;
            this.rbZA.Text = "Z-A";
            this.rbZA.UseVisualStyleBackColor = true;
            // 
            // rbAZ
            // 
            this.rbAZ.AutoSize = true;
            this.rbAZ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbAZ.Location = new System.Drawing.Point(123, 29);
            this.rbAZ.Name = "rbAZ";
            this.rbAZ.Size = new System.Drawing.Size(52, 24);
            this.rbAZ.TabIndex = 4;
            this.rbAZ.Text = "A-Z";
            this.rbAZ.UseVisualStyleBackColor = true;
            // 
            // rbDateAjout
            // 
            this.rbDateAjout.AutoSize = true;
            this.rbDateAjout.Checked = true;
            this.rbDateAjout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbDateAjout.Location = new System.Drawing.Point(6, 29);
            this.rbDateAjout.Name = "rbDateAjout";
            this.rbDateAjout.Size = new System.Drawing.Size(112, 24);
            this.rbDateAjout.TabIndex = 3;
            this.rbDateAjout.TabStop = true;
            this.rbDateAjout.Text = "Date d\'ajout";
            this.rbDateAjout.UseVisualStyleBackColor = true;
            // 
            // gbRecent
            // 
            this.gbRecent.BackColor = System.Drawing.Color.Transparent;
            this.gbRecent.Controls.Add(this.panelRecent);
            this.gbRecent.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.gbRecent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbRecent.Location = new System.Drawing.Point(549, 12);
            this.gbRecent.Name = "gbRecent";
            this.gbRecent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbRecent.Size = new System.Drawing.Size(413, 70);
            this.gbRecent.TabIndex = 61;
            this.gbRecent.TabStop = false;
            this.gbRecent.Text = "Vue récemment";
            // 
            // panelRecent
            // 
            this.panelRecent.AutoScroll = true;
            this.panelRecent.AutoScrollMinSize = new System.Drawing.Size(0, 50);
            this.panelRecent.Controls.Add(this.recent3);
            this.panelRecent.Controls.Add(this.lblDate3);
            this.panelRecent.Controls.Add(this.recent2);
            this.panelRecent.Controls.Add(this.lblDate2);
            this.panelRecent.Controls.Add(this.recent1);
            this.panelRecent.Controls.Add(this.lblDate1);
            this.panelRecent.Location = new System.Drawing.Point(6, 25);
            this.panelRecent.Name = "panelRecent";
            this.panelRecent.Size = new System.Drawing.Size(401, 39);
            this.panelRecent.TabIndex = 0;
            // 
            // recent3
            // 
            this.recent3.AutoSize = true;
            this.recent3.BackColor = System.Drawing.Color.Transparent;
            this.recent3.Font = new System.Drawing.Font("Gentium Basic", 10.25F);
            this.recent3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recent3.Location = new System.Drawing.Point(103, 38);
            this.recent3.Name = "recent3";
            this.recent3.Size = new System.Drawing.Size(90, 16);
            this.recent3.TabIndex = 62;
            this.recent3.Text = "Nom du projet";
            // 
            // lblDate3
            // 
            this.lblDate3.AutoSize = true;
            this.lblDate3.BackColor = System.Drawing.Color.Transparent;
            this.lblDate3.Font = new System.Drawing.Font("Gentium Basic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblDate3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDate3.Location = new System.Drawing.Point(3, 38);
            this.lblDate3.Name = "lblDate3";
            this.lblDate3.Size = new System.Drawing.Size(94, 17);
            this.lblDate3.TabIndex = 61;
            this.lblDate3.Text = "jj/mm/aaaa :";
            // 
            // recent2
            // 
            this.recent2.AutoSize = true;
            this.recent2.BackColor = System.Drawing.Color.Transparent;
            this.recent2.Font = new System.Drawing.Font("Gentium Basic", 10.25F);
            this.recent2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recent2.Location = new System.Drawing.Point(103, 20);
            this.recent2.Name = "recent2";
            this.recent2.Size = new System.Drawing.Size(90, 16);
            this.recent2.TabIndex = 60;
            this.recent2.Text = "Nom du projet";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.BackColor = System.Drawing.Color.Transparent;
            this.lblDate2.Font = new System.Drawing.Font("Gentium Basic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblDate2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDate2.Location = new System.Drawing.Point(3, 20);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(94, 17);
            this.lblDate2.TabIndex = 59;
            this.lblDate2.Text = "jj/mm/aaaa :";
            // 
            // recent1
            // 
            this.recent1.AutoSize = true;
            this.recent1.BackColor = System.Drawing.Color.Transparent;
            this.recent1.Font = new System.Drawing.Font("Gentium Basic", 10.25F);
            this.recent1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recent1.Location = new System.Drawing.Point(103, 1);
            this.recent1.Name = "recent1";
            this.recent1.Size = new System.Drawing.Size(90, 16);
            this.recent1.TabIndex = 58;
            this.recent1.Text = "Nom du projet";
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.BackColor = System.Drawing.Color.Transparent;
            this.lblDate1.Font = new System.Drawing.Font("Gentium Basic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblDate1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDate1.Location = new System.Drawing.Point(3, 1);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(94, 17);
            this.lblDate1.TabIndex = 57;
            this.lblDate1.Text = "jj/mm/aaaa :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 475);
            this.panel1.TabIndex = 60;
            // 
            // FormMiniature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Skill_Project.Properties.Resources.yuyukyuk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.gbRecherche);
            this.Controls.Add(this.gbTri);
            this.Controls.Add(this.gbRecent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMiniature";
            this.Text = "Affichage Miniature";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Leave += new System.EventHandler(this.FormMiniature_Leave);
            this.gbRecherche.ResumeLayout(false);
            this.gbRecherche.PerformLayout();
            this.gbTri.ResumeLayout(false);
            this.gbTri.PerformLayout();
            this.gbRecent.ResumeLayout(false);
            this.panelRecent.ResumeLayout(false);
            this.panelRecent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRecherche;
        private System.Windows.Forms.ComboBox cbRecherche;
        private System.Windows.Forms.Label lblrecherche;
        private System.Windows.Forms.GroupBox gbTri;
        private System.Windows.Forms.RadioButton rbZA;
        private System.Windows.Forms.RadioButton rbAZ;
        private System.Windows.Forms.RadioButton rbDateAjout;
        private System.Windows.Forms.GroupBox gbRecent;
        private System.Windows.Forms.Panel panelRecent;
        private System.Windows.Forms.Label recent3;
        private System.Windows.Forms.Label lblDate3;
        private System.Windows.Forms.Label recent2;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label recent1;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.Panel panel1;
    }
}