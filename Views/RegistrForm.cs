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
using HotelSelect.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace HotelSelect
{
    public partial class RegistrForm : Form
    {
        FacadeRegistrUser facadeRegistrUser = new FacadeRegistrUser();

        public RegistrForm()
        {
            InitializeComponent();  
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            if (!facadeRegistrUser.CheckFieldsStrings(Surname.Text, Name.Text, Patronymic.Text, Login.Text, Password.Text) && 
                !facadeRegistrUser.CheckFieldsComboBox(Countries, Cities) &&
                !facadeRegistrUser.CheckUserFieldDateTime(DateOfBirth)) {

                MessageBox.Show("User failed varification");
                return;
            }

            newUser = facadeRegistrUser.RegistrationFacade(PhoneNumberOrEmail.Text, newUser);

            newUser.FullName = new FullName
            {
                Surname = Surname.Text,
                Name = Name.Text,
                Patronymic = Patronymic.Text,
            };
            newUser.DateOfBirth = DateOfBirth.Value;
            newUser.Login = Login.Text;
            newUser.Password = Password.Text;
            newUser.CountryId = 1;
            newUser.CityId = 1;

            if (!facadeRegistrUser.CheckExistData(newUser)) {
                MessageBox.Show("User already exist");
                return;
            }

            facadeRegistrUser.RegistrationUser(newUser);

            PersonalAccount personalAccount = new PersonalAccount();
            this.Close();
        }

        private void Patronymic_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Patronymic.Text))
            {
                label10.Visible = true;
            }
            else
            {
                label10.Visible = false;
            }
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Login.Text))
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Password.Text))
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
        }

        private void PhoneNumberOrEmail_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PhoneNumberOrEmail.Text))
            {
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Name.Text))
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void Countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Countries.Text))
            {
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
            }
        }

        private void Cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Cities.Text))
            {
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
            }
        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Surname.Text))
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void RegistrForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
