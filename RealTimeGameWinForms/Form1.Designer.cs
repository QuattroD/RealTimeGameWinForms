namespace RealTimeGameWinForms
{
    partial class RealTimeGameWinForms
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealTimeGameWinForms));
            this.ChoiceUnit = new System.Windows.Forms.ComboBox();
            this.ChoiceUnitLabel = new System.Windows.Forms.Label();
            this.StrengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.DexterityNumeric = new System.Windows.Forms.NumericUpDown();
            this.ConnstitutionLabel = new System.Windows.Forms.Label();
            this.ConstitutionNumeric = new System.Windows.Forms.NumericUpDown();
            this.IntellisenceLabel = new System.Windows.Forms.Label();
            this.IntellisenceNumeric = new System.Windows.Forms.NumericUpDown();
            this.Create = new System.Windows.Forms.Button();
            this.Avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StrengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexterityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConstitutionNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntellisenceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // ChoiceUnit
            // 
            this.ChoiceUnit.FormattingEnabled = true;
            this.ChoiceUnit.Items.AddRange(new object[] {
            "Warrior",
            "Rogue",
            "Wizard"});
            this.ChoiceUnit.Location = new System.Drawing.Point(12, 33);
            this.ChoiceUnit.Name = "ChoiceUnit";
            this.ChoiceUnit.Size = new System.Drawing.Size(121, 23);
            this.ChoiceUnit.TabIndex = 0;
            this.ChoiceUnit.SelectedIndexChanged += new System.EventHandler(this.ChoiceUnit_SelectedIndexChanged);
            // 
            // ChoiceUnitLabel
            // 
            this.ChoiceUnitLabel.AutoSize = true;
            this.ChoiceUnitLabel.Location = new System.Drawing.Point(12, 15);
            this.ChoiceUnitLabel.Name = "ChoiceUnitLabel";
            this.ChoiceUnitLabel.Size = new System.Drawing.Size(68, 15);
            this.ChoiceUnitLabel.TabIndex = 1;
            this.ChoiceUnitLabel.Text = "Choice unit";
            // 
            // StrengthNumeric
            // 
            this.StrengthNumeric.Location = new System.Drawing.Point(12, 89);
            this.StrengthNumeric.Name = "StrengthNumeric";
            this.StrengthNumeric.Size = new System.Drawing.Size(120, 23);
            this.StrengthNumeric.TabIndex = 2;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(12, 71);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(52, 15);
            this.StrengthLabel.TabIndex = 3;
            this.StrengthLabel.Text = "Strength";
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.AutoSize = true;
            this.DexterityLabel.Location = new System.Drawing.Point(12, 126);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(54, 15);
            this.DexterityLabel.TabIndex = 5;
            this.DexterityLabel.Text = "Dexterity";
            // 
            // DexterityNumeric
            // 
            this.DexterityNumeric.Location = new System.Drawing.Point(12, 144);
            this.DexterityNumeric.Name = "DexterityNumeric";
            this.DexterityNumeric.Size = new System.Drawing.Size(120, 23);
            this.DexterityNumeric.TabIndex = 4;
            // 
            // ConnstitutionLabel
            // 
            this.ConnstitutionLabel.AutoSize = true;
            this.ConnstitutionLabel.Location = new System.Drawing.Point(12, 180);
            this.ConnstitutionLabel.Name = "ConnstitutionLabel";
            this.ConnstitutionLabel.Size = new System.Drawing.Size(73, 15);
            this.ConnstitutionLabel.TabIndex = 7;
            this.ConnstitutionLabel.Text = "Constitution";
            // 
            // ConstitutionNumeric
            // 
            this.ConstitutionNumeric.Location = new System.Drawing.Point(12, 198);
            this.ConstitutionNumeric.Name = "ConstitutionNumeric";
            this.ConstitutionNumeric.Size = new System.Drawing.Size(120, 23);
            this.ConstitutionNumeric.TabIndex = 6;
            // 
            // IntellisenceLabel
            // 
            this.IntellisenceLabel.AutoSize = true;
            this.IntellisenceLabel.Location = new System.Drawing.Point(12, 234);
            this.IntellisenceLabel.Name = "IntellisenceLabel";
            this.IntellisenceLabel.Size = new System.Drawing.Size(66, 15);
            this.IntellisenceLabel.TabIndex = 9;
            this.IntellisenceLabel.Text = "Intellisence";
            // 
            // IntellisenceNumeric
            // 
            this.IntellisenceNumeric.Location = new System.Drawing.Point(12, 252);
            this.IntellisenceNumeric.Name = "IntellisenceNumeric";
            this.IntellisenceNumeric.Size = new System.Drawing.Size(120, 23);
            this.IntellisenceNumeric.TabIndex = 8;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(12, 281);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 10;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Avatar
            // 
            this.Avatar.Location = new System.Drawing.Point(176, 15);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(394, 330);
            this.Avatar.TabIndex = 11;
            this.Avatar.TabStop = false;
            this.Avatar.Visible = false;
            // 
            // RealTimeGameWinForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 386);
            this.Controls.Add(this.Avatar);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.IntellisenceLabel);
            this.Controls.Add(this.IntellisenceNumeric);
            this.Controls.Add(this.ConnstitutionLabel);
            this.Controls.Add(this.ConstitutionNumeric);
            this.Controls.Add(this.DexterityLabel);
            this.Controls.Add(this.DexterityNumeric);
            this.Controls.Add(this.StrengthLabel);
            this.Controls.Add(this.StrengthNumeric);
            this.Controls.Add(this.ChoiceUnitLabel);
            this.Controls.Add(this.ChoiceUnit);
            this.DoubleBuffered = true;
            this.Name = "RealTimeGameWinForms";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StrengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexterityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConstitutionNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntellisenceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ChoiceUnit;
        private Label ChoiceUnitLabel;
        private NumericUpDown StrengthNumeric;
        private Label StrengthLabel;
        private Label DexterityLabel;
        private NumericUpDown DexterityNumeric;
        private Label ConnstitutionLabel;
        private NumericUpDown ConstitutionNumeric;
        private Label IntellisenceLabel;
        private NumericUpDown IntellisenceNumeric;
        private Button Create;
        private PictureBox Avatar;
    }
}