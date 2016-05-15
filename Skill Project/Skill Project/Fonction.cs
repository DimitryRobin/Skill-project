using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Project
{
    class Fonction
    {
        public static string fileName2 = @"C:\SkillProject\Preferences_SkillProject.txt";

        public static void ecrireFichier(string transparence, string BoiteMessage, string Police, string InformationsDefilantes, string Langue, string Tutoriel, string provenance, string dateprovenance)
        {
            // On récupère tout
            StreamReader reader = File.OpenText(fileName2);
            string ligne;

            List<string> listeElement = new List<string>();
            while (!reader.EndOfStream)
            {
                ligne = reader.ReadLine();
                listeElement.Add(ligne);
            }
            reader.Close();

            // Debut MAJ

            // Gestion recents
            if(provenance != "")
            {
                listeElement[11] = listeElement[9];
                listeElement[10] = listeElement[8];
                listeElement[9] = listeElement[7];
                listeElement[8] = listeElement[6];
                listeElement[7] = dateprovenance;
                listeElement[6] = provenance;
            }

            // Gestion transparence
            if (transparence != "")
            {
                listeElement[0] = transparence;
            }

            // Gestion des boites de messages
            if (BoiteMessage != "")
            {
                listeElement[1] = BoiteMessage;
            }

            // Gestion de la police
            if (Police != "")
            {
                listeElement[2] = Police;
            }

            // Gestion des Informations Defilantes
            if (InformationsDefilantes != "")
            {
                listeElement[3] = InformationsDefilantes;
            }

            // Gestion de la Langue
            if (Langue != "")
            {
                listeElement[4] = Langue;
            }

            // Gestion du Tutoriel
            if (Tutoriel != "")
            {
                listeElement[5] = Tutoriel;
            }


            // Fin MAJ

            // on renvoie tout

            StreamWriter writer = new StreamWriter(fileName2);

            foreach (var item in listeElement)
            {
                writer.WriteLine(item);
            }
            writer.Close();

        }


        public static List<string> Preference()
        {            
            StreamReader reader = File.OpenText(fileName2);
            string ligne;

            List<string> listeElement = new List<string>();
            while (!reader.EndOfStream)
            {
                ligne = reader.ReadLine();
                listeElement.Add(ligne);
            }
            reader.Close();

            if (listeElement[4] == "Francais")
            {
                listeElement[4] = "Francais.txt";
            }

            if (listeElement[4] == "Anglais")
            {
                listeElement[4] = "Anglais.txt";
            }

            return listeElement;
        }

        public static List<string> LectureProjet()
        {
            List<string> ListeProjet = new List<string>();
            List<string> Langue = new List<string>();

            Langue = Preference();
            string name = "Projet" + Langue[4];

            // string fileName = @"Langage\Projet\"+ name; // Une fois publié
            string fileName = @"..\..\Langage\Projet\"+ name;

            StreamReader reader = File.OpenText(fileName);
            string ligne;

            while (!reader.EndOfStream)
            {
                ligne = reader.ReadLine();
                ListeProjet.Add(ligne);
            }
            reader.Close();

            return ListeProjet;
        }

        public static void creationFichier()
        {
            string folderName = @"c:\";
            string pathString = System.IO.Path.Combine(folderName, "SkillProject");
            System.IO.Directory.CreateDirectory(pathString);
            string fileName = "Preferences_SkillProject.txt";
            pathString = System.IO.Path.Combine(pathString, fileName);


            Console.WriteLine("Path to my file: {0}\n", pathString);


            using (System.IO.FileStream fs = new System.IO.FileStream(pathString, FileMode.Append))
            {

                for (byte i = 0; i < 100; i++)
                {
                    fs.WriteByte(i);
                }

            }

            try
            {
                byte[] readBuffer = System.IO.File.ReadAllBytes(pathString);
                foreach (byte b in readBuffer)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }

            string[] lines = { "1", "True", "Palatino Linotype", "False", "Francais", "True" , "Aucun", "jj/mm/aaaa", "Aucun", "jj/mm/aaaa", "Aucun", "jj/mm/aaaa" };
            System.IO.File.WriteAllLines(@"C:\SkillProject\Preferences_SkillProject.txt", lines);
        }

        public static string[] lireFichier()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\SkillProject\Preferences_SkillProject.txt");

            return lines;
        }

        public static int InputBox(string title, string promptText)
        {
            Form form = new Form();
            LinkLabel texte = new LinkLabel();
            ProgressBar Progress = new ProgressBar();

            Progress.Minimum = 0;
            Progress.Maximum = 100;

            form.Text = title;
            texte.Text = promptText;
            texte.SetBounds(9, 20, 372, 13);
            Progress.SetBounds(9, 30, 372, 20);

            texte.AutoSize = true;
            Progress.Anchor = Progress.Anchor | AnchorStyles.Right;

            form.ClientSize = new Size(396, 91);
            form.Controls.AddRange(new Control[] { texte, Progress });
            form.ClientSize = new Size(Math.Max(300, texte.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            Progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;

            form.Show();

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10); // --> Timer au tick

                Progress.Value += 1;
                form.Show();
            }

            int Res = Progress.Value;
            if (Res == 100)
                form.Close();

            return Res;
        }
    }
}
