using HotelSelect.Dao.inreface;
using HotelSelect.Entity;
using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect.Dao.Implementations
{
    internal class ImplUserValidatorViaPhone : ImplChecksStringsComboBoxDateTimeViaRegistr
    {
        public string CheckUserPhoneNumber(string phoneNumber)
        {
            PhoneNumberUtil phoneNumberUtil = PhoneNumberUtil.GetInstance();

            if (String.IsNullOrEmpty(phoneNumber)) {
                throw new ArgumentException("Phone number null or empty", nameof(phoneNumber));
            }

            if (!phoneNumber.StartsWith("+")) {
                phoneNumber = "+" + phoneNumber;
            }

            try
            {
                PhoneNumber number = phoneNumberUtil.Parse(phoneNumber, null);
                string countryCode = number.CountryCode.ToString();
                string nationalNumber = number.NationalNumber.ToString();
                string formattednumber = phoneNumberUtil.Format(number, PhoneNumberFormat.INTERNATIONAL);

                if (!phoneNumberUtil.IsValidNumber(number))
                {
                    throw new ArgumentException("Phone number not valid", nameof(phoneNumber));
                }

                return formattednumber;
            }
            catch (NumberParseException e)
            {
                throw new ArgumentException("Error parsing phone number: " + e.Message);
            }
        }
    }
}
