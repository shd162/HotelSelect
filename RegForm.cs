using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSelect.Dao.impl;
using HotelSelect.Dao.inreface;
using HotelSelect.Dao.service;
using HotelSelect.Entity;

namespace HotelSelect
{
    public partial class RegForm : Form
    {

        private IUserDao userService = new UserService();
        public RegForm()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User newUser = new User
            {
                FullName = new FullName
                {
                    Surname = Surname.Text,
                    Name = Name.Text,
                    Patronymic = Patronymic.Text,
                },
                DateOfBirth = DateOfBirth.Value,
                Login = Login.Text,
                Password = Password.Text,
                PhoneNumber = PhoneNumber.Text,
                Email = Email.Text,
            };

            userService.SaveUser(newUser);
        }
    }
}
