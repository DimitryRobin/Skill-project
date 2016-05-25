using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Project
{
    public partial class FormAPropos : System.Windows.Forms.Form
    {
        public FormAPropos()
        {
            InitializeComponent();
        }

        private void btnRetourAP_Click(object sender, EventArgs e)
        {
            FormIndex FI = (FormIndex)this.MdiParent;

            if (FI.nb == 1) // dehors
            {

                FI.SfsfToolStripMenuItem.Enabled = true;
                FI.AfficToolStripMenuItem.Enabled = true;
                FI.CommentÇaMarcheToolStripMenuItem.Enabled = true;
                FI.QuiSommesNousToolStripMenuItem.Enabled = true;

                this.Close();
                
                FI.CommentÇaMarcheToolStripMenuItem.BackColor = Color.Transparent;

                FI.PictureBox1.Visible = true;
                var pos = FI.PointToScreen(FI.LblCreateur.Location);
                pos = FI.PictureBox1.PointToClient(pos);
                FI.LblCreateur.Parent = FI.PictureBox1;
                FI.LblCreateur.Location = pos;
                FI.LblCreateur.BackColor = Color.Transparent;
            }
            else // dedans
            {
                FI.QuitterToolStripMenuItem.Enabled = true;
                FI.AffichageToolStripMenuItem.Enabled = true;
                FI.AfficToolStripMenuItem.Enabled = true;
                FI.CommentÇaMarcheToolStripMenuItem.Enabled = true;
                FI.QuiSommesNousToolStripMenuItem.Enabled = true;
                FI.SuggestionToolStripMenuItem.Enabled = true;

                if (FI.ListeToolStripMenuItem.Enabled == false)
                {
                    FormListe FL = new FormListe();
                    FL.MdiParent = FI;
                    FL.Show();
                }

                if (FI.MiniaturesToolStripMenuItem.Enabled == false)
                {
                    FormMiniature FM = new FormMiniature();
                    FM.MdiParent = FI;
                    FM.Show();
                }

                if (FI.ArborescenceToolStripMenuItem.Enabled == false)
                {
                    FormArborescence FA = new FormArborescence();
                    FA.MdiParent = FI;
                    FA.Show();
                }


                this.Close();
                
                FI.AffichageToolStripMenuItem.BackColor = Color.SandyBrown;
                FI.CommentÇaMarcheToolStripMenuItem.BackColor = Color.Transparent;
            }
        }

        private void FormAPropos_Load(object sender, EventArgs e)
        {
            Fonction.policeTexte(this); // Gestion police

            radioButton1.Select();
            label1.Text = "Skill project est une application créée, entièrement par moi-même, afin de répertorier toutes les compétences\nque j'ai acquises jusqu'ici. L'idée de créer ce petit logiciel m'est venu lorsque j'ai appris qu'il fallait garder\ntoutes traces de réalisation pratique, lors de mon enseignement en BTS, pour passer l'épreuve E6.\n\nDès lors, je me suis dis : pourquoi pas créer un portefeuille de compétences sous forme logiciel ?\n\nAprès approbration de mes enseignants quant à la possibilité d'utiliser cette méthode pour l'examen, je me\nsuis mis à la tâche. Puis, je me suis rendu compte, au fur et à mesure que je développais, que Skill project\npourrait servir à autrui.\n\nJe me suis alors posé la question : pourquoi pas faire évoluer l'application afin d'aider mon prochain ?\n\nDe part ces raisonnements, Skill project a vu le jour puis évolue petit à petit dans le but d'offrir les réponses aux\nquestions de tous développeurs, mais aussi dans le but d'offrir du contenu différent de celui trouvé sur internet.\nDe part sa simplicité d'utilisation et son interface conviviale, Skill project permet :\n\n- d'apprendre, en copiant d'un simple clic, le code d'une compétence\n- de faire des suggestions (amélioration du logiciel, ajout de nouvelles compétences etc..)\n- de partager mes compétences et mon savoir-faire avec vous\n\nEnfin, Skill project ne nécessite aucune connexion à une base de donnée, premièrement car il n'existe aucun\nhébergeur, à ma connaisance, d'application C# (mis à part db4free.net, environnnement de test) et dans un\nsecond temps parce que la connexion à une base de donnée, via des requêtes, pourrait ralentir le logiciel.\nAfin de gérer les préférences de chaque utilisateurs, il est possible qu'un fichier .txt soit créée sur votre\nordinateur dans le seul et unique objectif de sauvegarder vos paramètres.";

        }
    }
}
