using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Project.FormsCompetence.Pendu
{
    class Mot
    {
        private String unMot = null;

        /*constructeur de la classe Mot*/
        public Mot(String unMot)
        {
            this.unMot = unMot;
        }


        /*permet de comparer le mot courant avec un mot proposé. Renvoie vrai si  le mot est identique et faux sinon*/
        public bool compareMot(String motPropose)
        {
            bool ret;
            ret = unMot.Equals(motPropose);
            return ret;
        }

        public bool ContientLettre(char lettre)
        {
            return unMot.Contains(lettre);
        }

        public int IndiceLettre(char lettre)
        {
            int position;
            position = unMot.IndexOf(lettre);
            return position;
        }

        //retourne un tableau d'entiers contenant toutes les positions possibles de la lettre
        public int[] IndicesLettre(char lettre)
        {
            String unMotTemp = unMot;
            int i = 0;
            int indice = 0;
            int[] positions = new int[5] { -1, -1, -1, -1, -1 };
            
            List<char> liste = new List<char>(unMotTemp.ToCharArray());
            List<int> liste2 = new List<int>();

            foreach (char x in liste)
            {
                if (x == lettre)
                {
                    liste2.Add(indice);
                }

                indice++;
            }

            for (int ii = 5; liste2.Count < ii;)
            {
                liste2.Add(-1);
            }

            foreach (int t in liste2)
            {
                positions[i] = t;
                i++;
            }

            /*
            while (unMotTemp.Contains(lettre))
            {

                indice = unMotTemp.IndexOf(lettre) + indice; //pour calculer l'indice du sous-mot
                positions[i] = indice;
                indice = indice + 1;
                if (indice <= 4) unMotTemp = unMotTemp.Substring(indice);
                else break; // je sors du while car fin du mot

                i++;

            }
            */            

            return positions;
        }

        public Char affiche(int indiceLettre)
        {
            return unMot.ElementAt(indiceLettre);
        }

        public String affiche()
        {
            return unMot;
        }

    }
}
