using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealTimeGameWinForms
{
    public partial class SelectSkill : Form
    {
        public string skillName = string.Empty;
        public SelectSkill()
        {
            InitializeComponent();    
        }
        
        private void Skills_1_Click(object sender, EventArgs e)
        {            
            skillName = "Mist Coil";
            DialogResult = DialogResult.OK;
        }

        private void Skills_2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            skillName = "Aphotic Shield";
        }

        private void Skills_3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            skillName = "Curse of Avernus";

        }
    }
}
