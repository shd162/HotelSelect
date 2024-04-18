using System.Dynamic;
using HotelSelect.Entity;

namespace HotelSelect.Security
{
    public class UserSession
    {
        private User authUser;
        private static UserSession _instance;

        public static UserSession GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserSession();
            }
            return _instance;
        }
        public void SaveUserSession(User user)
        {
            authUser = user;
        }

        public void DestroySession()
        {
            authUser = null;
        }

        public User getUser()
        {
            return authUser;
        }
    }
}