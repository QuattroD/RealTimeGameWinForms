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
    public partial class Teams : Form
    {
        public Teams()
        {
            InitializeComponent();
        }

        private void Bauto_Click(object sender, EventArgs e)
        {
            if(listBoxFreeUnits.Items.Count != 0)
            {
                for (int i = 0; i < listBoxFreeUnits.Items.Count; i++)
                {

                }
            }
            else
            {
                MessageBox.Show($"Нету доступных юнитов");
            }
        }
    }
}
