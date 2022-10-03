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
        RealTimeGameWinForms realtimegamewinforms = new RealTimeGameWinForms();
        
        public SelectSkill()
        {
            InitializeComponent();    
        }        

        private void Skills_1_Click(object sender, EventArgs e)
        {
            
            string skillName = "Mist Coil";
            realtimegamewinforms.SelectedSkill = skillName;
            Close();
        }

        private void Skills_2_Click(object sender, EventArgs e)
        {
            string skillName = "Aphotic Shield";
            realtimegamewinforms.SelectedSkill = skillName;
            Show();
            Close();
        }

        private void Skills_3_Click(object sender, EventArgs e)
        {
            string skillName = "Curse of Avernus";
            realtimegamewinforms.SelectedSkill = skillName;
            Close();
        }
    }
}
