namespace practice_15.Forms
{
    partial class UserInfo
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
            User_Info = new Label();
            Name_UserInfo = new Label();
            Phone_UserInfo = new Label();
            Email_Userinfo = new Label();
            Username_UserInfo = new Label();
            Password_UserInfo = new Label();
            LogOut_Button = new Button();
            SuspendLayout();
            // 
            // User_Info
            // 
            User_Info.AutoSize = true;
            User_Info.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User_Info.Location = new Point(286, 28);
            User_Info.Name = "User_Info";
            User_Info.Size = new Size(170, 50);
            User_Info.TabIndex = 8;
            User_Info.Text = "User Info";
            
            // 
            // Name_UserInfo
            // 
            Name_UserInfo.AutoSize = true;
            Name_UserInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name_UserInfo.Location = new Point(286, 106);
            Name_UserInfo.Name = "Name_UserInfo";
            Name_UserInfo.Size = new Size(80, 31);
            Name_UserInfo.TabIndex = 9;
            Name_UserInfo.Text = "Name:";
            
            // 
            // Phone_UserInfo
            // 
            Phone_UserInfo.AutoSize = true;
            Phone_UserInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Phone_UserInfo.Location = new Point(286, 178);
            Phone_UserInfo.Name = "Phone_UserInfo";
            Phone_UserInfo.Size = new Size(83, 31);
            Phone_UserInfo.TabIndex = 10;
            Phone_UserInfo.Text = "Phone:";
            // 
            // Email_Userinfo
            // 
            Email_Userinfo.AutoSize = true;
            Email_Userinfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email_Userinfo.Location = new Point(286, 147);
            Email_Userinfo.Name = "Email_Userinfo";
            Email_Userinfo.Size = new Size(75, 31);
            Email_Userinfo.TabIndex = 11;
            Email_Userinfo.Text = "Email:";
            // 
            // Username_UserInfo
            // 
            Username_UserInfo.AutoSize = true;
            Username_UserInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_UserInfo.Location = new Point(286, 209);
            Username_UserInfo.Name = "Username_UserInfo";
            Username_UserInfo.Size = new Size(122, 31);
            Username_UserInfo.TabIndex = 12;
            Username_UserInfo.Text = "Username:";
            // 
            // Password_UserInfo
            // 
            Password_UserInfo.AutoSize = true;
            Password_UserInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_UserInfo.Location = new Point(286, 240);
            Password_UserInfo.Name = "Password_UserInfo";
            Password_UserInfo.Size = new Size(115, 31);
            Password_UserInfo.TabIndex = 13;
            Password_UserInfo.Text = "Password:";
            
            // 
            // LogOut_Button
            // 
            LogOut_Button.BackColor = SystemColors.MenuHighlight;
            LogOut_Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOut_Button.ForeColor = SystemColors.Control;
            LogOut_Button.Location = new Point(286, 297);
            LogOut_Button.Name = "LogOut_Button";
            LogOut_Button.Size = new Size(214, 59);
            LogOut_Button.TabIndex = 14;
            LogOut_Button.Text = "Log Out";
            LogOut_Button.UseVisualStyleBackColor = false;
            LogOut_Button.Click += Log_Out;
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogOut_Button);
            Controls.Add(Password_UserInfo);
            Controls.Add(Username_UserInfo);
            Controls.Add(Email_Userinfo);
            Controls.Add(Phone_UserInfo);
            Controls.Add(Name_UserInfo);
            Controls.Add(User_Info);
            Name = "UserInfo";
            Text = "UserInfo";
            ResumeLayout(false);
            PerformLayout();
            
        }
        

        #endregion

        private Label User_Info;
        private Label Name_UserInfo;
        private Label Phone_UserInfo;
        private Label Email_Userinfo;
        private Label Username_UserInfo;
        private Label Password_UserInfo;
        private Button LogOut_Button;
    }
}