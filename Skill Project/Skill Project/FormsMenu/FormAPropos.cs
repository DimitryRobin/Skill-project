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
    public partial class FormAPropos : System.Windows.Forms.Form
    {

        List<string> LangueElement = new List<string>();

        public FormAPropos()
        {
            InitializeComponent();
        }

        private void btnRetourAP_Click(object sender, EventArgs e)
        {
            FormIndex FI = (FormIndex)this.MdiParent;

            if (FI.nb == 1) // dehors
            {

                FI.SfsfToolStripMenuItem.Enabled = true;
                FI.AfficToolStripMenuItem.Enabled = true;
                FI.CommentÇaMarcheToolStripMenuItem.Enabled = true;
                FI.QuiSommesNousToolStripMenuItem.Enabled = true;

                this.Close();
                
                FI.CommentÇaMarcheToolStripMenuItem.BackColor = Color.Transparent;

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
                
                FI.AffichageToolStripMenuItem.BackColor = Color.SandyBrown;
                FI.CommentÇaMarcheToolStripMenuItem.BackColor = Color.Transparent;
            }
        }

        private void FormAPropos_Load(object sender, EventArgs e)
        {
            LangueElement = Fonction.LangageAppli();
            this.Text = LangueElement[73];
            lblTitreAP.Text = LangueElement[73];
            btnRetourAP.Text = LangueElement[74];

            Fonction.policeTexte(this); // Gestion police

            radioButton1.Select();
            label1.Text = LangueElement[75] + "\n" + LangueElement[76] + "\n" + LangueElement[77] + "\n\n" +
                LangueElement[78] + "\n\n" + LangueElement[79] + "\n" + LangueElement[80] + "\n" + LangueElement[81] + "\n\n" +
                LangueElement[82] + "\n\n" + LangueElement[83] + "\n" + LangueElement[84] + "\n" + LangueElement[85] + "\n\n" +
                LangueElement[86] + "\n" + LangueElement[87] + "\n" + LangueElement[88] + "\n\n" + LangueElement[89] + "\n" +
                LangueElement[90] + "\n" + LangueElement[91] + "\n" + LangueElement[92] + "\n" + LangueElement[93];

        }
    }
}
