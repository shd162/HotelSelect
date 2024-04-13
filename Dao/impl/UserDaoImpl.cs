using HotelSelect.Dao.inreface;
using HotelSelect.Entity;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using HotelSelect.Dao.repository;

namespace HotelSelect.Dao.impl
{
    internal class UserDaoImpl : IUserDao
    {
        private SqlConnection dbConnector = DbConnector.GetInstance().GetConnection();
        public UserDaoImpl()
        {
            
        }

        public User FindUserById(long id)
        {
            throw new NotImplementedException();
        }

        public User FindUserByLoginAndPassword(string login, string password)
        {
            throw new NotImplementedException();
        }

        public void SaveUser(User user)
        {
            var sqlSaveUser = "INSERT INTO users (first_name, last_name, age, login, password, phone_number, email, country_id, city_id) " +
                          "VALUES (@firstName, @lastName, @age, @login, @password, @phone_number, @email, @country_id, @city_id)";
            
            
            var saveUserCommand = new SqlCommand(sqlSaveUser, dbConnector);
            saveUserCommand.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar).Value = user.FirstName;
            saveUserCommand.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar).Value = user.LastName;
            saveUserCommand.Parameters.Add("@age", System.Data.SqlDbType.Date).Value = user.Age;
            saveUserCommand.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = user.Login;
            saveUserCommand.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = user.Password;
            saveUserCommand.Parameters.Add("@phone_number", System.Data.SqlDbType.VarChar).Value = user.PhoneNumber;
            saveUserCommand.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = user.Email;
            saveUserCommand.Parameters.Add("@country_id", System.Data.SqlDbType.BigInt).Value = user.CountryId;
            saveUserCommand.Parameters.Add("@city_id", System.Data.SqlDbType.BigInt).Value = user.CityId;


            try
            {
                dbConnector.Open();
                saveUserCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbConnector.Close();
            }
            
        }
    }
}
