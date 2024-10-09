
namespace WinformConnectSqlServer
{
    partial class RegisterForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbConfirmPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNickName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(106, 60);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(114, 21);
            this.tbPassword.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "密码：";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(106, 33);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(114, 21);
            this.tbUserName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户名：";
            // 
            // tbConfirmPwd
            // 
            this.tbConfirmPwd.Location = new System.Drawing.Point(106, 87);
            this.tbConfirmPwd.Name = "tbConfirmPwd";
            this.tbConfirmPwd.PasswordChar = '*';
            this.tbConfirmPwd.Size = new System.Drawing.Size(114, 21);
            this.tbConfirmPwd.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "确认密码：";
            // 
            // tbNickName
            // 
            this.tbNickName.Location = new System.Drawing.Point(106, 114);
            this.tbNickName.Name = "tbNickName";
            this.tbNickName.Size = new System.Drawing.Size(114, 21);
            this.tbNickName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "昵称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "性别：";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(107, 144);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(35, 16);
            this.rbMale.TabIndex = 15;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "男";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(148, 144);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(35, 16);
            this.rbFemale.TabIndex = 16;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "女";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 251);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNickName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbConfirmPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbConfirmPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNickName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
    }
}