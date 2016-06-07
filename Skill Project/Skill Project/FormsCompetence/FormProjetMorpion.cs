using Skill_Project.FormsCompetence.Morpion;
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
    public partial class FormProjetMorpion : Form
    {
        List<string> LangueElement = new List<string>();
        private string arrivage;
        private static string joueur1;
        private static string joueur2;
        private static string mode;

        public int nbj1 = 0;
        public int nbj2 = 0;

        bool against_computer = false;

        bool tour = true; // true = X turn; false = Y turn;
        int nb_tour = 0;

        public FormProjetMorpion(string provenance)
        {
            InitializeComponent();

            arrivage = provenance;
            lblnbj1.Text = nbj1.ToString();
            lblnbj2.Text = nbj2.ToString();
        }

        public static void recupNomJoueur(string md, string n1, string n2)
        {
            joueur1 = n1;
            joueur2 = n2;
            mode = md;
        }

        private void pbCode_Click(object sender, EventArgs e)
        {
            string[] recupCode = Fonction.lireCodeProjet(@"Morpion\CodeMorpion.txt");
            tbCode.Text = "";
            tbCode.ReadOnly = true;
            tbCode.BorderStyle = 0;
            tbCode.TabStop = false;
            tbCode.Visible = true;
            pbRetour.Visible = false;

            tbCode.Lines = recupCode;

            tbCode.BringToFront();
            // panel1.Focus();
            // panel1.Select();

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

        private void FormProjetMorpion_Load(object sender, EventArgs e)
        {
            FormJoueur FP = new FormJoueur(arrivage);
            FP.ShowDialog();
            

            LangueElement = Fonction.LangageAppli();
            label2.Text = LangueElement[208];
            label4.Text = LangueElement[209];
            lblj1.Text = LangueElement[210];
            lblj2.Text = LangueElement[211];
            btnRejouer.Text = LangueElement[212];
            label1.Text = LangueElement[217];

            Fonction.policeTexte(this); // Gestion police
            
            lblj1.Text = joueur1[0].ToString().ToUpper() + joueur1.Substring(1).ToLower();

            if (mode == "0")
            {
                lblj2.Text = LangueElement[213];
                against_computer = true;
                label4.Visible = true;
                label1.Visible = true;
            }
            else
            {
                lblj2.Text = joueur2[0].ToString().ToUpper() + joueur2.Substring(1).ToLower();
                against_computer = false;
                label4.Visible = false;
                label1.Visible = false;
            }
            
        }

        private void pbClassement_Click(object sender, EventArgs e)
        {            
            FormIndex FI = (FormIndex)this.MdiParent;

            FormStatsMorpion FP = new FormStatsMorpion(this);
            FP.MdiParent = FI;

            FP.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pbClassement_Click(sender, e);
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (tour)
                b.Text = "X";
            else
                b.Text = "O";


            if (lblj1.BackColor == Color.Transparent)
            {
                lblj1.BackColor = Color.Gold;
                lblj2.BackColor = Color.Transparent;
            }
            else
            {
                lblj1.BackColor = Color.Transparent;
                lblj2.BackColor = Color.Gold;
            }

            tour = !tour;
            b.Enabled = false;
            nb_tour++;

            ChercheGagant();

            if((!tour) && (against_computer))
            {
                computer_make_move();

                lblj1.BackColor = Color.Gold;
                lblj2.BackColor = Color.Transparent;
            }
        }

        private void ChercheGagant()
        {
            bool gagnant = false;

            //horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                gagnant = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                gagnant = true;
            else if((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                gagnant = true;

            //vertical
            else if((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                gagnant = true;
            else if((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                gagnant = true;
            else if((A3.Text == B3.Text) && (B2.Text == C3.Text) && (!A3.Enabled))
                gagnant = true;

            //diagonal
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                gagnant = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                gagnant = true;

            if (gagnant)
            {
                DesactiveBouton();
                String winner = "";

                if (tour)
                {
                    nbj2++;
                    lblnbj2.Text = nbj2.ToString();
                    winner = lblj2.Text;

                    Fonction.ecrireFichierProjetJeu(@"Morpion\StatsMorpion.txt", winner, "Victoire");
                    Fonction.ecrireFichierProjetJeu(@"Morpion\StatsMorpion.txt", lblj1.Text, "Defaite");
                }
                else
                {
                    nbj1++;
                    lblnbj1.Text = nbj1.ToString();
                    winner = lblj1.Text;

                    Fonction.ecrireFichierProjetJeu(@"Morpion\StatsMorpion.txt", winner, "Victoire");
                    Fonction.ecrireFichierProjetJeu(@"Morpion\StatsMorpion.txt", lblj2.Text, "Defaite");
                }

                MessageBox.Show(winner + LangueElement[214], LangueElement[215]);
            }
            else
            {
                if (nb_tour == 9)
                    MessageBox.Show(LangueElement[216], LangueElement[215]);
            }
        }

        private void DesactiveBouton()
        {
            foreach (Control c in Controls)
            {
                if(c.Text != LangueElement[212])
                {
                    try
                    {
                        Button b = (Button)c;
                        b.Enabled = false;
                    }
                    catch
                    { }
                }
            }
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            tour = true;
            nb_tour = 0;
            
            foreach (Control c in Controls)
            {
                if (c.Text != LangueElement[212])
                {
                    try
                    {
                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = "";
                    }
                    catch
                    { }
                }
            }

            lblj1.BackColor = Color.Gold;
            lblj2.BackColor = Color.Transparent;
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Enabled)
            {
                if (tour)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void computer_make_move()
        {
            Button move = null;

            // cherche une opportunité
            move = look_for_win_or_block("O"); // de gagner
            if (move == null)
            {
                move = look_for_win_or_block("X"); // de bloquer
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }//end if
                }//end if
            }//end if

            try
            {

                move.PerformClick();
            }
            catch { }
        }

        private Button look_for_open_space()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                if (c.Text != LangueElement[212])
                {
                    b = c as Button;
                    if (b != null)
                    {
                        if (b.Text == "")
                            return b;
                    }//end if
                }
            }//end if

            return null;
        }

        private Button look_for_corner()
        {
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }

        private Button look_for_win_or_block(string mark)
        {
            // horizontal
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            // vertical
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            // diagonal
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }

        private void FormProjetMorpion_Enter(object sender, EventArgs e)
        {
            FormIndex form = (FormIndex)this.MdiParent;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormProjetMorpion_Leave(object sender, EventArgs e)
        {
            // this.Close();
            this.Hide();
        }
    }
}
