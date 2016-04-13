using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Skill_Project
{
    public partial class FormSuggestion : System.Windows.Forms.Form
    {
        public static Cursor IBeam { get; }
        public static Cursor Default { get; }
        public bool IsBalloon { get; set; }
        // public Brush BorderBrush { get; set; } // fonctionne pas 

        public int click = 0;
        public int click2 = 0;
        public int click3 = 0;
        public int click4 = 0;
        public string sexe;

        public FormSuggestion()
        {
            InitializeComponent();
        }

        private void btnRetourSuggestion_Click(object sender, EventArgs e)
        {
            FormIndex FI = (FormIndex)this.MdiParent;
            
            
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

            FI.SuggestionToolStripMenuItem.BackColor = Color.Transparent;
            FI.AffichageToolStripMenuItem.BackColor = Color.SandyBrown;
        }

        private void tbNom_Click(object sender, EventArgs e)
        {
            tbNom.Clear();
            tbDate2.Clear();
            tbDate2.Text = DateTime.Now.ToString();
            tbDate2.Visible = true;
            lblDate2.Visible = true;
            lblDate.Visible = false;
            tbDate.Visible = false;

            tbNom.Clear(); // Palatino Linotype; 12pt; style=Bold
            tbNom.Cursor = IBeam;
            tbNom.ForeColor = Color.Black;
            click = 1;

            if(tbPrénom.Text == "")
            {
                tbPrénom.ForeColor = Color.DarkGray;
                tbPrénom.Clear();

                tbPrénom.ForeColor = Color.DarkGray;
                tbPrénom.Cursor = Default;
                tbPrénom.Text = "Prénom";
                click3 = 0;
            }

            if(rtbSuggestion.Text == "")
            {
                rtbSuggestion.ForeColor = Color.DarkGray;
                rtbSuggestion.Clear();
                rtbSuggestion.ForeColor = Color.DarkGray;

                rtbSuggestion.Cursor = Default;
                rtbSuggestion.Text = "Rédigez votre suggestion..";
                click2 = 0;
            }

            if (tbMail.Text == "")
            {
                tbMail.ForeColor = Color.DarkGray;
                tbMail.Clear();
                tbMail.ForeColor = Color.DarkGray;

                tbMail.Cursor = Default;
                tbMail.Text = "Adresse Mail";
                click4 = 0;
            }
        }
        
        private void tbNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSuggestion_Leave(object sender, EventArgs e)
        {

        }

        private void tbPrénom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrénom_Click(object sender, EventArgs e)
        {
            tbPrénom.Clear();

            tbDate2.Clear();
            tbDate2.Text = DateTime.Now.ToString();
            tbDate2.Visible = true;
            lblDate2.Visible = true;
            lblDate.Visible = false;
            tbDate.Visible = false;

            tbPrénom.Clear(); // Palatino Linotype; 12pt; style=Bold
            tbPrénom.Cursor = IBeam;
            tbPrénom.ForeColor = Color.Black;
            click3 = 1;

            if (tbNom.Text == "")
            {
                tbNom.ForeColor = Color.DarkGray;
                tbNom.Clear();
                tbNom.ForeColor = Color.DarkGray;

                tbNom.Cursor = Default;
                tbNom.Text = "Nom";
                click = 0;
            }

            if (rtbSuggestion.Text == "")
            {
                rtbSuggestion.ForeColor = Color.DarkGray;
                rtbSuggestion.Clear();
                rtbSuggestion.ForeColor = Color.DarkGray;

                rtbSuggestion.Cursor = Default;
                rtbSuggestion.Text = "Rédigez votre suggestion..";
                click2 = 0;
            }

            if (tbMail.Text == "")
            {
                tbMail.ForeColor = Color.DarkGray;
                tbMail.Clear();
                tbMail.ForeColor = Color.DarkGray;

                tbMail.Cursor = Default;
                tbMail.Text = "Adresse Mail";
                click4 = 0;
            }
        }

        private void rtbSuggestion_TextChanged(object sender, EventArgs e)
        {
            click2 = click2 + 1;
            if (click2 != 1)
            {
                if (rtbSuggestion.Text == "")
                {
                    rtbSuggestion.ForeColor = Color.DarkGray;

                    rtbSuggestion.Cursor = Default;
                    rtbSuggestion.Text = "Rédigez votre suggestion..";
                    click2 = 0;
                }
            }
            else
            {
                rtbSuggestion.Clear();
                rtbSuggestion.ForeColor = Color.Black;
                rtbSuggestion.Cursor = Default;
            }
        }

        private void rtbSuggestion_Click(object sender, EventArgs e)
        {
            if(rtbSuggestion.Text == "Rédigez votre suggestion..")
            {
                rtbSuggestion.Clear();
            }

            tbDate2.Clear();
            tbDate2.Text = DateTime.Now.ToString();
            tbDate2.Visible = true;
            lblDate2.Visible = true;
            lblDate.Visible = false;
            tbDate.Visible = false;
            
            rtbSuggestion.Refresh();
            

            rtbSuggestion.Cursor = IBeam;
            rtbSuggestion.ForeColor = Color.Black;
            click2 = 1;

            if (tbNom.Text == "")
            {
                tbNom.ForeColor = Color.DarkGray;
                tbNom.Clear();
                tbNom.ForeColor = Color.DarkGray;

                tbNom.Cursor = Default;
                tbNom.Text = "Nom";
                click = 0;
            }

            if (tbPrénom.Text == "")
            {
                tbPrénom.ForeColor = Color.DarkGray;
                tbPrénom.Clear();
                tbPrénom.ForeColor = Color.DarkGray;
                tbPrénom.Cursor = Default;
                tbPrénom.Text = "Prénom";
                click3 = 0;
            }

            if (tbMail.Text == "")
            {
                tbMail.ForeColor = Color.DarkGray;
                tbMail.Clear();
                tbMail.ForeColor = Color.DarkGray;

                tbMail.Cursor = Default;
                tbMail.Text = "Adresse Mail";
                click4 = 0;
            }
        }

        private void FormSuggestion_Load(object sender, EventArgs e)
        {
            tbDate2.Text = DateTime.Now.ToString();
        }

        private void btnEnvoyerSuggestion_Click(object sender, EventArgs e)
        {
            int durationMilliseconds = 3000;

            tbDate2.Clear();
            tbDate2.Text = DateTime.Now.ToString();

            if (tbNom.Text == "" || tbNom.Text == "Nom")
            {
                toolTip1.Show(toolTip1.GetToolTip(tbNom), tbNom, durationMilliseconds);
            }
            if(tbPrénom.Text == "" || tbPrénom.Text == "Prénom")
            {
                toolTip2.Show(toolTip2.GetToolTip(tbPrénom), tbPrénom, durationMilliseconds);
            }
            if (tbMail.Text == "" || tbMail.Text == "Adresse Mail")
            {
                toolTip6.Show(toolTip6.GetToolTip(tbMail), tbMail, durationMilliseconds);
            }
            if (nudAge.Value <= 0)
            {
                toolTip3.Show(toolTip3.GetToolTip(nudAge), nudAge, durationMilliseconds);
            }
            if (rbF.Checked == false && rbM.Checked == false)
            {
                toolTip4.Show(toolTip4.GetToolTip(rbF), rbF, durationMilliseconds);
            }
            if (rtbSuggestion.Text == "" || rtbSuggestion.Text == "Rédigez votre suggestion..")
            {
                toolTip5.Show(toolTip5.GetToolTip(rtbSuggestion), rtbSuggestion, durationMilliseconds);
            }

            // envoie

            if (tbMail.Text != "" && tbMail.Text != "Adresse Mail" && tbNom.Text != "" && tbNom.Text != "Nom" && tbPrénom.Text != "" && tbPrénom.Text != "Prénom" && nudAge.Value != 0 && rbF.Checked == true && rtbSuggestion.Text != "" && rtbSuggestion.Text != "Rédigez votre suggestion..")
            {
                tbDate2.Visible = false;
                lblDate2.Visible = false;
                pbSuggestion.Visible = true;
                pbSuggestion.Minimum = 0;
                pbSuggestion.Maximum = 8;
                pbSuggestion.Value = pbSuggestion.Minimum;

                while (pbSuggestion.Value < pbSuggestion.Maximum)
                {
                    pbSuggestion.Value += 1;
                    System.Threading.Thread.Sleep(500); //Cette ligne ne sert qu'a stopper l'exécution 1 seconde entre chaque changement de la progressBar.
                }

                if(rbF.Checked == true)
                {
                    sexe = "Femme";
                }
                else
                {
                    sexe = "Homme";
                }

                MailAddress from = new MailAddress("skillproject@hotmail.com");
                MailAddress to = new MailAddress("dimy@hotmail.fr");
                MailMessage email = new MailMessage(from, to);
                email.Subject = "Suggestion Skill Project";
                email.Body = "Date & Heure : " + tbDate2.Text + "\n\nNom : " + tbNom.Text + ".\nPrénom : " + tbPrénom.Text + ".\n\nEmail : " + tbMail.Text + ".\n\nAge : " + nudAge.Value + ".\nSexe : " + sexe + ".\n\n\nSuggestion :\n\n " + rtbSuggestion.Text;
                SmtpClient client = new SmtpClient("smtp.live.com");
                client.Port = 587;
                #region Confidentiel
                client.Credentials = new System.Net.NetworkCredential("skillproject@hotmail.com", "Dimtchek12");
                #endregion
                client.EnableSsl = true;

                try
                {
                    client.Send(email);
                    pbSuggestion.Visible = false;

                    tbNom.Clear();
                    tbPrénom.Clear();
                    tbMail.Clear();
                    nudAge.Value = 0;
                    rbF.Checked = false;
                    rbM.Checked = false;
                    rtbSuggestion.Clear();
                    tbDate2.Clear();
                    tbDate2.Text = DateTime.Now.ToString();
                    tbDate.Clear();
                    tbDate.Text = DateTime.Now.ToString();
                    tbDate2.Visible = false;
                    lblDate2.Visible = false;
                    lblDate.Visible = true;
                    tbDate.Visible = true;
                }

                catch (SmtpException ex)
                {
                    MessageBox.Show("Erreur dans l'envoi : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (tbMail.Text != "" && tbMail.Text != "Adresse Mail" && tbNom.Text != "" && tbNom.Text != "Nom" && tbPrénom.Text != "" && tbPrénom.Text != "Prénom" && nudAge.Value != 0 && rbM.Checked == true && rtbSuggestion.Text != "" && rtbSuggestion.Text != "Rédigez votre suggestion..")
            {
                tbDate2.Visible = false;
                lblDate2.Visible = false;

                pbSuggestion.Visible = true;
                pbSuggestion.Minimum = 0;
                pbSuggestion.Maximum = 8;
                pbSuggestion.Value = pbSuggestion.Minimum;

                while (pbSuggestion.Value < pbSuggestion.Maximum)
                {
                    pbSuggestion.Value += 1;
                    System.Threading.Thread.Sleep(500); //Cette ligne ne sert qu'a stopper l'exécution 1 seconde entre chaque changement de la progressBar.
                }

                if (rbF.Checked == true)
                {
                    sexe = "Femme";
                }
                else
                {
                    sexe = "Homme";
                }

                MailAddress from = new MailAddress("skillproject@hotmail.com");
                MailAddress to = new MailAddress("dimy@hotmail.fr");
                MailMessage email = new MailMessage(from, to);
                email.Subject = "Suggestion Skill Project";
                email.Body = "Date & Heure : " + tbDate2.Text + "\n\nNom : " + tbNom.Text + ".\nPrénom : " + tbPrénom.Text + ".\n\nEmail : " + tbMail.Text + ".\n\nAge : " + nudAge.Value + ".\nSexe : " + sexe + ".\n\n\nSuggestion :\n\n " + rtbSuggestion.Text;
                SmtpClient client = new SmtpClient("smtp.live.com");
                client.Port = 587;
                #region Confidentiel
                client.Credentials = new System.Net.NetworkCredential("skillproject@hotmail.com", "Dimtchek12");
                #endregion
                client.EnableSsl = true;

                try
                {
                    client.Send(email);
                    pbSuggestion.Visible = false;

                    tbNom.Clear();
                    tbPrénom.Clear();
                    tbMail.Clear();
                    nudAge.Value = 0;
                    rbF.Checked = false;
                    rbM.Checked = false;
                    rtbSuggestion.Clear();
                    tbDate2.Clear();
                    tbDate2.Text = DateTime.Now.ToString();
                    tbDate.Clear();
                    tbDate.Text = DateTime.Now.ToString();
                    tbDate2.Visible = false;
                    lblDate2.Visible = false;
                    lblDate.Visible = true;
                    tbDate.Visible = true;
                }

                catch (SmtpException ex)
                {
                    MessageBox.Show("Erreur dans l'envoi : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void rbF_Click(object sender, EventArgs e)
        {
            tbDate2.Clear();
            tbDate2.Text = DateTime.Now.ToString();
            tbDate2.Visible = true;
            lblDate2.Visible = true;
            lblDate.Visible = false;
            tbDate.Visible = false;

            rbM.Checked = false;
        }

        private void rbM_Click(object sender, EventArgs e)
        {
            tbDate2.Clear();
            tbDate2.Text = DateTime.Now.ToString();
            tbDate2.Visible = true;
            lblDate2.Visible = true;
            lblDate.Visible = false;
            tbDate.Visible = false;

            rbF.Checked = false;
        }

        private void tbMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMail_Click(object sender, EventArgs e)
        {
            tbMail.Clear();

            tbDate2.Clear();
            tbDate2.Text = DateTime.Now.ToString();
            tbDate2.Visible = true;
            lblDate2.Visible = true;
            lblDate.Visible = false;
            tbDate.Visible = false;

            tbMail.Clear(); // Palatino Linotype; 12pt; style=Bold
            tbMail.Cursor = IBeam;
            tbMail.ForeColor = Color.Black;
            click4 = 1;

            if (tbNom.Text == "")
            {
                tbNom.ForeColor = Color.DarkGray;
                tbNom.Clear();
                tbNom.ForeColor = Color.DarkGray;

                tbNom.Cursor = Default;
                tbNom.Text = "Nom";
                click = 0;
            }

            if (rtbSuggestion.Text == "")
            {
                rtbSuggestion.ForeColor = Color.DarkGray;
                rtbSuggestion.Clear();
                rtbSuggestion.ForeColor = Color.DarkGray;

                rtbSuggestion.Cursor = Default;
                rtbSuggestion.Text = "Rédigez votre suggestion..";
                click2 = 0;
            }

            if (tbPrénom.Text == "")
            {
                tbPrénom.ForeColor = Color.DarkGray;
                tbPrénom.Clear();
                tbPrénom.ForeColor = Color.DarkGray;
                tbPrénom.Cursor = Default;
                tbPrénom.Text = "Prénom";
                click3 = 0;
            }
        }

        private void tbNom_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbNom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9)
            {
                MessageBox.Show("Vous devez entrer une chaîne de caractère !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbNom.Clear();
            }
        }

        private void tbPrénom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9)
            {
                MessageBox.Show("Vous devez entrer une chaîne de caractère !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbPrénom.Clear();
            }
        }

        private void tbNom_Leave(object sender, EventArgs e)
        {
            if(tbNom.Text == "Nom" || tbNom.Text == "" || tbNom.Text == " ")
            {
                tbNom.ForeColor = Color.DarkGray;

                tbNom.Cursor = Default;
                tbNom.Text = "Nom";
            }
        }

        private void tbPrénom_Leave(object sender, EventArgs e)
        {
            if (tbPrénom.Text == "Prénom" || tbPrénom.Text == "" || tbPrénom.Text == " ")
            {
                tbPrénom.ForeColor = Color.DarkGray;

                tbPrénom.Cursor = Default;
                tbPrénom.Text = "Prénom";
            }
        }

        private void tbMail_Leave(object sender, EventArgs e)
        {

            if (tbMail.Text == "Adresse Mail" || tbMail.Text == "" || tbMail.Text == " ")
            {
                tbMail.ForeColor = Color.DarkGray;

                tbMail.Cursor = Default;
                tbMail.Text = "Adresse Mail";
            }
        }

        private void rtbSuggestion_Leave(object sender, EventArgs e)
        {
            if (rtbSuggestion.Text == "Rédigez votre suggestion.." || rtbSuggestion.Text == "" || rtbSuggestion.Text == " ")
            {
                rtbSuggestion.ForeColor = Color.DarkGray;

                rtbSuggestion.Cursor = Default;
                rtbSuggestion.Text = "Rédigez votre suggestion..";
            }
        }

        private void tbPrénom_Enter(object sender, EventArgs e)
        {
            tbPrénom_Click(sender, e);
        }

        private void tbNom_Enter(object sender, EventArgs e)
        {
            tbNom_Click(sender, e);
        }

        private void tbMail_Enter(object sender, EventArgs e)
        {
            tbMail_Click(sender, e);
        }
    }
}
