namespace Skill_Project
{
    partial class FormFaireUnDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaireUnDon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetourFUD = new System.Windows.Forms.Button();
            this.lblTitreFUD = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, 1400);
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRetourFUD);
            this.panel1.Controls.Add(this.lblTitreFUD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 561);
            this.panel1.TabIndex = 10;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(96, 290);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(779, 990);
            this.webBrowser1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(534, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Via votre navigateur";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label2, "https://www.paypal.com/fr/cgi-bin/webscr?cmd=_flow&SESSION=pC7KUR60wFW2hrWorWOreF" +
        "ZUtSdZa-AYcNMt7FlfJtHnSo4wl48-B3W00h8&dispatch=5885d80a13c0db1f8e263663d3faee8d6" +
        "4ad11bbf4d2a5a1a0d303a50933f9b2");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(206, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Via l\'application";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip2.SetToolTip(this.label3, "Ouvre un navigateur web de données");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(430, -15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(125, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 19;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRetourFUD
            // 
            this.btnRetourFUD.BackColor = System.Drawing.Color.Transparent;
            this.btnRetourFUD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetourFUD.BackgroundImage")));
            this.btnRetourFUD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRetourFUD.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourFUD.Location = new System.Drawing.Point(430, 1318);
            this.btnRetourFUD.Name = "btnRetourFUD";
            this.btnRetourFUD.Size = new System.Drawing.Size(110, 44);
            this.btnRetourFUD.TabIndex = 17;
            this.btnRetourFUD.Text = "Retour";
            this.btnRetourFUD.UseVisualStyleBackColor = false;
            this.btnRetourFUD.Click += new System.EventHandler(this.btnRetourFUD_Click);
            // 
            // lblTitreFUD
            // 
            this.lblTitreFUD.AutoSize = true;
            this.lblTitreFUD.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreFUD.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreFUD.Location = new System.Drawing.Point(398, 12);
            this.lblTitreFUD.Name = "lblTitreFUD";
            this.lblTitreFUD.Size = new System.Drawing.Size(186, 39);
            this.lblTitreFUD.TabIndex = 2;
            this.lblTitreFUD.Text = "Faire un don";
            this.lblTitreFUD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormFaireUnDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Skill_Project.Properties.Resources.yuyukyuk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormFaireUnDon";
            this.Text = "Faire un don";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormFaireUnDon_Load);
            this.Enter += new System.EventHandler(this.FormFaireUnDon_Enter);
            this.Leave += new System.EventHandler(this.FormFaireUnDon_Leave);
            this.MouseEnter += new System.EventHandler(this.FormFaireUnDon_MouseEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetourFUD;
        private System.Windows.Forms.Label lblTitreFUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}