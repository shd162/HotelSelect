using HotelSelect.Entity;

namespace HotelSelect.DataAccessObject.Interfaces
{
    internal interface IServiceDAO 
    {
        bool CheckExistUser(User user);
    }
}
