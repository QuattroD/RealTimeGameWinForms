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
        public Dictionary<string, int> user_lvl = new Dictionary<string, int>();
        public List<string> unitsTeams = new List<string>();
        public int blue_sum_lvl = 0;
        public int red_sum_lvl = 0;
        public Teams()
        {
            InitializeComponent();
        }

        private void Bauto_Click(object sender, EventArgs e)
        {
            if(listBoxFreeUnits.Items.Count != 0)
            {
                foreach(var pair in user_lvl.OrderBy(pair => pair.Value).Reverse())
                {
                    if (blue_sum_lvl > red_sum_lvl)
                    {
                        listBoxRedTeam.Items.Add(pair);
                        red_sum_lvl += pair.Value;
                    }
                    else
                    {
                        listBoxBlueTeam.Items.Add(pair);
                        blue_sum_lvl += pair.Value;
                    }
                    listBoxFreeUnits.Items.Remove(pair);
                }
            }
            else
            {
                MessageBox.Show($"Нету доступных юнитов");
            }
        }

        private void Teams_Load(object sender, EventArgs e)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            
            List<Unit> names = collection.AsQueryable().ToList<Unit>();
            foreach (var item in names)
            {
                user_lvl.Add(item.name, item.LVL);
            }
            foreach (var pair in user_lvl.OrderBy(pair => pair.Value).Reverse())
            {
                listBoxFreeUnits.Items.Add(pair);
            }
            /*for (int i = 0; i < unitsTeams.Count; i++)
            {
                listBoxFreeUnits.Items.Add(unitsTeams[i]);
            }*/
        }
    }
}
