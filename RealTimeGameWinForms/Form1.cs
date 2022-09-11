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
                    StrengthNumeric.Value = 30;
                    StrengthNumeric.Maximum = 250;
                    DexterityNumeric.Value = 15;
                    DexterityNumeric.Maximum = 70;
                    ConstitutionNumeric.Value = 20;
                    ConstitutionNumeric.Maximum = 100;
                    IntellisenceNumeric.Value = 10;
                    IntellisenceNumeric.Maximum = 50;
                    Avatar.Load(@"C:\Users\vnsxd\Desktop\Other\C#\RealTimeGameWinForms\warrior.gif");
                    Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 1:
                    StrengthNumeric.Value = 15;
                    StrengthNumeric.Maximum = 55;
                    DexterityNumeric.Value = 30;
                    DexterityNumeric.Maximum = 250;
                    ConstitutionNumeric.Value = 20;
                    ConstitutionNumeric.Maximum = 80;
                    IntellisenceNumeric.Value = 15;
                    IntellisenceNumeric.Maximum = 70;
                    Avatar.Load(@"C:\Users\vnsxd\Desktop\Other\C#\RealTimeGameWinForms\rogue.gif");
                    Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 2:
                    StrengthNumeric.Value = 10;
                    StrengthNumeric.Maximum = 45;
                    DexterityNumeric.Value = 20;
                    DexterityNumeric.Maximum = 70;
                    ConstitutionNumeric.Value = 15;
                    ConstitutionNumeric.Maximum = 60;
                    IntellisenceNumeric.Value = 35;
                    IntellisenceNumeric.Maximum = 250;
                    Avatar.Load(@"C:\Users\vnsxd\Desktop\Other\C#\RealTimeGameWinForms\wizard.gif");
                    Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            double Strength = Convert.ToDouble(StrengthNumeric.Value);
            double Dexterity = Convert.ToDouble(DexterityNumeric.Value);
            double Constitution = Convert.ToDouble(ConstitutionNumeric.Value);
            double Intellisence = Convert.ToDouble(IntellisenceNumeric.Value);

            switch (ChoiceUnit.SelectedIndex)
            {
                case 0:

                    double TotalHealth = ((Strength * 2) + (Constitution * 10));
                    double TotalDamage = ((Strength * 5) + (Dexterity));
                    double TotalMagicDamage = Intellisence;
                    double TotalPhysicalDefence = ((Dexterity) + (Constitution * 2));
                    double TotalManaPool = Intellisence;
                    MessageBox.Show($"Здоровья - {TotalHealth} \nУрон - {TotalDamage} \nМагический урон - {TotalMagicDamage} \nБроня - {TotalPhysicalDefence} \nМана - {TotalManaPool}", "Юнит создан");
                break;

                case 1:
                    TotalHealth = ((Strength) + (Constitution * 6));
                    TotalDamage = ((Strength * 2) + (Dexterity * 4));
                    TotalMagicDamage = (Intellisence * 2);
                    TotalPhysicalDefence = (Dexterity * 1.5);
                    TotalManaPool = (Intellisence * 1.5);
                    MessageBox.Show($"Здоровья - {TotalHealth} \nУрон - {TotalDamage} \nМагический урон - {TotalMagicDamage} \nБроня - {TotalPhysicalDefence} \nМана - {TotalManaPool}", "Юнит создан");
                break;

                case 2:
                    TotalHealth = ((Strength) + (Constitution * 3));
                    TotalDamage = (Strength * 2);
                    TotalMagicDamage = (Intellisence * 5);
                    TotalPhysicalDefence = ((Dexterity * 0.5) + (Constitution));
                    TotalManaPool = (Intellisence * 2);
                    MessageBox.Show($"Здоровья - {TotalHealth} \nУрон - {TotalDamage} \nМагический урон - {TotalMagicDamage} \nБроня - {TotalPhysicalDefence} \nМана - {TotalManaPool}", "Юнит создан");
                break;
            }          
        }
    }
}