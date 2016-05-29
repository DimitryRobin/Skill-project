namespace Skill_Project
{
    partial class FormSuggestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuggestion));
            this.lblTitreSuggestion = new System.Windows.Forms.Label();
            this.rtbSuggestion = new System.Windows.Forms.RichTextBox();
            this.btnRetourSuggestion = new System.Windows.Forms.Button();
            this.btnEnvoyerSuggestion = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrénom = new System.Windows.Forms.TextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.tbMail = new System.Windows.Forms.TextBox();
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.lblInfoSuggesstion = new System.Windows.Forms.Label();
            this.lblInfo2Suggestion = new System.Windows.Forms.Label();
            this.lblInfo3Suggestion = new System.Windows.Forms.Label();
            this.pbSuggestion = new System.Windows.Forms.ProgressBar();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.tbDate2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitreSuggestion
            // 
            this.lblTitreSuggestion.AutoSize = true;
            this.lblTitreSuggestion.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreSuggestion.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreSuggestion.Location = new System.Drawing.Point(338, 12);
            this.lblTitreSuggestion.Name = "lblTitreSuggestion";
            this.lblTitreSuggestion.Size = new System.Drawing.Size(297, 39);
            this.lblTitreSuggestion.TabIndex = 0;
            this.lblTitreSuggestion.Text = "Faire une Suggestion";
            this.lblTitreSuggestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtbSuggestion
            // 
            this.rtbSuggestion.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbSuggestion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSuggestion.ForeColor = System.Drawing.Color.DarkGray;
            this.rtbSuggestion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtbSuggestion.Location = new System.Drawing.Point(1, 199);
            this.rtbSuggestion.Name = "rtbSuggestion";
            this.rtbSuggestion.Size = new System.Drawing.Size(983, 274);
            this.rtbSuggestion.TabIndex = 7;
            this.rtbSuggestion.Text = "Rédigez votre suggestion..";
            this.toolTip5.SetToolTip(this.rtbSuggestion, "Champs requis");
            this.rtbSuggestion.Click += new System.EventHandler(this.rtbSuggestion_Click);
            this.rtbSuggestion.TextChanged += new System.EventHandler(this.rtbSuggestion_TextChanged);
            this.rtbSuggestion.Leave += new System.EventHandler(this.rtbSuggestion_Leave);
            // 
            // btnRetourSuggestion
            // 
            this.btnRetourSuggestion.BackColor = System.Drawing.Color.Transparent;
            this.btnRetourSuggestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetourSuggestion.BackgroundImage")));
            this.btnRetourSuggestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRetourSuggestion.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourSuggestion.Location = new System.Drawing.Point(12, 479);
            this.btnRetourSuggestion.Name = "btnRetourSuggestion";
            this.btnRetourSuggestion.Size = new System.Drawing.Size(110, 44);
            this.btnRetourSuggestion.TabIndex = 9;
            this.btnRetourSuggestion.Text = "Retour";
            this.btnRetourSuggestion.UseVisualStyleBackColor = false;
            this.btnRetourSuggestion.Click += new System.EventHandler(this.btnRetourSuggestion_Click);
            // 
            // btnEnvoyerSuggestion
            // 
            this.btnEnvoyerSuggestion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEnvoyerSuggestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnvoyerSuggestion.BackgroundImage")));
            this.btnEnvoyerSuggestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnvoyerSuggestion.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.btnEnvoyerSuggestion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnvoyerSuggestion.Location = new System.Drawing.Point(848, 479);
            this.btnEnvoyerSuggestion.Name = "btnEnvoyerSuggestion";
            this.btnEnvoyerSuggestion.Size = new System.Drawing.Size(124, 44);
            this.btnEnvoyerSuggestion.TabIndex = 8;
            this.btnEnvoyerSuggestion.Text = "Envoyer";
            this.btnEnvoyerSuggestion.UseVisualStyleBackColor = false;
            this.btnEnvoyerSuggestion.Click += new System.EventHandler(this.btnEnvoyerSuggestion_Click);
            // 
            // tbNom
            // 
            this.tbNom.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbNom.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.tbNom.ForeColor = System.Drawing.Color.DarkGray;
            this.tbNom.Location = new System.Drawing.Point(42, 154);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(126, 29);
            this.tbNom.TabIndex = 1;
            this.tbNom.Text = "Nom";
            this.toolTip1.SetToolTip(this.tbNom, "Champs requis");
            this.tbNom.Click += new System.EventHandler(this.tbNom_Click);
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            this.tbNom.Enter += new System.EventHandler(this.tbNom_Enter);
            this.tbNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNom_KeyDown);
            this.tbNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNom_KeyPress);
            this.tbNom.Leave += new System.EventHandler(this.tbNom_Leave);
            // 
            // tbPrénom
            // 
            this.tbPrénom.BackColor = System.Drawing.SystemColors.Window;
            this.tbPrénom.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbPrénom.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.tbPrénom.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPrénom.Location = new System.Drawing.Point(199, 155);
            this.tbPrénom.Name = "tbPrénom";
            this.tbPrénom.Size = new System.Drawing.Size(131, 29);
            this.tbPrénom.TabIndex = 2;
            this.tbPrénom.Text = "Prénom";
            this.toolTip2.SetToolTip(this.tbPrénom, "Champs requis");
            this.tbPrénom.Click += new System.EventHandler(this.tbPrénom_Click);
            this.tbPrénom.TextChanged += new System.EventHandler(this.tbPrénom_TextChanged);
            this.tbPrénom.Enter += new System.EventHandler(this.tbPrénom_Enter);
            this.tbPrénom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPrénom_KeyDown);
            this.tbPrénom.Leave += new System.EventHandler(this.tbPrénom_Leave);
            // 
            // nudAge
            // 
            this.nudAge.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.nudAge.Location = new System.Drawing.Point(670, 156);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(54, 29);
            this.nudAge.TabIndex = 4;
            this.toolTip3.SetToolTip(this.nudAge, "Age requis");
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.BackColor = System.Drawing.Color.Transparent;
            this.rbM.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.rbM.Location = new System.Drawing.Point(894, 155);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(44, 26);
            this.rbM.TabIndex = 6;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = false;
            this.rbM.Click += new System.EventHandler(this.rbM_Click);
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.BackColor = System.Drawing.Color.Transparent;
            this.rbF.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.rbF.Location = new System.Drawing.Point(840, 155);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(37, 26);
            this.rbF.TabIndex = 5;
            this.rbF.TabStop = true;
            this.rbF.Text = "F";
            this.toolTip4.SetToolTip(this.rbF, "Sexe requis");
            this.rbF.UseVisualStyleBackColor = false;
            this.rbF.Click += new System.EventHandler(this.rbF_Click);
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.BackColor = System.Drawing.Color.Transparent;
            this.lblSexe.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSexe.Location = new System.Drawing.Point(757, 154);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(60, 26);
            this.lblSexe.TabIndex = 9;
            this.lblSexe.Text = "Sexe :";
            this.lblSexe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblAge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAge.Location = new System.Drawing.Point(599, 154);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(56, 26);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "Âge :";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDate.Location = new System.Drawing.Point(377, 490);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(267, 26);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Message envoyé avec succès le";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDate.Visible = false;
            // 
            // tbDate
            // 
            this.tbDate.Cursor = System.Windows.Forms.Cursors.No;
            this.tbDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.tbDate.Location = new System.Drawing.Point(664, 487);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(149, 29);
            this.tbDate.TabIndex = 12;
            this.tbDate.Visible = false;
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.SystemColors.Window;
            this.tbMail.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbMail.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.tbMail.ForeColor = System.Drawing.Color.DarkGray;
            this.tbMail.Location = new System.Drawing.Point(354, 155);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(223, 29);
            this.tbMail.TabIndex = 3;
            this.tbMail.Text = "Adresse Mail";
            this.toolTip6.SetToolTip(this.tbMail, "Champs requis");
            this.tbMail.Click += new System.EventHandler(this.tbMail_Click);
            this.tbMail.TextChanged += new System.EventHandler(this.tbMail_TextChanged);
            this.tbMail.Enter += new System.EventHandler(this.tbMail_Enter);
            this.tbMail.Leave += new System.EventHandler(this.tbMail_Leave);
            // 
            // lblInfoSuggesstion
            // 
            this.lblInfoSuggesstion.AutoSize = true;
            this.lblInfoSuggesstion.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoSuggesstion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblInfoSuggesstion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInfoSuggesstion.Location = new System.Drawing.Point(58, 60);
            this.lblInfoSuggesstion.Name = "lblInfoSuggesstion";
            this.lblInfoSuggesstion.Size = new System.Drawing.Size(819, 26);
            this.lblInfoSuggesstion.TabIndex = 14;
            this.lblInfoSuggesstion.Text = "Ici, vous pouvez me proposer de réaliser quoique ce soit qui ne fait pas encore p" +
    "artit de ce logiciel.";
            this.lblInfoSuggesstion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfo2Suggestion
            // 
            this.lblInfo2Suggestion.AutoSize = true;
            this.lblInfo2Suggestion.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo2Suggestion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblInfo2Suggestion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInfo2Suggestion.Location = new System.Drawing.Point(162, 86);
            this.lblInfo2Suggestion.Name = "lblInfo2Suggestion";
            this.lblInfo2Suggestion.Size = new System.Drawing.Size(615, 26);
            this.lblInfo2Suggestion.TabIndex = 15;
            this.lblInfo2Suggestion.Text = "Cela peut-être une compétence, un accessoire, un jeu ou bien autre chose.";
            this.lblInfo2Suggestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfo3Suggestion
            // 
            this.lblInfo3Suggestion.AutoSize = true;
            this.lblInfo3Suggestion.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo3Suggestion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblInfo3Suggestion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInfo3Suggestion.Location = new System.Drawing.Point(71, 111);
            this.lblInfo3Suggestion.Name = "lblInfo3Suggestion";
            this.lblInfo3Suggestion.Size = new System.Drawing.Size(774, 26);
            this.lblInfo3Suggestion.TabIndex = 16;
            this.lblInfo3Suggestion.Text = "Je réponderai à votre message, par mail, quant à la possibilité de réaliser votre" +
    " projet ou non.";
            this.lblInfo3Suggestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbSuggestion
            // 
            this.pbSuggestion.Location = new System.Drawing.Point(163, 486);
            this.pbSuggestion.Name = "pbSuggestion";
            this.pbSuggestion.Size = new System.Drawing.Size(221, 29);
            this.pbSuggestion.TabIndex = 17;
            this.pbSuggestion.Visible = false;
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.BackColor = System.Drawing.Color.Transparent;
            this.lblDate2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblDate2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDate2.Location = new System.Drawing.Point(354, 486);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(128, 26);
            this.lblDate2.TabIndex = 18;
            this.lblDate2.Text = "Date && Heure";
            this.lblDate2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbDate2
            // 
            this.tbDate2.Cursor = System.Windows.Forms.Cursors.No;
            this.tbDate2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.tbDate2.Location = new System.Drawing.Point(493, 484);
            this.tbDate2.Name = "tbDate2";
            this.tbDate2.ReadOnly = true;
            this.tbDate2.Size = new System.Drawing.Size(149, 29);
            this.tbDate2.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormSuggestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.tbDate2);
            this.Controls.Add(this.lblDate2);
            this.Controls.Add(this.pbSuggestion);
            this.Controls.Add(this.lblInfo3Suggestion);
            this.Controls.Add(this.lblInfo2Suggestion);
            this.Controls.Add(this.lblInfoSuggesstion);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSexe);
            this.Controls.Add(this.rbF);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.tbPrénom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btnEnvoyerSuggestion);
            this.Controls.Add(this.btnRetourSuggestion);
            this.Controls.Add(this.rtbSuggestion);
            this.Controls.Add(this.lblTitreSuggestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormSuggestion";
            this.Text = "Suggestion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormSuggestion_Activated);
            this.Load += new System.EventHandler(this.FormSuggestion_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormSuggestion_DragEnter);
            this.Enter += new System.EventHandler(this.FormSuggestion_Enter);
            this.Leave += new System.EventHandler(this.FormSuggestion_Leave);
            this.MouseHover += new System.EventHandler(this.FormSuggestion_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreSuggestion;
        private System.Windows.Forms.RichTextBox rtbSuggestion;
        private System.Windows.Forms.Button btnRetourSuggestion;
        private System.Windows.Forms.Button btnEnvoyerSuggestion;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrénom;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.Label lblInfoSuggesstion;
        private System.Windows.Forms.Label lblInfo2Suggestion;
        private System.Windows.Forms.Label lblInfo3Suggestion;
        private System.Windows.Forms.ProgressBar pbSuggestion;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.TextBox tbDate2;
        private System.Windows.Forms.Timer timer1;
    }
}