
namespace Cyber_353_Project
{
    partial class NotificationTest
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
            this.MessageTxtBox = new System.Windows.Forms.RichTextBox();
            this.sendTxtBtn = new System.Windows.Forms.Button();
            this.sendEmailBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.PhoneTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SendFull = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageTxtBox
            // 
            this.MessageTxtBox.Location = new System.Drawing.Point(13, 44);
            this.MessageTxtBox.Name = "MessageTxtBox";
            this.MessageTxtBox.Size = new System.Drawing.Size(268, 253);
            this.MessageTxtBox.TabIndex = 0;
            this.MessageTxtBox.Text = "";
            // 
            // sendTxtBtn
            // 
            this.sendTxtBtn.Location = new System.Drawing.Point(13, 303);
            this.sendTxtBtn.Name = "sendTxtBtn";
            this.sendTxtBtn.Size = new System.Drawing.Size(131, 52);
            this.sendTxtBtn.TabIndex = 1;
            this.sendTxtBtn.Text = "Send Text";
            this.sendTxtBtn.UseVisualStyleBackColor = true;
            this.sendTxtBtn.Click += new System.EventHandler(this.SendTxtBtn_Click);
            // 
            // sendEmailBtn
            // 
            this.sendEmailBtn.Location = new System.Drawing.Point(150, 303);
            this.sendEmailBtn.Name = "sendEmailBtn";
            this.sendEmailBtn.Size = new System.Drawing.Size(131, 52);
            this.sendEmailBtn.TabIndex = 2;
            this.sendEmailBtn.Text = "Send Email";
            this.sendEmailBtn.UseVisualStyleBackColor = true;
            this.sendEmailBtn.Click += new System.EventHandler(this.SendEmailBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxtBox.Location = new System.Drawing.Point(399, 44);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(138, 31);
            this.EmailTxtBox.TabIndex = 5;
            // 
            // PhoneTxtBox
            // 
            this.PhoneTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTxtBox.Location = new System.Drawing.Point(399, 81);
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.Size = new System.Drawing.Size(138, 31);
            this.PhoneTxtBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone:";
            // 
            // SendFull
            // 
            this.SendFull.Location = new System.Drawing.Point(287, 303);
            this.SendFull.Name = "SendFull";
            this.SendFull.Size = new System.Drawing.Size(250, 52);
            this.SendFull.TabIndex = 8;
            this.SendFull.Text = "Send Full Notification";
            this.SendFull.UseVisualStyleBackColor = true;
            this.SendFull.Click += new System.EventHandler(this.SendFull_Click);
            // 
            // NotificationTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 367);
            this.Controls.Add(this.SendFull);
            this.Controls.Add(this.PhoneTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendEmailBtn);
            this.Controls.Add(this.sendTxtBtn);
            this.Controls.Add(this.MessageTxtBox);
            this.Name = "NotificationTest";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageTxtBox;
        private System.Windows.Forms.Button sendTxtBtn;
        private System.Windows.Forms.Button sendEmailBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.TextBox PhoneTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SendFull;
    }
}