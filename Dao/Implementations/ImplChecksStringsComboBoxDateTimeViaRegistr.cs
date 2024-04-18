using HotelSelect.Dao.inreface;
using HotelSelect.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect
{
    internal class ImplChecksStringsComboBoxDateTimeViaRegistr : IUserValidator
    {
        public bool CheckUserFieldsStrings(params string[] strings)
        {
            try
            {
                foreach (string str in strings)
                {
                    if (string.IsNullOrEmpty(str)) {
                        throw new Exception();
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                throw new ArgumentException("Fields with strings - null or empty" + e.Message);
            }
        }

        public bool CheckUserFieldsComboBox(params string[] comboBoxes)
        {
            throw new NotImplementedException();
        }

        public bool CheckUserFieldDateTime(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}
