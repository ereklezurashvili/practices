namespace practice_15
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TextBoxName = new TextBox();
            TextBoxEmail = new TextBox();
            TextBoxPhone = new TextBox();
            TextBoxUsername = new TextBox();
            TextBoxPassword = new TextBox();
            Sign_Up_Button_Design = new Button();
            label2 = new Label();
            Login_Here_Design = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 77);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            label1.Click += label1_Click;
            // 
            // TextBoxName
            // 
            TextBoxName.BackColor = SystemColors.ScrollBar;
            TextBoxName.Location = new Point(287, 89);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(236, 27);
            TextBoxName.TabIndex = 1;
            TextBoxName.Text = "Name:";
            TextBoxName.TextChanged += Name_Method;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.BackColor = SystemColors.ScrollBar;
            TextBoxEmail.Location = new Point(287, 122);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(236, 27);
            TextBoxEmail.TabIndex = 2;
            TextBoxEmail.Text = "Email:";
            TextBoxEmail.TextChanged += Email;
            // 
            // TextBoxPhone
            // 
            TextBoxPhone.BackColor = SystemColors.ScrollBar;
            TextBoxPhone.Location = new Point(287, 155);
            TextBoxPhone.Name = "TextBoxPhone";
            TextBoxPhone.Size = new Size(236, 27);
            TextBoxPhone.TabIndex = 3;
            TextBoxPhone.Text = "Phone:";
            TextBoxPhone.TextChanged += Phone;
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.BackColor = SystemColors.ScrollBar;
            TextBoxUsername.Location = new Point(287, 188);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(236, 27);
            TextBoxUsername.TabIndex = 4;
            TextBoxUsername.Text = "Username:";
            TextBoxUsername.TextChanged += Username;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.BackColor = SystemColors.ScrollBar;
            TextBoxPassword.Location = new Point(287, 221);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(236, 27);
            TextBoxPassword.TabIndex = 5;
            TextBoxPassword.Text = "Password:";
            TextBoxPassword.TextChanged += Password;
            // 
            // Sign_Up_Button_Design
            // 
            Sign_Up_Button_Design.BackColor = SystemColors.MenuHighlight;
            Sign_Up_Button_Design.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sign_Up_Button_Design.ForeColor = SystemColors.Control;
            Sign_Up_Button_Design.Location = new Point(287, 278);
            Sign_Up_Button_Design.Name = "Sign_Up_Button_Design";
            Sign_Up_Button_Design.Size = new Size(236, 64);
            Sign_Up_Button_Design.TabIndex = 6;
            Sign_Up_Button_Design.Text = "Sign Up";
            Sign_Up_Button_Design.UseVisualStyleBackColor = false;
            Sign_Up_Button_Design.Click += Sign_Up_Button;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 11;
            // 
            // Login_Here_Design
            // 
            Login_Here_Design.ForeColor = Color.FromArgb(0, 0, 192);
            Login_Here_Design.Location = new Point(429, 348);
            Login_Here_Design.Name = "Login_Here_Design";
            Login_Here_Design.Size = new Size(94, 29);
            Login_Here_Design.TabIndex = 8;
            Login_Here_Design.Text = "Login Here";
            Login_Here_Design.UseVisualStyleBackColor = true;
            Login_Here_Design.Click += Login_Here;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 352);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 10;
            label3.Text = "Already a member?";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(Login_Here_Design);
            Controls.Add(label2);
            Controls.Add(Sign_Up_Button_Design);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxUsername);
            Controls.Add(TextBoxPhone);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxName);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        private TextBox TextBoxName;
        private TextBox TextBoxEmail;
        private TextBox TextBoxPhone;
        private TextBox TextBoxUsername;
        private TextBox TextBoxPassword;
        private Button Sign_Up_Button_Design;
        private Label label2;
        private Button Login_Here_Design;
        private Label label3;
    }
}
