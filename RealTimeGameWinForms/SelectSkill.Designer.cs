namespace RealTimeGameWinForms
{
    partial class SelectSkill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectSkill));
            this.Skills_1 = new System.Windows.Forms.Button();
            this.Skills_2 = new System.Windows.Forms.Button();
            this.Skills_3 = new System.Windows.Forms.Button();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.SkillnameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Skills_1
            // 
            this.Skills_1.BackColor = System.Drawing.Color.Transparent;
            this.Skills_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Skills_1.BackgroundImage")));
            this.Skills_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skills_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Skills_1.Location = new System.Drawing.Point(53, 149);
            this.Skills_1.Name = "Skills_1";
            this.Skills_1.Size = new System.Drawing.Size(100, 100);
            this.Skills_1.TabIndex = 0;
            this.Skills_1.UseVisualStyleBackColor = false;
            this.Skills_1.Click += new System.EventHandler(this.Skills_1_Click);
            // 
            // Skills_2
            // 
            this.Skills_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Skills_2.BackgroundImage")));
            this.Skills_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skills_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Skills_2.Location = new System.Drawing.Point(210, 149);
            this.Skills_2.Name = "Skills_2";
            this.Skills_2.Size = new System.Drawing.Size(100, 100);
            this.Skills_2.TabIndex = 0;
            this.Skills_2.UseVisualStyleBackColor = true;
            this.Skills_2.Click += new System.EventHandler(this.Skills_2_Click);
            // 
            // Skills_3
            // 
            this.Skills_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Skills_3.BackgroundImage")));
            this.Skills_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skills_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Skills_3.Location = new System.Drawing.Point(365, 149);
            this.Skills_3.Name = "Skills_3";
            this.Skills_3.Size = new System.Drawing.Size(100, 100);
            this.Skills_3.TabIndex = 0;
            this.Skills_3.UseVisualStyleBackColor = true;
            this.Skills_3.Click += new System.EventHandler(this.Skills_3_Click);
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectLabel.Location = new System.Drawing.Point(94, 60);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(330, 86);
            this.SelectLabel.TabIndex = 1;
            this.SelectLabel.Text = "Select skill";
            // 
            // SkillnameTextBox
            // 
            this.SkillnameTextBox.Location = new System.Drawing.Point(188, 34);
            this.SkillnameTextBox.Name = "SkillnameTextBox";
            this.SkillnameTextBox.Size = new System.Drawing.Size(100, 23);
            this.SkillnameTextBox.TabIndex = 2;
            // 
            // SelectSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 326);
            this.Controls.Add(this.SkillnameTextBox);
            this.Controls.Add(this.SelectLabel);
            this.Controls.Add(this.Skills_3);
            this.Controls.Add(this.Skills_2);
            this.Controls.Add(this.Skills_1);
            this.Name = "SelectSkill";
            this.Text = "SelectSkill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Skills_1;
        private Button Skills_2;
        private Button Skills_3;
        private Label SelectLabel;
        private TextBox SkillnameTextBox;
    }
}