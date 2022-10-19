using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RealTimeGameWinForms
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void EquipmentlistView_DoubleClick(object sender, EventArgs e)
        {
            if (EquipmentlistView.SelectedItems.Count < 1) return;
            var item = EquipmentlistView.SelectedItems[0];
            SelectedlistView.Items.Add((ListViewItem)item.Clone());
            EquipmentlistView.Items.Remove((ListViewItem)EquipmentlistView.SelectedItems[0]); 
                switch (SelectedlistView.Items[0].SubItems[1].Text)
                {
                    case "Helmet":
                        comboBoxHelmet.Items.Add(SelectedlistView.);
                    break;

                    case "Armor":
                        comboBoxArmor.Items.Add(SelectedlistView.SelectedItems.ToString());
                    break;

                    case "Weapon":
                    comboBoxWeapon.Items.Add(SelectedlistView.SelectedItems.ToString());
                    break;
                }
        }

        private void SelectedlistView_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedlistView.SelectedItems.Count < 1) return;
            var item = SelectedlistView.SelectedItems[0];
            EquipmentlistView.Items.Add((ListViewItem)item.Clone());
            SelectedlistView.Items.Remove((ListViewItem)SelectedlistView.SelectedItems[0]);
        }

        private void SaveB_Click(object sender, EventArgs e)
        {

        }
    }
}
