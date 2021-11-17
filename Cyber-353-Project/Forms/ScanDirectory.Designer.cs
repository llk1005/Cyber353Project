
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
            this.ActivityScanDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.SelectDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.SelectedDirLbl = new System.Windows.Forms.Label();
            this.ScanDirectoryBtn = new System.Windows.Forms.Button();
            this.ScanBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // SelectedDirLbl
            // 
            this.SelectedDirLbl.AutoSize = true;
            this.SelectedDirLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedDirLbl.Location = new System.Drawing.Point(12, 9);
            this.SelectedDirLbl.Name = "SelectedDirLbl";
            this.SelectedDirLbl.Size = new System.Drawing.Size(158, 16);
            this.SelectedDirLbl.TabIndex = 3;
            this.SelectedDirLbl.Text = "Selected Directory: None";
            // 
            // ScanDirectoryBtn
            // 
            this.ScanDirectoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanDirectoryBtn.Location = new System.Drawing.Point(11, 36);
            this.ScanDirectoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ScanDirectoryBtn.Name = "ScanDirectoryBtn";
            this.ScanDirectoryBtn.Size = new System.Drawing.Size(465, 125);
            this.ScanDirectoryBtn.TabIndex = 4;
            this.ScanDirectoryBtn.Text = "SCAN DIRECTORY";
            this.ScanDirectoryBtn.UseVisualStyleBackColor = true;
            this.ScanDirectoryBtn.Click += new System.EventHandler(this.ScanDirectoryBtn_Click);
            // 
            // ScanBar
            // 
            this.ScanBar.Location = new System.Drawing.Point(17, 167);
            this.ScanBar.Name = "ScanBar";
            this.ScanBar.Size = new System.Drawing.Size(458, 23);
            this.ScanBar.TabIndex = 5;
            // 
            // ActivityMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 225);
            this.Controls.Add(this.ScanBar);
            this.Controls.Add(this.ScanDirectoryBtn);
            this.Controls.Add(this.SelectedDirLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ActivityMonitor";
            this.Text = "Activity Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog ActivityScanDirectory;
        private System.Windows.Forms.FolderBrowserDialog SelectDirectory;
        private System.Windows.Forms.Label SelectedDirLbl;
        private System.Windows.Forms.Button ScanDirectoryBtn;
        private System.Windows.Forms.ProgressBar ScanBar;
    }
}