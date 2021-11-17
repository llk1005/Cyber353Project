
namespace Cyber_353_Project.Forms
{
    partial class MainMenu
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
            this.ScanBtn = new System.Windows.Forms.Button();
            this.NetworkBtn = new System.Windows.Forms.Button();
            this.RDBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScanBtn
            // 
            this.ScanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanBtn.Location = new System.Drawing.Point(13, 13);
            this.ScanBtn.Name = "ScanBtn";
            this.ScanBtn.Size = new System.Drawing.Size(155, 87);
            this.ScanBtn.TabIndex = 0;
            this.ScanBtn.Text = "Scan Directory";
            this.ScanBtn.UseVisualStyleBackColor = true;
            this.ScanBtn.Click += new System.EventHandler(this.ScanBtn_Click);
            // 
            // NetworkBtn
            // 
            this.NetworkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkBtn.Location = new System.Drawing.Point(174, 13);
            this.NetworkBtn.Name = "NetworkBtn";
            this.NetworkBtn.Size = new System.Drawing.Size(155, 87);
            this.NetworkBtn.TabIndex = 1;
            this.NetworkBtn.Text = "Network Activity";
            this.NetworkBtn.UseVisualStyleBackColor = true;
            this.NetworkBtn.Click += new System.EventHandler(this.NetworkBtn_Click);
            // 
            // RDBtn
            // 
            this.RDBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBtn.Location = new System.Drawing.Point(335, 13);
            this.RDBtn.Name = "RDBtn";
            this.RDBtn.Size = new System.Drawing.Size(155, 87);
            this.RDBtn.TabIndex = 2;
            this.RDBtn.Text = "Remote Desktop";
            this.RDBtn.UseVisualStyleBackColor = true;
            this.RDBtn.Click += new System.EventHandler(this.RDBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 116);
            this.Controls.Add(this.RDBtn);
            this.Controls.Add(this.NetworkBtn);
            this.Controls.Add(this.ScanBtn);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ScanBtn;
        private System.Windows.Forms.Button NetworkBtn;
        private System.Windows.Forms.Button RDBtn;
    }
}