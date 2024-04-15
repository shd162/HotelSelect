using HotelSelect.Entity;
using System;
using System.Windows.Forms;
using HotelSelect.Dao.inreface;
using HotelSelect.Dao.service;
using HotelSelect.Security;

namespace HotelSelect
{
    public partial class AuthForm : Form
    {
        private readonly IUserDao userService = new UserService();
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegForm rf = new RegForm();
            rf.Show();
        }

        private void authBtn_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(login.Text) && !String.IsNullOrEmpty(password.Text))
            {
                User user = new User();
                user.Login = login.Text;
                user.Password = password.Text;

                Security.Security sec = new Security.Security();

                if (sec.AuthUser(user))
                {
                    Form f = new Form();
                    f.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }

        }
    }
}
