using HotelSelect.Entity;
using System;
using System.Windows.Forms;
using HotelSelect.Dao.inreface;
using HotelSelect.Dao.service;
using HotelSelect.Security;
using System.Reflection.Emit;

namespace HotelSelect
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            RegistrForm registrationForm = new RegistrForm();
            registrationForm.Hide();

            if (registrationForm.ShowDialog() == DialogResult.Cancel) { this.Show(); }
        }

        private void authBtn_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(login.Text) && !String.IsNullOrEmpty(password.Text)) {

                User user = new User();
                user.Login = login.Text;
                user.Password = password.Text;

                Security.Security sec = new Security.Security();

                if (sec.AuthUser(user)) {
                    HotelAdd  CreateHotel= new HotelAdd();
                    CreateHotel.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }

        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(login.Text))               
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
            
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(password.Text))
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(password.PasswordChar == '\0')
            {
                button3.BringToFront();
                password.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '*')
            {
                button2.BringToFront();
                password.PasswordChar = '\0';
            }
        }
    }
}
