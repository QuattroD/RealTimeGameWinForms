using System.Windows.Forms;
using System;
using static System.Net.WebRequestMethods;
using MongoDB.Driver;
using System.Xml.Linq;

namespace RealTimeGameWinForms
{
    public partial class RealTimeGameWinForms : Form
    {
        public RealTimeGameWinForms()
        {
            InitializeComponent();
            /*var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            List<Unit> names = collection.AsQueryable().ToList<Unit>();
            foreach (var item in names)
            {
                UnitsListBox.Items.Add(item.name);
            }*/
        }

        MongoDB mongoDB = new MongoDB();   
        private void ChoiceUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChoiceUnit.SelectedIndex)
            {
                case 0:
                    StrengthNumeric.Minimum = 30;
                    StrengthNumeric.Value = 30;
                    StrengthNumeric.Maximum = 250;

                    DexterityNumeric.Minimum = 15;
                    DexterityNumeric.Value = 15;
                    DexterityNumeric.Maximum = 70;

                    ConstitutionNumeric.Minimum = 20;
                    ConstitutionNumeric.Value = 20;
                    ConstitutionNumeric.Maximum = 100;

                    IntellisenceNumeric.Minimum = 10;
                    IntellisenceNumeric.Value = 10;
                    IntellisenceNumeric.Maximum = 50;
                    //Avatar.Load(url: @"https://static.cdprojektred.com/playgwent.com/news/big/playgwent.com_en_1535708549_5b890d852fb152.36885555.jpg");
                    Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 1:
                    StrengthNumeric.Minimum = 15;
                    StrengthNumeric.Value = 15;
                    StrengthNumeric.Maximum = 55;

                    DexterityNumeric.Minimum = 30;
                    DexterityNumeric.Value = 30;
                    DexterityNumeric.Maximum = 250;

                    ConstitutionNumeric.Minimum = 20;
                    ConstitutionNumeric.Value = 20;
                    ConstitutionNumeric.Maximum = 80;

                    IntellisenceNumeric.Minimum = 15;
                    IntellisenceNumeric.Value = 15;
                    IntellisenceNumeric.Maximum = 70;
                    //Avatar.Load(url: @"https://staticctf.akamaized.net/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/2EFsSmHHzSOjl3u7zcw1V3/5d4c2b629ca15a6044fda6bbbd6c2d07/acrogue_remastered_hero_mobile_Mobile-v2.jpg");
                    Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 2:
                    StrengthNumeric.Minimum = 10;
                    StrengthNumeric.Value = 10;
                    StrengthNumeric.Maximum = 45;

                    DexterityNumeric.Minimum = 20;
                    DexterityNumeric.Value = 20;
                    DexterityNumeric.Maximum = 70;

                    ConstitutionNumeric.Minimum = 15;
                    ConstitutionNumeric.Value = 15;
                    ConstitutionNumeric.Maximum = 60;

                    IntellisenceNumeric.Minimum = 35;
                    IntellisenceNumeric.Value = 35;
                    IntellisenceNumeric.Maximum = 250;
                    //Avatar.Load(url: @"http://www.cinema.com.my/images/news/2016/7g_warcraftnew00.jpg");
                    Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        public void Create_Click(object sender, EventArgs e)
        {
            UnitsListBox.Visible = true;
            double Strength = Convert.ToDouble(StrengthNumeric.Value);
            double Dexterity = Convert.ToDouble(DexterityNumeric.Value);
            double Constitution = Convert.ToDouble(ConstitutionNumeric.Value);
            double Intellisence = Convert.ToDouble(IntellisenceNumeric.Value);
            double TotalHealth;
            double TotalDamage;
            double TotalMagicDamage;
            double TotalPhysicalDefence;
            double TotalManaPool;
            
            switch (ChoiceUnit.SelectedIndex)
            {
                case 0:
                    TotalHealth = (Strength * 2) + (Constitution * 10);
                    TotalDamage = (Strength * 5) + Dexterity;
                    TotalMagicDamage = Intellisence;
                    TotalPhysicalDefence = Dexterity + (Constitution * 2);
                    TotalManaPool = Intellisence;
                    FootMan footman = new FootMan(NametextBox.Text, TotalHealth, TotalDamage, TotalMagicDamage, TotalPhysicalDefence, TotalManaPool, Strength, Dexterity, Constitution, Intellisence);
                    MessageBox.Show($"��� - {footman.name} \n�������� - {footman.health} \n���� - {footman.damage} \n���������� ���� - {footman.magicdamage} \n����� - {footman.armor} \n���� - {footman.manapool}", "���� ������");
                    mongoDB.AddToDB(footman);
                break;

                case 1:
                    TotalHealth = Strength + (Constitution * 6);
                    TotalDamage = (Strength * 2) + (Dexterity * 4);
                    TotalMagicDamage = Intellisence * 2;
                    TotalPhysicalDefence = Dexterity * 1.5;
                    TotalManaPool = Intellisence * 1.5;
                    Rogue rogue = new Rogue(NametextBox.Text, TotalHealth, TotalDamage, TotalMagicDamage, TotalPhysicalDefence, TotalManaPool, Strength, Dexterity, Constitution, Intellisence);
                    MessageBox.Show($"��� - {rogue.name} \n�������� - {rogue.health} \n���� - {rogue.damage} \n���������� ���� - {rogue.magicdamage} \n����� - {rogue.armor} \n���� - {rogue.manapool}", "���� ������");
                    mongoDB.AddToDB(rogue);
                break;

                case 2:
                    TotalHealth = Strength + (Constitution * 3);
                    TotalDamage = Strength * 2;
                    TotalMagicDamage = Intellisence * 5;
                    TotalPhysicalDefence = (Dexterity * 0.5) + Constitution;
                    TotalManaPool = Intellisence * 2;
                    Wizard wizard = new Wizard(NametextBox.Text, TotalHealth, TotalDamage, TotalMagicDamage, TotalPhysicalDefence, TotalManaPool, Strength, Dexterity, Constitution, Intellisence);
                    MessageBox.Show($"��� - {wizard.name} \n�������� - {wizard.health} \n���� - {wizard.damage} \n���������� ���� - {wizard.magicdamage} \n����� - {wizard.armor} \n���� - {wizard.manapool}", "���� ������");
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
            switch(one.GetType().Name)
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
    }
}