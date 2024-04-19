using HotelSelect.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect.Dao.inreface
{
    internal interface IUserValidator
    {
        bool CheckUserFieldsStrings(params string[] strings);
        bool CheckUserFieldsComboBox(dynamic comboBoxCountries, dynamic comboBoxCities);
        bool CheckUserFieldDateTime(dynamic dateTime);
    }
}
