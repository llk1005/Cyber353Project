
namespace Cyber_353_Project
{
    partial class RemoteDesktopConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteDesktopConnection));
            this.DestIPTxtB = new System.Windows.Forms.TextBox();
            this.DestUserNameTxtB = new System.Windows.Forms.TextBox();
            this.DestPassTxtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.RdpClient = new AxMSTSCLib.AxMsRdpClient8NotSafeForScripting();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RdpClient)).BeginInit();
            this.SuspendLayout();
            // 
            // DestIPTxtB
            // 
            this.DestIPTxtB.Location = new System.Drawing.Point(137, 49);
            this.DestIPTxtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DestIPTxtB.Name = "DestIPTxtB";
            this.DestIPTxtB.Size = new System.Drawing.Size(76, 20);
            this.DestIPTxtB.TabIndex = 0;
            // 
            // DestUserNameTxtB
            // 
            this.DestUserNameTxtB.Location = new System.Drawing.Point(137, 72);
            this.DestUserNameTxtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DestUserNameTxtB.Name = "DestUserNameTxtB";
            this.DestUserNameTxtB.Size = new System.Drawing.Size(76, 20);
            this.DestUserNameTxtB.TabIndex = 1;
            // 
            // DestPassTxtB
            // 
            this.DestPassTxtB.Location = new System.Drawing.Point(137, 94);
            this.DestPassTxtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DestPassTxtB.Name = "DestPassTxtB";
            this.DestPassTxtB.Size = new System.Drawing.Size(76, 20);
            this.DestPassTxtB.PasswordChar = '*';
            this.DestPassTxtB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destination IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destination Password";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(262, 93);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 19);
            this.ConnectBtn.TabIndex = 6;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // RdpClient
            // 
            this.RdpClient.Enabled = true;
            this.RdpClient.Location = new System.Drawing.Point(12, 144);
            this.RdpClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RdpClient.Name = "RdpClient";
            this.RdpClient.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("RdpClient.OcxState")));
            this.RdpClient.Size = new System.Drawing.Size(789, 481);
            this.RdpClient.TabIndex = 7;
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(417, 94);
            this.DisconnectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(68, 19);
            this.DisconnectBtn.TabIndex = 8;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // RemoteDesktopConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 635);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.RdpClient);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DestPassTxtB);
            this.Controls.Add(this.DestUserNameTxtB);
            this.Controls.Add(this.DestIPTxtB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RemoteDesktopConnection";
            this.Text = "Remote Desktop Connection";
            ((System.ComponentModel.ISupportInitialize)(this.RdpClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DestIPTxtB;
        private System.Windows.Forms.TextBox DestUserNameTxtB;
        private System.Windows.Forms.TextBox DestPassTxtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConnectBtn;
        private AxMSTSCLib.AxMsRdpClient8NotSafeForScripting RdpClient;
        private System.Windows.Forms.Button DisconnectBtn;
    }
}