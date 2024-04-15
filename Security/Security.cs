using System;
using HotelSelect.Dao.inreface;
using HotelSelect.Dao.service;
using HotelSelect.Entity;

namespace HotelSelect.Security
{
    public class Security
    {
        private IUserDao userService = new UserService();
        private UserSession UserSession = HotelSelect.Security.UserSession.GetInstance();
        public bool AuthUser(User user)
        {
            User tryAuthUser = userService.FindUserByLoginAndPassword(user);
            if (tryAuthUser.Id != 0)
            {
                UserSession.SaveUserSession(tryAuthUser);
                return true;
            }

            return false;
        }

        public void LogoutUser()
        {
            UserSession.DestroySession();
        }
    }
}