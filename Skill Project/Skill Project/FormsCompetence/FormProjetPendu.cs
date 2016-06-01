using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Skill_Project.FormsCompetence.Pendu;

namespace Skill_Project.FormsCompetence
{
    public partial class FormProjetPendu : Form
    {
        private LesMots5Lettres listeMots;
        private Mot motAlea;
        private int compteur = 10; // Nombre de coup avant d'être pendu
        private string lol;
        private string arrivage;

        private List<Joueur> lesJoueurs = new List<Joueur>();

        int gagne = 0;
        int perdu = 0;
        int indice = 0;

        public FormProjetPendu(string nom, Joueur J, List<Joueur> lesJ, string provenance)
        {
            InitializeComponent();

            arrivage = provenance;
            lol = nom;

            // Création de la liste de mots contenant tous les mots de 5 lettres
            listeMots = new LesMots5Lettres();
            btnRejouer.Visible = false;

            // Au début, on donne un mot aléatoire de la liste de mots
            motAlea = listeMots.donneUnMotAléatoire();
            lblPendu.Text = Convert.ToString(compteur);
            
            lblprenom.Text = lol;

            // Pour test

            reponse.Visible = true;
            reponse.Text = Convert.ToString(motAlea.affiche());
        }

        private void FormProjetPendu_Load(object sender, EventArgs e)
        {

        }

