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
        public string username = string.Empty;
        public double stregth = 0;
        public double dexterity = 0;
        public double constitution = 0;
        public double intelligence = 0;

        public Equipment()
        {
            InitializeComponent();
        }

        private void EquipmentlistView_DoubleClick(object sender, EventArgs e)
        {                     
            if (EquipmentlistView.SelectedItems.Count < 1) return;
            var item = EquipmentlistView.SelectedItems[0];
             
            if(stregth >= int.Parse(item.SubItems[3].Text) && dexterity >= int.Parse(item.SubItems[4].Text) && constitution >= int.Parse(item.SubItems[5].Text) && intelligence >= int.Parse(item.SubItems[6].Text))
            {
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
            else
            {
                MessageBox.Show("недостаточно атрибутов");
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

        private void Equipment_Load(object sender, EventArgs e)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            var one = collection.Find(x => x.name == username).FirstOrDefault();
            if (one != null)
            {
                comboBoxHelmet.Text = one.helmet;
                comboBoxArmor.Text = one.armor;
                comboBoxWeapon.Text = one.weapon;
            }
        }
    }
}
