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
            this.UnitsListBox = new System.Windows.Forms.ListBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.BFind = new System.Windows.Forms.Button();
            this.FindtextBox = new System.Windows.Forms.TextBox();
            this.BFindAll = new System.Windows.Forms.Button();
            this.ItemtextBox = new System.Windows.Forms.TextBox();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.BChange = new System.Windows.Forms.Button();
            this.B500exp = new System.Windows.Forms.Button();
            this.B1000exp = new System.Windows.Forms.Button();
            this.progressEXP = new System.Windows.Forms.ProgressBar();
            this.ShowUnitTable = new System.Windows.Forms.DataGridView();
            this.LVLtextBox = new System.Windows.Forms.TextBox();
            this.LVLlabel = new System.Windows.Forms.Label();
            this.ExpInfo = new System.Windows.Forms.Label();
            this.SelectSkills = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StrengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexterityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConstitutionNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntellisenceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowUnitTable)).BeginInit();
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
            this.ChoiceUnitLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChoiceUnitLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoiceUnitLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChoiceUnitLabel.Location = new System.Drawing.Point(12, 10);
            this.ChoiceUnitLabel.Name = "ChoiceUnitLabel";
            this.ChoiceUnitLabel.Size = new System.Drawing.Size(83, 20);
            this.ChoiceUnitLabel.TabIndex = 1;
            this.ChoiceUnitLabel.Text = "Choice unit";
            // 
            // StrengthNumeric
            // 
            this.StrengthNumeric.Location = new System.Drawing.Point(12, 133);
            this.StrengthNumeric.Name = "StrengthNumeric";
            this.StrengthNumeric.Size = new System.Drawing.Size(120, 23);
            this.StrengthNumeric.TabIndex = 2;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.StrengthLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StrengthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StrengthLabel.Location = new System.Drawing.Point(12, 110);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(65, 20);
            this.StrengthLabel.TabIndex = 3;
            this.StrengthLabel.Text = "Strength";
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.AutoSize = true;
            this.DexterityLabel.BackColor = System.Drawing.Color.Transparent;
            this.DexterityLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DexterityLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DexterityLabel.Location = new System.Drawing.Point(12, 165);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(69, 20);
            this.DexterityLabel.TabIndex = 5;
            this.DexterityLabel.Text = "Dexterity";
            // 
            // DexterityNumeric
            // 
            this.DexterityNumeric.Location = new System.Drawing.Point(12, 188);
            this.DexterityNumeric.Name = "DexterityNumeric";
            this.DexterityNumeric.Size = new System.Drawing.Size(120, 23);
            this.DexterityNumeric.TabIndex = 4;
            // 
            // ConnstitutionLabel
            // 
            this.ConnstitutionLabel.AutoSize = true;
            this.ConnstitutionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConnstitutionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConnstitutionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConnstitutionLabel.Location = new System.Drawing.Point(12, 219);
            this.ConnstitutionLabel.Name = "ConnstitutionLabel";
            this.ConnstitutionLabel.Size = new System.Drawing.Size(89, 20);
            this.ConnstitutionLabel.TabIndex = 7;
            this.ConnstitutionLabel.Text = "Constitution";
            // 
            // ConstitutionNumeric
            // 
            this.ConstitutionNumeric.Location = new System.Drawing.Point(12, 242);
            this.ConstitutionNumeric.Name = "ConstitutionNumeric";
            this.ConstitutionNumeric.Size = new System.Drawing.Size(120, 23);
            this.ConstitutionNumeric.TabIndex = 6;
            // 
            // IntellisenceLabel
            // 
            this.IntellisenceLabel.AutoSize = true;
            this.IntellisenceLabel.BackColor = System.Drawing.Color.Transparent;
            this.IntellisenceLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IntellisenceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IntellisenceLabel.Location = new System.Drawing.Point(12, 273);
            this.IntellisenceLabel.Name = "IntellisenceLabel";
            this.IntellisenceLabel.Size = new System.Drawing.Size(83, 20);
            this.IntellisenceLabel.TabIndex = 9;
            this.IntellisenceLabel.Text = "Intellisence";
            // 
            // IntellisenceNumeric
            // 
            this.IntellisenceNumeric.Location = new System.Drawing.Point(12, 296);
            this.IntellisenceNumeric.Name = "IntellisenceNumeric";
            this.IntellisenceNumeric.Size = new System.Drawing.Size(120, 23);
            this.IntellisenceNumeric.TabIndex = 8;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(10, 386);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(52, 23);
            this.Create.TabIndex = 10;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Avatar
            // 
            this.Avatar.Location = new System.Drawing.Point(948, 365);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(187, 184);
            this.Avatar.TabIndex = 11;
            this.Avatar.TabStop = false;
            this.Avatar.Visible = false;
            // 
            // UnitsListBox
            // 
            this.UnitsListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnitsListBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnitsListBox.FormattingEnabled = true;
            this.UnitsListBox.ItemHeight = 30;
            this.UnitsListBox.Location = new System.Drawing.Point(148, 10);
            this.UnitsListBox.MultiColumn = true;
            this.UnitsListBox.Name = "UnitsListBox";
            this.UnitsListBox.Size = new System.Drawing.Size(156, 184);
            this.UnitsListBox.TabIndex = 12;
            this.UnitsListBox.SelectedIndexChanged += new System.EventHandler(this.UnitsListBox_SelectedIndexChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(12, 60);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 20);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "Name";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(12, 83);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(120, 23);
            this.NametextBox.TabIndex = 15;
            // 
            // BFind
            // 
            this.BFind.Location = new System.Drawing.Point(10, 444);
            this.BFind.Name = "BFind";
            this.BFind.Size = new System.Drawing.Size(52, 23);
            this.BFind.TabIndex = 16;
            this.BFind.Text = "Find";
            this.BFind.UseVisualStyleBackColor = true;
            this.BFind.Click += new System.EventHandler(this.BFind_Click);
            // 
            // FindtextBox
            // 
            this.FindtextBox.Location = new System.Drawing.Point(10, 415);
            this.FindtextBox.Name = "FindtextBox";
            this.FindtextBox.Size = new System.Drawing.Size(120, 23);
            this.FindtextBox.TabIndex = 17;
            // 
            // BFindAll
            // 
            this.BFindAll.Location = new System.Drawing.Point(68, 444);
            this.BFindAll.Name = "BFindAll";
            this.BFindAll.Size = new System.Drawing.Size(62, 23);
            this.BFindAll.TabIndex = 18;
            this.BFindAll.Text = "FindAll";
            this.BFindAll.UseVisualStyleBackColor = true;
            this.BFindAll.Click += new System.EventHandler(this.BFindAll_Click);
            // 
            // ItemtextBox
            // 
            this.ItemtextBox.Location = new System.Drawing.Point(10, 352);
            this.ItemtextBox.Name = "ItemtextBox";
            this.ItemtextBox.Size = new System.Drawing.Size(67, 23);
            this.ItemtextBox.TabIndex = 22;
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.ItemLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemLabel.Location = new System.Drawing.Point(10, 329);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(39, 20);
            this.ItemLabel.TabIndex = 21;
            this.ItemLabel.Text = "Item";
            // 
            // BChange
            // 
            this.BChange.Location = new System.Drawing.Point(71, 386);
            this.BChange.Name = "BChange";
            this.BChange.Size = new System.Drawing.Size(62, 23);
            this.BChange.TabIndex = 26;
            this.BChange.Text = "Change";
            this.BChange.UseVisualStyleBackColor = true;
            this.BChange.Click += new System.EventHandler(this.BChange_Click);
            // 
            // B500exp
            // 
            this.B500exp.Location = new System.Drawing.Point(148, 299);
            this.B500exp.Name = "B500exp";
            this.B500exp.Size = new System.Drawing.Size(75, 23);
            this.B500exp.TabIndex = 27;
            this.B500exp.Text = "+500EXP";
            this.B500exp.UseVisualStyleBackColor = true;
            this.B500exp.Visible = false;
            this.B500exp.Click += new System.EventHandler(this.B500exp_Click);
            // 
            // B1000exp
            // 
            this.B1000exp.Location = new System.Drawing.Point(229, 299);
            this.B1000exp.Name = "B1000exp";
            this.B1000exp.Size = new System.Drawing.Size(75, 23);
            this.B1000exp.TabIndex = 28;
            this.B1000exp.Text = "+1000exp";
            this.B1000exp.UseVisualStyleBackColor = true;
            this.B1000exp.Visible = false;
            this.B1000exp.Click += new System.EventHandler(this.B1000exp_Click);
            // 
            // progressEXP
            // 
            this.progressEXP.BackColor = System.Drawing.Color.Gray;
            this.progressEXP.Location = new System.Drawing.Point(148, 270);
            this.progressEXP.Name = "progressEXP";
            this.progressEXP.Size = new System.Drawing.Size(100, 20);
            this.progressEXP.TabIndex = 29;
            this.progressEXP.Tag = "";
            this.progressEXP.Visible = false;
            // 
            // ShowUnitTable
            // 
            this.ShowUnitTable.AllowUserToDeleteRows = false;
            this.ShowUnitTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowUnitTable.Location = new System.Drawing.Point(649, 7);
            this.ShowUnitTable.Name = "ShowUnitTable";
            this.ShowUnitTable.ReadOnly = true;
            this.ShowUnitTable.RowTemplate.Height = 25;
            this.ShowUnitTable.Size = new System.Drawing.Size(486, 315);
            this.ShowUnitTable.TabIndex = 31;
            this.ShowUnitTable.Visible = false;
            // 
            // LVLtextBox
            // 
            this.LVLtextBox.Location = new System.Drawing.Point(188, 247);
            this.LVLtextBox.Multiline = true;
            this.LVLtextBox.Name = "LVLtextBox";
            this.LVLtextBox.ReadOnly = true;
            this.LVLtextBox.Size = new System.Drawing.Size(22, 20);
            this.LVLtextBox.TabIndex = 32;
            this.LVLtextBox.Text = "1";
            this.LVLtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LVLtextBox.Visible = false;
            this.LVLtextBox.TextChanged += new System.EventHandler(this.LVLtextBox_TextChanged);
            // 
            // LVLlabel
            // 
            this.LVLlabel.AutoSize = true;
            this.LVLlabel.BackColor = System.Drawing.Color.Transparent;
            this.LVLlabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LVLlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LVLlabel.Location = new System.Drawing.Point(148, 247);
            this.LVLlabel.Name = "LVLlabel";
            this.LVLlabel.Size = new System.Drawing.Size(34, 20);
            this.LVLlabel.TabIndex = 33;
            this.LVLlabel.Text = "LVL:";
            this.LVLlabel.Visible = false;
            // 
            // ExpInfo
            // 
            this.ExpInfo.AutoSize = true;
            this.ExpInfo.BackColor = System.Drawing.Color.Transparent;
            this.ExpInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExpInfo.Location = new System.Drawing.Point(272, 270);
            this.ExpInfo.Name = "ExpInfo";
            this.ExpInfo.Size = new System.Drawing.Size(0, 20);
            this.ExpInfo.TabIndex = 34;
            // 
            // SelectSkills
            // 
            this.SelectSkills.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectSkills.Location = new System.Drawing.Point(148, 337);
            this.SelectSkills.Name = "SelectSkills";
            this.SelectSkills.Size = new System.Drawing.Size(156, 72);
            this.SelectSkills.TabIndex = 35;
            this.SelectSkills.Text = "Select skill";
            this.SelectSkills.UseVisualStyleBackColor = true;
            this.SelectSkills.Visible = false;
            this.SelectSkills.Click += new System.EventHandler(this.SelectSkills_Click);
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(83, 352);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(50, 23);
            this.BAdd.TabIndex = 36;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // RealTimeGameWinForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 561);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.SelectSkills);
            this.Controls.Add(this.ExpInfo);
            this.Controls.Add(this.LVLlabel);
            this.Controls.Add(this.LVLtextBox);
            this.Controls.Add(this.ShowUnitTable);
            this.Controls.Add(this.progressEXP);
            this.Controls.Add(this.B1000exp);
            this.Controls.Add(this.B500exp);
            this.Controls.Add(this.BChange);
            this.Controls.Add(this.ItemtextBox);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.BFindAll);
            this.Controls.Add(this.FindtextBox);
            this.Controls.Add(this.BFind);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.UnitsListBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.ShowUnitTable)).EndInit();
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
        private ListBox UnitsListBox;
        private Label NameLabel;
        private TextBox NametextBox;
        private Button BFind;
        private TextBox FindtextBox;
        private Button BFindAll;
        private TextBox ItemtextBox;
        private Label ItemLabel;
        private Button BChange;
        private Button B500exp;
        private Button B1000exp;
        private ProgressBar progressEXP;
        private DataGridView ShowUnitTable;
        private TextBox LVLtextBox;
        private Label LVLlabel;
        private Label ExpInfo;
        private Button SelectSkills;
        private Button BAdd;
    }
}