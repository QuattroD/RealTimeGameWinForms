using System.Windows.Forms;
using System;
using static System.Net.WebRequestMethods;

namespace RealTimeGameWinForms
{
    public partial class RealTimeGameWinForms : Form
    {
        public RealTimeGameWinForms()
        {
            InitializeComponent();
        }

        private void ChoiceUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Avatar.Visible = true;
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
                    Avatar.Load(@"C:\Users\vnsxd\Desktop\Other\C#\RealTimeGameWinForms\warrior.gif");
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
                    Avatar.Load(@"C:\Users\vnsxd\Desktop\Other\C#\RealTimeGameWinForms\rogue.gif");
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
                    Avatar.Load(@"C:\Users\vnsxd\Desktop\Other\C#\RealTimeGameWinForms\wizard.gif");
                    Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        public void Create_Click(object sender, EventArgs e)
        {
            MongoDB mongoDB = new MongoDB();
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
                    FootMan footman = new FootMan(NametextBox.Text, TotalHealth, TotalDamage, TotalMagicDamage, TotalPhysicalDefence, TotalManaPool);
                    MessageBox.Show($"Имя - {footman.name} \nЗдоровья - {footman.health} \nУрон - {footman.damage} \nМагический урон - {footman.magicdamage} \nБроня - {footman.armor} \nМана - {footman.manapool}", "Юнит создан");
                    mongoDB.AddToDB(footman);
                break;

                case 1:
                    TotalHealth = Strength + (Constitution * 6);
                    TotalDamage = (Strength * 2) + (Dexterity * 4);
                    TotalMagicDamage = Intellisence * 2;
                    TotalPhysicalDefence = Dexterity * 1.5;
                    TotalManaPool = Intellisence * 1.5;
                    Rogue rogue = new Rogue(NametextBox.Text, TotalHealth, TotalDamage, TotalMagicDamage, TotalPhysicalDefence, TotalManaPool);
                    MessageBox.Show($"Имя - {rogue.name} \nЗдоровья - {rogue.health} \nУрон - {rogue.damage} \nМагический урон - {rogue.magicdamage} \nБроня - {rogue.armor} \nМана - {rogue.manapool}", "Юнит создан");
                    mongoDB.AddToDB(rogue);
                break;

                case 2:
                    TotalHealth = Strength + (Constitution * 3);
                    TotalDamage = Strength * 2;
                    TotalMagicDamage = Intellisence * 5;
                    TotalPhysicalDefence = (Dexterity * 0.5) + Constitution;
                    TotalManaPool = Intellisence * 2;
                    Wizard wizard = new Wizard(NametextBox.Text, TotalHealth, TotalDamage, TotalMagicDamage, TotalPhysicalDefence, TotalManaPool);
                    MessageBox.Show($"Имя - {wizard.name} \nЗдоровья - {wizard.health} \nУрон - {wizard.damage} \nМагический урон - {wizard.magicdamage} \nБроня - {wizard.armor} \nМана - {wizard.manapool}", "Юнит создан");
                    mongoDB.AddToDB(wizard);
                break;
            }
        }

    }
}