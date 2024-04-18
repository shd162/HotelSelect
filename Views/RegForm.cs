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
using HotelSelect.Patterns;

namespace HotelSelect
{
    public partial class RegForm : Form
    {
        private IUserDao userService = new UserService();
        UserRegistrationFacade userRegistrationFacade = new UserRegistrationFacade();

        public RegForm()
        {
            InitializeComponent();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            newUser = userRegistrationFacade.RegistrationFacade(PhoneNumberOrEmail.Text, newUser);

            if (userRegistrationFacade.CheckFieldsStrings(Surname.Text, Name.Text, Patronymic.Text, Login.Text, Password.Text) &&
                userRegistrationFacade.CheckFieldsComboBox(Countries, Cities) &&
                userRegistrationFacade.CheckUserFieldDateTime(DateOfBirth.Value)) {

                newUser.FullName = new FullName
                {
                    Surname = Surname.Text,
                    Name = Name.Text,
                    Patronymic = Patronymic.Text,
                };
                newUser.DateOfBirth = DateOfBirth.Value;
                newUser.Login = Login.Text;
                newUser.Password = Password.Text;
            }




        }
    }
}
