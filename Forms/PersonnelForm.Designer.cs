﻿namespace Practice
{
    partial class PersonnelForm
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
            this.patternsLabel = new System.Windows.Forms.Label();
            this.tablesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patternsLabel
            // 
            this.patternsLabel.AutoSize = true;
            this.patternsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patternsLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patternsLabel.Location = new System.Drawing.Point(11, 50);
            this.patternsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patternsLabel.Name = "patternsLabel";
            this.patternsLabel.Size = new System.Drawing.Size(105, 25);
            this.patternsLabel.TabIndex = 7;
            this.patternsLabel.Text = "Шаблони";
            this.patternsLabel.Click += new System.EventHandler(this.patternsLabel_Click);
            // 
            // tablesLabel
            // 
            this.tablesLabel.AutoSize = true;
            this.tablesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.tablesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablesLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablesLabel.Location = new System.Drawing.Point(11, 10);
            this.tablesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tablesLabel.Name = "tablesLabel";
            this.tablesLabel.Size = new System.Drawing.Size(91, 25);
            this.tablesLabel.TabIndex = 4;
            this.tablesLabel.Text = "Таблиці";
            this.tablesLabel.Click += new System.EventHandler(this.tablesLabel_Click);
            // 
            // PersonnelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 86);
            this.Controls.Add(this.patternsLabel);
            this.Controls.Add(this.tablesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonnelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PersonnelForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patternsLabel;
        private System.Windows.Forms.Label tablesLabel;
    }
}