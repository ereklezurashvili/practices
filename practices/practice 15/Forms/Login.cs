using practice_15.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace practice_15.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void Username_Login(object sender, EventArgs e)
        {

        }
        public void Password_Login(object sender, EventArgs e)
        {

        }
        public void Login_Button_Method(object sender, EventArgs e)
        {
            string username = textBoxUsernameLogin.Text;
            string password = textBoxPasswordLogin.Text;

            if(Services.UserService.AuthenticateUser(username, password) == true)
            {
                UserInfo userinfo = new UserInfo(UserService.Users[Services.UserService.idx]);
                userinfo.Show();
                this.Hide();

            }
           

           
            else
            {
                MessageBox.Show("Invalid username or password!");
            }




        }
        
        public void Register_Now(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();

        }
    }
}
