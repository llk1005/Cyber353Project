
namespace Cyber_353_Project
{
    partial class ActivityMonitor
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
            this.SelectDirBtn = new System.Windows.Forms.Button();
            this.GenerateReportBtn = new System.Windows.Forms.Button();
            this.ActivityScanDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.GenerateNetworkReportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectDirBtn
            // 
            this.SelectDirBtn.Location = new System.Drawing.Point(13, 13);
            this.SelectDirBtn.Name = "SelectDirBtn";
            this.SelectDirBtn.Size = new System.Drawing.Size(147, 58);
            this.SelectDirBtn.TabIndex = 0;
            this.SelectDirBtn.Text = "Select Directory";
            this.SelectDirBtn.UseVisualStyleBackColor = true;
            this.SelectDirBtn.Click += new System.EventHandler(this.SelectDirBtn_Click);
            // 
            // GenerateReportBtn
            // 
            this.GenerateReportBtn.Location = new System.Drawing.Point(166, 13);
            this.GenerateReportBtn.Name = "GenerateReportBtn";
            this.GenerateReportBtn.Size = new System.Drawing.Size(147, 58);
            this.GenerateReportBtn.TabIndex = 1;
            this.GenerateReportBtn.Text = "Generate File Activity Report";
            this.GenerateReportBtn.UseVisualStyleBackColor = true;
            this.GenerateReportBtn.Click += new System.EventHandler(this.GenerateReportBtn_Click);
            // 
            // GenerateNetworkReportBtn
            // 
            this.GenerateNetworkReportBtn.Location = new System.Drawing.Point(320, 13);
            this.GenerateNetworkReportBtn.Name = "GenerateNetworkReportBtn";
            this.GenerateNetworkReportBtn.Size = new System.Drawing.Size(147, 58);
            this.GenerateNetworkReportBtn.TabIndex = 2;
            this.GenerateNetworkReportBtn.Text = "Generate Network Activity Report";
            this.GenerateNetworkReportBtn.UseVisualStyleBackColor = true;
            this.GenerateNetworkReportBtn.Click += new System.EventHandler(this.GenerateNetworkReportBtn_Click);
            // 
            // ActivityMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenerateNetworkReportBtn);
            this.Controls.Add(this.GenerateReportBtn);
            this.Controls.Add(this.SelectDirBtn);
            this.Name = "ActivityMonitor";
            this.Text = "Activity Monitor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectDirBtn;
        private System.Windows.Forms.Button GenerateReportBtn;
        private System.Windows.Forms.FolderBrowserDialog ActivityScanDirectory;
        private System.Windows.Forms.Button GenerateNetworkReportBtn;
    }
}