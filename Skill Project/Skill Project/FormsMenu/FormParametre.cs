using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Project
{
    public partial class FormParametre : System.Windows.Forms.Form
    {
        string test, test1, test2, test3;
        double opa = 1;
        bool BM;
        bool ID;
        bool Tuto;

        public FormParametre()
        {
            InitializeComponent();
        }

        private void creationFichier()
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

            string[] lines = { opa.ToString(), BM.ToString(), ID.ToString(), Tuto.ToString() };
            System.IO.File.WriteAllLines(@"C:\SkillProject\Preferences_SkillProject.txt", lines);
        }

        private void ecrireFichier()
        {
            if(cbBoiteMessagesOui.Checked == true)
            {
                BM = true;
            }
            else
            {
                BM = false;
            }

            if (cbInfoDefilantesOui.Checked == true)
            {
                ID = true;
            }
            else
            {
                ID = false;
            }

            if (cbTutorielOui.Checked == true)
            {
                Tuto = true;
            }
            else
            {
                Tuto = false;
            }

            string[] lines = { opa.ToString(), BM.ToString(), ID.ToString(), Tuto.ToString() };
            System.IO.File.WriteAllLines(@"C:\SkillProject\Preferences_SkillProject.txt", lines);
        }

        private void lireFichier()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\SkillProject\Preferences_SkillProject.txt");

            test = lines[0].ToString();
            test1 = lines[1].ToString();
            test2 = lines[2].ToString();
            test3 = lines[3].ToString();
        }


        private void FormParametre_FormClosed(object sender, FormClosedEventArgs e)
        {
            ecrireFichier();
        }

        private void FormParametre_Load(object sender, EventArgs e)
        {
            string curFile = @"C:\SkillProject\Preferences_SkillProject.txt";

            if (File.Exists(curFile))
            {
                lireFichier();
                Opacity = Convert.ToDouble(test);
                hScrollBar1.Value = Convert.ToInt32(Opacity * 100);

                if (test1.ToString() == "True")
                {
                    cbBoiteMessagesNon.Checked = false;
                    cbBoiteMessagesOui.Checked = true;
                }
                else
                {
                    cbBoiteMessagesOui.Checked = false;
                    cbBoiteMessagesNon.Checked = true;
                }

                if (test2.ToString() == "True")
                {
                    cbInfoDefilantesNon.Checked = false;
                    cbInfoDefilantesOui.Checked = true;
                }
                else
                {
                    cbInfoDefilantesOui.Checked = false;
                    cbInfoDefilantesNon.Checked = true;
                }

                if (test3.ToString() == "True")
                {
                    CbTutorielNon.Checked = false;
                    CbTutorielOui.Checked = true;
                }
                else
                {
                    CbTutorielOui.Checked = false;
                    CbTutorielNon.Checked = true;
                }
            }
            else
            {
                creationFichier();
            }
        }

        private void FormParametre_Leave(object sender, EventArgs e)
        {

        }

        private void FormParametre_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            lblNbTransparence.Text = hScrollBar1.Value.ToString();
            opa = Convert.ToDouble(Convert.ToDouble((lblNbTransparence.Text)) / 100);
            Opacity = opa;

            FormIndex.ActiveForm.Opacity = opa;
        }

        private void cbTutorielOui_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbTutorielNon_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbTutorielNon_Click(object sender, EventArgs e)
        {
            cbTutorielOui.Checked = false;
            cbTutorielNon.Checked = true;

            Tuto = false;
        }

        private void cbTutorielOui_Click(object sender, EventArgs e)
        {
            cbTutorielNon.Checked = false;
            cbTutorielOui.Checked = true;

            Tuto = true;
        }

        private void cbInfoDefilantesOui_Click(object sender, EventArgs e)
        {
            cbInfoDefilantesOui.Checked = true;
            cbInfoDefilantesNon.Checked = false;

            ID = true;
        }

        private void cbInfoDefilantesNon_Click(object sender, EventArgs e)
        {
            cbInfoDefilantesOui.Checked = false;
            cbInfoDefilantesNon.Checked = true;

            ID = false;
        }

        private void cbBoiteMessagesOui_Click(object sender, EventArgs e)
        {
            cbBoiteMessagesOui.Checked = true;
            cbBoiteMessagesNon.Checked = false;

            BM = true;
        }

        private void cbBoiteMessagesNon_Click(object sender, EventArgs e)
        {
            cbBoiteMessagesOui.Checked = false;
            cbBoiteMessagesNon.Checked = true;

            BM = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
