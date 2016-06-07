namespace Skill_Project.FormsCompetence.Morpion
{
    partial class FormJoueur
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
            this.rbOrdi = new System.Windows.Forms.RadioButton();
            this.rb2j = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnJouer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbOrdi
            // 
            this.rbOrdi.AutoSize = true;
            this.rbOrdi.Checked = true;
            this.rbOrdi.Font = new System.Drawing.Font("Palatino Linotype", 10.25F);
            this.rbOrdi.Location = new System.Drawing.Point(43, 12);
            this.rbOrdi.Name = "rbOrdi";
            this.rbOrdi.Size = new System.Drawing.Size(113, 23);
            this.rbOrdi.TabIndex = 0;
            this.rbOrdi.TabStop = true;
            this.rbOrdi.Text = "Vs ordinateur";
            this.rbOrdi.UseVisualStyleBackColor = true;
            this.rbOrdi.CheckedChanged += new System.EventHandler(this.rbOrdi_CheckedChanged);
            this.rbOrdi.Click += new System.EventHandler(this.rbOrdi_Click);
            // 
            // rb2j
            // 
            this.rb2j.AutoSize = true;
            this.rb2j.Font = new System.Drawing.Font("Palatino Linotype", 10.25F);
            this.rb2j.Location = new System.Drawing.Point(162, 12);
            this.rb2j.Name = "rb2j";
            this.rb2j.Size = new System.Drawing.Size(86, 23);
            this.rb2j.TabIndex = 1;
            this.rb2j.TabStop = true;
            this.rb2j.Text = "2 joueurs";
            this.rb2j.UseVisualStyleBackColor = true;
            this.rb2j.CheckedChanged += new System.EventHandler(this.rb2j_CheckedChanged);
            this.rb2j.Click += new System.EventHandler(this.rb2j_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Joueur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Joueur 2 :";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(98, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Pseudonyme..";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox2.Location = new System.Drawing.Point(98, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Pseudonyme..";
            this.textBox2.Visible = false;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // btnJouer
            // 
            this.btnJouer.Location = new System.Drawing.Point(225, 105);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(75, 23);
            this.btnJouer.TabIndex = 4;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // FormJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 133);
            this.ControlBox = false;
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb2j);
            this.Controls.Add(this.rbOrdi);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormJoueur";
            this.Text = "Morpion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJoueur_FormClosing);
            this.Load += new System.EventHandler(this.FormJoueur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbOrdi;
        private System.Windows.Forms.RadioButton rb2j;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnJouer;
    }
}