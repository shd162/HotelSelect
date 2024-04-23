using System;
using System.Windows.Forms;
using HotelSelect.DataAccessObject.Services;
using HotelSelect.Entity;
using HotelSelect.Patterns;

namespace HotelSelect
{
    public partial class RegistrForm : Form
    {
        bool clickForDateTimePicker;

        public RegistrForm()
        {
            InitializeComponent();

            DateTimePicker dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.ValueChanged += DateOfBirth_ValueChanged;
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            if (!UniversalMethodsCheckIsEmptyAndSelected.CheckStringsIsNullOfEmpty(Surname.Text, Name.Text, Patronymic.Text, 
                Login.Text, Password.Text) || !CheckDateTimePickerClicked()) {
                return;
            }
            //else if (!UniversalMethodsCheckIsEmptyAndSelected.CheckComboBoxesIsSelected(Countries, Cities))
            //{
            //    MessageBox.Show("ComboBoxes no selected");
            //    return;
            //}

            FacadeRegistrUser facadeRegistrUser = new FacadeRegistrUser();

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

            if (!facadeRegistrUser.CheckExistUser(newUser)) {
                MessageBox.Show("User already exist");
                return;
            }

            facadeRegistrUser.RegistrationUser(newUser);

            PersonalAccount personalAccount = new PersonalAccount();
            this.Close();
        }

        private void Patronymic_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Patronymic.Text))
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
            if (string.IsNullOrEmpty(Login.Text))
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
            if (string.IsNullOrEmpty(Password.Text))
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
            if (string.IsNullOrEmpty(PhoneNumberOrEmail.Text))
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
            if (string.IsNullOrEmpty(Name.Text))
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
            if (string.IsNullOrEmpty(Countries.Text))
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
            if (string.IsNullOrEmpty(Cities.Text))
            {
                label9.Visible =  true;
            }
            else
            {
                label9.Visible = false;
            }
        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Surname.Text))
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void DateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            clickForDateTimePicker = true;
        }

        private bool CheckDateTimePickerClicked()
        {
            bool isClicked = false;

            if (clickForDateTimePicker)
            {
                isClicked = true;
            }

            return isClicked;
        }

        private void RegistrForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
