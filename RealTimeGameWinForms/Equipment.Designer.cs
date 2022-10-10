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
            this.EquipmentListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EquipmentListBox
            // 
            this.EquipmentListBox.FormattingEnabled = true;
            this.EquipmentListBox.ItemHeight = 15;
            this.EquipmentListBox.Location = new System.Drawing.Point(61, 109);
            this.EquipmentListBox.Name = "EquipmentListBox";
            this.EquipmentListBox.Size = new System.Drawing.Size(151, 154);
            this.EquipmentListBox.TabIndex = 0;
            this.EquipmentListBox.SelectedValueChanged += new System.EventHandler(this.EquipmentListBox_SelectedValueChanged);
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EquipmentListBox);
            this.Name = "Equipment";
            this.Text = "Helmet";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox EquipmentListBox;
    }
}