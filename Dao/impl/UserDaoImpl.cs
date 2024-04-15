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

        public User FindUserByLoginAndPassword(User user)
        {
            var sqlFindUser = "SELECT * FROM users WHERE login = @login AND password = @password";
            var findUserCommand = new SqlCommand(sqlFindUser, dbConnector);
            findUserCommand.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = user.Login;
            findUserCommand.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = user.Password;

            try
            {
                dbConnector.Open();
                SqlDataReader sqlDataReader = findUserCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    User findedUser = new User();
                    while (sqlDataReader.Read())
                    {
                        findedUser.Id =          (long)sqlDataReader.GetValue(0);
                        findedUser.FirstName =   (string)sqlDataReader.GetValue(1);
                        findedUser.LastName =    (string)sqlDataReader.GetValue(2);
                        findedUser.Age =         (DateTime)sqlDataReader.GetValue(3);
                        findedUser.Login =       (string)sqlDataReader.GetValue(4);
                        findedUser.Password =    (string)sqlDataReader.GetValue(5);
                        findedUser.PhoneNumber = (string)sqlDataReader.GetValue(6);
                        findedUser.Email =       (string)sqlDataReader.GetValue(7);
                        findedUser.CountryId =   (long)sqlDataReader.GetValue(8);
                        findedUser.CityId =      (int)sqlDataReader.GetValue(9);
                    }

                    return findedUser;
                }
            }   
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                
                dbConnector.Close();
                
            }
            return new User();
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
