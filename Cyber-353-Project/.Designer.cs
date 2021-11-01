
namespace Cyber_353_Project
{
    partial class ActivityWindow
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
            this.CheckDirBtn = new System.Windows.Forms.Button();
            this.GenerateReportBtn = new System.Windows.Forms.Button();
            this.ActivityDirectorySelect = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // CheckDirBtn
            // 
            this.CheckDirBtn.Location = new System.Drawing.Point(12, 12);
            this.CheckDirBtn.Name = "CheckDirBtn";
            this.CheckDirBtn.Size = new System.Drawing.Size(144, 56);
            this.CheckDirBtn.TabIndex = 0;
            this.CheckDirBtn.Text = "Check Directory";
            this.CheckDirBtn.UseVisualStyleBackColor = true;
            this.CheckDirBtn.Click += new System.EventHandler(this.CheckDirBtn_Click);
            // 
            // GenerateReportBtn
            // 
            this.GenerateReportBtn.Location = new System.Drawing.Point(163, 13);
            this.GenerateReportBtn.Name = "GenerateReportBtn";
            this.GenerateReportBtn.Size = new System.Drawing.Size(144, 56);
            this.GenerateReportBtn.TabIndex = 1;
            this.GenerateReportBtn.Text = "Generate Report";
            this.GenerateReportBtn.UseVisualStyleBackColor = true;
            this.GenerateReportBtn.Click += new System.EventHandler(this.GenerateReportBtn_Click);
            // 
            // ActivityWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenerateReportBtn);
            this.Controls.Add(this.CheckDirBtn);
            this.Name = "ActivityWindow";
            this.Text = "Activity Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CheckDirBtn;
        private System.Windows.Forms.Button GenerateReportBtn;
        private System.Windows.Forms.FolderBrowserDialog ActivityDirectorySelect;
    }
}