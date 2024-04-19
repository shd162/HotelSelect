using System;
using System.Windows.Forms;
using HotelSelect.Dao.impl;
using HotelSelect.Dao.inreface;
using HotelSelect.Entity;

namespace HotelSelect.Dao.service
{
    public class UserService : IUserDao
    {
        private IUserDao userDao = new UserDaoImpl();
        
        public User FindUserByLoginAndPassword(User user)
        {
            return userDao.FindUserByLoginAndPassword(user);
        }

        public User FindUserById(long id)
        {
            throw new System.NotImplementedException();
        }

        public void SaveUser(User user)
        {
            userDao.SaveUser(user);

            //if (user.CheckFieldsOnNullOrEmpty())
            //{
            //    userDao.SaveUser(user);

            //}
            //else
            //{
            //    MessageBox.Show("Введите данные");
            //}
        }
    }
}