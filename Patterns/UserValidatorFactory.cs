using HotelSelect.Dao.Implementations;
using HotelSelect.Dao.inreface;
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
    internal class UserValidatorFactory
    {
        public dynamic CreateValidator(string text, User user)
        {
            try
            {
                if (text.Contains(".com") || text.Contains(".ru")) {
                    ImplUserValidatorViaEmail implUserValidatorViaEmail = new ImplUserValidatorViaEmail();
                    user.Email = implUserValidatorViaEmail.CheckUserEmail(text);

                    return implUserValidatorViaEmail;
                }
                else if (text.Any(char.IsDigit)) {
                    ImplUserValidatorViaPhone implUserValidatorViaPhone = new ImplUserValidatorViaPhone();
                    user.PhoneNumber = implUserValidatorViaPhone.CheckUserPhoneNumber(text);

                    return implUserValidatorViaPhone;
                }
                else {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Create validator error: {e.Message}");
            }
        }
    }
}
