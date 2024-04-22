using HotelSelect.Dao.impl;
using HotelSelect.Dao.inreface;
using HotelSelect.Dao.service;
using HotelSelect.Entity;

namespace HotelSelect.Patterns
{
    internal class FacadeRegistrUser
    {
        public User RegistrationFacade(string text, User user)
        {
            FactoryRegistrUser factoryRegistrUser = new FactoryRegistrUser();
            factoryRegistrUser.CreateFactory(text, user);

            return user;
        }

        public void RegistrationUser(User user)
        {
            IUserDAO implUserDAO = new ImplUserDAO();

            implUserDAO.SaveUser(user);
        }

        public bool CheckExistUser(User user)
        {
            VerificationsUserForRegistr userService = new VerificationsUserForRegistr();

            return userService.CheckExistUser(user);   
        }
    }
}
