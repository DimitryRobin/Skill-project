namespace Skill_Project
{
    partial class FormArborescence
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
            this.label2 = new System.Windows.Forms.Label();
            this.pbClassement = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.gbTri.SuspendLayout();
            this.gbRecent.SuspendLayout();
            this.panelRecent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClassement)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTri
            // 
            this.gbTri.BackColor = System.Drawing.Color.Transparent;
            this.gbTri.Controls.Add(this.rbZA);
            this.gbTri.Controls.Add(this.rbAZ);
            this.gbTri.Controls.Add(this.rbDateAjout);
            this.gbTri.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.gbTri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbTri.Location = new System.Drawing.Point(272, 12);
            this.gbTri.Name = "gbTri";
            this.gbTri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbTri.Size = new System.Drawing.Size(281, 70);
            this.gbTri.TabIndex = 7;
            this.gbTri.TabStop = false;
            this.gbTri.Text = "Trier par";
            // 
            // rbZA
            // 
            this.rbZA.AutoSize = true;
            this.rbZA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbZA.Location = new System.Drawing.Point(206, 29);
            this.rbZA.Name = "rbZA";
            this.rbZA.Size = new System.Drawing.Size(52, 24);
            this.rbZA.TabIndex = 5;
            this.rbZA.Text = "Z-A";
            this.rbZA.UseVisualStyleBackColor = true;
            this.rbZA.Click += new System.EventHandler(this.rbZA_Click);
            // 
            // rbAZ
            // 
            this.rbAZ.AutoSize = true;
            this.rbAZ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbAZ.Location = new System.Drawing.Point(144, 29);
            this.rbAZ.Name = "rbAZ";
            this.rbAZ.Size = new System.Drawing.Size(52, 24);
            this.rbAZ.TabIndex = 4;
            this.rbAZ.Text = "A-Z";
            this.rbAZ.UseVisualStyleBackColor = true;
            this.rbAZ.Click += new System.EventHandler(this.rbAZ_Click);
            // 
            // rbDateAjout
            // 
            this.rbDateAjout.AutoSize = true;
            this.rbDateAjout.Checked = true;
            this.rbDateAjout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbDateAjout.Location = new System.Drawing.Point(9, 29);
            this.rbDateAjout.Name = "rbDateAjout";
            this.rbDateAjout.Size = new System.Drawing.Size(116, 24);
            this.rbDateAjout.TabIndex = 3;
            this.rbDateAjout.TabStop = true;
            this.rbDateAjout.Text = "Date / Réini.";
            this.rbDateAjout.UseVisualStyleBackColor = true;
            this.rbDateAjout.CheckedChanged += new System.EventHandler(this.rbDateAjout_CheckedChanged);
            this.rbDateAjout.Click += new System.EventHandler(this.rbDateAjout_Click);
            // 
            // gbRecent
            // 
            this.gbRecent.BackColor = System.Drawing.Color.Transparent;
            this.gbRecent.Controls.Add(this.panelRecent);
            this.gbRecent.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.gbRecent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbRecent.Location = new System.Drawing.Point(559, 12);
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
            this.recent3.Click += new System.EventHandler(this.LB_Click);
            this.recent3.MouseHover += new System.EventHandler(this.recent1_MouseHover);
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
            this.recent2.Click += new System.EventHandler(this.LB_Click);
            this.recent2.MouseHover += new System.EventHandler(this.recent1_MouseHover);
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
            this.recent1.Click += new System.EventHandler(this.LB_Click);
            this.recent1.MouseHover += new System.EventHandler(this.recent1_MouseHover);
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
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, 730);
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pbClassement);
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 476);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(864, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 105;
            this.label2.Text = "Classement";
            this.label2.Visible = false;
            // 
            // pbClassement
            // 
            this.pbClassement.BackColor = System.Drawing.Color.Transparent;
            this.pbClassement.BackgroundImage = global::Skill_Project.Properties.Resources.classement;
            this.pbClassement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbClassement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbClassement.Location = new System.Drawing.Point(866, 3);
            this.pbClassement.Name = "pbClassement";
            this.pbClassement.Size = new System.Drawing.Size(100, 50);
            this.pbClassement.TabIndex = 104;
            this.pbClassement.TabStop = false;
            this.pbClassement.Visible = false;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Lavender;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.treeView1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(263, 561);
            this.treeView1.TabIndex = 62;
            this.treeView1.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCollapse);
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // FormArborescence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Skill_Project.Properties.Resources.yuyukyuk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbTri);
            this.Controls.Add(this.gbRecent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormArborescence";
            this.Text = "Vue en arborescence";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormArborescence_Load);
            this.Leave += new System.EventHandler(this.FormArborescence_Leave);
            this.gbTri.ResumeLayout(false);
            this.gbTri.PerformLayout();
            this.gbRecent.ResumeLayout(false);
            this.panelRecent.ResumeLayout(false);
            this.panelRecent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClassement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbRecent;
        private System.Windows.Forms.Panel panelRecent;
        private System.Windows.Forms.Label recent3;
        private System.Windows.Forms.Label lblDate3;
        private System.Windows.Forms.Label recent2;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label recent1;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.GroupBox gbTri;
        private System.Windows.Forms.RadioButton rbZA;
        private System.Windows.Forms.RadioButton rbAZ;
        private System.Windows.Forms.RadioButton rbDateAjout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbClassement;
    }
}