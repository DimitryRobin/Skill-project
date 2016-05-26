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
        string test, test1, test2, test3, test4;
        double opa = 1;
        bool BM;
        bool ID;
        bool Tuto;
        string family = "Palatino Linotype";
        string langueApres = "";

        List<string> LangueElement = new List<string>();

        public FormParametre()
        {
            InitializeComponent();
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

            if (combobLangue.Text == "Francais" || combobLangue.Text == "French")
            {
                langueApres = "Francais";
            }
            else if (combobLangue.Text == "Anglais" || combobLangue.Text == "English")
            {
                langueApres = "Anglais";
            }

            string[] lines = Fonction.lireFichier();


            Fonction.ecrireFichier(opa.ToString(), BM.ToString(), lblPolice.Text, ID.ToString(), langueApres, Tuto.ToString(), "", "");
            
            if (lines[0].ToString() != opa.ToString() || lines[1].ToString() != BM.ToString() || lines[2].ToString() != lblPolice.Text || lines[3].ToString() != ID.ToString()
                 || lines[4].ToString() != langueApres || lines[5].ToString() != Tuto.ToString())
            {
                DialogResult DR = MessageBox.Show(LangueElement[124], LangueElement[125], MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DR == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }            
        }


        private void FormParametre_FormClosed(object sender, FormClosedEventArgs e)
        {
            ecrireFichier();
        }

        private void FormParametre_Load(object sender, EventArgs e)
        {
            LangueElement = Fonction.LangageAppli();
            this.Text = LangueElement[108];
            lblTitreSuggestion.Text = LangueElement[108];
            lblTransparence.Text = LangueElement[109];
            label3.Text = LangueElement[110];
            lblMessageBox.Text = LangueElement[111];
            cbBoiteMessagesOui.Text = LangueElement[112];
            cbBoiteMessagesNon.Text = LangueElement[113];
            lblInfoPolice.Text = LangueElement[114];
            lblRedemRequis3.Text = LangueElement[115];
            label4.Text = LangueElement[116];
            label5.Text = LangueElement[117];
            label2.Text = LangueElement[118];
            label1.Text = LangueElement[119];
            cbTutorielOui.Text = LangueElement[112];
            cbTutorielNon.Text = LangueElement[113];
            cbInfoDefilantesOui.Text = LangueElement[112];
            cbInfoDefilantesNon.Text = LangueElement[113];


            string[] lines = Fonction.lireFichier();

            test = lines[0].ToString();
            test1 = lines[1].ToString();
            lblPolice.Text = lines[2].ToString();
            test2 = lines[3].ToString();
            test4 = lines[4].ToString();
            test3 = lines[5].ToString();

            combobLangue.Items.Clear();

            if (test4 == "Francais")
            {
                combobLangue.Items.Add("Francais");
                combobLangue.Items.Add("Anglais");

                combobLangue.Text = test4;
            }
            else
            {
                combobLangue.Items.Add("French");
                combobLangue.Items.Add("English");

                combobLangue.Text = "English";

            }

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

            Fonction.policeTexte(this); // Gestion police
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

        private void pbPolice_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lblPolice.Text = fontDialog1.Font.Name.ToString();

                if (lblPolice.Text != family)
                {
                    try
                    {
                        foreach (Control x in this.Controls)
                        {
                            // MessageBox.Show(x.ToString());

                            if (x is TextBox || x is RichTextBox || x is Label || x is Button || x is GroupBox || x is ListBox || x is DataGridView || x is ComboBox || x is CheckBox
                                || x is RadioButton || x is TreeView || x is NumericUpDown)
                            {
                                x.Font = new Font(lblPolice.Text, x.Font.SizeInPoints, x.Font.Style);
                            }

                            // Panel
                            if (x is Panel)
                            {
                                foreach (Control c in x.Controls)
                                {
                                    c.Font = new Font(lblPolice.Text, c.Font.SizeInPoints, c.Font.Style);
                                }
                            }

                            // GroupBox
                            if (x is GroupBox)
                            {
                                foreach (Control c in x.Controls)
                                {
                                    c.Font = new Font(lblPolice.Text, c.Font.SizeInPoints, c.Font.Style);
                                }
                            }

                        }
                    }
                    catch
                    {
                        foreach (Control x in this.Controls)
                        {
                            // MessageBox.Show(x.ToString());

                            if (x is TextBox || x is RichTextBox || x is Label || x is Button || x is GroupBox || x is ListBox || x is DataGridView || x is ComboBox || x is CheckBox
                                || x is RadioButton || x is TreeView || x is NumericUpDown)
                            {
                                x.Font = new Font(family, x.Font.SizeInPoints, x.Font.Style);
                            }

                            // Panel
                            if (x is Panel)
                            {
                                foreach (Control c in x.Controls)
                                {
                                    c.Font = new Font(family, c.Font.SizeInPoints, c.Font.Style);
                                }
                            }

                            // GroupBox
                            if (x is GroupBox)
                            {
                                foreach (Control c in x.Controls)
                                {
                                    c.Font = new Font(family, c.Font.SizeInPoints, c.Font.Style);
                                }
                            }

                        }
                    }
                }
                else
                {
                    foreach (Control x in this.Controls)
                    {
                        // MessageBox.Show(x.ToString());

                        if (x is TextBox || x is RichTextBox || x is Label || x is Button || x is GroupBox || x is ListBox || x is DataGridView || x is ComboBox || x is CheckBox
                            || x is RadioButton || x is TreeView || x is NumericUpDown)
                        {
                            x.Font = new Font(family, x.Font.SizeInPoints, x.Font.Style);
                        }

                        // Panel
                        if (x is Panel)
                        {
                            foreach (Control c in x.Controls)
                            {
                                c.Font = new Font(family, c.Font.SizeInPoints, c.Font.Style);
                            }
                        }

                        // GroupBox
                        if (x is GroupBox)
                        {
                            foreach (Control c in x.Controls)
                            {
                                c.Font = new Font(family, c.Font.SizeInPoints, c.Font.Style);
                            }
                        }

                    }
                }

            }
        }

        private void btnDefautPolice_Click(object sender, EventArgs e)
        {
            if (lblPolice.Text == "Palatino Linotype")
            {
                // MessageBox.Show(LangueElement[124], LangueElement[105], MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(LangueElement[122] + lblTitreSuggestion.Font.Name, LangueElement[123], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // lblTitrePara.Font = new Font(family, lblTitrePara.Font.SizeInPoints, lblTitrePara.Font.Style);

                foreach (Control x in this.Controls)
                {
                    // MessageBox.Show(x.ToString());

                    if (x is TextBox || x is RichTextBox || x is Label || x is Button || x is GroupBox || x is ListBox || x is DataGridView || x is ComboBox || x is CheckBox
                        || x is RadioButton || x is TreeView || x is NumericUpDown)
                    {
                        x.Font = new Font(family, x.Font.SizeInPoints, x.Font.Style);
                    }

                    // Panel
                    if (x is Panel)
                    {
                        foreach (Control c in x.Controls)
                        {
                            c.Font = new Font(family, c.Font.SizeInPoints, c.Font.Style);
                        }
                    }

                    // GroupBox
                    if (x is GroupBox)
                    {
                        foreach (Control c in x.Controls)
                        {
                            c.Font = new Font(family, c.Font.SizeInPoints, c.Font.Style);
                        }
                    }

                }

                lblPolice.Text = "Palatino Linotype";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void combobLangue_SelectedIndexChanged(object sender, EventArgs e)
        {

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
