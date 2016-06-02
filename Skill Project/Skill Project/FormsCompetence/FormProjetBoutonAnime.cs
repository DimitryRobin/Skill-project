using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Project.FormsCompetence
{
    public partial class FormProjetBoutonAnime : Form
    {
        private string arrivage;

        List<string> LangueElement = new List<string>();

        public FormProjetBoutonAnime(string provenance)
        {
            InitializeComponent();
            arrivage = provenance;
        }

        private void FormProjetBoutonAnime_Load(object sender, EventArgs e)
        {
            LangueElement = Fonction.LangageAppli();
            this.Text = LangueElement[187];
            lblTitre.Text = LangueElement[187];
            lblTexte.Text = LangueElement[188] + "\n" + LangueElement[189] + "\n" + LangueElement[190];
            animated_Button1.Text = LangueElement[191];
            animated_Button21.Text = LangueElement[191] + " 2";
            animated_Button31.Text = LangueElement[191] + " 3";

            Fonction.policeTexte(this); // Gestion police
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

        private void pbCode_Click(object sender, EventArgs e)
        {
            string[] recupCode = Fonction.lireCodeProjet(@"BoutonAnime\CodeBA.txt");
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

        private void FormProjetBoutonAnime_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
