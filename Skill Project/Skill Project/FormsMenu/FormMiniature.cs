using Skill_Project.FormsCompetence.Pendu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Project
{
    public partial class FormMiniature : Form
    {
        List<string> ListeProjet = new List<string>();
        List<string> Preference = new List<string>();
        List<string> Destination = new List<string>();

        List<string> LangueElement = new List<string>();

        private Joueur nouvJoueur;
        private List<Joueur> lesJoueurs = new List<Joueur>();

        string police;
        string dateRecent1, Recent1, dateRecent2, Recent2, dateRecent3, Recent3;


        public FormMiniature()
        {
            InitializeComponent();
            Preference = Fonction.Preference();
            ListeProjet = Fonction.LectureProjet();
            police = Preference[2];
            dateRecent1 = Preference[7];
            Recent1 = Preference[6];
            dateRecent2 = Preference[9];
            Recent2 = Preference[8];
            dateRecent3 = Preference[11];
            Recent3 = Preference[10];
        }

        private void Chargement()
        {
            if (cbRecherche.Text == "" || cbRecherche.Text == LangueElement[134])
            {
                int count = 0;

                panel1.Controls.Clear();

                foreach (var item0 in ListeProjet)
                {
                    count++;
                }

                int count2 = 0;
                int y = 10;
                int yy = 10;

                foreach (var item in ListeProjet)
                {
                    // string[] nomProjet = item.Split(new[] { " /// " }, StringSplitOptions.None);

                    string[] result = Regex.Split(item, @"\-\-\-");


                    if (count2 <= (count / 2))
                    {
                        Label article = new Label();
                        Label date = new Label();
                        PictureBox logo = new PictureBox();
                        logo.ImageLocation = @"..\..\Resources\" + result[2];
                        logo.SizeMode = PictureBoxSizeMode.Zoom;
                        logo.BackgroundImageLayout = ImageLayout.Stretch;
                        article.Text = result[0];
                        date.Text = result[1];
                        article.Font = new Font(police, lblrecherche.Font.SizeInPoints + 4, FontStyle.Bold);
                        date.Font = new Font(police, lblrecherche.Font.SizeInPoints + 3, FontStyle.Italic);
                        article.Click += new EventHandler(LB_Click);
                        article.MouseHover += new EventHandler(recent1_MouseHover);
                        logo.Size = new Size(60, 60);
                        article.BackColor = Color.Transparent;
                        article.AutoSize = true;
                        article.SetBounds(90, y, 200, 10);
                        date.BackColor = Color.Transparent;
                        date.AutoSize = true;
                        date.SetBounds(90, y + 30, 200, 10);
                        logo.SetBounds(20, y, 60, 60);
                        panel1.Controls.AddRange(new Control[] { article, date, logo });

                        y = y + 60;
                    }
                    else if (count2 > (count / 2))
                    {
                        Label article = new Label();
                        Label date = new Label();
                        PictureBox logo = new PictureBox();
                        logo.ImageLocation = @"..\..\Resources\" + result[2];
                        logo.SizeMode = PictureBoxSizeMode.Zoom;
                        logo.BackgroundImageLayout = ImageLayout.Stretch;
                        logo.Size = new Size(60, 60);
                        logo.SetBounds(450, yy, 60, 60);
                        article.Text = result[0];
                        date.Text = result[1];
                        article.Font = new Font(police, lblrecherche.Font.SizeInPoints + 4, FontStyle.Bold);
                        date.Font = new Font(police, lblrecherche.Font.SizeInPoints + 3, FontStyle.Italic);
                        article.Click += new EventHandler(LB_Click);
                        article.MouseHover += new EventHandler(recent1_MouseHover);
                        article.BackColor = Color.Transparent;
                        article.AutoSize = true;
                        article.SetBounds(540, yy, 200, 10);
                        date.BackColor = Color.Transparent;
                        date.AutoSize = true;
                        date.SetBounds(540, yy + 30, 200, 10);
                        panel1.Controls.AddRange(new Control[] { article, date, logo });

                        yy = yy + 60;
                    }

                    count2++;
                }

                if (y > yy)
                {
                    panel1.AutoScrollMinSize = new Size(0, y + 40);
                    panel1.BackgroundImage = Skill_Project.Properties.Resources.yuyukyuk;
                }
                else
                {
                    panel1.AutoScrollMinSize = new Size(0, yy + 40);
                    panel1.BackgroundImage = Skill_Project.Properties.Resources.yuyukyuk;
                }
            }
            else
            {
                int count = 0;
                string res = "";

                panel1.Controls.Clear();

                foreach (var item0 in ListeProjet)
                {
                    if (cbRecherche.Text.Length > 25)
                    {
                        res = cbRecherche.Text.Substring(0, 24);

                        if (item0.Contains(res))
                        {
                            count++;
                        }
                    }
                    else
                    {
                        res = cbRecherche.Text;

                        if (item0.Contains(cbRecherche.Text))
                        {
                            count++;
                        }
                    }
                }

                int count2 = 0;
                int y = 10;
                int yy = 10;

                foreach (var item in ListeProjet)
                {
                    // string[] nomProjet = item.Split(new[] { " /// " }, StringSplitOptions.None);


                    string[] result = Regex.Split(item, @"\-\-\-");

                    if (count2 <= (count / 2))
                    {
                        if (result[0].Contains(res))
                        {
                            Label article = new Label();
                            Label date = new Label();
                            PictureBox logo = new PictureBox();
                            logo.ImageLocation = @"..\..\Resources\" + result[2];
                            logo.SizeMode = PictureBoxSizeMode.Zoom;
                            logo.BackgroundImageLayout = ImageLayout.Stretch;
                            article.Text = result[0];
                            date.Text = result[1];
                            article.Font = new Font(police, lblrecherche.Font.SizeInPoints + 4, FontStyle.Bold);
                            date.Font = new Font(police, lblrecherche.Font.SizeInPoints + 3, FontStyle.Italic);
                            article.Click += new EventHandler(LB_Click);
                            article.MouseHover += new EventHandler(recent1_MouseHover);
                            logo.Size = new Size(60, 60);
                            article.BackColor = Color.Transparent;
                            article.AutoSize = true;
                            article.SetBounds(90, y, 200, 10);
                            date.BackColor = Color.Transparent;
                            date.AutoSize = true;
                            date.SetBounds(90, y + 30, 200, 10);
                            logo.SetBounds(20, y, 60, 60);
                            panel1.Controls.AddRange(new Control[] { article, date, logo });

                            y = y + 60;
                            count2++;
                        }

                    }
                    else if (count2 > (count / 2))
                    {
                        if (result[0].Contains(res))
                        {
                            Label article = new Label();
                            Label date = new Label();
                            PictureBox logo = new PictureBox();
                            logo.ImageLocation = @"..\..\Resources\" + result[2];
                            logo.SizeMode = PictureBoxSizeMode.Zoom;
                            logo.BackgroundImageLayout = ImageLayout.Stretch;
                            logo.Size = new Size(60, 60);
                            logo.SetBounds(450, yy, 60, 60);
                            article.Text = result[0];
                            date.Text = result[1];
                            article.Font = new Font(police, lblrecherche.Font.SizeInPoints + 4, FontStyle.Bold);
                            date.Font = new Font(police, lblrecherche.Font.SizeInPoints + 3, FontStyle.Italic);
                            article.Click += new EventHandler(LB_Click);
                            article.MouseHover += new EventHandler(recent1_MouseHover);
                            article.BackColor = Color.Transparent;
                            article.AutoSize = true;
                            article.SetBounds(540, yy, 200, 10);
                            date.BackColor = Color.Transparent;
                            date.AutoSize = true;
                            date.SetBounds(540, yy + 30, 200, 10);
                            panel1.Controls.AddRange(new Control[] { article, date, logo });

                            yy = yy + 60;
                            count2++;
                        }
                    }


                }

                if (y > yy)
                {
                    panel1.AutoScrollMinSize = new Size(0, y + 40);
                    panel1.BackgroundImage = Skill_Project.Properties.Resources.yuyukyuk;
                }
                else
                {
                    panel1.AutoScrollMinSize = new Size(0, yy + 40);
                    panel1.BackgroundImage = Skill_Project.Properties.Resources.yuyukyuk;
                }
            }

        }

        private void FormSkillProject_Load(object sender, EventArgs e)
        {
            LangueElement = Fonction.LangageAppli();
            this.Text = LangueElement[129];
            gbTri.Text = LangueElement[130];
            rbDateAjout.Text = LangueElement[131];
            gbRecherche.Text = LangueElement[132];
            lblrecherche.Text = LangueElement[133];
            cbRecherche.Text = LangueElement[134];
            gbRecent.Text = LangueElement[135];

            Fonction.policeTexte(this); // Gestion police

            cbRecherche.Items.Clear();

            lblDate1.Text = dateRecent1;
            lblDate2.Text = dateRecent2;
            lblDate3.Text = dateRecent3;
            recent1.Text = Recent1;
            recent2.Text = Recent2;
            recent3.Text = Recent3;

            if (Recent1 != "Aucun")
            {
                lblDate1.Text = dateRecent1;
                recent1.Text = Recent1;
                lblDate1.Visible = true;
                recent1.Visible = true;
            }
            else
            {
                lblDate1.Visible = false;
                recent1.Visible = false;
            }

            if (Recent2 != "Aucun")
            {
                lblDate2.Text = dateRecent2;
                recent2.Text = Recent2;
                lblDate2.Visible = true;
                recent2.Visible = true;
            }
            else
            {
                lblDate2.Visible = false;
                recent2.Visible = false;
            }

            if (Recent3 != "Aucun")
            {
                lblDate3.Text = dateRecent3;
                recent3.Text = Recent3;
                lblDate3.Visible = true;
                recent3.Visible = true;
            }
            else
            {
                lblDate3.Visible = false;
                recent3.Visible = false;
            }

            if (Recent1 == "Aucun" && Recent2 == "Aucun" && Recent3 == "Aucun")
            {
                gbRecent.Visible = false;
            }
            else
            {
                gbRecent.Visible = true;
            }

            foreach (var item in ListeProjet)
            {
                // string[] nomProjet = item.Split(new[] { " /// " }, StringSplitOptions.None);

                string[] result = Regex.Split(item, @"\-\-\-");
                
                if (result[0].Length > 25)
                {
                    string res = result[0].Substring(0, 25);
                    res = res + "..";
                    cbRecherche.Items.Add(res);
                }
                else
                {
                    cbRecherche.Items.Add(result[0]);
                }

                Destination.Add(result[0]);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void FormSkillProject_Leave(object sender, EventArgs e)
        {
            FormIndex FI = (FormIndex)this.MdiParent;
            FI.accesRapide();
            this.Close();
        }

        private void rbAZ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbZA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbRecherche_Leave(object sender, EventArgs e)
        {
            if (cbRecherche.Text == LangueElement[134] || cbRecherche.Text == "" || cbRecherche.Text == " ")
            {
                cbRecherche.ForeColor = Color.DarkGray;
                cbRecherche.Text = LangueElement[134];
            }
        }

        private void cbRecherche_Click(object sender, EventArgs e)
        {
            cbRecherche.Text = "";
            cbRecherche.ForeColor = Color.Black;
        }

        private void cbRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbRecherche_TextChanged(object sender, EventArgs e)
        {
            panel1.AutoScrollMinSize = new Size(0, 0);

            Chargement();
        }

        private void recent1_Click(object sender, EventArgs e)
        {

        }

        private void recent1_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void rbAZ_Click(object sender, EventArgs e)
        {
            panel1.AutoScrollMinSize = new Size(0, 0);

            ListeProjet.Sort();
            Chargement();
        }

        private void rbZA_Click(object sender, EventArgs e)
        {
            panel1.AutoScrollMinSize = new Size(0, 0);

            ListeProjet.Reverse();
            Chargement();
        }

        public void TriDate()
        {
            int count = 0;
            List<String> TriDatee = new List<String>();

            foreach (var item0 in ListeProjet)
            {
                count++;
            }

            foreach (var item in ListeProjet)
            {
                // string[] nomProjet = item.Split(new[] { " /// " }, StringSplitOptions.None);

                string[] result = Regex.Split(item, @"\-\-\-");

                if (result[1] != "jj/mm/aaaa" && result[1] != "dd/mm/yyyy")
                {
                    TriDatee.Add(result[1]);
                }
            }

            TriDatee = TriDatee.OrderByDescending(o => o).ToList();

            int count2 = 0;
            int y = 10;
            int yy = 10;
            int i = 0;


            panel1.Controls.Clear();

        ici:

            foreach (var item in ListeProjet)
            {
                string[] result = Regex.Split(item, @"\-\-\-");

                if (result[1] == TriDatee[i].ToString())
                {

                    if (count2 <= (TriDatee.Count / 2))
                    {

                        Label article = new Label();
                        Label date = new Label();
                        PictureBox logo = new PictureBox();
                        logo.ImageLocation = @"..\..\Resources\"+result[2];
                        logo.SizeMode = PictureBoxSizeMode.Zoom;
                        logo.BackgroundImageLayout = ImageLayout.Stretch;
                        article.Text = result[0];
                        date.Text = result[1];
                        article.Font = new Font(police, lblrecherche.Font.SizeInPoints+4, FontStyle.Bold);
                        date.Font = new Font(police, lblrecherche.Font.SizeInPoints+3, FontStyle.Italic);
                        article.Click += new EventHandler(LB_Click);
                        article.MouseHover += new EventHandler(recent1_MouseHover);
                        logo.Size = new Size(60, 60);
                        article.BackColor = Color.Transparent;
                        article.AutoSize = true;
                        article.SetBounds(90, y, 200, 10);
                        date.BackColor = Color.Transparent;
                        date.AutoSize = true;
                        date.SetBounds(90, y + 30, 200, 10);
                        logo.SetBounds(20, y, 60, 60);
                        panel1.Controls.AddRange(new Control[] { article, date, logo });

                        y = y + 60;

                    }
                    else if (count2 > (TriDatee.Count / 2))
                    {

                        Label article = new Label();
                        Label date = new Label();
                        PictureBox logo = new PictureBox();
                        logo.ImageLocation = @"..\..\Resources\" + result[2];
                        logo.SizeMode = PictureBoxSizeMode.Zoom;
                        logo.BackgroundImageLayout = ImageLayout.Stretch;
                        logo.Size = new Size(60, 60);
                        logo.SetBounds(470, yy, 60, 60);
                        article.Text = result[0];
                        date.Text = result[1];
                        article.Font = new Font(police, lblrecherche.Font.SizeInPoints+4, FontStyle.Bold);
                        date.Font = new Font(police, lblrecherche.Font.SizeInPoints+3, FontStyle.Italic);
                        article.Click += new EventHandler(LB_Click);
                        article.MouseHover += new EventHandler(recent1_MouseHover);
                        article.BackColor = Color.Transparent;
                        article.AutoSize = true;
                        article.SetBounds(540, yy, 200, 10);
                        date.BackColor = Color.Transparent;
                        date.AutoSize = true;
                        date.SetBounds(540, yy + 30, 200, 10);
                        panel1.Controls.AddRange(new Control[] { article, date, logo });

                        yy = yy + 60;

                    }

                    count2++;

                    if (i < (TriDatee.Count - 1))
                    {
                        i++;
                        goto ici;
                    }
                }
            }

            if (y > yy)
            {
                panel1.AutoScrollMinSize = new Size(0, y + 40);
                panel1.BackgroundImage = Skill_Project.Properties.Resources.yuyukyuk;
            }
            else
            {
                panel1.AutoScrollMinSize = new Size(0, yy + 40);
                panel1.BackgroundImage = Skill_Project.Properties.Resources.yuyukyuk;
            }
        }

        private void rbDateAjout_Click(object sender, EventArgs e)
        {
            panel1.AutoScrollMinSize = new Size(0, 0);

            cbRecherche.ForeColor = Color.DarkGray;
            cbRecherche.Text = LangueElement[134];
            TriDate();
        }

        protected void LB_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            List<String> Item2 = new List<String>();

            string dt = DateTime.Today.ToShortDateString();

            // MessageBox.Show(lbl.Text);
            // MessageBox.Show(Destination[0].ToString());

            if (lbl.Text == Destination[0].ToString())
            {
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);

                FormIndex form = (FormIndex)this.MdiParent;
                FormsCompetence.FormProjetCalculatrice FPC = new FormsCompetence.FormProjetCalculatrice();
                FPC.MdiParent = form;
                FPC.Show();
            }

            if (lbl.Text == Destination[1].ToString())
            {
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);

                FormIndex form = (FormIndex)this.MdiParent;
                FormsCompetence.FormProjetBarreProgCirculaire FPC = new FormsCompetence.FormProjetBarreProgCirculaire();
                FPC.MdiParent = form;
                FPC.Show();
            }

            if (lbl.Text == Destination[2].ToString())
            {
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);

                FormIndex form = (FormIndex)this.MdiParent;
                FormsCompetence.FormProjetBoutonAnime FPC = new FormsCompetence.FormProjetBoutonAnime();
                FPC.MdiParent = form;
                FPC.Show();
            }

            if (lbl.Text == Destination[3].ToString())
            {
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);

                FormIndex form = (FormIndex)this.MdiParent;
                FormsCompetence.FormProjetCodeSourceSiteWeb FPC = new FormsCompetence.FormProjetCodeSourceSiteWeb();
                FPC.MdiParent = form;
                FPC.Show();
            }
            if (lbl.Text == Destination[4].ToString())
            {
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);

                FormIndex form = (FormIndex)this.MdiParent;
                FormsCompetence.FormProjetFormulaireContactPersonnalise FPC = new FormsCompetence.FormProjetFormulaireContactPersonnalise();
                FPC.MdiParent = form;
                FPC.Show();
            }

            if (lbl.Text == Destination[5].ToString())
            {
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);

                FormIndex form = (FormIndex)this.MdiParent;
                FormsCompetence.FormProjetImageFlottante FPC = new FormsCompetence.FormProjetImageFlottante();
                FPC.MdiParent = form;
                FPC.Show();
            }

            if (lbl.Text == Destination[6].ToString())
            {
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);

                FormIndex form = (FormIndex)this.MdiParent;
                FormsCompetence.FormProjetInfoBulle FPC = new FormsCompetence.FormProjetInfoBulle();
                FPC.MdiParent = form;
                FPC.Show();
            }

            if (lbl.Text == Destination[7].ToString())
            {
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);

                FormIndex form = (FormIndex)this.MdiParent;
                FormsCompetence.FormProjetAddFindPlayer FPC = new FormsCompetence.FormProjetAddFindPlayer();
                FPC.MdiParent = form;
                FPC.Show();
            }

            if (lbl.Text == Destination[8].ToString())
            {
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);

                FormIndex form = (FormIndex)this.MdiParent;
                FormsCompetence.FormProjetMorpion FPC = new FormsCompetence.FormProjetMorpion();
                FPC.MdiParent = form;
                FPC.Show();
            }

            if (lbl.Text == Destination[9].ToString())
            {
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);

            recommence:

                string value = "Pseudonyme";
                bool check = false;

                if (Fonction.InputBoxLogin("Pendu", LangueElement[172], ref value, ref check) == DialogResult.OK)
                {
                    if (check == false)
                    {
                        if (value != "Pseudonyme" && value != "" && value != " " && value != "  " && value != "   " && value != "    " && value != "     ")
                        {
                            nouvJoueur = new Joueur(value);
                            lesJoueurs.Add(nouvJoueur);
                            nouvJoueur.ModifNbPartie();

                            nouvJoueur.AfficherJoueur();

                            FormIndex form = (FormIndex)this.MdiParent;
                            FormsCompetence.FormProjetPendu FPC = new FormsCompetence.FormProjetPendu(value, nouvJoueur, lesJoueurs, "miniature");
                            FPC.MdiParent = form;
                            FPC.Show();
                        }
                        else
                        {
                            MessageBox.Show(LangueElement[174], LangueElement[173], MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            goto recommence;
                        }
                    }
                    else
                    {
                        nouvJoueur = new Joueur("Guest");
                        lesJoueurs.Add(nouvJoueur);
                        nouvJoueur.ModifNbPartie();

                        nouvJoueur.AfficherJoueur();

                        FormIndex form = (FormIndex)this.MdiParent;
                        FormsCompetence.FormProjetPendu FPC = new FormsCompetence.FormProjetPendu("Guest", nouvJoueur, lesJoueurs, "miniature");
                        FPC.MdiParent = form;
                        FPC.Show();
                    }
                }
            }

            if (lbl.Text == Destination[10].ToString())
            {
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);

                FormIndex form = (FormIndex)this.MdiParent;
                FormsCompetence.FormProjetSnake FPC = new FormsCompetence.FormProjetSnake();
                FPC.MdiParent = form;
                FPC.Show();
            }
        }
    }
}
