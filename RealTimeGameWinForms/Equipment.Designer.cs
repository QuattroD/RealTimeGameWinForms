namespace RealTimeGameWinForms
{
    partial class Equipment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "CONFESSOR HOOD",
            "test"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "CONFESSOR ARMOR",
            "test1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("DAGGERS");
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnType = new System.Windows.Forms.ColumnHeader();
            this.columnStrength = new System.Windows.Forms.ColumnHeader();
            this.columnDexterity = new System.Windows.Forms.ColumnHeader();
            this.columnConstitution = new System.Windows.Forms.ColumnHeader();
            this.columnIntellegence = new System.Windows.Forms.ColumnHeader();
            this.columnLVL = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnType,
            this.columnLVL,
            this.columnStrength,
            this.columnDexterity,
            this.columnConstitution,
            this.columnIntellegence});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(313, 117);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(428, 170);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 135;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            // 
            // columnStrength
            // 
            this.columnStrength.DisplayIndex = 2;
            this.columnStrength.Text = "Strength";
            // 
            // columnDexterity
            // 
            this.columnDexterity.DisplayIndex = 3;
            this.columnDexterity.Text = "Dexterity";
            // 
            // columnConstitution
            // 
            this.columnConstitution.DisplayIndex = 4;
            this.columnConstitution.Text = "Constitution";
            // 
            // columnIntellegence
            // 
            this.columnIntellegence.DisplayIndex = 5;
            this.columnIntellegence.Text = "Intellegence";
            // 
            // columnLVL
            // 
            this.columnLVL.DisplayIndex = 6;
            this.columnLVL.Text = "ColumnLVL";
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "Equipment";
            this.Text = "Helmet";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnName;
        private ColumnHeader columnType;
        private ColumnHeader columnStrength;
        private ColumnHeader columnDexterity;
        private ColumnHeader columnConstitution;
        private ColumnHeader columnIntellegence;
        private ColumnHeader columnLVL;
    }
}