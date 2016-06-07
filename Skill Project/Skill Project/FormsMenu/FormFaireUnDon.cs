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

        List<string> LangueElement = new List<string>();

        public FormFaireUnDon()
        {
            InitializeComponent();
        }

        private void FormFaireUnDon_Load(object sender, EventArgs e)
        {
            LangueElement = Fonction.LangageAppli();
            this.Text = LangueElement[97];
            lblTitreFUD.Text = LangueElement[97];
            label3.Text = LangueElement[98];
            label2.Text = LangueElement[99];
            btnRetourFUD.Text = LangueElement[100];
            toolTip2.ToolTipTitle = LangueElement[101];

            Fonction.policeTexte(this); // Gestion police

            label1.Text = LangueElement[102] + "\n" + LangueElement[103] + "\n" + LangueElement[104];
            radioButton1.Select();

            panel1.AutoScroll = false;
            panel1.AutoScrollMinSize = new Size(0, 0);
            btnRetourFUD.Location = new Point(430, 470);
            webBrowser1.Visible = false;

            webBrowser1.Navigate("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=XW7DWPCENB2C8");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=XW7DWPCENB2C8";
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
            FormIndex form = (FormIndex)this.MdiParent;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormFaireUnDon_MouseEnter(object sender, EventArgs e)
        {

        }

        private void FormFaireUnDon_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
