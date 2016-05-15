using System.Windows.Forms;

namespace Skill_Project
{
    partial class FormParametre
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
            this.lblTransparence = new System.Windows.Forms.Label();
            this.lblTitreSuggestion = new System.Windows.Forms.Label();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoiteMessagesOui = new System.Windows.Forms.CheckBox();
            this.cbBoiteMessagesNon = new System.Windows.Forms.CheckBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.lblNbTransparence = new System.Windows.Forms.Label();
            this.cbInfoDefilantesOui = new System.Windows.Forms.CheckBox();
            this.cbInfoDefilantesNon = new System.Windows.Forms.CheckBox();
            this.cbTutorielNon = new System.Windows.Forms.CheckBox();
            this.cbTutorielOui = new System.Windows.Forms.CheckBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combobLangue = new System.Windows.Forms.ComboBox();
            this.lblRedemRequis3 = new System.Windows.Forms.Label();
            this.lblPolice = new System.Windows.Forms.Label();
            this.btnDefautPolice = new System.Windows.Forms.Button();
            this.lblInfoPolice = new System.Windows.Forms.Label();
            this.pbPolice = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbPolice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransparence
            // 
            this.lblTransparence.AutoSize = true;
            this.lblTransparence.BackColor = System.Drawing.Color.Transparent;
            this.lblTransparence.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.lblTransparence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTransparence.Location = new System.Drawing.Point(30, 86);
            this.lblTransparence.Name = "lblTransparence";
            this.lblTransparence.Size = new System.Drawing.Size(123, 23);
            this.lblTransparence.TabIndex = 20;
            this.lblTransparence.Text = "Transparence :";
            this.lblTransparence.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitreSuggestion
            // 
            this.lblTitreSuggestion.AutoSize = true;
            this.lblTitreSuggestion.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreSuggestion.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreSuggestion.Location = new System.Drawing.Point(236, 13);
            this.lblTitreSuggestion.Name = "lblTitreSuggestion";
            this.lblTitreSuggestion.Size = new System.Drawing.Size(166, 39);
            this.lblTitreSuggestion.TabIndex = 21;
            this.lblTitreSuggestion.Text = "Paramètres";
            this.lblTitreSuggestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageBox.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.lblMessageBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMessageBox.Location = new System.Drawing.Point(30, 155);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(245, 23);
            this.lblMessageBox.TabIndex = 22;
            this.lblMessageBox.Text = "Afficher les boîtes de message :";
            this.lblMessageBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(30, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Afficher les informations défilantes :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(30, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Afficher Tutoriel :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbBoiteMessagesOui
            // 
            this.cbBoiteMessagesOui.AutoSize = true;
            this.cbBoiteMessagesOui.Checked = true;
            this.cbBoiteMessagesOui.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBoiteMessagesOui.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.cbBoiteMessagesOui.Location = new System.Drawing.Point(312, 155);
            this.cbBoiteMessagesOui.Name = "cbBoiteMessagesOui";
            this.cbBoiteMessagesOui.Size = new System.Drawing.Size(57, 27);
            this.cbBoiteMessagesOui.TabIndex = 25;
            this.cbBoiteMessagesOui.Text = "Oui";
            this.cbBoiteMessagesOui.UseVisualStyleBackColor = true;
            this.cbBoiteMessagesOui.Click += new System.EventHandler(this.cbBoiteMessagesOui_Click);
            // 
            // cbBoiteMessagesNon
            // 
            this.cbBoiteMessagesNon.AutoSize = true;
            this.cbBoiteMessagesNon.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.cbBoiteMessagesNon.Location = new System.Drawing.Point(375, 155);
            this.cbBoiteMessagesNon.Name = "cbBoiteMessagesNon";
            this.cbBoiteMessagesNon.Size = new System.Drawing.Size(62, 27);
            this.cbBoiteMessagesNon.TabIndex = 26;
            this.cbBoiteMessagesNon.Text = "Non";
            this.cbBoiteMessagesNon.UseVisualStyleBackColor = true;
            this.cbBoiteMessagesNon.Click += new System.EventHandler(this.cbBoiteMessagesNon_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(180, 86);
            this.hScrollBar1.Maximum = 109;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(170, 23);
            this.hScrollBar1.TabIndex = 27;
            this.hScrollBar1.Value = 100;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // lblNbTransparence
            // 
            this.lblNbTransparence.AutoSize = true;
            this.lblNbTransparence.BackColor = System.Drawing.Color.Transparent;
            this.lblNbTransparence.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.lblNbTransparence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNbTransparence.Location = new System.Drawing.Point(371, 86);
            this.lblNbTransparence.Name = "lblNbTransparence";
            this.lblNbTransparence.Size = new System.Drawing.Size(37, 23);
            this.lblNbTransparence.TabIndex = 28;
            this.lblNbTransparence.Text = "100";
            this.lblNbTransparence.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbInfoDefilantesOui
            // 
            this.cbInfoDefilantesOui.AutoSize = true;
            this.cbInfoDefilantesOui.Checked = true;
            this.cbInfoDefilantesOui.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInfoDefilantesOui.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.cbInfoDefilantesOui.Location = new System.Drawing.Point(351, 260);
            this.cbInfoDefilantesOui.Name = "cbInfoDefilantesOui";
            this.cbInfoDefilantesOui.Size = new System.Drawing.Size(57, 27);
            this.cbInfoDefilantesOui.TabIndex = 30;
            this.cbInfoDefilantesOui.Text = "Oui";
            this.cbInfoDefilantesOui.UseVisualStyleBackColor = true;
            this.cbInfoDefilantesOui.Click += new System.EventHandler(this.cbInfoDefilantesOui_Click);
            // 
            // cbInfoDefilantesNon
            // 
            this.cbInfoDefilantesNon.AutoSize = true;
            this.cbInfoDefilantesNon.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.cbInfoDefilantesNon.Location = new System.Drawing.Point(414, 260);
            this.cbInfoDefilantesNon.Name = "cbInfoDefilantesNon";
            this.cbInfoDefilantesNon.Size = new System.Drawing.Size(62, 27);
            this.cbInfoDefilantesNon.TabIndex = 31;
            this.cbInfoDefilantesNon.Text = "Non";
            this.cbInfoDefilantesNon.UseVisualStyleBackColor = true;
            this.cbInfoDefilantesNon.Click += new System.EventHandler(this.cbInfoDefilantesNon_Click);
            // 
            // cbTutorielNon
            // 
            this.cbTutorielNon.AutoSize = true;
            this.cbTutorielNon.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.cbTutorielNon.Location = new System.Drawing.Point(267, 336);
            this.cbTutorielNon.Name = "cbTutorielNon";
            this.cbTutorielNon.Size = new System.Drawing.Size(62, 27);
            this.cbTutorielNon.TabIndex = 33;
            this.cbTutorielNon.Text = "Non";
            this.cbTutorielNon.UseVisualStyleBackColor = true;
            this.cbTutorielNon.CheckedChanged += new System.EventHandler(this.cbTutorielNon_CheckedChanged);
            this.cbTutorielNon.Click += new System.EventHandler(this.cbTutorielNon_Click);
            // 
            // cbTutorielOui
            // 
            this.cbTutorielOui.AutoSize = true;
            this.cbTutorielOui.Checked = true;
            this.cbTutorielOui.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTutorielOui.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.cbTutorielOui.Location = new System.Drawing.Point(204, 336);
            this.cbTutorielOui.Name = "cbTutorielOui";
            this.cbTutorielOui.Size = new System.Drawing.Size(57, 27);
            this.cbTutorielOui.TabIndex = 32;
            this.cbTutorielOui.Text = "Oui";
            this.cbTutorielOui.UseVisualStyleBackColor = true;
            this.cbTutorielOui.CheckedChanged += new System.EventHandler(this.cbTutorielOui_CheckedChanged);
            this.cbTutorielOui.Click += new System.EventHandler(this.cbTutorielOui_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.lblPercent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPercent.Location = new System.Drawing.Point(403, 86);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(24, 23);
            this.lblPercent.TabIndex = 29;
            this.lblPercent.Text = "%";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.25F, System.Drawing.FontStyle.Italic);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(46, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(596, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Redémarrage de Skill project requis pour que la transparence soit effective sur l" +
    "a globalité de l\'application.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(30, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Langue :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // combobLangue
            // 
            this.combobLangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobLangue.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobLangue.FormattingEnabled = true;
            this.combobLangue.Items.AddRange(new object[] {
            "Francais",
            "Anglais"});
            this.combobLangue.Location = new System.Drawing.Point(126, 297);
            this.combobLangue.Name = "combobLangue";
            this.combobLangue.Size = new System.Drawing.Size(135, 26);
            this.combobLangue.TabIndex = 56;
            // 
            // lblRedemRequis3
            // 
            this.lblRedemRequis3.AutoSize = true;
            this.lblRedemRequis3.BackColor = System.Drawing.Color.Transparent;
            this.lblRedemRequis3.Font = new System.Drawing.Font("Palatino Linotype", 10.25F, System.Drawing.FontStyle.Italic);
            this.lblRedemRequis3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRedemRequis3.Location = new System.Drawing.Point(46, 224);
            this.lblRedemRequis3.Name = "lblRedemRequis3";
            this.lblRedemRequis3.Size = new System.Drawing.Size(470, 20);
            this.lblRedemRequis3.TabIndex = 70;
            this.lblRedemRequis3.Text = "Redémarrage requis pour que la police soit effective sur la globalité de l\'applic" +
    "ation.";
            this.lblRedemRequis3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPolice
            // 
            this.lblPolice.AutoSize = true;
            this.lblPolice.BackColor = System.Drawing.Color.Transparent;
            this.lblPolice.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPolice.Location = new System.Drawing.Point(176, 195);
            this.lblPolice.Name = "lblPolice";
            this.lblPolice.Size = new System.Drawing.Size(86, 22);
            this.lblPolice.TabIndex = 69;
            this.lblPolice.Text = "Par défaut";
            this.lblPolice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDefautPolice
            // 
            this.btnDefautPolice.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.btnDefautPolice.Location = new System.Drawing.Point(99, 191);
            this.btnDefautPolice.Name = "btnDefautPolice";
            this.btnDefautPolice.Size = new System.Drawing.Size(30, 30);
            this.btnDefautPolice.TabIndex = 67;
            this.btnDefautPolice.Text = "↻";
            this.btnDefautPolice.UseVisualStyleBackColor = true;
            this.btnDefautPolice.Click += new System.EventHandler(this.btnDefautPolice_Click);
            // 
            // lblInfoPolice
            // 
            this.lblInfoPolice.AutoSize = true;
            this.lblInfoPolice.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoPolice.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.lblInfoPolice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInfoPolice.Location = new System.Drawing.Point(30, 195);
            this.lblInfoPolice.Name = "lblInfoPolice";
            this.lblInfoPolice.Size = new System.Drawing.Size(63, 23);
            this.lblInfoPolice.TabIndex = 66;
            this.lblInfoPolice.Text = "Police :";
            this.lblInfoPolice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbPolice
            // 
            this.pbPolice.BackColor = System.Drawing.SystemColors.Control;
            this.pbPolice.BackgroundImage = global::Skill_Project.Properties.Resources.letter;
            this.pbPolice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPolice.Location = new System.Drawing.Point(146, 196);
            this.pbPolice.Name = "pbPolice";
            this.pbPolice.Size = new System.Drawing.Size(20, 20);
            this.pbPolice.TabIndex = 68;
            this.pbPolice.TabStop = false;
            this.pbPolice.Click += new System.EventHandler(this.pbPolice_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Skill_Project.Properties.Resources.honeycomb_grey_pattern_wallpapers;
            this.pictureBox2.Location = new System.Drawing.Point(2, 370);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(643, 2);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Skill_Project.Properties.Resources.honeycomb_grey_pattern_wallpapers;
            this.pictureBox1.Location = new System.Drawing.Point(3, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 2);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // FormParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 404);
            this.Controls.Add(this.lblRedemRequis3);
            this.Controls.Add(this.lblPolice);
            this.Controls.Add(this.pbPolice);
            this.Controls.Add(this.btnDefautPolice);
            this.Controls.Add(this.lblInfoPolice);
            this.Controls.Add(this.combobLangue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbTutorielNon);
            this.Controls.Add(this.cbTutorielOui);
            this.Controls.Add(this.cbInfoDefilantesNon);
            this.Controls.Add(this.cbInfoDefilantesOui);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblNbTransparence);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.cbBoiteMessagesNon);
            this.Controls.Add(this.cbBoiteMessagesOui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessageBox);
            this.Controls.Add(this.lblTitreSuggestion);
            this.Controls.Add(this.lblTransparence);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormParametre";
            this.ShowIcon = false;
            this.Text = "Paramètres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormParametre_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormParametre_FormClosed);
            this.Load += new System.EventHandler(this.FormParametre_Load);
            this.Leave += new System.EventHandler(this.FormParametre_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pbPolice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransparence;
        private System.Windows.Forms.Label lblTitreSuggestion;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbBoiteMessagesOui;
        private System.Windows.Forms.CheckBox cbBoiteMessagesNon;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label lblNbTransparence;
        private System.Windows.Forms.CheckBox cbInfoDefilantesOui;
        private System.Windows.Forms.CheckBox cbInfoDefilantesNon;
        private System.Windows.Forms.CheckBox cbTutorielNon;
        private System.Windows.Forms.CheckBox cbTutorielOui;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Label lblPercent;
        private Label label3;
        private Label label4;
        private ComboBox combobLangue;
        private Label lblRedemRequis3;
        private Label lblPolice;
        private PictureBox pbPolice;
        private Button btnDefautPolice;
        private Label lblInfoPolice;
        private FontDialog fontDialog1;

        public CheckBox CbTutorielOui
        {
            get
            {
                return cbTutorielOui;
            }

            set
            {
                cbTutorielOui = value;
            }
        }

        public CheckBox CbTutorielNon
        {
            get
            {
                return cbTutorielNon;
            }

            set
            {
                cbTutorielNon = value;
            }
        }

        public CheckBox CbInfoDefilantesNon
        {
            get
            {
                return cbInfoDefilantesNon;
            }

            set
            {
                cbInfoDefilantesNon = value;
            }
        }

        public CheckBox CbInfoDefilantesOui
        {
            get
            {
                return cbInfoDefilantesOui;
            }

            set
            {
                cbInfoDefilantesOui = value;
            }
        }

        public Label LblNbTransparence
        {
            get
            {
                return lblNbTransparence;
            }

            set
            {
                lblNbTransparence = value;
            }
        }

        public CheckBox CbBoiteMessagesNon
        {
            get
            {
                return cbBoiteMessagesNon;
            }

            set
            {
                cbBoiteMessagesNon = value;
            }
        }

        public CheckBox CbBoiteMessagesOui
        {
            get
            {
                return cbBoiteMessagesOui;
            }

            set
            {
                cbBoiteMessagesOui = value;
            }
        }
    }
}