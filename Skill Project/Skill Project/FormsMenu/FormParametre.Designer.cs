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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransparence
            // 
            this.lblTransparence.AutoSize = true;
            this.lblTransparence.BackColor = System.Drawing.Color.Transparent;
            this.lblTransparence.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.lblTransparence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTransparence.Location = new System.Drawing.Point(30, 101);
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
            this.lblMessageBox.Location = new System.Drawing.Point(30, 177);
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
            this.label1.Location = new System.Drawing.Point(30, 236);
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
            this.label2.Location = new System.Drawing.Point(30, 294);
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
            this.cbBoiteMessagesOui.Location = new System.Drawing.Point(312, 177);
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
            this.cbBoiteMessagesNon.Location = new System.Drawing.Point(375, 177);
            this.cbBoiteMessagesNon.Name = "cbBoiteMessagesNon";
            this.cbBoiteMessagesNon.Size = new System.Drawing.Size(62, 27);
            this.cbBoiteMessagesNon.TabIndex = 26;
            this.cbBoiteMessagesNon.Text = "Non";
            this.cbBoiteMessagesNon.UseVisualStyleBackColor = true;
            this.cbBoiteMessagesNon.Click += new System.EventHandler(this.cbBoiteMessagesNon_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(180, 101);
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
            this.lblNbTransparence.Location = new System.Drawing.Point(371, 101);
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
            this.cbInfoDefilantesOui.Location = new System.Drawing.Point(351, 236);
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
            this.cbInfoDefilantesNon.Location = new System.Drawing.Point(414, 236);
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
            this.cbTutorielNon.Location = new System.Drawing.Point(267, 294);
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
            this.cbTutorielOui.Location = new System.Drawing.Point(204, 294);
            this.cbTutorielOui.Name = "cbTutorielOui";
            this.cbTutorielOui.Size = new System.Drawing.Size(57, 27);
            this.cbTutorielOui.TabIndex = 32;
            this.cbTutorielOui.Text = "Oui";
            this.cbTutorielOui.UseVisualStyleBackColor = true;
            this.cbTutorielOui.CheckedChanged += new System.EventHandler(this.cbTutorielOui_CheckedChanged);
            this.cbTutorielOui.Click += new System.EventHandler(this.cbTutorielOui_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Skill_Project.Properties.Resources.honeycomb_grey_pattern_wallpapers;
            this.pictureBox2.Location = new System.Drawing.Point(2, 370);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(643, 2);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.lblPercent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPercent.Location = new System.Drawing.Point(403, 101);
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
            this.label3.Location = new System.Drawing.Point(46, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(596, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Redémarrage de Skill project requis pour que la transparence soit effective sur l" +
    "a globalité de l\'application.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 404);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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