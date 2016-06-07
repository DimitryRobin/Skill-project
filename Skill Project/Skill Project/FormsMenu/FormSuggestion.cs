using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

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

        List<string> LangueElement = new List<string>();

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
                tbPrénom.Text = LangueElement[28];
                click3 = 0;
            }

            if(rtbSuggestion.Text == "")
            {
                rtbSuggestion.ForeColor = Color.DarkGray;
                rtbSuggestion.Clear();
                rtbSuggestion.ForeColor = Color.DarkGray;

                rtbSuggestion.Cursor = Default;
                rtbSuggestion.Text = LangueElement[32];
                click2 = 0;
            }

            if (tbMail.Text == "")
            {
                tbMail.ForeColor = Color.DarkGray;
                tbMail.Clear();
                tbMail.ForeColor = Color.DarkGray;

                tbMail.Cursor = Default;
                tbMail.Text = LangueElement[29];
                click4 = 0;
            }
        }
        
        private void tbNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSuggestion_Leave(object sender, EventArgs e)
        {
            this.Close();
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
                tbNom.Text = LangueElement[27];
                click = 0;
            }

            if (rtbSuggestion.Text == "")
            {
                rtbSuggestion.ForeColor = Color.DarkGray;
                rtbSuggestion.Clear();
                rtbSuggestion.ForeColor = Color.DarkGray;

                rtbSuggestion.Cursor = Default;
                rtbSuggestion.Text = LangueElement[32];
                click2 = 0;
            }

            if (tbMail.Text == "")
            {
                tbMail.ForeColor = Color.DarkGray;
                tbMail.Clear();
                tbMail.ForeColor = Color.DarkGray;

                tbMail.Cursor = Default;
                tbMail.Text = LangueElement[29];
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
                    rtbSuggestion.Text = LangueElement[32];
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
            if(rtbSuggestion.Text == LangueElement[32])
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
                tbNom.Text = LangueElement[27];
                click = 0;
            }

            if (tbPrénom.Text == "")
            {
                tbPrénom.ForeColor = Color.DarkGray;
                tbPrénom.Clear();
                tbPrénom.ForeColor = Color.DarkGray;
                tbPrénom.Cursor = Default;
                tbPrénom.Text = LangueElement[28];
                click3 = 0;
            }

            if (tbMail.Text == "")
            {
                tbMail.ForeColor = Color.DarkGray;
                tbMail.Clear();
                tbMail.ForeColor = Color.DarkGray;

                tbMail.Cursor = Default;
                tbMail.Text = LangueElement[29];
                click4 = 0;
            }
        }

        private void FormSuggestion_Load(object sender, EventArgs e)
        {
            LangueElement = Fonction.LangageAppli();
            this.Text = LangueElement[22];
            lblTitreSuggestion.Text = LangueElement[23];
            lblInfoSuggesstion.Text = LangueElement[24];
            lblInfo2Suggestion.Text = LangueElement[25];
            lblInfo3Suggestion.Text = LangueElement[26];
            tbNom.Text = LangueElement[27];
            tbPrénom.Text = LangueElement[28];
            tbMail.Text = LangueElement[29];
            lblAge.Text = LangueElement[30];
            lblSexe.Text = LangueElement[31];
            rtbSuggestion.Text = LangueElement[32];
            btnRetourSuggestion.Text = LangueElement[33];
            lblDate2.Text = LangueElement[34];
            lblDate.Text = LangueElement[35];
            btnEnvoyerSuggestion.Text = LangueElement[36];

            toolTip1.ToolTipTitle = LangueElement[37];
            toolTip3.ToolTipTitle = LangueElement[38];
            toolTip4.ToolTipTitle = LangueElement[39];


            Fonction.policeTexte(this); // Gestion police
            timer1.Start();
        }

        private void btnEnvoyerSuggestion_Click(object sender, EventArgs e)
        {
            int durationMilliseconds = 3000;

            tbDate2.Clear();
            tbDate2.Text = DateTime.Now.ToString();

            if (tbNom.Text == "" || tbNom.Text == LangueElement[27])
            {
                toolTip1.Show(toolTip1.GetToolTip(tbNom), tbNom, durationMilliseconds);
            }
            if(tbPrénom.Text == "" || tbPrénom.Text == LangueElement[28])
            {
                toolTip2.Show(toolTip2.GetToolTip(tbPrénom), tbPrénom, durationMilliseconds);
            }
            if (tbMail.Text == "" || tbMail.Text == LangueElement[29])
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
            if (rtbSuggestion.Text == "" || rtbSuggestion.Text == LangueElement[32])
            {
                toolTip5.Show(toolTip5.GetToolTip(rtbSuggestion), rtbSuggestion, durationMilliseconds);
            }

            // envoie

            if (tbMail.Text != "" && tbMail.Text != LangueElement[29] && tbNom.Text != "" && tbNom.Text != LangueElement[27] && tbPrénom.Text != "" && tbPrénom.Text != LangueElement[28] && nudAge.Value != 0 && rbF.Checked == true && rtbSuggestion.Text != "" && rtbSuggestion.Text != LangueElement[32])
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
                

                // MailAddress from = new MailAddress("tirdimpact@yahoo.com");
                MailAddress from = new MailAddress("skillproject@hotmail.com");
                MailAddress to = new MailAddress("tirdimpact@yahoo.com");
                // MailAddress to = new MailAddress("dimy@hotmail.fr");

                MailMessage email = new MailMessage(from, to);
                email.Subject = "Suggestion Skill Project";
                email.Body = "Date & Heure : " + tbDate2.Text + "\n\nNom : " + tbNom.Text + ".\nPrénom : " + tbPrénom.Text + ".\n\nEmail : " + tbMail.Text + ".\n\nAge : " + nudAge.Value + ".\nSexe : " + sexe + ".\n\n\nSuggestion :\n\n " + rtbSuggestion.Text;
                // SmtpClient client = new SmtpClient("smtp.mail.yahoo.com");
                SmtpClient client = new SmtpClient("smtp.live.com");
                // SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                // client.Port = 465;
                #region Confidentiel
                // client.Credentials = new System.Net.NetworkCredential("tirdimpact@yahoo.com", "Dimtchek12");
                client.Credentials = new System.Net.NetworkCredential("skillproject@hotmail.com", "Dimtchek12");
                #endregion
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                // client.UseDefaultCredentials = true;


                try
                {
                    client.Send(email);
                    //smtp.Send(message);

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
                    MessageBox.Show(LangueElement[40] + ex.Message, LangueElement[41], MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pbSuggestion.Visible = false;
                }
            }

            if (tbMail.Text != "" && tbMail.Text != LangueElement[29] && tbNom.Text != "" && tbNom.Text != LangueElement[27] && tbPrénom.Text != "" && tbPrénom.Text != LangueElement[28] && nudAge.Value != 0 && rbM.Checked == true && rtbSuggestion.Text != "" && rtbSuggestion.Text != LangueElement[32])
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
                
                // MailAddress from = new MailAddress("tirdimpact@yahoo.com");
                MailAddress from = new MailAddress("skillproject@hotmail.com");
                MailAddress to = new MailAddress("tirdimpact@yahoo.com");
                // MailAddress to = new MailAddress("dimy@hotmail.fr");

                MailMessage email = new MailMessage(from, to);
                email.Subject = "Suggestion Skill Project";
                email.Body = "Date & Heure : " + tbDate2.Text + "\n\nNom : " + tbNom.Text + ".\nPrénom : " + tbPrénom.Text + ".\n\nEmail : " + tbMail.Text + ".\n\nAge : " + nudAge.Value + ".\nSexe : " + sexe + ".\n\n\nSuggestion :\n\n " + rtbSuggestion.Text;
                // SmtpClient client = new SmtpClient("smtp.mail.yahoo.com");
                SmtpClient client = new SmtpClient("smtp.live.com");
                // SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                // client.Port = 465;
                #region Confidentiel
                // client.Credentials = new System.Net.NetworkCredential("tirdimpact@yahoo.com", "Dimtchek12");
                client.Credentials = new System.Net.NetworkCredential("skillproject@hotmail.com", "Dimtchek12");
                #endregion
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                // client.UseDefaultCredentials = true;

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
                    MessageBox.Show(LangueElement[40] + ex.Message, LangueElement[41], MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pbSuggestion.Visible = false;
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
                tbNom.Text = LangueElement[27];
                click = 0;
            }

            if (rtbSuggestion.Text == "")
            {
                rtbSuggestion.ForeColor = Color.DarkGray;
                rtbSuggestion.Clear();
                rtbSuggestion.ForeColor = Color.DarkGray;

                rtbSuggestion.Cursor = Default;
                rtbSuggestion.Text = LangueElement[32];
                click2 = 0;
            }

            if (tbPrénom.Text == "")
            {
                tbPrénom.ForeColor = Color.DarkGray;
                tbPrénom.Clear();
                tbPrénom.ForeColor = Color.DarkGray;
                tbPrénom.Cursor = Default;
                tbPrénom.Text = LangueElement[28];
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
                MessageBox.Show(LangueElement[42], LangueElement[41], MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbNom.Clear();
            }
        }

        private void tbPrénom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9)
            {
                MessageBox.Show(LangueElement[42], LangueElement[41], MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbPrénom.Clear();
            }
        }

        private void tbNom_Leave(object sender, EventArgs e)
        {
            if(tbNom.Text == LangueElement[27] || tbNom.Text == "" || tbNom.Text == " ")
            {
                tbNom.ForeColor = Color.DarkGray;

                tbNom.Cursor = Default;
                tbNom.Text = LangueElement[27];
            }
        }

        private void tbPrénom_Leave(object sender, EventArgs e)
        {
            if (tbPrénom.Text == LangueElement[28] || tbPrénom.Text == "" || tbPrénom.Text == " ")
            {
                tbPrénom.ForeColor = Color.DarkGray;

                tbPrénom.Cursor = Default;
                tbPrénom.Text = LangueElement[28];
            }
        }

        private void tbMail_Leave(object sender, EventArgs e)
        {

            if (tbMail.Text == LangueElement[29] || tbMail.Text == "" || tbMail.Text == " ")
            {
                tbMail.ForeColor = Color.DarkGray;

                tbMail.Cursor = Default;
                tbMail.Text = LangueElement[29];
            }
        }

        private void rtbSuggestion_Leave(object sender, EventArgs e)
        {
            if (rtbSuggestion.Text == LangueElement[32] || rtbSuggestion.Text == "" || rtbSuggestion.Text == " ")
            {
                rtbSuggestion.ForeColor = Color.DarkGray;

                rtbSuggestion.Cursor = Default;
                rtbSuggestion.Text = LangueElement[32];
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbDate2.Text = DateTime.Now.ToString();
        }

        private void FormSuggestion_Enter(object sender, EventArgs e)
        {
            FormIndex form = (FormIndex)this.MdiParent;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormSuggestion_Activated(object sender, EventArgs e)
        {
            
        }

        private void FormSuggestion_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void FormSuggestion_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
