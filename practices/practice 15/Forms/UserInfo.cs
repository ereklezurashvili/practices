using Microsoft.VisualBasic.ApplicationServices;
using practice_15.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practice_15.Models;

namespace practice_15.Forms
{
    public partial class UserInfo : Form
    {
        public Models.User currentUser;
        public UserInfo(Models.User user)
        {
            InitializeComponent();
            currentUser = user;
            this.Load += UserInfoForm_Load;
        }

        public void UserInfoForm_Load(object sender, EventArgs e)
        {
            Name_UserInfo.Text = "Name: " + currentUser.Name;
            Phone_UserInfo.Text = "Phone: " + currentUser.Phone;
            Email_Userinfo.Text = "Email: " + currentUser.Email;
            Username_UserInfo.Text = "Username: " + currentUser.Username;
            Password_UserInfo.Text = "Password: " + currentUser.Password;
        }

        private void Log_Out(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();

        }

        
    }
}
