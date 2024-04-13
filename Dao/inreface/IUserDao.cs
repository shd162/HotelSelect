using HotelSelect.Entity;

namespace HotelSelect.Dao.inreface
{
    internal interface IUserDao
    {
        User FindUserByLoginAndPassword(string login, string password);
        User FindUserById(long id);
        void SaveUser(User user);
    }
}
