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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 561);
            this.panel1.TabIndex = 8;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
    }
}