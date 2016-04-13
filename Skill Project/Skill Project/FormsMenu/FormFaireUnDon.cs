using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Project
{
    public partial class FormFaireUnDon : System.Windows.Forms.Form
    {
        int durationMilliseconds = 3000;

        public FormFaireUnDon()
        {
            InitializeComponent();
        }

        private void FormFaireUnDon_Load(object sender, EventArgs e)
        {
            label1.Text = "Derrière cette application, beaucoup de ressources ont été épuisées et des centaines\nd'heures se sont déroulées afin de vous rendre un travail de qualité.\nAppréciez le boulot fournis et Soutenez Skill project en effectuant un don.";
            radioButton1.Select();

            panel1.AutoScroll = false;
            panel1.AutoScrollMinSize = new Size(0, 0);
            btnRetourFUD.Location = new Point(430, 470);
            webBrowser1.Visible = false;

            webBrowser1.Navigate("https://www.paypal.com/fr/cgi-bin/webscr?cmd=_flow&SESSION=pC7KUR60wFW2hrWorWOreFZUtSdZa-AYcNMt7FlfJtHnSo4wl48-B3W00h8&dispatch=5885d80a13c0db1f8e263663d3faee8d64ad11bbf4d2a5a1a0d303a50933f9b2");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "https://www.paypal.com/fr/cgi-bin/webscr?cmd=_flow&SESSION=pC7KUR60wFW2hrWorWOreFZUtSdZa-AYcNMt7FlfJtHnSo4wl48-B3W00h8&dispatch=5885d80a13c0db1f8e263663d3faee8d64ad11bbf4d2a5a1a0d303a50933f9b2";
            p.Start();

            radioButton1.Select();

            panel1.AutoScroll = false;
            panel1.AutoScrollMinSize = new Size(0, 0);
            btnRetourFUD.Location = new Point(430, 470);
            webBrowser1.Visible = false;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(toolTip1.GetToolTip(label2), label2, durationMilliseconds);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show(toolTip2.GetToolTip(label3), label3, durationMilliseconds);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = new Size(0, 1400);
            btnRetourFUD.Location = new Point(430, 1318);

            webBrowser1.Visible = true;
        }

        private void btnRetourFUD_Click(object sender, EventArgs e)
        {
            FormIndex FI = (FormIndex)this.MdiParent;

            if (FI.nb == 1) // dehors
            {

                FI.SfsfToolStripMenuItem.Enabled = true;
                FI.AfficToolStripMenuItem.Enabled = true;
                FI.CommentÇaMarcheToolStripMenuItem.Enabled = true;
                FI.QuiSommesNousToolStripMenuItem.Enabled = true;

                this.Close();
                
                FI.AfficToolStripMenuItem.BackColor = Color.Transparent;

                
                FI.PictureBox1.Visible = true;
                var pos = FI.PointToScreen(FI.LblCreateur.Location);
                pos = FI.PictureBox1.PointToClient(pos);
                FI.LblCreateur.Parent = FI.PictureBox1;
                FI.LblCreateur.Location = pos;
                FI.LblCreateur.BackColor = Color.Transparent;
            }
            else // dedans
            {
                FI.QuitterToolStripMenuItem.Enabled = true;
                FI.AffichageToolStripMenuItem.Enabled = true;
                FI.AfficToolStripMenuItem.Enabled = true;
                FI.CommentÇaMarcheToolStripMenuItem.Enabled = true;
                FI.QuiSommesNousToolStripMenuItem.Enabled = true;
                FI.SuggestionToolStripMenuItem.Enabled = true;

                if (FI.ListeToolStripMenuItem.Enabled == false)
                {
                    FormListe FL = new FormListe();
                    FL.MdiParent = FI;
                    FL.Show();
                }

                if (FI.MiniaturesToolStripMenuItem.Enabled == false)
                {
                    FormMiniature FM = new FormMiniature();
                    FM.MdiParent = FI;
                    FM.Show();
                }

                if (FI.ArborescenceToolStripMenuItem.Enabled == false)
                {
                    FormArborescence FA = new FormArborescence();
                    FA.MdiParent = FI;
                    FA.Show();
                }

                this.Close();

                FI.AfficToolStripMenuItem.BackColor = Color.Transparent;
                FI.AffichageToolStripMenuItem.BackColor = Color.SandyBrown;
            }
        }

        private void FormFaireUnDon_Enter(object sender, EventArgs e)
        {

        }

        private void FormFaireUnDon_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
