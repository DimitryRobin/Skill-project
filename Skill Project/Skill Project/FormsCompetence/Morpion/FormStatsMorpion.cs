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

namespace Skill_Project.FormsCompetence.Morpion
{
    public partial class FormStatsMorpion : Form
    {
        Form f;

        List<string> LangueElement = new List<string>();

        public FormStatsMorpion(Form fm)
        {
            InitializeComponent();
            f = fm;
        }

        private void FormStatsMorpion_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbRetour_Click(object sender, EventArgs e)
        {
            f.Show();
            // f.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void FormStatsMorpion_Load(object sender, EventArgs e)
        {
            FormIndex form = (FormIndex)this.MdiParent;

            LangueElement = Fonction.LangageAppli();
            this.Text = LangueElement[161];
            lblStats.Text = LangueElement[161];
            lblInfoVDR.Text = LangueElement[162];

            var pos = this.PointToScreen(pbClassement.Location);
            pos = this.PointToClient(pos);
            pbClassement.Parent = this;
            pbClassement.Location = pos;
            pbClassement.BackColor = Color.Transparent;

            List<string> ListeStats = new List<string>();
            ListeStats = Fonction.LireStatsProjetJeu(@"..\..\FormsCompetence\Morpion\StatsMorpion.txt"); // J | V | D | R

            int i = 0;
            int l = 0;

            foreach (var item in ListeStats)
            {
                l++;
            }

            List<string> ListeTrieUnique = new List<string>();

            foreach (var item in ListeStats)
            {
                string[] result = Regex.Split(item, @"\|");

                ListeTrieUnique.Add(result[3]);
            }

            ListeTrieUnique.Sort((a, b) => -1 * a.CompareTo(b)); // descending sort

            List<string> ListeTrieFini = new List<string>();

            foreach (var item in ListeTrieUnique)
            {
                foreach (var item2 in ListeStats)
                {
                    string[] result = Regex.Split(item2, @"\|");

                    if (item == result[3])
                    {
                        ListeTrieFini.Add(result[0] + "|" + result[1] + "|" + result[2] + "|" + result[3]);
                        ListeStats.Remove(result[0] + "|" + result[1] + "|" + result[2] + "|" + result[3]);
                        break;
                    }
                }
            }


            foreach (var item in ListeTrieFini)
            {
                string[] result = Regex.Split(item, @"\|");

                if (i <= 9)
                {

                    Label lblJoueur = new Label();
                    Label lblStatsJoueur = new Label();
                    lblJoueur.Text = result[0];
                    lblStatsJoueur.Text = "V : " + result[1] + " | D : " + result[2] + " | R : " + result[3];
                    lblJoueur.Font = new Font("Palatino Linotype", lblJ1.Font.SizeInPoints, FontStyle.Bold);
                    lblStatsJoueur.Font = new Font("Palatino Linotype", lblJ1bis.Font.SizeInPoints);
                    lblJoueur.BackColor = Color.Transparent;
                    lblJoueur.AutoSize = true;
                    lblJoueur.Visible = true;

                    if (i == 0)
                    {
                        lblJoueur.SetBounds(445, 87, 200, 10);
                        lblStatsJoueur.SetBounds(415, 105, 200, 10);
                        this.Controls.Add(lblJoueur);
                        this.Controls.Add(lblStatsJoueur);
                    }
                    else if (i == 1)
                    {
                        lblJoueur.SetBounds(298, 130, 200, 10);
                        lblStatsJoueur.SetBounds(268, 148, 200, 10);
                        this.Controls.Add(lblJoueur);
                        this.Controls.Add(lblStatsJoueur);
                    }
                    else if (i == 2)
                    {
                        lblJoueur.SetBounds(589, 138, 200, 10);
                        lblStatsJoueur.SetBounds(559, 156, 200, 10);
                        this.Controls.Add(lblJoueur);
                        this.Controls.Add(lblStatsJoueur);
                    }
                    else if (i == 3)
                    {
                        if (l == 6 || l == 5 || l == 4)
                        {
                            lblJoueur.SetBounds(130, 0, 200, 10);
                            lblStatsJoueur.SetBounds(130, 20, 200, 10);
                            label1.SetBounds(110, 0, 200, 10);
                            panel1.Controls.Add(label1);
                            panel1.Controls.Add(lblJoueur);
                            panel1.Controls.Add(lblStatsJoueur);
                        }
                        else
                        {
                            lblJoueur.SetBounds(0, 0, 200, 10);
                            lblStatsJoueur.SetBounds(0, 20, 200, 10);
                            panel1.Controls.Add(lblJoueur);
                            panel1.Controls.Add(lblStatsJoueur);
                        }
                    }
                    else if (i == 4)
                    {
                        if (l == 6 || l == 5 || l == 4)
                        {
                            lblJoueur.SetBounds(130, 60, 200, 10);
                            lblStatsJoueur.SetBounds(130, 80, 200, 10);
                            label2.SetBounds(110, 60, 200, 10);
                            panel1.Controls.Add(label2);
                            panel1.Controls.Add(lblJoueur);
                            panel1.Controls.Add(lblStatsJoueur);
                        }
                        else
                        {
                            lblJoueur.SetBounds(0, 60, 200, 10);
                            lblStatsJoueur.SetBounds(0, 80, 200, 10);
                            panel1.Controls.Add(lblJoueur);
                            panel1.Controls.Add(lblStatsJoueur);
                        }
                    }
                    else if (i == 5)
                    {
                        if (l == 6 || l == 5 || l == 4)
                        {
                            lblJoueur.SetBounds(130, 120, 200, 10);
                            lblStatsJoueur.SetBounds(130, 140, 200, 10);
                            label3.SetBounds(110, 120, 200, 10);
                            panel1.Controls.Add(label3);
                            panel1.Controls.Add(lblJoueur);
                            panel1.Controls.Add(lblStatsJoueur);
                        }
                        else
                        {
                            lblJoueur.SetBounds(0, 120, 200, 10);
                            lblStatsJoueur.SetBounds(0, 140, 200, 10);
                            panel1.Controls.Add(lblJoueur);
                            panel1.Controls.Add(lblStatsJoueur);
                        }
                    }
                    else if (i == 6)
                    {
                        lblJoueur.SetBounds(235, 0, 200, 10);
                        lblStatsJoueur.SetBounds(235, 20, 200, 10);
                        label6.SetBounds(215, 0, 200, 10);
                        panel1.Controls.Add(label6);
                        panel1.Controls.Add(lblJoueur);
                        panel1.Controls.Add(lblStatsJoueur);
                    }

                    else if (i == 7)
                    {
                        lblJoueur.SetBounds(235, 60, 200, 10);
                        lblStatsJoueur.SetBounds(235, 80, 200, 10);
                        label5.SetBounds(215, 60, 200, 10);
                        panel1.Controls.Add(label5);
                        panel1.Controls.Add(lblJoueur);
                        panel1.Controls.Add(lblStatsJoueur);
                    }
                    else if (i == 8)
                    {
                        lblJoueur.SetBounds(235, 120, 200, 10);
                        lblStatsJoueur.SetBounds(235, 140, 200, 10);
                        label4.SetBounds(215, 120, 200, 10);
                        panel1.Controls.Add(label4);
                        panel1.Controls.Add(lblJoueur);
                        panel1.Controls.Add(lblStatsJoueur);
                    }


                    lblJoueur.BringToFront();
                    lblStatsJoueur.BackColor = Color.Transparent;
                    lblStatsJoueur.AutoSize = true;
                    lblStatsJoueur.Visible = true;

                    lblStatsJoueur.BringToFront();


                    if (i == 0 || i == 1 || i == 2)
                    {
                        var pos4 = this.PointToScreen(lblJoueur.Location);
                        pos4 = pbClassement.PointToClient(pos4);
                        lblJoueur.Parent = pbClassement;
                        lblJoueur.Location = pos4;
                        lblJoueur.BackColor = Color.Transparent;

                        var pos5 = this.PointToScreen(lblStatsJoueur.Location);
                        pos5 = pbClassement.PointToClient(pos5);
                        lblStatsJoueur.Parent = pbClassement;
                        lblStatsJoueur.Location = pos5;
                        lblStatsJoueur.BackColor = Color.Transparent;
                    }


                }

                i++;
            }

            if (i == 8)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
                label4.Visible = true;
            }

            if (i == 8)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
                label4.Visible = false;
            }

            if (i == 7)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label6.Visible = true;
                label5.Visible = false;
                label4.Visible = false;
            }

            if (i == 6)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label6.Visible = false;
                label5.Visible = false;
                label4.Visible = false;
            }

            if (i == 5)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                label4.Visible = false;
            }

            if (i == 4)
            {
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                label4.Visible = false;
            }

            if (i == 3 || i == 2 || i == 1 || i == 0)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                label4.Visible = false;
            }

            Fonction.policeTexte(this); // Gestion police
        }
    }
}
