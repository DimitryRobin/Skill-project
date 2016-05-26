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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParametre));
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
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPolice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransparence
            // 
            resources.ApplyResources(this.lblTransparence, "lblTransparence");
            this.lblTransparence.BackColor = System.Drawing.Color.Transparent;
            this.lblTransparence.Name = "lblTransparence";
            // 
            // lblTitreSuggestion
            // 
            resources.ApplyResources(this.lblTitreSuggestion, "lblTitreSuggestion");
            this.lblTitreSuggestion.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreSuggestion.Name = "lblTitreSuggestion";
            // 
            // lblMessageBox
            // 
            resources.ApplyResources(this.lblMessageBox, "lblMessageBox");
            this.lblMessageBox.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageBox.Name = "lblMessageBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbBoiteMessagesOui
            // 
            resources.ApplyResources(this.cbBoiteMessagesOui, "cbBoiteMessagesOui");
            this.cbBoiteMessagesOui.Checked = true;
            this.cbBoiteMessagesOui.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBoiteMessagesOui.Name = "cbBoiteMessagesOui";
            this.cbBoiteMessagesOui.UseVisualStyleBackColor = true;
            this.cbBoiteMessagesOui.Click += new System.EventHandler(this.cbBoiteMessagesOui_Click);
            // 
            // cbBoiteMessagesNon
            // 
            resources.ApplyResources(this.cbBoiteMessagesNon, "cbBoiteMessagesNon");
            this.cbBoiteMessagesNon.Name = "cbBoiteMessagesNon";
            this.cbBoiteMessagesNon.UseVisualStyleBackColor = true;
            this.cbBoiteMessagesNon.Click += new System.EventHandler(this.cbBoiteMessagesNon_Click);
            // 
            // hScrollBar1
            // 
            resources.ApplyResources(this.hScrollBar1, "hScrollBar1");
            this.hScrollBar1.Maximum = 109;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Value = 100;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // lblNbTransparence
            // 
            resources.ApplyResources(this.lblNbTransparence, "lblNbTransparence");
            this.lblNbTransparence.BackColor = System.Drawing.Color.Transparent;
            this.lblNbTransparence.Name = "lblNbTransparence";
            // 
            // cbInfoDefilantesOui
            // 
            resources.ApplyResources(this.cbInfoDefilantesOui, "cbInfoDefilantesOui");
            this.cbInfoDefilantesOui.Checked = true;
            this.cbInfoDefilantesOui.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInfoDefilantesOui.Name = "cbInfoDefilantesOui";
            this.cbInfoDefilantesOui.UseVisualStyleBackColor = true;
            this.cbInfoDefilantesOui.Click += new System.EventHandler(this.cbInfoDefilantesOui_Click);
            // 
            // cbInfoDefilantesNon
            // 
            resources.ApplyResources(this.cbInfoDefilantesNon, "cbInfoDefilantesNon");
            this.cbInfoDefilantesNon.Name = "cbInfoDefilantesNon";
            this.cbInfoDefilantesNon.UseVisualStyleBackColor = true;
            this.cbInfoDefilantesNon.Click += new System.EventHandler(this.cbInfoDefilantesNon_Click);
            // 
            // cbTutorielNon
            // 
            resources.ApplyResources(this.cbTutorielNon, "cbTutorielNon");
            this.cbTutorielNon.Name = "cbTutorielNon";
            this.cbTutorielNon.UseVisualStyleBackColor = true;
            this.cbTutorielNon.CheckedChanged += new System.EventHandler(this.cbTutorielNon_CheckedChanged);
            this.cbTutorielNon.Click += new System.EventHandler(this.cbTutorielNon_Click);
            // 
            // cbTutorielOui
            // 
            resources.ApplyResources(this.cbTutorielOui, "cbTutorielOui");
            this.cbTutorielOui.Checked = true;
            this.cbTutorielOui.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTutorielOui.Name = "cbTutorielOui";
            this.cbTutorielOui.UseVisualStyleBackColor = true;
            this.cbTutorielOui.CheckedChanged += new System.EventHandler(this.cbTutorielOui_CheckedChanged);
            this.cbTutorielOui.Click += new System.EventHandler(this.cbTutorielOui_Click);
            // 
            // lblPercent
            // 
            resources.ApplyResources(this.lblPercent, "lblPercent");
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Name = "lblPercent";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // combobLangue
            // 
            this.combobLangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.combobLangue, "combobLangue");
            this.combobLangue.FormattingEnabled = true;
            this.combobLangue.Name = "combobLangue";
            this.combobLangue.SelectedIndexChanged += new System.EventHandler(this.combobLangue_SelectedIndexChanged);
            // 
            // lblRedemRequis3
            // 
            resources.ApplyResources(this.lblRedemRequis3, "lblRedemRequis3");
            this.lblRedemRequis3.BackColor = System.Drawing.Color.Transparent;
            this.lblRedemRequis3.Name = "lblRedemRequis3";
            // 
            // lblPolice
            // 
            resources.ApplyResources(this.lblPolice, "lblPolice");
            this.lblPolice.BackColor = System.Drawing.Color.Transparent;
            this.lblPolice.Name = "lblPolice";
            // 
            // btnDefautPolice
            // 
            resources.ApplyResources(this.btnDefautPolice, "btnDefautPolice");
            this.btnDefautPolice.Name = "btnDefautPolice";
            this.btnDefautPolice.UseVisualStyleBackColor = true;
            this.btnDefautPolice.Click += new System.EventHandler(this.btnDefautPolice_Click);
            // 
            // lblInfoPolice
            // 
            resources.ApplyResources(this.lblInfoPolice, "lblInfoPolice");
            this.lblInfoPolice.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoPolice.Name = "lblInfoPolice";
            // 
            // pbPolice
            // 
            this.pbPolice.BackColor = System.Drawing.SystemColors.Control;
            this.pbPolice.BackgroundImage = global::Skill_Project.Properties.Resources.letter;
            resources.ApplyResources(this.pbPolice, "pbPolice");
            this.pbPolice.Name = "pbPolice";
            this.pbPolice.TabStop = false;
            this.pbPolice.Click += new System.EventHandler(this.pbPolice_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Skill_Project.Properties.Resources.honeycomb_grey_pattern_wallpapers;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Skill_Project.Properties.Resources.honeycomb_grey_pattern_wallpapers;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // FormParametre
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormParametre";
            this.ShowIcon = false;
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
        private Label label5;

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