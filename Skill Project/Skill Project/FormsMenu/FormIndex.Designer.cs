using System.Windows.Forms;

namespace Skill_Project
{
    partial class FormIndex
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndex));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCreateur = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentÇaMarcheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiSommesNousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suggestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfsfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arborescenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblAccesRapide = new System.Windows.Forms.Label();
            this.lblACDate1 = new System.Windows.Forms.Label();
            this.lblACDate3 = new System.Windows.Forms.Label();
            this.lblACDate2 = new System.Windows.Forms.Label();
            this.lblACNom1 = new System.Windows.Forms.Label();
            this.lblACNom3 = new System.Windows.Forms.Label();
            this.lblACNom2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::Skill_Project.Properties.Resources.abstract_wallpaper_by_justin_maller;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCreateur
            // 
            resources.ApplyResources(this.lblCreateur, "lblCreateur");
            this.lblCreateur.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateur.Name = "lblCreateur";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.paramètreToolStripMenuItem,
            this.afficToolStripMenuItem,
            this.commentÇaMarcheToolStripMenuItem,
            this.quiSommesNousToolStripMenuItem,
            this.suggestionToolStripMenuItem,
            this.sfsfToolStripMenuItem,
            this.affichageToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.quitterToolStripMenuItem, "quitterToolStripMenuItem");
            this.quitterToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // paramètreToolStripMenuItem
            // 
            this.paramètreToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.paramètreToolStripMenuItem, "paramètreToolStripMenuItem");
            this.paramètreToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.paramètreToolStripMenuItem.Name = "paramètreToolStripMenuItem";
            this.paramètreToolStripMenuItem.Click += new System.EventHandler(this.paramètreToolStripMenuItem_Click);
            // 
            // afficToolStripMenuItem
            // 
            this.afficToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.afficToolStripMenuItem, "afficToolStripMenuItem");
            this.afficToolStripMenuItem.Name = "afficToolStripMenuItem";
            this.afficToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.afficToolStripMenuItem.Click += new System.EventHandler(this.afficToolStripMenuItem_Click);
            // 
            // commentÇaMarcheToolStripMenuItem
            // 
            this.commentÇaMarcheToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.commentÇaMarcheToolStripMenuItem, "commentÇaMarcheToolStripMenuItem");
            this.commentÇaMarcheToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.commentÇaMarcheToolStripMenuItem.Name = "commentÇaMarcheToolStripMenuItem";
            this.commentÇaMarcheToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.commentÇaMarcheToolStripMenuItem.Click += new System.EventHandler(this.commentÇaMarcheToolStripMenuItem_Click);
            // 
            // quiSommesNousToolStripMenuItem
            // 
            this.quiSommesNousToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.quiSommesNousToolStripMenuItem, "quiSommesNousToolStripMenuItem");
            this.quiSommesNousToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.quiSommesNousToolStripMenuItem.Name = "quiSommesNousToolStripMenuItem";
            this.quiSommesNousToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quiSommesNousToolStripMenuItem.Click += new System.EventHandler(this.quiSommesNousToolStripMenuItem_Click);
            // 
            // suggestionToolStripMenuItem
            // 
            this.suggestionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.suggestionToolStripMenuItem, "suggestionToolStripMenuItem");
            this.suggestionToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.suggestionToolStripMenuItem.Name = "suggestionToolStripMenuItem";
            this.suggestionToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.suggestionToolStripMenuItem.Click += new System.EventHandler(this.suggestionToolStripMenuItem_Click);
            // 
            // sfsfToolStripMenuItem
            // 
            resources.ApplyResources(this.sfsfToolStripMenuItem, "sfsfToolStripMenuItem");
            this.sfsfToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.sfsfToolStripMenuItem.Name = "sfsfToolStripMenuItem";
            this.sfsfToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sfsfToolStripMenuItem.Click += new System.EventHandler(this.sfsfToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeToolStripMenuItem,
            this.miniaturesToolStripMenuItem,
            this.arborescenceToolStripMenuItem});
            resources.ApplyResources(this.affichageToolStripMenuItem, "affichageToolStripMenuItem");
            this.affichageToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.affichageToolStripMenuItem.Click += new System.EventHandler(this.affichageToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            resources.ApplyResources(this.listeToolStripMenuItem, "listeToolStripMenuItem");
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // miniaturesToolStripMenuItem
            // 
            this.miniaturesToolStripMenuItem.Name = "miniaturesToolStripMenuItem";
            resources.ApplyResources(this.miniaturesToolStripMenuItem, "miniaturesToolStripMenuItem");
            this.miniaturesToolStripMenuItem.Click += new System.EventHandler(this.miniaturesToolStripMenuItem_Click);
            // 
            // arborescenceToolStripMenuItem
            // 
            this.arborescenceToolStripMenuItem.Name = "arborescenceToolStripMenuItem";
            resources.ApplyResources(this.arborescenceToolStripMenuItem, "arborescenceToolStripMenuItem");
            this.arborescenceToolStripMenuItem.Click += new System.EventHandler(this.arborescenceToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblAccesRapide
            // 
            resources.ApplyResources(this.lblAccesRapide, "lblAccesRapide");
            this.lblAccesRapide.BackColor = System.Drawing.Color.Transparent;
            this.lblAccesRapide.Name = "lblAccesRapide";
            // 
            // lblACDate1
            // 
            resources.ApplyResources(this.lblACDate1, "lblACDate1");
            this.lblACDate1.BackColor = System.Drawing.Color.Transparent;
            this.lblACDate1.Name = "lblACDate1";
            // 
            // lblACDate3
            // 
            resources.ApplyResources(this.lblACDate3, "lblACDate3");
            this.lblACDate3.BackColor = System.Drawing.Color.Transparent;
            this.lblACDate3.Name = "lblACDate3";
            this.lblACDate3.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblACDate2
            // 
            resources.ApplyResources(this.lblACDate2, "lblACDate2");
            this.lblACDate2.BackColor = System.Drawing.Color.Transparent;
            this.lblACDate2.Name = "lblACDate2";
            // 
            // lblACNom1
            // 
            resources.ApplyResources(this.lblACNom1, "lblACNom1");
            this.lblACNom1.BackColor = System.Drawing.Color.Transparent;
            this.lblACNom1.Name = "lblACNom1";
            this.lblACNom1.Click += new System.EventHandler(this.lblACNom1_Click);
            this.lblACNom1.MouseHover += new System.EventHandler(this.lblACNom1_MouseHover);
            // 
            // lblACNom3
            // 
            resources.ApplyResources(this.lblACNom3, "lblACNom3");
            this.lblACNom3.BackColor = System.Drawing.Color.Transparent;
            this.lblACNom3.Name = "lblACNom3";
            this.lblACNom3.Click += new System.EventHandler(this.lblACNom1_Click);
            this.lblACNom3.MouseHover += new System.EventHandler(this.lblACNom1_MouseHover);
            // 
            // lblACNom2
            // 
            resources.ApplyResources(this.lblACNom2, "lblACNom2");
            this.lblACNom2.BackColor = System.Drawing.Color.Transparent;
            this.lblACNom2.Name = "lblACNom2";
            this.lblACNom2.Click += new System.EventHandler(this.lblACNom1_Click);
            this.lblACNom2.MouseHover += new System.EventHandler(this.lblACNom1_MouseHover);
            // 
            // FormIndex
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblACNom2);
            this.Controls.Add(this.lblACNom3);
            this.Controls.Add(this.lblACNom1);
            this.Controls.Add(this.lblACDate2);
            this.Controls.Add(this.lblACDate3);
            this.Controls.Add(this.lblACDate1);
            this.Controls.Add(this.lblAccesRapide);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblCreateur);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormIndex";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormIndex_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.FormIndex_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCreateur;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentÇaMarcheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quiSommesNousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suggestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sfsfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miniaturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arborescenceToolStripMenuItem;
        private ToolTip toolTip1;
        private Timer timer1;
        private Label lblAccesRapide;
        private Label lblACDate1;
        private Label lblACDate3;
        private Label lblACDate2;
        private Label lblACNom1;
        private Label lblACNom3;
        private Label lblACNom2;

        public ToolStripMenuItem ArborescenceToolStripMenuItem
        {
            get
            {
                return arborescenceToolStripMenuItem;
            }

            set
            {
                arborescenceToolStripMenuItem = value;
            }
        }

        public ToolStripMenuItem QuitterToolStripMenuItem
        {
            get
            {
                return quitterToolStripMenuItem;
            }

            set
            {
                quitterToolStripMenuItem = value;
            }
        }

        public ToolStripMenuItem AfficToolStripMenuItem
        {
            get
            {
                return afficToolStripMenuItem;
            }

            set
            {
                afficToolStripMenuItem = value;
            }
        }

        public ToolStripMenuItem CommentÇaMarcheToolStripMenuItem
        {
            get
            {
                return commentÇaMarcheToolStripMenuItem;
            }

            set
            {
                commentÇaMarcheToolStripMenuItem = value;
            }
        }

        public ToolStripMenuItem QuiSommesNousToolStripMenuItem
        {
            get
            {
                return quiSommesNousToolStripMenuItem;
            }

            set
            {
                quiSommesNousToolStripMenuItem = value;
            }
        }

        public ToolStripMenuItem SuggestionToolStripMenuItem
        {
            get
            {
                return suggestionToolStripMenuItem;
            }

            set
            {
                suggestionToolStripMenuItem = value;
            }
        }

        public ToolStripMenuItem SfsfToolStripMenuItem
        {
            get
            {
                return sfsfToolStripMenuItem;
            }

            set
            {
                sfsfToolStripMenuItem = value;
            }
        }

        public ToolStripMenuItem AffichageToolStripMenuItem
        {
            get
            {
                return affichageToolStripMenuItem;
            }

            set
            {
                affichageToolStripMenuItem = value;
            }
        }

        public ToolStripMenuItem ListeToolStripMenuItem
        {
            get
            {
                return listeToolStripMenuItem;
            }

            set
            {
                listeToolStripMenuItem = value;
            }
        }

        public ToolStripMenuItem MiniaturesToolStripMenuItem
        {
            get
            {
                return miniaturesToolStripMenuItem;
            }

            set
            {
                miniaturesToolStripMenuItem = value;
            }
        }

        public ToolStripMenuItem ParamètreToolStripMenuItem
        {
            get
            {
                return paramètreToolStripMenuItem;
            }

            set
            {
                paramètreToolStripMenuItem = value;
            }
        }

        public Label LblCreateur
        {
            get
            {
                return lblCreateur;
            }

            set
            {
                lblCreateur = value;
            }
        }

        public PictureBox PictureBox1
        {
            get
            {
                return pictureBox1;
            }

            set
            {
                pictureBox1 = value;
            }
        }
    }
}

