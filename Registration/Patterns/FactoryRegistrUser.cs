using HotelSelect.Dao.inreface;
using HotelSelect.Dao.service;
using HotelSelect.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HotelSelect.Patterns
{
    internal class FactoryRegistrUser
    {
        VerificationsUserForRegistr serviceRegistrUser = new VerificationsUserForRegistr();

        public void CreateFactory(string text, User user)
        {
            if (text.Contains(".com") || text.Contains(".ru")) {
                user.Email = serviceRegistrUser.CheckEmailUser(text);
                user.PhoneNumber = "";
            }
            else if (text.Any(char.IsDigit)) {
                user.PhoneNumber = serviceRegistrUser.CheckPhoneNumberUser(text);
                user.Email = "";
            }
            else {
                MessageBox.Show("Create validator error");
            }
        }
    }
}
