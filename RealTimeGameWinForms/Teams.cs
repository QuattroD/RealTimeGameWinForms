using MongoDB.Driver;
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
        public List<string> unitsTeams = new List<string>();
        public Teams()
        {
            InitializeComponent();
        }

        private void Bauto_Click(object sender, EventArgs e)
        {
            if(listBoxFreeUnits.Items.Count != 0)
            {
                var client = new MongoClient();
                var database = client.GetDatabase("Army");
                var collection = database.GetCollection<Unit>("Units");
                var one = collection.Find(x => x.name == listBoxFreeUnits.SelectedItem.ToString()).FirstOrDefault();
                
            }
            else
            {
                MessageBox.Show($"Нету доступных юнитов");
            }
        }

        private void Teams_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < unitsTeams.Count; i++)
            {
                listBoxFreeUnits.Items.Add(unitsTeams[i]);
            }               
        }
    }
}
