using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Project
{
    public partial class FormMiniature : Form
    {
        public FormMiniature()
        {
            InitializeComponent();
        }

        private void FormMiniature_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
