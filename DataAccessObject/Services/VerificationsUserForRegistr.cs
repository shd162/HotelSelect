using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using HotelSelect.Dao.impl;
using HotelSelect.Dao.inreface;
using HotelSelect.Dao.repository;
using HotelSelect.Entity;
using PhoneNumbers;

namespace HotelSelect.Dao.service
{
    internal class VerificationsUserForRegistr  
    {

        private SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        public bool CheckFieldsStrings(params string[] strings)
        {
            foreach (string str in strings)
            {
                if (string.IsNullOrEmpty(str))
                {
                    throw new Exception("Fields with strings is null or empty");
                }
            }

            return true;
        }

        public bool CheckFieldsComboBox(dynamic comboBoxCountries, dynamic comboBoxCities)
        {
            if (comboBoxCountries.Items.Count == 0 || comboBoxCountries.SelectedItem)
            {
                throw new Exception("Fields with comboBoxes is null or empty");
            }

            return true;
        }

        public bool CheckFieldDateTime(dynamic dateOfBirth)
        {
            if (!dateOfBirth.Checked || dateOfBirth.Value == DateTime.MinValue)
            {
                throw new Exception("Fields with dateTime is null or empty");
            }

            return true;
        }

        public string CheckEmailUser(string emailUser)
        {
            if (String.IsNullOrEmpty(emailUser))
            {
                throw new Exception("Email is null of empty");
            }

            if (!emailUser.Contains("@"))
            {
                throw new Exception("Email not Contains @");
            }

            return emailUser;
        }

        public string CheckPhoneNumberUser(string phoneNumber)
        {
            PhoneNumberUtil phoneNumberUtil = PhoneNumberUtil.GetInstance();

            if (String.IsNullOrEmpty(phoneNumber))
            {
                throw new ArgumentException("Phone number null or empty", nameof(phoneNumber));
            }

            if (!phoneNumber.StartsWith("+"))
            {
                phoneNumber = "+" + phoneNumber;
            }

            try
            {
                PhoneNumber number = phoneNumberUtil.Parse(phoneNumber, null);
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

        public bool CheckExistData(User user)
        {
            sqlConnection.Open();

            string sqlRequest = "SELECT COUNT(*) FROM Users WHERE phoneNumber = @phoneNumber " +
                                "UNION SELECT COUNT(*) FROM Users WHERE email = @email " +
                                "UNION SELECT COUNT(*) FROM Users WHERE login = @login ";

            SqlCommand sqlCommand = new SqlCommand(sqlRequest, sqlConnection);

            try
            {
                sqlConnection.Open();

                sqlCommand.Parameters.AddWithValue("@phoneNumber", user.PhoneNumber);
                int countPhoneNumber = (int)sqlCommand.ExecuteScalar();

                sqlCommand.Parameters.AddWithValue("@email", user.Email);
                int countEmail = (int)sqlCommand.ExecuteScalar();

                sqlCommand.Parameters.AddWithValue("@login", user.Login);
                int countLogin = (int)sqlCommand.ExecuteScalar();

                if (countPhoneNumber > 0 || countEmail > 0 || countLogin > 0) {
                    return false;
                }
                else {
                    return true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Произошла ошибка при работе с базой данных: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Произошла ошибка: " + ex.Message);
            }
            finally { sqlConnection.Close(); }
        }
    }
}