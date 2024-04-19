using HotelSelect.Dao.inreface;
using HotelSelect.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool CheckUserFieldsComboBox(dynamic comboBoxCountries, dynamic comboBoxCities)
        {
            try
            {
                if (comboBoxCountries.Items.Count == 0 || comboBoxCountries.SelectedItem) {
                    throw new Exception();
                }

                return true;
            }
            catch (Exception e)
            {
                throw new ArgumentException("Fields with strings - null or empty" + e.Message);
            }
        }

        public bool CheckUserFieldDateTime(dynamic dateTime)
        {
            try
            {
                if (!dateTime.Checked || dateTime.Value == DateTime.MinValue) {
                    throw new Exception();
                }

                return true;
            }
            catch (Exception e)
            {
                throw new ArgumentException("Fields with strings - null or empty" + e.Message);
            }
        }
    }
}
