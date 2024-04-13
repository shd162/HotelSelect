using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect.Entity
{
    public class User
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


        public User()
        {
        }

        public User(long id, string firstName, string lastName, DateTime age, string login, string password, string phoneNumber, string email, long countryId, long cityId)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.login = login;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.countryId = countryId;
            this.cityId = cityId;
        }

        public long Id
        {
            get => id;
            set => id = value;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public DateTime Age
        {
            get => age;
            set => age = value;
        }

        public string Login
        {
            get => login;
            set => login = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public long CountryId
        {
            get => countryId;
            set => countryId = value;
        }

        public long CityId
        {
            get => cityId;
            set => cityId = value;
        }

        public bool CheckFieldsOnNullOrEmpty()
        {
            return !(String.IsNullOrEmpty(FirstName)
                || String.IsNullOrEmpty(LastName)
                || String.IsNullOrEmpty(login)
                || String.IsNullOrEmpty(password)
                );
        }
    }
}
