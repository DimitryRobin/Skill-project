using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_Project.FormsCompetence.Pendu
{
    class LesMots5Lettres
    {
        private List<Mot> tabMots = new List<Mot>();

        public LesMots5Lettres()
        {

            String[] tabMotString;
            String fichier;

            StreamReader reader = new StreamReader(@"..\..\FormsCompetence\Pendu\ListeMots5LettresSansAccents.txt");

            fichier = reader.ReadToEnd();
            fichier = fichier.ToUpper();

            tabMotString = fichier.Split(','); //Récupère tous les mots dans un tableau....chaque mot est séparé par une virgule ici
            //on parcours le tableau de mot en chaine pour remplir le tableau de MOTS tabMots

            for (int i = 0; i < tabMotString.Length; i++)
            {
                tabMots.Add(new Mot(tabMotString[i]));
            }

        }

        public Mot donneUnMotAléatoire()
        {
            //donne un nombre aléatoire entre 1 et la longueur du tableau de mots
            Random ra = new Random();
            int indiceMot = ra.Next(1, tabMots.Count + 1);
            //retourne l'objet MOT  correspondant à cet indice
            return tabMots[indiceMot];


        }

    }
}
