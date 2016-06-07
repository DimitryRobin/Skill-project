using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Project.FormsCompetence.Morpion
{
    public partial class FormJoueur : Form
    {
        string mode, provenance, j1, j2;
        List<string> LangueElement = new List<string>();

        public FormJoueur(string provenance2)
        {
            InitializeComponent();

            provenance = provenance2;
        }

        private void rbOrdi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb2j_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormJoueur_Load(object sender, EventArgs e)
        {
            LangueElement = Fonction.LangageAppli();
            rbOrdi.Text = LangueElement[195];
            rb2j.Text = LangueElement[196];
            label1.Text = LangueElement[197];
            label2.Text = LangueElement[199];
            btnJouer.Text = LangueElement[200];

            Fonction.policeTexte(this); // Gestion police
        }

        private void FormJoueur_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox1.Clear(); // Palatino Linotype; 12pt; style=Bold
            textBox1.Cursor = Cursors.IBeam;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            textBox2.Clear(); // Palatino Linotype; 12pt; style=Bold
            textBox2.Cursor = Cursors.IBeam;
            textBox2.ForeColor = Color.Black;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1_Click(sender, e);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2_Click(sender, e);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "Pseudonyme.." || textBox1.Text == "" || textBox1.Text == " ")
            {
                textBox1.ForeColor = Color.DarkGray;

                textBox1.Cursor = Cursors.Default;
                textBox1.Text = "Pseudonyme..";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "Pseudonyme.." || textBox2.Text == "" || textBox2.Text == " ")
            {
                textBox2.ForeColor = Color.DarkGray;

                textBox2.Cursor = Cursors.Default;
                textBox2.Text = "Pseudonyme..";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbOrdi.Checked == true)
            {
                if (e.KeyChar.ToString() == "\r")
                    btnJouer.PerformClick();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rb2j.Checked == true)
            {
                if (e.KeyChar.ToString() == "\r")
                    btnJouer.PerformClick();
            }
        }

        private void rbOrdi_Click(object sender, EventArgs e)
        {
            this.Size = new Size(328, 146);
            btnJouer.Location = new Point(225, 78);

            label1.Text = LangueElement[197];

            rb2j.Checked = false;
            
            label2.Visible = false;
            textBox2.Visible = false;
        }

        private void rb2j_Click(object sender, EventArgs e)
        {
            this.Size=new Size(328, 172);
            btnJouer.Location = new Point(225, 105);
        
            label1.Text = LangueElement[198];

            rbOrdi.Checked = false;
            
            label2.Visible = true;
            textBox2.Visible = true;
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            if (rbOrdi.Checked == true)
            {
                mode = "0";

                if(textBox1.Text != "Pseudonyme.." && textBox1.Text != "" && textBox1.Text != " " && textBox1.Text != "  " && textBox1.Text != "   " && textBox1.Text != "    " &&
                    textBox1.Text != "     " && textBox1.Text != "      " && textBox1.Text != "       " && textBox1.Text != "        " && textBox1.Text != "         ")
                {
                    j1 = textBox1.Text;
                    j2 = "";

                    FormProjetMorpion.recupNomJoueur(mode, j1, j2);

                    this.Close();
                }
                else
                {
                    MessageBox.Show(LangueElement[201], LangueElement[202], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                mode = "1";

                if (textBox1.Text != "Pseudonyme.." && textBox1.Text != "" && textBox1.Text != " " && textBox1.Text != "  " && textBox1.Text != "   " && textBox1.Text != "    " &&
                    textBox1.Text != "     " && textBox1.Text != "      " && textBox1.Text != "       " && textBox1.Text != "        " && textBox1.Text != "         " &&
                    textBox2.Text != "Pseudonyme.." && textBox2.Text != "" && textBox2.Text != " " && textBox2.Text != "  " && textBox2.Text != "   " && textBox2.Text != "    " &&
                    textBox2.Text != "     " && textBox2.Text != "      " && textBox2.Text != "       " && textBox2.Text != "        " && textBox2.Text != "         "
                    && textBox1.Text != textBox2.Text)
                {
                    j1 = textBox1.Text;
                    j2 = textBox2.Text;

                    FormProjetMorpion.recupNomJoueur(mode, j1, j2);

                    this.Close();
                }
                else
                {
                    MessageBox.Show(LangueElement[203] + "\n" + LangueElement[204], LangueElement[202], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
