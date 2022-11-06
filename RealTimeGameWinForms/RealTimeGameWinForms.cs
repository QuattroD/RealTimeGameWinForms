using System.Windows.Forms;
using System;
using static System.Net.WebRequestMethods;
using MongoDB.Driver;
using System.Xml.Linq;
using System.Security.Policy;
using MongoDB.Bson.Serialization;
using System.Security.AccessControl;
using static System.Windows.Forms.DataFormats;

namespace RealTimeGameWinForms
{
    public partial class RealTimeGameWinForms : Form
    {
        MongoDB mongoDB = new MongoDB();
        public double TotalHealth { get; set; }
        public double TotalDamage { get; set; }
        public double TotalMagicDamage { get; set; }
        public double TotalPhysicalDefence { get; set; }
        public double TotalManaPool { get; set; }
        public double Strength = 0;
        public double Dexterity = 0;
        public double Constitution = 0;
        public double Intellisence = 0;
        public int Texp = 0;
        public RealTimeGameWinForms()
        {
            InitializeComponent();
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            List<Unit> names = collection.AsQueryable().ToList<Unit>();
            foreach (var item in names)
            {
                UnitsListBox.Items.Add(item.name);
            }
            ShowUnitTable.DataSource = names;
        }

        
        private void ChoiceUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChoiceUnit.SelectedIndex)
            {
                case 0:
                    StrengthNumeric.Minimum = 30;
                    StrengthNumeric.Maximum = 250;
                    StrengthNumeric.Value = 30;


                    DexterityNumeric.Minimum = 15;
                    DexterityNumeric.Maximum = 70;
                    DexterityNumeric.Value = 15;


                    ConstitutionNumeric.Minimum = 20;
                    ConstitutionNumeric.Maximum = 100;
                    ConstitutionNumeric.Value = 20;


                    IntellisenceNumeric.Minimum = 10;
                    IntellisenceNumeric.Maximum = 50;
                    IntellisenceNumeric.Value = 10;
                    break;

                case 1:
                    StrengthNumeric.Minimum = 15;
                    StrengthNumeric.Maximum = 55;
                    StrengthNumeric.Value = 15;


                    DexterityNumeric.Minimum = 30;
                    DexterityNumeric.Maximum = 250;
                    DexterityNumeric.Value = 30;


                    ConstitutionNumeric.Minimum = 20;
                    ConstitutionNumeric.Maximum = 80;
                    ConstitutionNumeric.Value = 20;


                    IntellisenceNumeric.Minimum = 15;
                    IntellisenceNumeric.Maximum = 70;
                    IntellisenceNumeric.Value = 15;
                    break;

                case 2:
                    StrengthNumeric.Minimum = 10;
                    StrengthNumeric.Maximum = 45;
                    StrengthNumeric.Value = 10;


                    DexterityNumeric.Minimum = 20;
                    DexterityNumeric.Maximum = 70;
                    DexterityNumeric.Value = 20;


                    ConstitutionNumeric.Minimum = 15;
                    ConstitutionNumeric.Maximum = 60;
                    ConstitutionNumeric.Value = 15;


                    IntellisenceNumeric.Minimum = 35;
                    IntellisenceNumeric.Maximum = 250;
                    IntellisenceNumeric.Value = 35;
                    break;
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            UnitsListBox.Visible = true;
            this.Strength = Convert.ToDouble(StrengthNumeric.Value);
            this.Dexterity = Convert.ToDouble(DexterityNumeric.Value);
            this.Constitution = Convert.ToDouble(ConstitutionNumeric.Value);
            this.Intellisence = Convert.ToDouble(IntellisenceNumeric.Value);
            SelectSkill selectSkill = new SelectSkill();
            Item items = new Item(ItemtextBox.Text, int.Parse(CounttextBox.Text));
            switch (ChoiceUnit.SelectedIndex)
            {
                case 0:
                    TotalHealth = (Strength * 2) + (Constitution * 10);
                    TotalDamage = (Strength * 5) + Dexterity;
                    TotalMagicDamage = Intellisence;
                    TotalPhysicalDefence = Dexterity + (Constitution * 2);
                    TotalManaPool = Intellisence;
                    
                    Warrior warrior = new Warrior(NametextBox.Text, ChoiceUnit.Text, TotalHealth, TotalDamage, TotalMagicDamage, TotalPhysicalDefence, TotalManaPool, Strength, Dexterity, Constitution, Intellisence, int.Parse(LVLtextBox.Text));
                    MessageBox.Show($"Имя - {warrior.name} \nЗдоровья - {warrior.health} \nУрон - {warrior.damage} \nМагический урон - {warrior.magicdamage} \nБроня - {warrior.physicaldefence} \nМана - {warrior.manapool}", "Юнит создан");
                    warrior.AddItem(new Item(ItemtextBox.Text, int.Parse(CounttextBox.Text)));                  
                    mongoDB.AddToDB(warrior);
                    break;

                case 1:
                    TotalHealth = Strength + (Constitution * 6);
                    TotalDamage = (Strength * 2) + (Dexterity * 4);
                    TotalMagicDamage = Intellisence * 2;
                    TotalPhysicalDefence = Dexterity * 1.5;
                    TotalManaPool = Intellisence * 1.5;
                    Rogue rogue = new Rogue(NametextBox.Text, ChoiceUnit.Text, TotalHealth, TotalDamage, TotalMagicDamage, TotalPhysicalDefence, TotalManaPool, Strength, Dexterity, Constitution, Intellisence, int.Parse(LVLtextBox.Text));
                    MessageBox.Show($"Имя - {rogue.name} \nЗдоровья - {rogue.health} \nУрон - {rogue.damage} \nМагический урон - {rogue.magicdamage} \nБроня - {rogue.physicaldefence} \nМана - {rogue.manapool}", "Юнит создан");
                    rogue.AddItem(new Item(ItemtextBox.Text, int.Parse(CounttextBox.Text)));
                    mongoDB.AddToDB(rogue);
                    break;

                case 2:
                    TotalHealth = Strength + (Constitution * 3);
                    TotalDamage = Strength * 2;
                    TotalMagicDamage = Intellisence * 5;
                    TotalPhysicalDefence = (Dexterity * 0.5) + Constitution;
                    TotalManaPool = Intellisence * 2;
                    Wizard wizard = new Wizard(NametextBox.Text, ChoiceUnit.Text, TotalHealth, TotalDamage, TotalMagicDamage, TotalPhysicalDefence, TotalManaPool, Strength, Dexterity, Constitution, Intellisence, int.Parse(LVLtextBox.Text));
                    MessageBox.Show($"Имя - {wizard.name} \nЗдоровья - {wizard.health} \nУрон - {wizard.damage} \nМагический урон - {wizard.magicdamage} \nБроня - {wizard.physicaldefence} \nМана - {wizard.manapool}", "Юнит создан");
                    wizard.AddItem(new Item(ItemtextBox.Text, int.Parse(CounttextBox.Text)));
                    mongoDB.AddToDB(wizard);
                    break;
            }
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            var one = collection.Find(x => x.name == NametextBox.Text).FirstOrDefault();
            UnitsListBox.Items.Add(one.name);
            NametextBox.Text = "";
        }

