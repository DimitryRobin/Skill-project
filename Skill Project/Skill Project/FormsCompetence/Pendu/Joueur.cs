using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Skill_Project.FormsCompetence.Pendu
{
    public class Joueur
    {
        #region propriétés
        private string nom;
        private int nbPartie;
        private double PrcWin;
        private int PartieWin;
        private int PartieLose;
        #endregion

        #region constructeur
        public Joueur()
        {

        }
        public Joueur(string unNom)
        {
            nom = unNom;
            nbPartie = 0;
            PrcWin = 0;
            PartieWin = 0;
            PartieLose = 0;
        }
        #endregion

        #region accesseurs
        public int Win
        {
            get { return PartieWin; }
        }
        public int lose
        {
            get { return PartieLose; }
        }
        public string Nom
        {
            get { return nom; }
        }
        public int NombredePartie
        {
            get { return nbPartie; }
        }
        public double PourcentageVictoire
        {
            get { return PrcWin; }
        }
        #endregion

        #region methode
        public void ModifNbPartie()
        {
            nbPartie++;
        }

        public void Gagner()
        {
            PartieWin++;
        }

        public void Perdu()
        {
            PartieLose++;
        }

        public void ModifPrcwin()
        {
            if (PartieLose == 0 && PartieWin != 0)
            {
                PrcWin = 100;
            }
            else // (PartieLose != 0 || PartieWin == 0)
            {
                PrcWin = PartieWin / PartieLose;
                PrcWin = PrcWin * 100;
            }
        }

        public void AfficherJoueur()
        {
            /*  string text;
              StreamWriter sw = new StreamWriter("W:/Projet SLAM MI Semestre/Player  " + nom + ".txt ");
              //création du fichier
              text = nom + "," + nbPartie + "," + PartieWin + "," + PartieLose + "," + PrcWin;
              sw.WriteLine(text);//enregistrement du message dans le fichier
        
             */
        }
        #endregion
    }
}