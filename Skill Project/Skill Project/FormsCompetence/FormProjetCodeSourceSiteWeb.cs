using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Project.FormsCompetence
{
    public partial class FormProjetCodeSourceSiteWeb : Form
    {
        private string arrivage;

        List<string> LangueElement = new List<string>();

        public FormProjetCodeSourceSiteWeb(string provenance)
        {
            InitializeComponent();
            arrivage = provenance;
        }

        private void pbRetour_Click(object sender, EventArgs e)
        {
            FormIndex FI = (FormIndex)this.MdiParent;

            if (arrivage == "index")
            {
                FI.PictureBox1.Visible = true;
                var pos = FI.PointToScreen(FI.LblCreateur.Location);
                pos = FI.PictureBox1.PointToClient(pos);
                FI.LblCreateur.Parent = FI.PictureBox1;
                FI.LblCreateur.Location = pos;
                FI.LblCreateur.BackColor = Color.Transparent;
            }

            if (arrivage == "liste")
            {
                FormListe FS = new FormListe();
                FS.MdiParent = FI;

                FS.Show();
            }

            if (arrivage == "miniature")
            {
                FormMiniature FS = new FormMiniature();
                FS.MdiParent = FI;

                FS.Show();
            }

            if (arrivage == "arborescence")
            {
                FormArborescence FS = new FormArborescence();
                FS.MdiParent = FI;

                FS.Show();
            }

            this.Close();
        }

        private void FormProjetCodeSourceSiteWeb_Load(object sender, EventArgs e)
        {
            LangueElement = Fonction.LangageAppli();
            this.Text = LangueElement[181];
            lblTitreCSSW.Text = LangueElement[181];
            btnCSSW.Text = LangueElement[182];
            rtbCSSW.Text = LangueElement[183];

            Fonction.policeTexte(this); // Gestion police
        }

        private void FormProjetCodeSourceSiteWeb_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbCode_Click(object sender, EventArgs e)
        {
            string[] recupCode = Fonction.lireCodeProjet(@"CSSW\CodeCSSW.txt");
            tbCode.Text = "";
            tbCode.ReadOnly = true;
            tbCode.BorderStyle = 0;
            tbCode.TabStop = false;
            tbCode.Visible = true;
            pbRetour.Visible = false;

            tbCode.Lines = recupCode;

            tbCode.BringToFront();

            pbCode.Visible = false;
            pbRetourForm.Visible = true;
            tbCode.Visible = true;

            pbRetourForm.BringToFront();

            var pos = this.PointToScreen(pbRetourForm.Location);
            pos = tbCode.PointToClient(pos);
            pbRetourForm.Parent = tbCode;
            pbRetourForm.Location = pos;
            pbRetourForm.BackColor = Color.Transparent;
        }

        private void pbRetourForm_Click(object sender, EventArgs e)
        {
            tbCode.Visible = false;
            pbCode.Visible = true;
            pbRetourForm.Visible = false;
            tbCode.Visible = false;
            pbRetour.Visible = true;
        }

        private void tbURL_Click(object sender, EventArgs e)
        {
            tbURL.Clear();

            tbURL.Clear(); // Palatino Linotype; 12pt; style=Bold
            tbURL.Cursor = Cursors.IBeam;
            tbURL.ForeColor = Color.Black;
        }

        private void tbURL_Enter(object sender, EventArgs e)
        {
            tbURL_Click(sender, e);
        }

        private void tbURL_Leave(object sender, EventArgs e)
        {
            if (tbURL.Text == "URL" || tbURL.Text == "" || tbURL.Text == " ")
            {
                tbURL.ForeColor = Color.DarkGray;

                tbURL.Cursor = Cursors.Default;
                tbURL.Text = "URL";
            }
        }

        private void btnCSSW_Click(object sender, EventArgs e)
        {
            rtbCSSW.Clear();

            rtbCSSW.Clear(); // Palatino Linotype; 12pt; style=Bold
            rtbCSSW.Cursor = Cursors.IBeam;
            rtbCSSW.ForeColor = Color.Black;
            
            string url = tbURL.Text;

            if (url != "URL")
            {
                HttpWebRequest requete = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse reponse = (HttpWebResponse)requete.GetResponse();
                StreamReader sr = new StreamReader(reponse.GetResponseStream());
                rtbCSSW.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
