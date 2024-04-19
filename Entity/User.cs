using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSelect.Entity
{
    public struct FullName
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
    }

    public class User
    {
        public long Id { get; set; }
        public int CountryId { get; set; }
        public long CityId { get; set; }
        public FullName FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        private string phoneNumber;

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }
        
        
    }
}