        private void bouton_Click(object sender, EventArgs e, Button nomBouton)
        {
            //String motCherche = "";

            int[] lesIndices; // déclare un tabelau d'entiers qui récupèrera les indices trouvés d' une lettre dans un mot
            int ret = -1; //aucune lettre trouvée dans le mot

            char l = char.Parse(nomBouton.Text);

            if (motAlea.ContientLettre(l)) //si la lettre du bouton cliqué est contenue dans le mot
            {
                lblInfoUtilisateur.Visible = true;
                lblInfoUtilisateur.ForeColor = Color.ForestGreen;
                lblInfoUtilisateur.Text = "Cette lettre EST BIEN présente dans le mot !";

                lesIndices = motAlea.IndicesLettre(l); //retourne LES indices de la lettre dans le mot

                for (int i = 0; i < lesIndices.Length; i++)
                {
                    ret = lesIndices[i];
                    if (ret == -1)
                    {
                        break; // je sors du for car plus de lettres à traiter
                    }
                    else
                    {

                        if (ret == 0) //le premier élément est à la position 0
                        {
                            lblettre1.Text = motAlea.affiche(ret).ToString();
                        }
                        else
                        {
                            if (ret == 1)
                            {
                                lblettre2.Text = motAlea.affiche(ret).ToString();
                            }
                            else
                            {
                                if (ret == 2)
                                {
                                    lblettre3.Text = motAlea.affiche(ret).ToString();
                                }
                                else
                                {
                                    if (ret == 3)
                                    {
                                        lblettre4.Text = motAlea.affiche(ret).ToString();
                                    }
                                    else
                                    {
                                        lblettre5.Text = motAlea.affiche(ret).ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else // la lettre n'est pas présente dans le mot
            {
                do
                {
                    pendu1.Visible = true;
                    compteur = compteur - 1;
                    lblPendu.Text = Convert.ToString(compteur);
                    lblInfoUtilisateur.Visible = true;
                    lblInfoUtilisateur.ForeColor = Color.Purple;
                    lblInfoUtilisateur.Text = "Cette lettre n'EST PAS présente dans le mot !";

                    if (compteur == 9)
                    {
                        pendu1.Visible = true;
                    }
                    else
                    {
                        if (compteur == 8)
                        {
                            pendu1.Visible = false;
                            pendu2.Visible = true;
                        }
                        else
                        {
                            if (compteur == 7)
                            {
                                pendu1.Visible = false;
                                pendu2.Visible = false;
                                pendu3.Visible = true;
                            }
                            else
                            {
                                if (compteur == 6)
                                {
                                    pendu1.Visible = false;
                                    pendu2.Visible = false;
                                    pendu3.Visible = false;
                                    pendu4.Visible = true;
                                }
                                else
                                {
                                    if (compteur == 5)
                                    {
                                        pendu1.Visible = false;
                                        pendu2.Visible = false;
                                        pendu3.Visible = false;
                                        pendu4.Visible = false;
                                        pendu5.Visible = true;
                                    }
                                    else
                                    {
                                        if (compteur == 4)
                                        {
                                            pendu1.Visible = false;
                                            pendu2.Visible = false;
                                            pendu3.Visible = false;
                                            pendu4.Visible = false;
                                            pendu5.Visible = false;
                                            pendu6.Visible = true;
                                        }
                                        else
                                        {
                                            if (compteur == 3)
                                            {
                                                pendu1.Visible = false;
                                                pendu2.Visible = false;
                                                pendu3.Visible = false;
                                                pendu4.Visible = false;
                                                pendu5.Visible = false;
                                                pendu6.Visible = false;
                                                pendu7.Visible = true;
                                            }
                                            else
                                            {
                                                if (compteur == 2)
                                                {
                                                    pendu1.Visible = false;
                                                    pendu2.Visible = false;
                                                    pendu3.Visible = false;
                                                    pendu4.Visible = false;
                                                    pendu5.Visible = false;
                                                    pendu6.Visible = false;
                                                    pendu7.Visible = false;
                                                    pendu8.Visible = true;
                                                }
                                                else
                                                {
                                                    if (compteur == 1)
                                                    {
                                                        pendu1.Visible = false;
                                                        pendu2.Visible = false;
                                                        pendu3.Visible = false;
                                                        pendu4.Visible = false;
                                                        pendu5.Visible = false;
                                                        pendu6.Visible = false;
                                                        pendu7.Visible = false;
                                                        pendu8.Visible = false;
                                                        pendu9.Visible = true;
                                                    }
                                                    else
                                                    {
                                                        if (compteur == 0)
                                                        {
                                                            pendu1.Visible = false;
                                                            pendu2.Visible = false;
                                                            pendu3.Visible = false;
                                                            pendu4.Visible = false;
                                                            pendu5.Visible = false;
                                                            pendu6.Visible = false;
                                                            pendu7.Visible = false;
                                                            pendu8.Visible = false;
                                                            pendu9.Visible = false;
                                                            pendu10.Visible = true;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                } while (compteur < 0);
            }

            if (compteur == 0)
            {

                lblInfoUtilisateur.ForeColor = Color.Red;
                lblInfoUtilisateur.Text = "Vous avez perdu.";
                lblPendu.Visible = false;
                lblinfo.ForeColor = Color.Red;
                lblinfo.Visible = true;
                lblinfo.Text = "ESSAIE ENCORE !";
                gbAlphabet.Enabled = false;
                btnRejouer.Visible = true;
                texteresultat.Visible = true;
                reponse.Visible = true;
                reponse.Text = Convert.ToString(motAlea.affiche());
                pendu10.Visible = true;
                pendu9.Visible = false;
                pendu8.Visible = false;
                pendu7.Visible = false;
                pendu6.Visible = false;
                pendu5.Visible = false;
                pendu4.Visible = false;
                pendu3.Visible = false;
                pendu2.Visible = false;
                pendu1.Visible = false;
                aide.Enabled = false;


                perdu = perdu + 1;

                // nouvJoueur.Perdu();
                // nouvJoueur.ModifPrcwin();

                Fonction.ecrireFichierProjetJeu(@"Pendu\StatsPendu.txt", lblprenom.Text, "Defaite");
            }

            if (lblettre1.Text != "_")
            {
                if (lblettre2.Text != "_")
                {
                    if (lblettre3.Text != "_")
                    {
                        if (lblettre4.Text != "_")
                        {
                            if (lblettre5.Text != "_")
                            {
                                lblInfoUtilisateur.ForeColor = Color.Purple;
                                lblInfoUtilisateur.Text = "Vous avez gagné.";
                                lblPendu.Visible = false;
                                lblinfo.ForeColor = Color.Green;
                                lblinfo.Visible = true;
                                lblinfo.Text = "FELICITATION !";
                                imagegagne.Visible = true;
                                gbAlphabet.Enabled = false;
                                btnRejouer.Visible = true;
                                pendu10.Visible = false;
                                pendu9.Visible = false;
                                pendu8.Visible = false;
                                pendu7.Visible = false;
                                pendu6.Visible = false;
                                pendu5.Visible = false;
                                pendu4.Visible = false;
                                pendu3.Visible = false;
                                pendu2.Visible = false;
                                pendu1.Visible = false;
                                aide.Enabled = false;

                                // nouvJoueur.Gagner();
                                // nouvJoueur.ModifPrcwin();

                                gagne = gagne + 1;

                                Fonction.ecrireFichierProjetJeu(@"Pendu\StatsPendu.txt", lblprenom.Text, "Victoire");
                            }
                        }
                    }
                }
            }

        }

        private void btnA_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnA); btnA.Visible = false; }
        private void btnB_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnB); btnB.Visible = false; }
        private void btnC_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnC); btnC.Visible = false; }
        private void btnD_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnD); btnD.Visible = false; }
        private void btnE_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnE); btnE.Visible = false; }
        private void btnF_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnF); btnF.Visible = false; }
        private void btnG_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnG); btnG.Visible = false; }
        private void btnH_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnH); btnH.Visible = false; }
        private void btnI_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnI); btnI.Visible = false; }
        private void btnJ_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnJ); btnJ.Visible = false; }
        private void btnK_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnK); btnK.Visible = false; }
        private void btnL_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnL); btnL.Visible = false; }
        private void btnM_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnM); btnM.Visible = false; }
        private void btnN_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnN); btnN.Visible = false; }
        private void btnO_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnO); btnO.Visible = false; }
        private void btnP_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnP); btnP.Visible = false; }
        private void btnQ_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnQ); btnQ.Visible = false; }
        private void btnR_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnR); btnR.Visible = false; }
        private void btnS_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnS); btnS.Visible = false; }
        private void btnT_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnT); btnT.Visible = false; }
        private void btnU_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnU); btnU.Visible = false; }
        private void btnV_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnV); btnV.Visible = false; }
        private void btnW_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnW); btnW.Visible = false; }
        private void btnX_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnX); btnX.Visible = false; }
        private void btnY_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnY); btnY.Visible = false; }
        private void btnZ_Click(object sender, EventArgs e) { bouton_Click(sender, e, btnZ); btnZ.Visible = false; }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
            btnE.Visible = true;
            btnF.Visible = true;
            btnG.Visible = true;
            btnH.Visible = true;
            btnI.Visible = true;
            btnJ.Visible = true;
            btnK.Visible = true;
            btnL.Visible = true;
            btnM.Visible = true;
            btnN.Visible = true;
            btnO.Visible = true;
            btnP.Visible = true;
            btnQ.Visible = true;
            btnR.Visible = true;
            btnS.Visible = true;
            btnT.Visible = true;
            btnU.Visible = true;
            btnV.Visible = true;
            btnW.Visible = true;
            btnX.Visible = true;
            btnY.Visible = true;
            btnZ.Visible = true;

            compteur = 10;
            lblPendu.Text = Convert.ToString(compteur);
            lblPendu.Visible = true;
            lblinfo.Visible = false;
            gbAlphabet.Enabled = true;
            btnRejouer.Visible = false;
            texteresultat.Visible = false;
            // reponse.Visible = false;
            aide.Enabled = true;

            imagegagne.Visible = false;

            pendu10.Visible = false;
            pendu9.Visible = false;
            pendu8.Visible = false;
            pendu7.Visible = false;
            pendu6.Visible = false;
            pendu5.Visible = false;
            pendu4.Visible = false;
            pendu3.Visible = false;
            pendu2.Visible = false;
            pendu1.Visible = false;

            lblInfoUtilisateur.Text = "";

            lblettre1.Text = "_";
            lblettre2.Text = "_";
            lblettre3.Text = "_";
            lblettre4.Text = "_";
            lblettre5.Text = "_";

            listeMots = new LesMots5Lettres();
            motAlea = listeMots.donneUnMotAléatoire();

            reponse.Text = Convert.ToString(motAlea.affiche());
        }

        private void aide_Click(object sender, EventArgs e)
        {
            int position_aleatoire = 0;
            Random rnd = new Random();

            do
            {
                position_aleatoire = rnd.Next(0, 5);
            }
            while (motAlea.affiche(position_aleatoire).ToString() == lblettre1.Text || motAlea.affiche(position_aleatoire).ToString() == lblettre2.Text ||
                motAlea.affiche(position_aleatoire).ToString() == lblettre3.Text || motAlea.affiche(position_aleatoire).ToString() == lblettre4.Text ||
                motAlea.affiche(position_aleatoire).ToString() == lblettre5.Text);

            // string nomLabel = "lblettre" + (position_aleatoire + 1).ToString();

            int[] lesIndices; // déclare un tabelau d'entiers qui récupèrera les indices trouvés d' une lettre dans un mot
            int ret = -1; //aucune lettre trouvée dans le mot
            char l = char.Parse(motAlea.affiche(position_aleatoire).ToString());


            // if (position_aleatoire != 4)
           // {
                if (motAlea.ContientLettre(l)) //si la lettre du bouton cliqué est contenue dans le mot
                {
                    lesIndices = motAlea.IndicesLettre(l); //retourne LES indices de la lettre dans le mot

                    for (int i = 0; i < lesIndices.Length; i++)
                    {
                        ret = lesIndices[i];
                        if (ret == -1)
                        {
                            break; // je sors du for car plus de lettres à traiter
                        }
                        else
                        {

                            if (ret == 0) //le premier élément est à la position 0
                            {
                                lblettre1.Text = motAlea.affiche(ret).ToString();
                            }
                            else
                            {
                                if (ret == 1)
                                {
                                    lblettre2.Text = motAlea.affiche(ret).ToString();
                                }
                                else
                                {
                                    if (ret == 2)
                                    {
                                        lblettre3.Text = motAlea.affiche(ret).ToString();
                                    }
                                    else
                                    {
                                        if (ret == 3)
                                        {
                                            lblettre4.Text = motAlea.affiche(ret).ToString();
                                        }
                                        else
                                        {
                                            lblettre5.Text = motAlea.affiche(ret).ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            foreach (Control x in this.Controls)
            {
                if (x is GroupBox)
                {
                    foreach (Control c in x.Controls)
                    {
                        if(c.Text == l.ToString())
                        {
                            c.Visible = false;
                        }
                    }
                }
            }
        
            
            indice = indice + 1;
            aide.Enabled = false;
            // }

            if (lblettre1.Text != "_")
            {
                if (lblettre2.Text != "_")
                {
                    if (lblettre3.Text != "_")
                    {
                        if (lblettre4.Text != "_")
                        {
                            if (lblettre5.Text != "_")
                            {
                                lblInfoUtilisateur.ForeColor = Color.Purple;
                                lblInfoUtilisateur.Text = "Vous avez gagné.";
                                lblPendu.Visible = false;
                                lblinfo.ForeColor = Color.Green;
                                lblinfo.Visible = true;
                                lblinfo.Text = "FELICITATION !";
                                imagegagne.Visible = true;
                                gbAlphabet.Enabled = false;
                                btnRejouer.Visible = true;
                                pendu10.Visible = false;
                                pendu9.Visible = false;
                                pendu8.Visible = false;
                                pendu7.Visible = false;
                                pendu6.Visible = false;
                                pendu5.Visible = false;
                                pendu4.Visible = false;
                                pendu3.Visible = false;
                                pendu2.Visible = false;
                                pendu1.Visible = false;
                                aide.Enabled = false;

                                // nouvJoueur.Gagner();
                                // nouvJoueur.ModifPrcwin();

                                gagne = gagne + 1;

                                Fonction.ecrireFichierProjetJeu(@"Pendu\StatsPendu.txt", lblprenom.Text, "Victoire");
                            }
                        }
                    }
                }
            }
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pbCode_Click(object sender, EventArgs e)
        {
            string[] recupCode = Fonction.lireCodeProjet(@"Pendu\CodePendu.txt");
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

        private void FormProjetPendu_Leave(object sender, EventArgs e)
        {
            // this.Close();
            this.Hide();
        }

        private void pbClassement_Click(object sender, EventArgs e)
        {
            FormIndex FI = (FormIndex)this.MdiParent;

            FormStatsPendu FP = new FormStatsPendu(this);
            FP.MdiParent = FI;
            
            FP.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pbClassement_Click(sender, e);
        }

        private void FormProjetPendu_Enter(object sender, EventArgs e)
        {

        }
    }
}
