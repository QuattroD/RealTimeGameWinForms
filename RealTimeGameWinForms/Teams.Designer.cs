﻿namespace RealTimeGameWinForms
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
            this.SuspendLayout();
            // 
            // listBoxBlueTeam
            // 
            this.listBoxBlueTeam.FormattingEnabled = true;
            this.listBoxBlueTeam.ItemHeight = 15;
            this.listBoxBlueTeam.Location = new System.Drawing.Point(35, 48);
            this.listBoxBlueTeam.Name = "listBoxBlueTeam";
            this.listBoxBlueTeam.Size = new System.Drawing.Size(176, 304);
            this.listBoxBlueTeam.TabIndex = 0;
            // 
            // listBoxFreeUnits
            // 
            this.listBoxFreeUnits.FormattingEnabled = true;
            this.listBoxFreeUnits.ItemHeight = 15;
            this.listBoxFreeUnits.Location = new System.Drawing.Point(309, 48);
            this.listBoxFreeUnits.Name = "listBoxFreeUnits";
            this.listBoxFreeUnits.Size = new System.Drawing.Size(176, 304);
            this.listBoxFreeUnits.TabIndex = 1;
            // 
            // listBoxRedTeam
            // 
            this.listBoxRedTeam.FormattingEnabled = true;
            this.listBoxRedTeam.ItemHeight = 15;
            this.listBoxRedTeam.Location = new System.Drawing.Point(586, 48);
            this.listBoxRedTeam.Name = "listBoxRedTeam";
            this.listBoxRedTeam.Size = new System.Drawing.Size(176, 304);
            this.listBoxRedTeam.TabIndex = 2;
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxRedTeam);
            this.Controls.Add(this.listBoxFreeUnits);
            this.Controls.Add(this.listBoxBlueTeam);
            this.Name = "Teams";
            this.Text = "Teams";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxBlueTeam;
        private ListBox listBoxFreeUnits;
        private ListBox listBoxRedTeam;
    }
}