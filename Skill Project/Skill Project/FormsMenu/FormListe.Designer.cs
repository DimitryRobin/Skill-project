using System.Windows.Forms;

namespace Skill_Project
{
    partial class FormListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListe));
            this.gbTri = new System.Windows.Forms.GroupBox();
            this.rbZA = new System.Windows.Forms.RadioButton();
            this.rbAZ = new System.Windows.Forms.RadioButton();
            this.rbDateAjout = new System.Windows.Forms.RadioButton();
            this.gbRecherche = new System.Windows.Forms.GroupBox();
            this.cbRecherche = new System.Windows.Forms.ComboBox();
            this.lblrecherche = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbRecent = new System.Windows.Forms.GroupBox();
            this.panelRecent = new System.Windows.Forms.Panel();
            this.recent3 = new System.Windows.Forms.Label();
            this.lblDate3 = new System.Windows.Forms.Label();
            this.recent2 = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.recent1 = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.gbTri.SuspendLayout();
            this.gbRecherche.SuspendLayout();
            this.gbRecent.SuspendLayout();
            this.panelRecent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTri
            // 
            this.gbTri.BackColor = System.Drawing.Color.Transparent;
            this.gbTri.Controls.Add(this.rbZA);
            this.gbTri.Controls.Add(this.rbAZ);
            this.gbTri.Controls.Add(this.rbDateAjout);
            resources.ApplyResources(this.gbTri, "gbTri");
            this.gbTri.Name = "gbTri";
            this.gbTri.TabStop = false;
            // 
            // rbZA
            // 
            resources.ApplyResources(this.rbZA, "rbZA");
            this.rbZA.Name = "rbZA";
            this.rbZA.UseVisualStyleBackColor = true;
            this.rbZA.CheckedChanged += new System.EventHandler(this.rbZA_CheckedChanged);
            this.rbZA.Click += new System.EventHandler(this.rbZA_Click);
            // 
            // rbAZ
            // 
            resources.ApplyResources(this.rbAZ, "rbAZ");
            this.rbAZ.Name = "rbAZ";
            this.rbAZ.UseVisualStyleBackColor = true;
            this.rbAZ.CheckedChanged += new System.EventHandler(this.rbAZ_CheckedChanged);
            this.rbAZ.Click += new System.EventHandler(this.rbAZ_Click);
            // 
            // rbDateAjout
            // 
            resources.ApplyResources(this.rbDateAjout, "rbDateAjout");
            this.rbDateAjout.Checked = true;
            this.rbDateAjout.Name = "rbDateAjout";
            this.rbDateAjout.TabStop = true;
            this.rbDateAjout.UseVisualStyleBackColor = true;
            this.rbDateAjout.Click += new System.EventHandler(this.rbDateAjout_Click);
            // 
            // gbRecherche
            // 
            this.gbRecherche.BackColor = System.Drawing.Color.Transparent;
            this.gbRecherche.Controls.Add(this.cbRecherche);
            this.gbRecherche.Controls.Add(this.lblrecherche);
            resources.ApplyResources(this.gbRecherche, "gbRecherche");
            this.gbRecherche.Name = "gbRecherche";
            this.gbRecherche.TabStop = false;
            // 
            // cbRecherche
            // 
            resources.ApplyResources(this.cbRecherche, "cbRecherche");
            this.cbRecherche.ForeColor = System.Drawing.Color.DarkGray;
            this.cbRecherche.FormattingEnabled = true;
            this.cbRecherche.Name = "cbRecherche";
            this.cbRecherche.SelectedIndexChanged += new System.EventHandler(this.cbRecherche_SelectedIndexChanged);
            this.cbRecherche.TextChanged += new System.EventHandler(this.cbRecherche_TextChanged);
            this.cbRecherche.Click += new System.EventHandler(this.cbRecherche_SelectedIndexChanged);
            this.cbRecherche.Enter += new System.EventHandler(this.cbRecherche_Click);
            this.cbRecherche.Leave += new System.EventHandler(this.cbRecherche_Leave);
            // 
            // lblrecherche
            // 
            resources.ApplyResources(this.lblrecherche, "lblrecherche");
            this.lblrecherche.BackColor = System.Drawing.Color.Transparent;
            this.lblrecherche.Name = "lblrecherche";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // gbRecent
            // 
            this.gbRecent.BackColor = System.Drawing.Color.Transparent;
            this.gbRecent.Controls.Add(this.panelRecent);
            resources.ApplyResources(this.gbRecent, "gbRecent");
            this.gbRecent.Name = "gbRecent";
            this.gbRecent.TabStop = false;
            // 
            // panelRecent
            // 
            resources.ApplyResources(this.panelRecent, "panelRecent");
            this.panelRecent.Controls.Add(this.recent3);
            this.panelRecent.Controls.Add(this.lblDate3);
            this.panelRecent.Controls.Add(this.recent2);
            this.panelRecent.Controls.Add(this.lblDate2);
            this.panelRecent.Controls.Add(this.recent1);
            this.panelRecent.Controls.Add(this.lblDate1);
            this.panelRecent.Name = "panelRecent";
            // 
            // recent3
            // 
            resources.ApplyResources(this.recent3, "recent3");
            this.recent3.BackColor = System.Drawing.Color.Transparent;
            this.recent3.Name = "recent3";
            this.recent3.Click += new System.EventHandler(this.LB_Click);
            this.recent3.MouseHover += new System.EventHandler(this.recent1_MouseHover);
            // 
            // lblDate3
            // 
            resources.ApplyResources(this.lblDate3, "lblDate3");
            this.lblDate3.BackColor = System.Drawing.Color.Transparent;
            this.lblDate3.Name = "lblDate3";
            // 
            // recent2
            // 
            resources.ApplyResources(this.recent2, "recent2");
            this.recent2.BackColor = System.Drawing.Color.Transparent;
            this.recent2.Name = "recent2";
            this.recent2.Click += new System.EventHandler(this.LB_Click);
            this.recent2.MouseHover += new System.EventHandler(this.recent1_MouseHover);
            // 
            // lblDate2
            // 
            resources.ApplyResources(this.lblDate2, "lblDate2");
            this.lblDate2.BackColor = System.Drawing.Color.Transparent;
            this.lblDate2.Name = "lblDate2";
            // 
            // recent1
            // 
            resources.ApplyResources(this.recent1, "recent1");
            this.recent1.BackColor = System.Drawing.Color.Transparent;
            this.recent1.Name = "recent1";
            this.recent1.Click += new System.EventHandler(this.LB_Click);
            this.recent1.MouseHover += new System.EventHandler(this.recent1_MouseHover);
            // 
            // lblDate1
            // 
            resources.ApplyResources(this.lblDate1, "lblDate1");
            this.lblDate1.BackColor = System.Drawing.Color.Transparent;
            this.lblDate1.Name = "lblDate1";
            // 
            // FormListe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Skill_Project.Properties.Resources.yuyukyuk;
            this.ControlBox = false;
            this.Controls.Add(this.gbRecent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbRecherche);
            this.Controls.Add(this.gbTri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormListe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSkillProject_Load);
            this.Leave += new System.EventHandler(this.FormSkillProject_Leave);
            this.gbTri.ResumeLayout(false);
            this.gbTri.PerformLayout();
            this.gbRecherche.ResumeLayout(false);
            this.gbRecherche.PerformLayout();
            this.gbRecent.ResumeLayout(false);
            this.panelRecent.ResumeLayout(false);
            this.panelRecent.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private GroupBox gbTri;
        private RadioButton rbZA;
        private RadioButton rbAZ;
        private RadioButton rbDateAjout;
        private GroupBox gbRecherche;
        private Label lblrecherche;
        private ComboBox cbRecherche;
        private Panel panel1;
        private GroupBox gbRecent;
        private Panel panelRecent;
        private Label recent1;
        private Label lblDate1;
        private Label recent3;
        private Label lblDate3;
        private Label recent2;
        private Label lblDate2;
    }
}