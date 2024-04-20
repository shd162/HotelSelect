using System.Dynamic;
using HotelSelect.Entity;

namespace HotelSelect.Security
{
    public class UserSession
    {
        private static UserSession instance;
        public User CurrentAuthUser { get; private set; }

        private UserSession(User user)
        {
            CurrentAuthUser = user;
        }

        public static UserSession StartSession(User user)
        {
            if (instance == null) {
                instance = new UserSession(user);
            }

            return instance;
        }

        public static void EndSession()
        {
            instance = null;
        }

        public static UserSession GetCurrentSession()
        {
            return instance;
        }
    }
}