        private void BFind_Click(object sender, EventArgs e)
        {
            mongoDB.Find(FindtextBox.Text);
            FindtextBox.Text = "";
        }

        private void BFindAll_Click(object sender, EventArgs e)
        {
            mongoDB.FindAll();
        }

        private void UnitsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            var one = collection.Find(x => x.name == UnitsListBox.SelectedItem.ToString()).FirstOrDefault();
            int index = 0;
            NametextBox.Text = Convert.ToString(one.name);
            switch (one.Class)
            {
                case "Warrior":
                    index = 0;
                    break;

                case "Rogue":
                    index = 1;
                    break;

                case "Wizard":
                    index = 2;
                    break;
            }
            ChoiceUnit.SelectedIndex = index;
            StrengthNumeric.Value = Convert.ToDecimal(one.Strength);
            DexterityNumeric.Value = Convert.ToDecimal(one.Dexterity);
            ConstitutionNumeric.Value = Convert.ToDecimal(one.Constitution);
            IntellisenceNumeric.Value = Convert.ToDecimal(one.Intellisence);
            LVLlabel.Visible = true;
            LVLtextBox.Visible = true;
            progressEXP.Visible = true;
            B500exp.Visible = true;
            B1000exp.Visible = true;
            LVLtextBox.Text = Convert.ToString(one.LVL);
            int CurrentExpMax = one.LVL * 1000 + 1000;
            progressEXP.Maximum = CurrentExpMax;
            progressEXP.Value = one.Currentexp;
            ExpInfo.Text = $"{progressEXP.Value}/{progressEXP.Maximum}";

        }

        private void BChange_Click(object sender, EventArgs e)
        {
            Strength = Convert.ToDouble(StrengthNumeric.Value);
            Dexterity = Convert.ToDouble(DexterityNumeric.Value);
            Constitution = Convert.ToDouble(ConstitutionNumeric.Value);
            Intellisence = Convert.ToDouble(IntellisenceNumeric.Value);
            switch (ChoiceUnit.SelectedIndex)
            {
                case 0:
                    TotalHealth = (Strength * 2) + (Constitution * 10);
                    TotalDamage = (Strength * 5) + Dexterity;
                    TotalMagicDamage = Intellisence;
                    TotalPhysicalDefence = Dexterity + (Constitution * 2);
                    TotalManaPool = Intellisence;
                    break;

                case 1:
                    TotalHealth = Strength + (Constitution * 6);
                    TotalDamage = (Strength * 2) + (Dexterity * 4);
                    TotalMagicDamage = Intellisence * 2;
                    TotalPhysicalDefence = Dexterity * 1.5;
                    TotalManaPool = Intellisence * 1.5;
                    break;

                case 2:
                    TotalHealth = Strength + (Constitution * 3);
                    TotalDamage = Strength * 2;
                    TotalMagicDamage = Intellisence * 5;
                    TotalPhysicalDefence = (Dexterity * 0.5) + Constitution;
                    TotalManaPool = Intellisence * 2;
                    break;
            }
            Unit unit = new Unit(NametextBox.Text, ChoiceUnit.Text, TotalHealth, TotalDamage, TotalMagicDamage, TotalPhysicalDefence, TotalManaPool, Strength, Dexterity, Constitution, Intellisence, int.Parse(LVLtextBox.Text));
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            collection.ReplaceOne(x => x.name == NametextBox.Text, unit);
        }

        private void B500exp_Click(object sender, EventArgs e)
        {        
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");           
            var one = collection.Find(x => x.name == UnitsListBox.SelectedItem.ToString()).FirstOrDefault();
            progressEXP.Maximum = 1000 + 1000 * int.Parse(LVLtextBox.Text);
            if (progressEXP.Value == progressEXP.Maximum)
            {
                one.LVL++;
                LVLtextBox.Text = Convert.ToString(one.LVL);                
                progressEXP.Value = 0;               
            }
            else
            {
                progressEXP.Value += 500;
                Texp += 500;
            }
            var updateEXP500 = Builders<Unit>.Update.Set("Currentexp", Convert.ToInt32(progressEXP.Value)).Set("LVL", Convert.ToInt32(LVLtextBox.Text)).Set("TotalExp", Texp);
            collection.UpdateOne(x => x.name == NametextBox.Text, updateEXP500);
            ExpInfo.Text = $"{progressEXP.Value}/{progressEXP.Maximum}";
        }

        private void B1000exp_Click(object sender, EventArgs e)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            var one = collection.Find(x => x.name == UnitsListBox.SelectedItem.ToString()).FirstOrDefault();
            progressEXP.Maximum = 1000 + 1000 * int.Parse(LVLtextBox.Text);
            if (progressEXP.Value >= progressEXP.Maximum)
            {
                one.LVL++;
                LVLtextBox.Text = Convert.ToString(one.LVL);               
                progressEXP.Value = 0;
                      
            }
            else
            {
                progressEXP.Value += 1000;
                Texp += 1000;
            }
            var updateEXP1000 = Builders<Unit>.Update.Set("Currentexp", Convert.ToInt32(progressEXP.Value)).Set("LVL", Convert.ToInt32(LVLtextBox.Text)).Set("TotalExp", Texp);
            collection.UpdateOne(x => x.name == NametextBox.Text, updateEXP1000);           
            ExpInfo.Text = $"{progressEXP.Value}/{progressEXP.Maximum}";
        }

        private void LVLtextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(LVLtextBox.Text) % 3 == 0)
            {
                SelectSkills.Visible = true;     
            }
            else
            {
                SelectSkills.Visible = false;
            }
        }

        private void SelectSkills_Click(object sender, EventArgs e)
        {
            SelectSkill selectSkill = new SelectSkill();          
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            if (selectSkill.ShowDialog() == DialogResult.OK)
            {                
                Skill skills = new Skill(selectSkill.skillName);
                SelectSkills.Visible = false;
                var updatePush = Builders<Unit>.Update.Push("Skills", skills);
                collection.UpdateOne(x => x.name == NametextBox.Text, updatePush);
            }
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            Item items = new Item(ItemtextBox.Text, int.Parse(CounttextBox.Text));
            var updatePush = Builders<Unit>.Update.Push("Items", items);
            collection.UpdateOne(x => x.name == NametextBox.Text, updatePush);
            ItemtextBox.Text = "";

        }

        private void InventoryB_Click(object sender, EventArgs e)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            var one = collection.Find(x => x.name == UnitsListBox.SelectedItem.ToString()).FirstOrDefault();
            Equipment invent = new Equipment();
            invent.username = one.name;
            invent.stregth = one.Strength;
            invent.dexterity = one.Dexterity;
            invent.constitution = one.Constitution;
            invent.intelligence = one.Intellisence;
            if (invent.ShowDialog() == DialogResult.OK)
            {               
                var helmet = invent.helmet;
                var armor = invent.armor;
                var weapon = invent.weapon;
                var update_equip = Builders<Unit>.Update.Set("helmet", helmet).Set("armor", armor).Set("weapon", weapon);
                collection.UpdateOne(x => x.name == NametextBox.Text, update_equip);
            }          
        }

        private void bteams_Click(object sender, EventArgs e)
        {
            List<string> _units = new List<string>();
            foreach(string items in UnitsListBox.Items)
            {
                _units.Add(items);
            }
            Teams teams = new Teams();
            foreach(var item in _units)
            {
                teams.unitsTeams.Add(item);
            }
            if (teams.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}