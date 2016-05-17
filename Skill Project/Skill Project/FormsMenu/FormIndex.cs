﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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

            MessageBox.Show("Merci d'avoir utilisé Skill Project ☺\nÀ bientôt !", "Déconnexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
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
        }

        private void FormIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
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
                procedure();
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetCalculatrice FPC = new FormsCompetence.FormProjetCalculatrice();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[7])
            {
                procedure();
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetAddFindPlayer FPC = new FormsCompetence.FormProjetAddFindPlayer();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[1])
            {
                procedure();
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetBarreProgCirculaire FPC = new FormsCompetence.FormProjetBarreProgCirculaire();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[2])
            {
                procedure();
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetBoutonAnime FPC = new FormsCompetence.FormProjetBoutonAnime();
                FPC.MdiParent = this;
                FPC.Show();
            }
            if (lbl.Text == Item2[3])
            {
                procedure();
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetCodeSourceSiteWeb FPC = new FormsCompetence.FormProjetCodeSourceSiteWeb();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[4])
            {
                procedure();
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetFormulaireContactPersonnalise FPC = new FormsCompetence.FormProjetFormulaireContactPersonnalise();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[5])
            {
                procedure();
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetImageFlottante FPC = new FormsCompetence.FormProjetImageFlottante();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[6])
            {
                procedure();
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetInfoBulle FPC = new FormsCompetence.FormProjetInfoBulle();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[8])
            {
                procedure();
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetMorpion FPC = new FormsCompetence.FormProjetMorpion();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[9])
            {
                procedure();
                Fonction.ecrireFichier("", "", "", "", "", "", lbl.Text, dt);
                
                FormsCompetence.FormProjetPendu FPC = new FormsCompetence.FormProjetPendu();
                FPC.MdiParent = this;
                FPC.Show();
            }

            if (lbl.Text == Item2[10])
            {
                procedure();
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
    }
}
