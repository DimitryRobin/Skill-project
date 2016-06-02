using Skill_Project.FormsCompetence.Pendu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Project
{
    public partial class FormIndex : System.Windows.Forms.Form
    {
        private string test;
        public int nb = 0;
        public int para = 0; // 0, 1, 2, 3, 4, 5, 6

        private Joueur nouvJoueur;
        private List<Joueur> lesJoueurs = new List<Joueur>();

        List<string> LangueElement = new List<string>();

        public MenuStrip MyMenu
        {
            get { return menuStrip1; }
        }

        public FormIndex()
        {
            InitializeComponent();

            var pos = this.PointToScreen(lblCreateur.Location);
            pos = pictureBox1.PointToClient(pos);
            lblCreateur.Parent = pictureBox1;
            lblCreateur.Location = pos;
            lblCreateur.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(lblAccesRapide.Location);
            pos2 = pictureBox1.PointToClient(pos2);
            lblAccesRapide.Parent = pictureBox1;
            lblAccesRapide.Location = pos2;
            lblAccesRapide.BackColor = Color.Transparent;

            var pos3 = this.PointToScreen(lblACDate1.Location);
            pos3 = pictureBox1.PointToClient(pos3);
            lblACDate1.Parent = pictureBox1;
            lblACDate1.Location = pos3;
            lblACDate1.BackColor = Color.Transparent;

            var pos4 = this.PointToScreen(lblACDate2.Location);
            pos4 = pictureBox1.PointToClient(pos4);
            lblACDate2.Parent = pictureBox1;
            lblACDate2.Location = pos4;
            lblACDate2.BackColor = Color.Transparent;

            var pos5 = this.PointToScreen(lblACDate3.Location);
            pos5 = pictureBox1.PointToClient(pos5);
            lblACDate3.Parent = pictureBox1;
            lblACDate3.Location = pos5;
            lblACDate3.BackColor = Color.Transparent;

            var pos6 = this.PointToScreen(lblACNom1.Location);
            pos6 = pictureBox1.PointToClient(pos6);
            lblACNom1.Parent = pictureBox1;
            lblACNom1.Location = pos6;
            lblACNom1.BackColor = Color.Transparent;

            var pos7 = this.PointToScreen(lblACNom2.Location);
            pos7 = pictureBox1.PointToClient(pos7);
            lblACNom2.Parent = pictureBox1;
            lblACNom2.Location = pos7;
            lblACNom2.BackColor = Color.Transparent;

            var pos8 = this.PointToScreen(lblACNom3.Location);
            pos8 = pictureBox1.PointToClient(pos8);
            lblACNom3.Parent = pictureBox1;
            lblACNom3.Location = pos8;
            lblACNom3.BackColor = Color.Transparent;

            var pos9 = this.PointToScreen(lblDate.Location);
            pos9 = pictureBox1.PointToClient(pos9);
            lblDate.Parent = pictureBox1;
            lblDate.Location = pos9;
            lblDate.BackColor = Color.Transparent;

            var pos10 = this.PointToScreen(lblHeure.Location);
            pos10 = pictureBox1.PointToClient(pos10);
            lblHeure.Parent = pictureBox1;
            lblHeure.Location = pos10;
            lblHeure.BackColor = Color.Transparent;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sfsfToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }

        public void procedure()
        {
            para = 1;

            pictureBox1.Visible = false;

            sfsfToolStripMenuItem.BackColor = Color.SandyBrown;
            affichageToolStripMenuItem.BackColor = Color.Transparent;
            afficToolStripMenuItem.BackColor = Color.Transparent;
            commentÇaMarcheToolStripMenuItem.BackColor = Color.Transparent;
            listeToolStripMenuItem.BackColor = Color.Transparent;
            miniaturesToolStripMenuItem.BackColor = Color.Transparent;
            quiSommesNousToolStripMenuItem.BackColor = Color.Transparent;
            quitterToolStripMenuItem.BackColor = Color.Transparent;
            suggestionToolStripMenuItem.BackColor = Color.Transparent;
            paramètreToolStripMenuItem.BackColor = Color.Transparent;

            affichageToolStripMenuItem.Enabled = true;
            listeToolStripMenuItem.Enabled = true;
            miniaturesToolStripMenuItem.Enabled = false;
            sfsfToolStripMenuItem.Enabled = false;
            suggestionToolStripMenuItem.Enabled = true;
            quitterToolStripMenuItem.Enabled = true;
            pictureBox1.Visible = false;
        }

        private void sfsfToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // MessageBox.Show("Bienvenue ☺", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*
            var request = WebRequest.Create("http://image.noelshack.com/fichiers/2015/47/1447964240-yuyukyuk.jpg");
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            menuStrip1.BackgroundImage = Bitmap.FromStream(stream);
            */

            procedure();


            FormMiniature FM = new FormMiniature();
            FM.MdiParent = this;

            FM.Show();
            
           
        }

        private void affichageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            para = 2;

            sfsfToolStripMenuItem.BackColor = Color.Transparent;
            affichageToolStripMenuItem.BackColor = Color.SandyBrown;
            afficToolStripMenuItem.BackColor = Color.Transparent;
            commentÇaMarcheToolStripMenuItem.BackColor = Color.Transparent;
            listeToolStripMenuItem.BackColor = Color.Transparent;
            miniaturesToolStripMenuItem.BackColor = Color.Transparent;
            quiSommesNousToolStripMenuItem.BackColor = Color.Transparent;
            quitterToolStripMenuItem.BackColor = Color.Transparent;
            suggestionToolStripMenuItem.BackColor = Color.Transparent;
            paramètreToolStripMenuItem.BackColor = Color.Transparent;
        }

        private void suggestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            para = 3;

            sfsfToolStripMenuItem.BackColor = Color.Transparent;
            affichageToolStripMenuItem.BackColor = Color.Transparent;
            afficToolStripMenuItem.BackColor = Color.Transparent;
            commentÇaMarcheToolStripMenuItem.BackColor = Color.Transparent;
            listeToolStripMenuItem.BackColor = Color.Transparent;
            miniaturesToolStripMenuItem.BackColor = Color.Transparent;
            quiSommesNousToolStripMenuItem.BackColor = Color.Transparent;
            quitterToolStripMenuItem.BackColor = Color.Transparent;
            suggestionToolStripMenuItem.BackColor = Color.SandyBrown;
            paramètreToolStripMenuItem.BackColor = Color.Transparent;
            
            affichageToolStripMenuItem.Enabled = false;
            afficToolStripMenuItem.Enabled = false;
            commentÇaMarcheToolStripMenuItem.Enabled = false;
            quiSommesNousToolStripMenuItem.Enabled = false;
            suggestionToolStripMenuItem.Enabled = false;

            FormSuggestion FS = new FormSuggestion();
            FS.MdiParent = this;
            
            FS.Show();
        }

        private void quiSommesNousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            para = 4;

            if (sfsfToolStripMenuItem.Enabled == true) // Dehors
            {
                nb = 1;
            }
            else // Dedans
            {
                nb = 2;
            }
            
            sfsfToolStripMenuItem.BackColor = Color.Transparent;
            affichageToolStripMenuItem.BackColor = Color.Transparent;
            afficToolStripMenuItem.BackColor = Color.Transparent;
            commentÇaMarcheToolStripMenuItem.BackColor = Color.Transparent;
            listeToolStripMenuItem.BackColor = Color.Transparent;
            miniaturesToolStripMenuItem.BackColor = Color.Transparent;
            quiSommesNousToolStripMenuItem.BackColor = Color.SandyBrown;
            quitterToolStripMenuItem.BackColor = Color.Transparent;
            suggestionToolStripMenuItem.BackColor = Color.Transparent;
            paramètreToolStripMenuItem.BackColor = Color.Transparent;

            pictureBox1.Visible = false;

            QuitterToolStripMenuItem.Enabled = false;
            sfsfToolStripMenuItem.Enabled = false;
            affichageToolStripMenuItem.Enabled = false;
            afficToolStripMenuItem.Enabled = false;
            commentÇaMarcheToolStripMenuItem.Enabled = false;
            quiSommesNousToolStripMenuItem.Enabled = false;
            suggestionToolStripMenuItem.Enabled = false;

            
            if (ListeToolStripMenuItem.Enabled == false)
            {
                FormListe FL = new FormListe();
                FL.Close();
            }

            if (MiniaturesToolStripMenuItem.Enabled == false)
            {
                FormMiniature FM = new FormMiniature();
                FM.Close();
            }

            if (ArborescenceToolStripMenuItem.Enabled == false)
            {
                FormArborescence FA = new FormArborescence();
                FA.Close();
            }

            FormQuiSuisJe FQSJ = new FormQuiSuisJe();
            FQSJ.MdiParent = this;

            FQSJ.Show();
        }

        private void commentÇaMarcheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            para = 5;

            if (sfsfToolStripMenuItem.Enabled == true) // Dehors
            {
                nb = 1;
            }
            else // Dedans
            {
                nb = 2;
            }

            sfsfToolStripMenuItem.BackColor = Color.Transparent;
            affichageToolStripMenuItem.BackColor = Color.Transparent;
            afficToolStripMenuItem.BackColor = Color.Transparent;
            commentÇaMarcheToolStripMenuItem.BackColor = Color.SandyBrown;
            listeToolStripMenuItem.BackColor = Color.Transparent;
            miniaturesToolStripMenuItem.BackColor = Color.Transparent;
            quiSommesNousToolStripMenuItem.BackColor = Color.Transparent;
            quitterToolStripMenuItem.BackColor = Color.Transparent;
            suggestionToolStripMenuItem.BackColor = Color.Transparent;
            paramètreToolStripMenuItem.BackColor = Color.Transparent;

            pictureBox1.Visible = false;

            QuitterToolStripMenuItem.Enabled = false;
            sfsfToolStripMenuItem.Enabled = false;
            affichageToolStripMenuItem.Enabled = false;
            afficToolStripMenuItem.Enabled = false;
            commentÇaMarcheToolStripMenuItem.Enabled = false;
            quiSommesNousToolStripMenuItem.Enabled = false;
            suggestionToolStripMenuItem.Enabled = false;

            FormAPropos FAP = new FormAPropos();
            FAP.MdiParent = this;

            FAP.Show();
        }

        private void afficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            para = 6;

            if (sfsfToolStripMenuItem.Enabled == true) // Dehors
            {
                nb = 1;
            }
            else // Dedans
            {
                nb = 2;
            }

            sfsfToolStripMenuItem.BackColor = Color.Transparent;
            affichageToolStripMenuItem.BackColor = Color.Transparent;
            afficToolStripMenuItem.BackColor = Color.SandyBrown;
            commentÇaMarcheToolStripMenuItem.BackColor = Color.Transparent;
            listeToolStripMenuItem.BackColor = Color.Transparent;
            miniaturesToolStripMenuItem.BackColor = Color.Transparent;
            quiSommesNousToolStripMenuItem.BackColor = Color.Transparent;
            quitterToolStripMenuItem.BackColor = Color.Transparent;
            suggestionToolStripMenuItem.BackColor = Color.Transparent;
            paramètreToolStripMenuItem.BackColor = Color.Transparent;

            pictureBox1.Visible = false;

            QuitterToolStripMenuItem.Enabled = false;
            sfsfToolStripMenuItem.Enabled = false;
            affichageToolStripMenuItem.Enabled = false;
            afficToolStripMenuItem.Enabled = false;
            commentÇaMarcheToolStripMenuItem.Enabled = false;
            quiSommesNousToolStripMenuItem.Enabled = false;
            suggestionToolStripMenuItem.Enabled = false;

            FormFaireUnDon FFUD = new FormFaireUnDon();
            FFUD.MdiParent = this;

            FFUD.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accesRapide();

            sfsfToolStripMenuItem.BackColor = Color.Transparent;
            affichageToolStripMenuItem.BackColor = Color.Transparent;
            afficToolStripMenuItem.BackColor = Color.Transparent;
            commentÇaMarcheToolStripMenuItem.BackColor = Color.Transparent;
            listeToolStripMenuItem.BackColor = Color.Transparent;
            miniaturesToolStripMenuItem.BackColor = Color.Transparent;
            quiSommesNousToolStripMenuItem.BackColor = Color.Transparent;
            suggestionToolStripMenuItem.BackColor = Color.Transparent;
            paramètreToolStripMenuItem.BackColor = Color.Transparent;

            MessageBox.Show(LangueElement[16] + "\n" + LangueElement[17], LangueElement[18], MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            affichageToolStripMenuItem.Enabled = false;
            sfsfToolStripMenuItem.Enabled = true;
            suggestionToolStripMenuItem.Enabled = false;
            quitterToolStripMenuItem.Enabled = false;
            pictureBox1.Visible = true;

            listeToolStripMenuItem.Enabled = false;
            miniaturesToolStripMenuItem.Enabled = true;
            arborescenceToolStripMenuItem.Enabled = true;

            /*
            if(listeToolStripMenuItem.Enabled==false)
            {
                FormListe FL = new FormListe();
                FL.Close();
            }

            if (miniaturesToolStripMenuItem.Enabled == false)
            {
                FormMiniature FM = new FormMiniature();
                FM.Close();
            }

            if(arborescenceToolStripMenuItem.Enabled== false)
            {
                FormArborescence FA = new FormArborescence();
                FA.Close();
            }
            */

            FormArborescence FA = new FormArborescence();
            FA.Close();
            FormMiniature FM = new FormMiniature();
            FM.Close();
            FormListe FL = new FormListe();
            FL.Close();

            Application.Exit();

        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfsfToolStripMenuItem.BackColor = Color.Transparent;
            affichageToolStripMenuItem.BackColor = Color.SandyBrown;
            afficToolStripMenuItem.BackColor = Color.Transparent;
            commentÇaMarcheToolStripMenuItem.BackColor = Color.Transparent;
            listeToolStripMenuItem.BackColor = Color.Transparent;
            miniaturesToolStripMenuItem.BackColor = Color.Transparent;
            quiSommesNousToolStripMenuItem.BackColor = Color.Transparent;
            quitterToolStripMenuItem.BackColor = Color.Transparent;
            suggestionToolStripMenuItem.BackColor = Color.Transparent;
            paramètreToolStripMenuItem.BackColor = Color.Transparent;

            listeToolStripMenuItem.Enabled = false;
            miniaturesToolStripMenuItem.Enabled = true;
            arborescenceToolStripMenuItem.Enabled = true;

            FormMiniature FM = new FormMiniature();
            FM.Close();
            
            FormArborescence FA = new FormArborescence();
            FA.Close();

            FormListe FL = new FormListe();
            FL.MdiParent = this;
            FL.Show();

        }

        private void miniaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfsfToolStripMenuItem.BackColor = Color.Transparent;
            affichageToolStripMenuItem.BackColor = Color.SandyBrown;
            afficToolStripMenuItem.BackColor = Color.Transparent;
            commentÇaMarcheToolStripMenuItem.BackColor = Color.Transparent;
            listeToolStripMenuItem.BackColor = Color.Transparent;
            miniaturesToolStripMenuItem.BackColor = Color.Transparent;
            quiSommesNousToolStripMenuItem.BackColor = Color.Transparent;
            quitterToolStripMenuItem.BackColor = Color.Transparent;
            suggestionToolStripMenuItem.BackColor = Color.Transparent;
            paramètreToolStripMenuItem.BackColor = Color.Transparent;

            listeToolStripMenuItem.Enabled = true;
            miniaturesToolStripMenuItem.Enabled = false;
            arborescenceToolStripMenuItem.Enabled = true;
            

            FormArborescence FA = new FormArborescence();
            FA.Close();

            FormListe FL = new FormListe();
            FL.Close();

            FormMiniature FM = new FormMiniature();
            FM.MdiParent = this;
            FM.Show();

        }

        public void accesRapide()
        {
            List<string> Preference = new List<string>();

            string police;
            string dateRecent1, Recent1, dateRecent2, Recent2, dateRecent3, Recent3;

            Preference = Fonction.Preference();
            police = Preference[2];
            dateRecent1 = Preference[7];
            Recent1 = Preference[6];
            dateRecent2 = Preference[9];
            Recent2 = Preference[8];
            dateRecent3 = Preference[11];
            Recent3 = Preference[10];

            if (Recent1 != "Aucun")
            {
                lblAccesRapide.Visible = true;
                lblACDate1.Text = dateRecent1;
                lblACNom1.Text = Recent1;
                lblACDate1.Visible = true;
                lblACNom1.Visible = true;
            }
            else
            {
                lblAccesRapide.Visible = false;
                lblACDate1.Visible = false;
                lblACNom1.Visible = false;
            }

            if (Recent2 != "Aucun")
            {
                lblACDate2.Text = dateRecent2;
                lblACNom2.Text = Recent2;
                lblACDate2.Visible = true;
                lblACNom2.Visible = true;
            }
            else
            {
                lblACDate2.Visible = false;
                lblACNom2.Visible = false;
            }

            if (Recent3 != "Aucun")
            {
                lblACDate3.Text = dateRecent3;
                lblACNom3.Text = Recent3;
                lblACDate3.Visible = true;
                lblACNom3.Visible = true;
            }
            else
            {
                lblACDate3.Visible = false;
                lblACNom3.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerHHmm.Start();

            string curFile = @"C:\SkillProject\Preferences_SkillProject.txt";

            if (File.Exists(curFile))
            {
                string[] lines = Fonction.lireFichier();

                test = lines[0].ToString();
                Opacity = Convert.ToDouble(test);
            }
            else
            {
                Fonction.creationFichier();
            }

            para = 0;
            accesRapide();

            Fonction.policeTexte(this); // Gestion police

            LangueElement = Fonction.LangageAppli();
            affichageToolStripMenuItem.Text = LangueElement[2];
            listeToolStripMenuItem.Text = LangueElement[3];
            miniaturesToolStripMenuItem.Text = LangueElement[4];
            ArborescenceToolStripMenuItem.Text = LangueElement[5];
            suggestionToolStripMenuItem.Text = LangueElement[6];
            QuiSommesNousToolStripMenuItem.Text = LangueElement[7];
            commentÇaMarcheToolStripMenuItem.Text = LangueElement[8];
            AfficToolStripMenuItem.Text = LangueElement[9];
            paramètreToolStripMenuItem.Text = LangueElement[10];
            QuitterToolStripMenuItem.Text = LangueElement[11];
            lblAccesRapide.Text = LangueElement[15];

            if (quitterToolStripMenuItem.Text == "Exit ➬")
            {
                quitterToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 2, 0);
                paramètreToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 2, 0);
                AfficToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 2, 0);
                commentÇaMarcheToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 2, 0);
                QuiSommesNousToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 2, 0);
                suggestionToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 2, 0);
            }
        }

        private void FormIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerHHmm.Stop();
            Application.Exit();
        }

        private void arborescenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfsfToolStripMenuItem.BackColor = Color.Transparent;
            affichageToolStripMenuItem.BackColor = Color.SandyBrown;
            afficToolStripMenuItem.BackColor = Color.Transparent;
            commentÇaMarcheToolStripMenuItem.BackColor = Color.Transparent;
            listeToolStripMenuItem.BackColor = Color.Transparent;
            miniaturesToolStripMenuItem.BackColor = Color.Transparent;
            quiSommesNousToolStripMenuItem.BackColor = Color.Transparent;
            quitterToolStripMenuItem.BackColor = Color.Transparent;
            suggestionToolStripMenuItem.BackColor = Color.Transparent;
            paramètreToolStripMenuItem.BackColor = Color.Transparent;

            listeToolStripMenuItem.Enabled = true;
            miniaturesToolStripMenuItem.Enabled = true;
            arborescenceToolStripMenuItem.Enabled = false;

            FormListe FL = new FormListe();
            FL.Close();

            FormMiniature FM = new FormMiniature();
            FM.Close();

            FormArborescence FA = new FormArborescence();
            FA.MdiParent = this;
            FA.Show();

        }

        private void paramètreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParametre FP = new FormParametre();
            FP.ShowDialog();
        }

        private void FormIndex_Enter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHeure.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
            lblDate.Text = lblDate.Text[0].ToString().ToUpper() + lblDate.Text.Substring(1).ToLower();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblACNom1_Click(object sender, EventArgs e)
        {
            List<String> Item2 = new List<String>();
            List<String> ListeProjet = new List<String>();

            ListeProjet = Fonction.LectureProjet();

            Label lbl = sender as Label;

            string dt = DateTime.Today.ToShortDateString();

            foreach (var item in ListeProjet)
            {
                // string[] nomProjet = item.Split(new[] { " /// " }, StringSplitOptions.None);

                string[] result = Regex.Split(item, @"\-\-\-");

                Item2.Add(result[0]);
            }

            if (lbl.Text == Item2[0])
            {
                pictureBox1.Visible = false;
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetCalculatrice FPC = new FormsCompetence.FormProjetCalculatrice();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[7])
            {
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);

                DialogResult DR = MessageBox.Show(LangueElement[175] + "\n" + LangueElement[176], LangueElement[177], MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DR == DialogResult.Yes)
                {
                    System.Diagnostics.Process p = new System.Diagnostics.Process();
                    p.StartInfo.FileName = "http://dimitryrobin.fr/Portfolio/AddFindPlayer.php";
                    p.Start();
                }

            }

            if (lbl.Text == Item2[1])
            {
                pictureBox1.Visible = false;
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetBarreProgCirculaire FPC = new FormsCompetence.FormProjetBarreProgCirculaire();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[2])
            {
                pictureBox1.Visible = false;
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetBoutonAnime FPC = new FormsCompetence.FormProjetBoutonAnime("index");
                FPC.MdiParent = this;
                FPC.Show();
            }
            if (lbl.Text == Item2[3])
            {
                pictureBox1.Visible = false;
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetCodeSourceSiteWeb FPC = new FormsCompetence.FormProjetCodeSourceSiteWeb("index");
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[4])
            {
                pictureBox1.Visible = false;
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetFormulaireContactPersonnalise FPC = new FormsCompetence.FormProjetFormulaireContactPersonnalise();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[5])
            {
                pictureBox1.Visible = false;
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetImageFlottante FPC = new FormsCompetence.FormProjetImageFlottante();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[6])
            {
                pictureBox1.Visible = false;
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetInfoBulle FPC = new FormsCompetence.FormProjetInfoBulle();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[8])
            {
                pictureBox1.Visible = false;
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetMorpion FPC = new FormsCompetence.FormProjetMorpion();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[9])
            {
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);

            recommence:

                string value = "Pseudonyme";
                bool check = false;

                if (Fonction.InputBoxLogin("Pendu", LangueElement[172], ref value, ref check) == DialogResult.OK)
                {
                    if(check == false)
                    {
                        if (value != "Pseudonyme" && value != "" && value != " " && value != "  " && value != "   " && value != "    " && value != "     ")
                        {
                            pictureBox1.Visible = false;

                            nouvJoueur = new Joueur(value);
                            lesJoueurs.Add(nouvJoueur);
                            nouvJoueur.ModifNbPartie();

                            nouvJoueur.AfficherJoueur();

                            FormsCompetence.FormProjetPendu FPC = new FormsCompetence.FormProjetPendu(value, nouvJoueur, lesJoueurs, "index");
                            FPC.MdiParent = this;
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
                        pictureBox1.Visible = false;

                        nouvJoueur = new Joueur("Guest");
                        lesJoueurs.Add(nouvJoueur);
                        nouvJoueur.ModifNbPartie();

                        nouvJoueur.AfficherJoueur();

                        FormsCompetence.FormProjetPendu FPC = new FormsCompetence.FormProjetPendu("Guest", nouvJoueur, lesJoueurs, "index");
                        FPC.MdiParent = this;
                        FPC.Show();
                    }
                    
                }                
            }

            if (lbl.Text == Item2[10])
            {
                pictureBox1.Visible = false;
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetSnake FPC = new FormsCompetence.FormProjetSnake();
                FPC.MdiParent = this;
                FPC.Show();
            }
        }

        private void lblACNom1_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
