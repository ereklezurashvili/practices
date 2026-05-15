using practice_15.Forms;
using practice_15.Models;
using System.Configuration;
using practice_15.Services;
namespace practice_15
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Name_Method(object sender, EventArgs e)
        {

        }

        private void Email(object sender, EventArgs e)
        {

        }

        private void Phone(object sender, EventArgs e)
        {

        }

        private void Username(object sender, EventArgs e)
        {

        }

        private void Password(object sender, EventArgs e)
        {

        }

        private void Sign_Up_Button(object sender, EventArgs e)
        {
            User user = new User(
                TextBoxName.Text,
                TextBoxEmail.Text,
                TextBoxPhone.Text,
                TextBoxUsername.Text,
                TextBoxPassword.Text
                );

            Services.UserService.RegisterUser(user);
            MessageBox.Show("Registration successful!");
            Login signUpForm = new Login();
            signUpForm.Show();
            this.Hide();

        }

        private void Login_Here(object sender, EventArgs e)
        {
            Login signUpForm = new Login();
            signUpForm.Show();
            this.Hide();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
