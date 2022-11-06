namespace RealTimeGameWinForms
{
    partial class Teams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teams));
            this.listBoxBlueTeam = new System.Windows.Forms.ListBox();
            this.listBoxFreeUnits = new System.Windows.Forms.ListBox();
            this.listBoxRedTeam = new System.Windows.Forms.ListBox();
            this.Bauto = new System.Windows.Forms.Button();
            this.labelBlueTeam = new System.Windows.Forms.Label();
            this.labelFree = new System.Windows.Forms.Label();
            this.labelRedTeam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxBlueTeam
            // 
            this.listBoxBlueTeam.FormattingEnabled = true;
            this.listBoxBlueTeam.ItemHeight = 15;
            this.listBoxBlueTeam.Location = new System.Drawing.Point(20, 67);
            this.listBoxBlueTeam.Name = "listBoxBlueTeam";
            this.listBoxBlueTeam.Size = new System.Drawing.Size(210, 304);
            this.listBoxBlueTeam.TabIndex = 0;
            // 
            // listBoxFreeUnits
            // 
            this.listBoxFreeUnits.FormattingEnabled = true;
            this.listBoxFreeUnits.ItemHeight = 15;
            this.listBoxFreeUnits.Location = new System.Drawing.Point(294, 67);
            this.listBoxFreeUnits.Name = "listBoxFreeUnits";
            this.listBoxFreeUnits.Size = new System.Drawing.Size(210, 304);
            this.listBoxFreeUnits.TabIndex = 1;
            // 
            // listBoxRedTeam
            // 
            this.listBoxRedTeam.FormattingEnabled = true;
            this.listBoxRedTeam.ItemHeight = 15;
            this.listBoxRedTeam.Location = new System.Drawing.Point(571, 67);
            this.listBoxRedTeam.Name = "listBoxRedTeam";
            this.listBoxRedTeam.Size = new System.Drawing.Size(210, 304);
            this.listBoxRedTeam.TabIndex = 2;
            // 
            // Bauto
            // 
            this.Bauto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bauto.Location = new System.Drawing.Point(312, 392);
            this.Bauto.Name = "Bauto";
            this.Bauto.Size = new System.Drawing.Size(174, 34);
            this.Bauto.TabIndex = 3;
            this.Bauto.Text = "Autodistribution";
            this.Bauto.UseVisualStyleBackColor = true;
            this.Bauto.Click += new System.EventHandler(this.Bauto_Click);
            // 
            // labelBlueTeam
            // 
            this.labelBlueTeam.AutoSize = true;
            this.labelBlueTeam.BackColor = System.Drawing.Color.Transparent;
            this.labelBlueTeam.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBlueTeam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBlueTeam.Location = new System.Drawing.Point(54, 23);
            this.labelBlueTeam.Name = "labelBlueTeam";
            this.labelBlueTeam.Size = new System.Drawing.Size(127, 29);
            this.labelBlueTeam.TabIndex = 4;
            this.labelBlueTeam.Text = "Blue team";
            // 
            // labelFree
            // 
            this.labelFree.AutoSize = true;
            this.labelFree.BackColor = System.Drawing.Color.Transparent;
            this.labelFree.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFree.Location = new System.Drawing.Point(333, 23);
            this.labelFree.Name = "labelFree";
            this.labelFree.Size = new System.Drawing.Size(125, 29);
            this.labelFree.TabIndex = 4;
            this.labelFree.Text = "Free team";
            // 
            // labelRedTeam
            // 
            this.labelRedTeam.AutoSize = true;
            this.labelRedTeam.BackColor = System.Drawing.Color.Transparent;
            this.labelRedTeam.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRedTeam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRedTeam.Location = new System.Drawing.Point(614, 23);
            this.labelRedTeam.Name = "labelRedTeam";
            this.labelRedTeam.Size = new System.Drawing.Size(120, 29);
            this.labelRedTeam.TabIndex = 4;
            this.labelRedTeam.Text = "Red team";
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRedTeam);
            this.Controls.Add(this.labelFree);
            this.Controls.Add(this.labelBlueTeam);
            this.Controls.Add(this.Bauto);
            this.Controls.Add(this.listBoxRedTeam);
            this.Controls.Add(this.listBoxFreeUnits);
            this.Controls.Add(this.listBoxBlueTeam);
            this.Name = "Teams";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Teams_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxBlueTeam;
        private ListBox listBoxFreeUnits;
        private ListBox listBoxRedTeam;
        private Button Bauto;
        private Label labelBlueTeam;
        private Label labelFree;
        private Label labelRedTeam;
    }
}