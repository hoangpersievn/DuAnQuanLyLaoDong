﻿namespace DuAnQuanLyNhanSu
{
    partial class FormMain
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
            this.mPanelChinh = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // mPanelChinh
            // 
            this.mPanelChinh.BackColor = System.Drawing.Color.Transparent;
            this.mPanelChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPanelChinh.HorizontalScrollbarBarColor = true;
            this.mPanelChinh.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelChinh.HorizontalScrollbarSize = 10;
            this.mPanelChinh.Location = new System.Drawing.Point(20, 60);
            this.mPanelChinh.Name = "mPanelChinh";
            this.mPanelChinh.Size = new System.Drawing.Size(610, 278);
            this.mPanelChinh.TabIndex = 0;
            this.mPanelChinh.UseCustomBackColor = true;
            this.mPanelChinh.VerticalScrollbarBarColor = true;
            this.mPanelChinh.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelChinh.VerticalScrollbarSize = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 358);
            this.Controls.Add(this.mPanelChinh);
            this.Name = "FormMain";
            this.Text = "Quản Lý Nhân Sự";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FromMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mPanelChinh;
    }
}

