using System.Windows.Forms;
using System;
using static System.Net.WebRequestMethods;
using MongoDB.Driver;
using System.Xml.Linq;
using System.Security.Policy;
using MongoDB.Bson.Serialization;
using System.Security.AccessControl;

namespace RealTimeGameWinForms
{
    public partial class RealTimeGameWinForms : Form
    {
        double TotalHealth;
        double TotalDamage;
        double TotalMagicDamage;
        double TotalPhysicalDefence;
        double TotalManaPool;
        double Strength = 0;
        double Dexterity = 0;
        double Constitution = 0;
        double Intellisence = 0;
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
        }

        MongoDB mongoDB = new MongoDB();
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

                    // Avatar.Load(url: @"https://static.cdprojektred.com/playgwent.com/news/big/playgwent.com_en_1535708549_5b890d852fb152.36885555.jpg");
                    Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
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

                    // Avatar.Load(url: @"https://staticctf.akamaized.net/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/2EFsSmHHzSOjl3u7zcw1V3/5d4c2b629ca15a6044fda6bbbd6c2d07/acrogue_remastered_hero_mobile_Mobile-v2.jpg");
                    Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
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

                    // Avatar.Load(url: @"http://www.cinema.com.my/images/news/2016/7g_warcraftnew00.jpg");
                    Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            UnitsListBox.Visible = true;
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
                    Warrior warrior = new Warrior(NametextBox.Text, TotalHealth, TotalDamage, TotalMagicDamage, TotalPhysicalDefence, TotalManaPool, Strength, Dexterity, Constitution, Intellisence);
                    MessageBox.Show($"Имя - {warrior.name} \nЗдоровья - {warrior.health} \nУрон - {warrior.damage} \nМагический урон - {warrior.magicdamage} \nБроня - {warrior.armor} \nМана - {warrior.manapool}", "Юнит создан");
                    warrior.AddItem(new Item(ItemtextBox.Text, int.Parse(Counttextbox.Text)));
                    mongoDB.AddToDB(warrior);
                    break;

                case 1:
                    TotalHealth = Strength + (Constitution * 6);
                    TotalDamage = (Strength * 2) + (Dexterity * 4);
                    TotalMagicDamage = Intellisence * 2;
                    TotalPhysicalDefence = Dexterity * 1.5;
                    TotalManaPool = Intellisence * 1.5;
                    Rogue rogue = new Rogue(NametextBox.Text, TotalHealth, TotalDamage, TotalMagicDamage, TotalPhysicalDefence, TotalManaPool, Strength, Dexterity, Constitution, Intellisence);
                    MessageBox.Show($"Имя - {rogue.name} \nЗдоровья - {rogue.health} \nУрон - {rogue.damage} \nМагический урон - {rogue.magicdamage} \nБроня - {rogue.armor} \nМана - {rogue.manapool}", "Юнит создан");
                    rogue.AddItem(new Item(ItemtextBox.Text, int.Parse(Counttextbox.Text)));
                    mongoDB.AddToDB(rogue);
                    break;

                case 2:
                    TotalHealth = Strength + (Constitution * 3);
                    TotalDamage = Strength * 2;
                    TotalMagicDamage = Intellisence * 5;
                    TotalPhysicalDefence = (Dexterity * 0.5) + Constitution;
                    TotalManaPool = Intellisence * 2;
                    Wizard wizard = new Wizard(NametextBox.Text, TotalHealth, TotalDamage, TotalMagicDamage, TotalPhysicalDefence, TotalManaPool, Strength, Dexterity, Constitution, Intellisence);
                    MessageBox.Show($"Имя - {wizard.name} \nЗдоровья - {wizard.health} \nУрон - {wizard.damage} \nМагический урон - {wizard.magicdamage} \nБроня - {wizard.armor} \nМана - {wizard.manapool}", "Юнит создан");
                    wizard.AddItem(new Item(ItemtextBox.Text, int.Parse(Counttextbox.Text)));
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
            switch (one.GetType().Name)
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
        }

        private void BChange_Click(object sender, EventArgs e)
        {
            Strength = Convert.ToDouble(StrengthNumeric.Value);
            Dexterity = Convert.ToDouble(DexterityNumeric.Value);
            Constitution = Convert.ToDouble(ConstitutionNumeric.Value);
            Intellisence = Convert.ToDouble(IntellisenceNumeric.Value);
            switch (UnitsListBox.SelectedIndex)
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
            Unit unit = new Unit(NametextBox.Text, TotalHealth, TotalDamage, TotalMagicDamage, TotalPhysicalDefence, TotalManaPool, Strength, Dexterity, Constitution, Intellisence);
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            collection.ReplaceOne(x => x.name == NametextBox.Text, unit);
        }
    }
}