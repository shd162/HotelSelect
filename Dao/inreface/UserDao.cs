using HotelSelect.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect.Dao.inreface
{
    internal interface UserDao
    {
        User findUserByLoginAndPassword(string login, string password);
        User findUserById(long id);
        void saveUser(User user);

    }
}
