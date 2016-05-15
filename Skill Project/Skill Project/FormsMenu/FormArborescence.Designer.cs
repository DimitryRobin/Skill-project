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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArborescence));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Calculatrice");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Accessoires", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Barre de progression circulaire");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Bouton animé");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Code source site web");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Formulaire de contact personnalisé");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Image flottante");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("InfoBulle");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Compétences", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("AddFindPlayer");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Morpion");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Pendu");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Snake");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Jeux", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbTri = new System.Windows.Forms.GroupBox();
            this.rbZA = new System.Windows.Forms.RadioButton();
            this.rbAZ = new System.Windows.Forms.RadioButton();
            this.rbDateAjout = new System.Windows.Forms.RadioButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.gbRecent = new System.Windows.Forms.GroupBox();
            this.panelRecent = new System.Windows.Forms.Panel();
            this.recent3 = new System.Windows.Forms.Label();
            this.lblDate3 = new System.Windows.Forms.Label();
            this.recent2 = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.recent1 = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbTri.SuspendLayout();
            this.gbRecent.SuspendLayout();
            this.panelRecent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.gbTri);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.gbRecent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 561);
            this.panel1.TabIndex = 8;
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
            this.gbTri.Size = new System.Drawing.Size(262, 70);
            this.gbTri.TabIndex = 7;
            this.gbTri.TabStop = false;
            this.gbTri.Text = "Trier par";
            // 
            // rbZA
            // 
            this.rbZA.AutoSize = true;
            this.rbZA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbZA.Location = new System.Drawing.Point(193, 29);
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
            this.rbAZ.Location = new System.Drawing.Point(135, 29);
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
            this.rbDateAjout.Location = new System.Drawing.Point(18, 29);
            this.rbDateAjout.Name = "rbDateAjout";
            this.rbDateAjout.Size = new System.Drawing.Size(112, 24);
            this.rbDateAjout.TabIndex = 3;
            this.rbDateAjout.TabStop = true;
            this.rbDateAjout.Text = "Date d\'ajout";
            this.rbDateAjout.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Lavender;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.treeView1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Calculatrice";
            treeNode1.Text = "Calculatrice";
            treeNode2.Name = "Accessoires";
            treeNode2.Text = "Accessoires";
            treeNode3.Name = "Barre de progression circulaire";
            treeNode3.Text = "Barre de progression circulaire";
            treeNode4.Name = "Bouton animé";
            treeNode4.Text = "Bouton animé";
            treeNode5.Name = "Code source site web";
            treeNode5.Text = "Code source site web";
            treeNode6.Name = "Formulaire de contact personnalisé";
            treeNode6.Text = "Formulaire de contact personnalisé";
            treeNode7.Name = "Image flottante";
            treeNode7.Text = "Image flottante";
            treeNode8.Name = "InfoBulle";
            treeNode8.Text = "InfoBulle";
            treeNode9.Name = "Compétences";
            treeNode9.Text = "Compétences";
            treeNode10.Name = "AddFindPlayer";
            treeNode10.Text = "AddFindPlayer";
            treeNode11.Name = "Morpion";
            treeNode11.Text = "Morpion";
            treeNode12.Name = "Pendu";
            treeNode12.Text = "Pendu";
            treeNode13.Name = "Snake";
            treeNode13.Text = "Snake";
            treeNode14.Name = "Jeux";
            treeNode14.Text = "Jeux";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode9,
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(263, 1000);
            this.treeView1.TabIndex = 1;
            // 
            // gbRecent
            // 
            this.gbRecent.BackColor = System.Drawing.Color.Transparent;
            this.gbRecent.Controls.Add(this.panelRecent);
            this.gbRecent.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.gbRecent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbRecent.Location = new System.Drawing.Point(540, 12);
            this.gbRecent.Name = "gbRecent";
            this.gbRecent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbRecent.Size = new System.Drawing.Size(413, 70);
            this.gbRecent.TabIndex = 61;
            this.gbRecent.TabStop = false;
            this.gbRecent.Text = "Récent";
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
            // FormArborescence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Skill_Project.Properties.Resources.yuyukyuk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormArborescence";
            this.Text = "Vue en arborescence";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormArborescence_Load);
            this.Leave += new System.EventHandler(this.FormArborescence_Leave);
            this.panel1.ResumeLayout(false);
            this.gbTri.ResumeLayout(false);
            this.gbTri.PerformLayout();
            this.gbRecent.ResumeLayout(false);
            this.panelRecent.ResumeLayout(false);
            this.panelRecent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
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
    }
}