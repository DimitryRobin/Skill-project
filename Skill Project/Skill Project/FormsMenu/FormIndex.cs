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

namespace Skill_Project
{
    public partial class FormIndex : System.Windows.Forms.Form
    {
        private string test;
        public int nb = 0;
        public int para = 0; // 0, 1, 2, 3, 4, 5, 6
        int time = 0;

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

        private void sfsfToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            MessageBox.Show("Bienvenue ☺", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*
            var request = WebRequest.Create("http://image.noelshack.com/fichiers/2015/47/1447964240-yuyukyuk.jpg");
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            menuStrip1.BackgroundImage = Bitmap.FromStream(stream);
            */

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
            listeToolStripMenuItem.Enabled = false;
            sfsfToolStripMenuItem.Enabled = false;
            suggestionToolStripMenuItem.Enabled = true;
            quitterToolStripMenuItem.Enabled = true;
            pictureBox1.Visible = false;

            
            FormListe FL = new FormListe();
            FL.MdiParent = this;

            FL.Show();
            
           
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

        private void lireFichier()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\SkillProject\Preferences_SkillProject.txt");

            test = lines[0].ToString();
            Opacity = Convert.ToDouble(test);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string curFile = @"C:\SkillProject\Preferences_SkillProject.txt";

            if (File.Exists(curFile))
            {
                lireFichier();
            }
                para = 0;
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
    }
}
