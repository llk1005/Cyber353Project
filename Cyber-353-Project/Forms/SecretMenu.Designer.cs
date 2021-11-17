
namespace Cyber_353_Project
{
    partial class SecretMenu
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
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.ActivityMonitorBtn = new System.Windows.Forms.Button();
            this.RDBtn = new System.Windows.Forms.Button();
            this.NotificationTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(12, 12);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(152, 58);
            this.AddUserBtn.TabIndex = 0;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // ActivityMonitorBtn
            // 
            this.ActivityMonitorBtn.Location = new System.Drawing.Point(170, 12);
            this.ActivityMonitorBtn.Name = "ActivityMonitorBtn";
            this.ActivityMonitorBtn.Size = new System.Drawing.Size(152, 58);
            this.ActivityMonitorBtn.TabIndex = 2;
            this.ActivityMonitorBtn.Text = "Open Activity Monitor";
            this.ActivityMonitorBtn.UseVisualStyleBackColor = true;
            this.ActivityMonitorBtn.Click += new System.EventHandler(this.ActivityMonitorBtn_Click);
            // 
            // RDBtn
            // 
            this.RDBtn.Location = new System.Drawing.Point(328, 12);
            this.RDBtn.Name = "RDBtn";
            this.RDBtn.Size = new System.Drawing.Size(152, 58);
            this.RDBtn.TabIndex = 3;
            this.RDBtn.Text = "Open Remote Desktop";
            this.RDBtn.UseVisualStyleBackColor = true;
            this.RDBtn.Click += new System.EventHandler(this.RDBtn_Click);
            // 
            // NotificationTestBtn
            // 
            this.NotificationTestBtn.Location = new System.Drawing.Point(486, 12);
            this.NotificationTestBtn.Name = "NotificationTestBtn";
            this.NotificationTestBtn.Size = new System.Drawing.Size(152, 58);
            this.NotificationTestBtn.TabIndex = 4;
            this.NotificationTestBtn.Text = "Open Notification Test";
            this.NotificationTestBtn.UseVisualStyleBackColor = true;
            this.NotificationTestBtn.Click += new System.EventHandler(this.NotificationTestBtn_Click);
            // 
            // SecretMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NotificationTestBtn);
            this.Controls.Add(this.RDBtn);
            this.Controls.Add(this.ActivityMonitorBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Name = "SecretMenu";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button ActivityMonitorBtn;
        private System.Windows.Forms.Button RDBtn;
        private System.Windows.Forms.Button NotificationTestBtn;
    }
}