using HotelSelect.Entity;

namespace HotelSelect.Dao.inreface
{
    internal interface IUserDao
    {
        User FindUserByLoginAndPassword(User user);
        User FindUserById(long id);
        void SaveUser(User user);
    }
}
