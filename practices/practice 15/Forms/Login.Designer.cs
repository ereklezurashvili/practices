namespace practice_15.Forms
{
    partial class Login
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
            label1 = new Label();
            textBoxUsernameLogin = new TextBox();
            textBoxPasswordLogin = new TextBox();
            Login_Button = new Button();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 53);
            label1.Name = "label1";
            label1.Size = new Size(146, 77);
            label1.TabIndex = 1;
            label1.Text = "Login";
            label1.Click += Username_Login;
            // 
            // textBoxUsernameLogin
            // 
            textBoxUsernameLogin.BackColor = SystemColors.ScrollBar;
            textBoxUsernameLogin.Location = new Point(288, 178);
            textBoxUsernameLogin.Name = "textBoxUsernameLogin";
            textBoxUsernameLogin.Size = new Size(209, 27);
            textBoxUsernameLogin.TabIndex = 2;
            textBoxUsernameLogin.Text = "Username:";
            textBoxUsernameLogin.TextChanged += Password_Login;
            // 
            // textBoxPasswordLogin
            // 
            textBoxPasswordLogin.BackColor = SystemColors.ScrollBar;
            textBoxPasswordLogin.Location = new Point(288, 211);
            textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            textBoxPasswordLogin.Size = new Size(209, 27);
            textBoxPasswordLogin.TabIndex = 3;
            textBoxPasswordLogin.Text = "Password:";
            textBoxPasswordLogin.TextChanged += Password_Login;
            // 
            // Login_Button
            // 
            Login_Button.BackColor = SystemColors.MenuHighlight;
            Login_Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_Button.ForeColor = SystemColors.Control;
            Login_Button.Location = new Point(288, 274);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(209, 61);
            Login_Button.TabIndex = 7;
            Login_Button.Text = "Login";
            Login_Button.UseVisualStyleBackColor = false;
            Login_Button.Click += Login_Button_Method;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 356);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 8;
            label2.Text = "Not a member?";
            // 
            // button2
            // 
            button2.ForeColor = Color.FromArgb(0, 0, 192);
            button2.Location = new Point(394, 352);
            button2.Name = "button2";
            button2.Size = new Size(119, 28);
            button2.TabIndex = 9;
            button2.Text = "Register Now:";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Register_Now;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(Login_Button);
            Controls.Add(textBoxPasswordLogin);
            Controls.Add(textBoxUsernameLogin);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        private TextBox textBoxUsernameLogin;
        private TextBox textBoxPasswordLogin;
        private Button Login_Button;
        private Label label2;
        private Button button2;
    }
}