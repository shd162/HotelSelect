using HotelSelect.Entity;

namespace HotelSelect.Dao.inreface
{
    internal interface IUserDAO
    {
        User FindUserByLoginAndPassword(User user);
        User FindUserById(long id);
        void SaveUser(User user);
    }
}
