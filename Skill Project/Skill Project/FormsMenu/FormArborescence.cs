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
    public partial class FormArborescence : Form
    {
        List<string> ListeProjet = new List<string>();
        List<string> Preference = new List<string>();
        List<string> Tempo = new List<string>();
        List<string> Destination = new List<string>();

        private Joueur nouvJoueur;
        private List<Joueur> lesJoueurs = new List<Joueur>();

        List<string> LangueElement = new List<string>();

        string police;
        string dateRecent1, Recent1, dateRecent2, Recent2, dateRecent3, Recent3;

        public FormArborescence()
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

        private void FormArborescence_Load(object sender, EventArgs e)
        {
            LangueElement = Fonction.LangageAppli();
            this.Text = LangueElement[129];
            gbTri.Text = LangueElement[130];
            rbDateAjout.Text = LangueElement[131];
            gbRecent.Text = LangueElement[135];

            Fonction.policeTexte(this); // Gestion police

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


            treeView1.Nodes.Add(LangueElement[139]);

            if (LangueElement[139] == "Accessoires")
            {
                treeView1.Nodes[0].Nodes.Add("Calculatrice");
            }
            else
            {
                treeView1.Nodes[0].Nodes.Add("Calculator");
            }
                 
            treeView1.Nodes.Add(LangueElement[140]);

            if (LangueElement[140] == "Compétences")
            {
                treeView1.Nodes[1].Nodes.Add("Barre de progression circulaire");
                treeView1.Nodes[1].Nodes.Add("Bouton animé");
                treeView1.Nodes[1].Nodes.Add("Code source site web");
                treeView1.Nodes[1].Nodes.Add("Formulaire de contact");
                treeView1.Nodes[1].Nodes.Add("Image flottante");
                treeView1.Nodes[1].Nodes.Add("InfoBulle");
            }
            else
            {
                treeView1.Nodes[1].Nodes.Add("Circular progress bar");
                treeView1.Nodes[1].Nodes.Add("Animated button");
                treeView1.Nodes[1].Nodes.Add("Source code website");
                treeView1.Nodes[1].Nodes.Add("Contact form");
                treeView1.Nodes[1].Nodes.Add("Floating image");
                treeView1.Nodes[1].Nodes.Add("Tooltip");
            }

            treeView1.Nodes.Add(LangueElement[141]);

            if (LangueElement[141] == "Jeux")
            {
                treeView1.Nodes[2].Nodes.Add("AddFindPlayer");
                treeView1.Nodes[2].Nodes.Add("Morpion");
                treeView1.Nodes[2].Nodes.Add("Pendu");
                treeView1.Nodes[2].Nodes.Add("Snake");
            }
            else
            {
                treeView1.Nodes[2].Nodes.Add("AddFindPlayer");
                treeView1.Nodes[2].Nodes.Add("Morpion");
                treeView1.Nodes[2].Nodes.Add("Pendu");
                treeView1.Nodes[2].Nodes.Add("Snake");
            }

            Chargement();

            foreach (var item in ListeProjet)
            {
                // string[] nomProjet = item.Split(new[] { " /// " }, StringSplitOptions.None);

                string[] result = Regex.Split(item, @"\-\-\-");

                Destination.Add(result[0]);
            }
            
        }

        private void recent1_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void FormSkillProject_Leave(object sender, EventArgs e)
        {
            FormIndex FI = (FormIndex)this.MdiParent;
            FI.accesRapide();
            this.Close();
        }

        private void Chargement()
        {
            int count = 0;

            panel1.Controls.Clear();

            foreach (var item0 in ListeProjet)
            {
                count++;
            }

            int y = 10;

            try
            {
                if (treeView1.SelectedNode.Text == LangueElement[141] || treeView1.SelectedNode.Text == LangueElement[140] || treeView1.SelectedNode.Text == LangueElement[139])
                {

                    foreach (var item in Tempo)
                    {
                        string[] result = Regex.Split(item, @"\-\-\-");

                        Label article = new Label();
                        Label date = new Label();
                        PictureBox logo = new PictureBox();
                        logo.ImageLocation = @"..\..\Resources\" + result[2];
                        logo.SizeMode = PictureBoxSizeMode.Zoom;
                        logo.BackgroundImageLayout = ImageLayout.Stretch;
                        article.Text = result[0];
                        date.Text = result[1];
                        article.Font = new Font(police, rbDateAjout.Font.SizeInPoints + 4, FontStyle.Bold);
                        date.Font = new Font(police, rbDateAjout.Font.SizeInPoints + 3, FontStyle.Italic);
                        article.Click += new EventHandler(LB_Click);
                        article.MouseHover += new EventHandler(recent1_MouseHover);
                        logo.Size = new Size(60, 60);
                        article.BackColor = Color.Transparent;
                        article.AutoSize = true;
                        article.SetBounds(400, y, 200, 10);
                        date.BackColor = Color.Transparent;
                        date.AutoSize = true;
                        date.SetBounds(400, y + 30, 200, 10);
                        logo.SetBounds(330, y, 60, 60);
                        panel1.Controls.AddRange(new Control[] { article, date, logo });

                        y = y + 60;
                    }
                }
                else
                {
                    foreach (var item in ListeProjet)
                    {
                        string[] result = Regex.Split(item, @"\-\-\-");

                        Label article = new Label();
                        Label date = new Label();
                        PictureBox logo = new PictureBox();
                        logo.ImageLocation = @"..\..\Resources\" + result[2];
                        logo.SizeMode = PictureBoxSizeMode.Zoom;
                        logo.BackgroundImageLayout = ImageLayout.Stretch;
                        article.Text = result[0];
                        date.Text = result[1];
                        article.Font = new Font(police, rbDateAjout.Font.SizeInPoints + 4, FontStyle.Bold);
                        date.Font = new Font(police, rbDateAjout.Font.SizeInPoints + 3, FontStyle.Italic);
                        article.Click += new EventHandler(LB_Click);
                        article.MouseHover += new EventHandler(recent1_MouseHover);
                        logo.Size = new Size(60, 60);
                        article.BackColor = Color.Transparent;
                        article.AutoSize = true;
                        article.SetBounds(400, y, 200, 10);
                        date.BackColor = Color.Transparent;
                        date.AutoSize = true;
                        date.SetBounds(400, y + 30, 200, 10);
                        logo.SetBounds(330, y, 60, 60);
                        panel1.Controls.AddRange(new Control[] { article, date, logo });

                        y = y + 60;
                    }
                }
            }
            catch
            {
                foreach (var item in ListeProjet)
                {
                    string[] result = Regex.Split(item, @"\-\-\-");

                    Label article = new Label();
                    Label date = new Label();
                    PictureBox logo = new PictureBox();
                    logo.ImageLocation = @"..\..\Resources\" + result[2];
                    logo.SizeMode = PictureBoxSizeMode.Zoom;
                    logo.BackgroundImageLayout = ImageLayout.Stretch;
                    article.Text = result[0];
                    date.Text = result[1];
                    article.Font = new Font(police, rbDateAjout.Font.SizeInPoints + 4, FontStyle.Bold);
                    date.Font = new Font(police, rbDateAjout.Font.SizeInPoints + 3, FontStyle.Italic);
                    article.Click += new EventHandler(LB_Click);
                    article.MouseHover += new EventHandler(recent1_MouseHover);
                    logo.Size = new Size(60, 60);
                    article.BackColor = Color.Transparent;
                    article.AutoSize = true;
                    article.SetBounds(400, y, 200, 10);
                    date.BackColor = Color.Transparent;
                    date.AutoSize = true;
                    date.SetBounds(400, y + 30, 200, 10);
                    logo.SetBounds(330, y, 60, 60);
                    panel1.Controls.AddRange(new Control[] { article, date, logo });

                    y = y + 60;
                }
            }
            
            panel1.AutoScrollMinSize = new Size(0, y+40);
            panel1.BackgroundImage = Skill_Project.Properties.Resources.yuyukyuk;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbDateAjout_Click(object sender, EventArgs e)
        {
            panel1.AutoScrollMinSize = new Size(0, 0);

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

            int y = 10;
            int i = 0;


            panel1.Controls.Clear();

            ici:

            foreach (var item in ListeProjet)
            {
                string[] result = Regex.Split(item, @"\-\-\-");

                if (result[1] == TriDatee[i].ToString())
                {
                    Label article = new Label();
                    Label date = new Label();
                    PictureBox logo = new PictureBox();
                    logo.ImageLocation = @"..\..\Resources\" + result[2];
                    logo.SizeMode = PictureBoxSizeMode.Zoom;
                    logo.BackgroundImageLayout = ImageLayout.Stretch;
                    article.Text = result[0];
                    date.Text = result[1];
                    article.Font = new Font(police, rbDateAjout.Font.SizeInPoints + 4, FontStyle.Bold);
                    date.Font = new Font(police, rbDateAjout.Font.SizeInPoints + 3, FontStyle.Italic);
                    article.Click += new EventHandler(LB_Click);
                    article.MouseHover += new EventHandler(recent1_MouseHover);
                    logo.Size = new Size(60, 60);
                    article.BackColor = Color.Transparent;
                    article.AutoSize = true;
                    article.SetBounds(400, y, 200, 10);
                    date.BackColor = Color.Transparent;
                    date.AutoSize = true;
                    date.SetBounds(400, y + 30, 200, 10);
                    logo.SetBounds(330, y, 60, 60);
                    panel1.Controls.AddRange(new Control[] { article, date, logo });

                    y = y + 60;

                    if (i < (TriDatee.Count - 1))
                    {
                        i++;
                        goto ici;
                    }
                }
            }

            panel1.AutoScrollMinSize = new Size(0, y + 40);
            panel1.BackgroundImage = Skill_Project.Properties.Resources.yuyukyuk;
        }

        private void rbAZ_Click(object sender, EventArgs e)
        {
            panel1.AutoScrollMinSize = new Size(0, 0);

            ListeProjet.Sort();
            Tempo.Sort();
            Chargement();
        }

        private void rbZA_Click(object sender, EventArgs e)
        {
            panel1.AutoScrollMinSize = new Size(0, 0);

            ListeProjet.Reverse();
            Tempo.Reverse();
            Chargement();
        }

        private void rbDateAjout_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormArborescence_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            panel1.AutoScrollMinSize = new Size(0, 0);

            rbAZ.Enabled = true;
            rbZA.Enabled = true;

            List<string> SousNoeud = new List<string>();

            foreach (var item in e.Node.Nodes)
            {
                SousNoeud.Add(item.ToString());
            }

            int count = 0;

            panel1.Controls.Clear();

            foreach (var item0 in ListeProjet)
            {
                count++;
            }

            int y = 10;
            int i = 0;


            ici:

            foreach (var item in ListeProjet)
            {
                string[] result = Regex.Split(item, @"\-\-\-");

                if (result[0] == SousNoeud[i].ToString())
                {
                    Label article = new Label();
                    Label date = new Label();
                    PictureBox logo = new PictureBox();
                    logo.ImageLocation = @"..\..\Resources\" + result[2];
                    logo.SizeMode = PictureBoxSizeMode.Zoom;
                    logo.BackgroundImageLayout = ImageLayout.Stretch;
                    article.Text = result[0];
                    date.Text = result[1];
                    article.Font = new Font(police, rbDateAjout.Font.SizeInPoints + 4, FontStyle.Bold);
                    date.Font = new Font(police, rbDateAjout.Font.SizeInPoints + 3, FontStyle.Italic);
                    article.Click += new EventHandler(LB_Click);
                    article.MouseHover += new EventHandler(recent1_MouseHover);
                    logo.Size = new Size(60, 60);
                    article.BackColor = Color.Transparent;
                    article.AutoSize = true;
                    article.SetBounds(400, y, 200, 10);
                    date.BackColor = Color.Transparent;
                    date.AutoSize = true;
                    date.SetBounds(400, y + 30, 200, 10);
                    logo.SetBounds(330, y, 60, 60);
                    panel1.Controls.AddRange(new Control[] { article, date, logo });

                    y = y + 60;

                    if (i < (SousNoeud.Count - 1))
                    {
                        i++;
                        goto ici;
                    }
                }
            }

            panel1.AutoScrollMinSize = new Size(0, y + 40);
            panel1.BackgroundImage = Skill_Project.Properties.Resources.yuyukyuk;

            if (e.Node.Text == LangueElement[141])
            {
                panel1.Controls.Add(pbClassement);
                panel1.Controls.Add(label2);

                pbClassement.Visible = true;
                label2.Visible = true;
            }
            else
            {
                pbClassement.Visible = false;
                label2.Visible = false;
            }
        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            panel1.AutoScrollMinSize = new Size(0, 0);

            rbAZ.Enabled = true;
            rbZA.Enabled = true;

            Chargement();

            if (e.Node.Text == LangueElement[141])
            {
                panel1.Controls.Add(pbClassement);
                panel1.Controls.Add(label2);

                pbClassement.Visible = true;
                label2.Visible = true;
            }
            else
            {
                pbClassement.Visible = false;
                label2.Visible = false;
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            panel1.AutoScrollMinSize = new Size(0, 0);

            if (e.Node.Text != LangueElement[141] && e.Node.Text != LangueElement[140] && e.Node.Text != LangueElement[139])
            {
                rbAZ.Enabled = false;
                rbZA.Enabled = false;

                int count = 0;

                panel1.Controls.Clear();

                foreach (var item0 in ListeProjet)
                {
                    count++;
                }

                int y = 10;

                foreach (var item in ListeProjet)
                {

                    string[] result = Regex.Split(item, @"\-\-\-");
                    
                    if (e.Node.Text.ToString() == result[0])
                    {
                        Label article = new Label();
                        Label date = new Label();
                        PictureBox logo = new PictureBox();
                        logo.ImageLocation = @"..\..\Resources\" + result[2];
                        logo.SizeMode = PictureBoxSizeMode.Zoom;
                        logo.BackgroundImageLayout = ImageLayout.Stretch;
                        article.Text = result[0];
                        date.Text = result[1];
                        article.Font = new Font(police, rbDateAjout.Font.SizeInPoints + 4, FontStyle.Bold);
                        date.Font = new Font(police, rbDateAjout.Font.SizeInPoints + 3, FontStyle.Italic);
                        article.Click += new EventHandler(LB_Click);
                        article.MouseHover += new EventHandler(recent1_MouseHover);
                        logo.Size = new Size(60, 60);
                        article.BackColor = Color.Transparent;
                        article.AutoSize = true;
                        article.SetBounds(400, y, 200, 10);
                        date.BackColor = Color.Transparent;
                        date.AutoSize = true;
                        date.SetBounds(400, y + 30, 200, 10);
                        logo.SetBounds(330, y, 60, 60);
                        panel1.Controls.AddRange(new Control[] { article, date, logo });

                        y = y + 60;
                    }
                }

                panel1.AutoScrollMinSize = new Size(0, y + 40);
                panel1.BackgroundImage = Skill_Project.Properties.Resources.yuyukyuk;
            }
            else
            {
                rbAZ.Enabled = true;
                rbZA.Enabled = true;

                // List<string> SousNoeud = new List<string>();

                List<string> SousNoeud = new List<string>();
                Tempo.Clear();

                foreach (var item in e.Node.Nodes)
                {
                    SousNoeud.Add(item.ToString());
                }

                int y = 10;

                panel1.Controls.Clear();

                foreach (var item in ListeProjet)
                {
                    string[] result = Regex.Split(item, @"\-\-\-");

                    foreach (var item2 in SousNoeud)
                    {
                        if (result[0] == item2.Substring(10, item2.Length - 10))
                        {
                            Tempo.Add(result[0] + "---" + result[1] + "---" + result[2]);

                            Label article = new Label();
                            Label date = new Label();
                            PictureBox logo = new PictureBox();
                            logo.ImageLocation = @"..\..\Resources\" + result[2];
                            logo.SizeMode = PictureBoxSizeMode.Zoom;
                            logo.BackgroundImageLayout = ImageLayout.Stretch;
                            article.Text = result[0];
                            date.Text = result[1];
                            article.Font = new Font(police, rbDateAjout.Font.SizeInPoints + 4, FontStyle.Bold);
                            date.Font = new Font(police, rbDateAjout.Font.SizeInPoints + 3, FontStyle.Italic);
                            article.Click += new EventHandler(LB_Click);
                            article.MouseHover += new EventHandler(recent1_MouseHover);
                            logo.Size = new Size(60, 60);
                            article.BackColor = Color.Transparent;
                            article.AutoSize = true;
                            article.SetBounds(400, y, 200, 10);
                            date.BackColor = Color.Transparent;
                            date.AutoSize = true;
                            date.SetBounds(400, y + 30, 200, 10);
                            logo.SetBounds(330, y, 60, 60);
                            panel1.Controls.AddRange(new Control[] { article, date, logo });

                            y = y + 60;
                        }
                    }
                }

                panel1.AutoScrollMinSize = new Size(0, y + 40);
                panel1.BackgroundImage = Skill_Project.Properties.Resources.yuyukyuk;
            }

            if (e.Node.Text == LangueElement[141])
            {
                panel1.Controls.Add(pbClassement);
                panel1.Controls.Add(label2);

                pbClassement.Visible = true;
                label2.Visible = true;
            }
            else
            {
                pbClassement.Visible = false;
                label2.Visible = false;
            }
        }

        protected void LB_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            List<String> Item2 = new List<String>();

            string dt = DateTime.Today.ToShortDateString();

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
                            FormsCompetence.FormProjetPendu FPC = new FormsCompetence.FormProjetPendu(value, nouvJoueur, lesJoueurs, "arborescence");
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
                        FormsCompetence.FormProjetPendu FPC = new FormsCompetence.FormProjetPendu("Guest", nouvJoueur, lesJoueurs, "arborescence");
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
