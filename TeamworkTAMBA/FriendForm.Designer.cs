﻿namespace TeamworkTAMBA
{
    partial class FriendForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.nakovSpeach = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(67, 199);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(160, 50);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // nakovSpeach
            // 
            this.nakovSpeach.AutoSize = true;
            this.nakovSpeach.Location = new System.Drawing.Point(90, 145);
            this.nakovSpeach.Name = "nakovSpeach";
            this.nakovSpeach.Size = new System.Drawing.Size(91, 13);
            this.nakovSpeach.TabIndex = 2;
            this.nakovSpeach.Text = "Nakov`s speache";
            this.nakovSpeach.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.nakovSpeach);
            this.Controls.Add(this.okButton);
            this.Name = "FriendForm";
            this.Text = "FriendForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label nakovSpeach;
    }
}