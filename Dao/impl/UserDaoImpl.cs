using HotelSelect.Dao.inreface;
using HotelSelect.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect.Dao.impl
{
    internal class UserDaoImpl : UserDao
    {
        public User findUserById(long id)
        {
            throw new NotImplementedException();
        }

        public User findUserByLoginAndPassword(string login, string password)
        {
            throw new NotImplementedException();
        }

        public void saveUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
