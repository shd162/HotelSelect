using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect.Entity
{
    internal class User
    {
        private long id;
        private string firstName;
        private string lastName;
        private DateTime age;
        private string login;
        private string password;
        private string phoneNumber;
        private string email;
        private long countryId;
        private long cityId;
        public long GetId()
        {
            return id;
        }

        public void SetId(long value)
        {
            id = value;
        }


        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string value)
        {
            firstName = value;
        }



        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string value)
        {
            lastName = value;
        }


        public DateTime GetAge()
        {
            return age;
        }

        public void SetAge(DateTime value)
        {
            age = value;
        }

        public string GetLogin()
        {
            return login;
        }

        public void SetLogin(string value)
        {
            login = value;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string value)
        {
            password = value;
        }

        public string GetPhoneNumber()
        {
            return phoneNumber;
        }

        public void SetPhoneNumber(string value)
        {
            phoneNumber = value;
        }


        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }

        public long GetCountryId()
        {
            return countryId;
        }

        public void SetCountryId(long value)
        {
            countryId = value;
        }

        public long GetCityId()
        {
            return cityId;
        }

        public void SetCityId(long value)
        {
            cityId = value;
        }
    }
}
