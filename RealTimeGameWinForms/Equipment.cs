using MongoDB.Driver;
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
        public string helmet = string.Empty;
        public string armor = string.Empty;
        public string weapon = string.Empty;
        public string name = string.Empty;
        public Equipment()
        {
            InitializeComponent();
            RealTimeGameWinForms test = new RealTimeGameWinForms();
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            var one = collection.Find(x => x.name == test.UserName()).FirstOrDefault();
            if(one != null)
            {
                MessageBox.Show($"{one.helmet} {one.armor} {one.weapon}");
            }
            else
            {
                MessageBox.Show($"пусто");
            }
        }

        private void EquipmentlistView_DoubleClick(object sender, EventArgs e)
        {                     
            if (EquipmentlistView.SelectedItems.Count < 1) return;
            var item = EquipmentlistView.SelectedItems[0];
            SelectedlistView.Items.Add((ListViewItem)item.Clone());
            EquipmentlistView.Items.Remove((ListViewItem)EquipmentlistView.SelectedItems[0]); 
            switch (item.SubItems[1].Text)
            {
                case "Helmet":
                    comboBoxHelmet.Items.Add(item.SubItems[0].Text);
                    break;

                case "Armor":
                    comboBoxArmor.Items.Add(item.SubItems[0].Text);
                    break;

                case "Weapon":
                    comboBoxWeapon.Items.Add(item.SubItems[0].Text);
                    break;
            }
        }

        private void SelectedlistView_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedlistView.SelectedItems.Count < 1) return;
            var item = SelectedlistView.SelectedItems[0];
            EquipmentlistView.Items.Add((ListViewItem)item.Clone());
            SelectedlistView.Items.Remove((ListViewItem)SelectedlistView.SelectedItems[0]);
            switch (item.SubItems[1].Text)
            {
                case "Helmet":
                    comboBoxHelmet.Items.Remove(item.SubItems[0].Text);
                    break;

                case "Armor":
                    comboBoxArmor.Items.Remove(item.SubItems[0].Text);
                    break;

                case "Weapon":
                    comboBoxWeapon.Items.Remove(item.SubItems[0].Text);
                    break;
            }
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            helmet = comboBoxHelmet.Text;
            armor = comboBoxArmor.Text;
            weapon = comboBoxWeapon.Text;           
        }
    }
}
