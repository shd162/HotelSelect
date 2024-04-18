using HotelSelect.Dao.Implementations;
using HotelSelect.Dao.inreface;
using HotelSelect.Dao.service;
using HotelSelect.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HotelSelect.Patterns
{
    internal class UserRegistrationFacade
    {
        private dynamic userValidator;
        private IUserDao userService = new UserService();

        public User RegistrationFacade(string text, User user)
        {
            UserValidatorFactory validatorFactory = new UserValidatorFactory();
            userValidator = validatorFactory.CreateValidator(text, user);

            if (userValidator == null) {
                MessageBox.Show("Error the creation userValidator");
            }

            return user;
        }

        public void UserRegistration(User user)
        {
            userService.SaveUser(user);
        }

        public bool CheckFieldsStrings(params string[] stringFields)
        {
            try
            {
                if (userValidator.CheckUserFieldsStrings(stringFields)) {
                    return true;
                }
                else {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException("Failed varification in filds strings" + e.Message);
            }
        }

        public bool CheckFieldsComboBox(params dynamic[] comboBoxFields)
        {
            try
            {
                if (userValidator.CheckUserFieldsComboBox(comboBoxFields)) {
                    return true;
                }
                else {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException("Failed varification in filds ComboBox" + e.Message);
            }
        }

        public bool CheckUserFieldDateTime(DateTime dateTime)
        {
            try
            {
                if (userValidator.CheckUserFieldDateTime(dateTime)) {
                    return true;
                }
                else {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException("Failed varification in fild DateTime" + e.Message);
            }
        }
    }
}
