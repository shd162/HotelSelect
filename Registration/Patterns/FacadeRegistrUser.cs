using HotelSelect.Dao.impl;
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
    internal class FacadeRegistrUser
    {
        private VerificationsUserForRegistr userService = new VerificationsUserForRegistr();
        private IUserDAO implUserDAO = new ImplUserDAO();

        public User RegistrationFacade(string text, User user)
        {
            FactoryRegistrUser factoryRegistrUser = new FactoryRegistrUser();
            factoryRegistrUser.CreateFactory(text, user);

            return user;
        }

        public void RegistrationUser(User user)
        {
            implUserDAO.SaveUser(user);
        }

        public bool CheckFieldsStrings(params string[] stringFields)
        {
            if (userService.CheckFieldsStrings(stringFields)) {
                return true;
            }

            return false;
        }

        public bool CheckFieldsComboBox(dynamic comboBoxCountries, dynamic comboBoxCities)
        {
            if (userService.CheckFieldsComboBox(comboBoxCountries, comboBoxCities)) {
                return true;
            }

            return false;
        }

        public bool CheckUserFieldDateTime(dynamic dateOfBirth)
        {
            if (userService.CheckFieldDateTime(dateOfBirth)) {
                return true;
            }

            return false;
        }

        public bool CheckExistData(User user)
        {
            if (userService.CheckExistData(user)) {
                return true;
            }

            return false;
        }
    }
}
