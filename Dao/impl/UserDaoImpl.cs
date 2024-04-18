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
                    User findedUser = new User { FullName = new FullName() };
                    while (sqlDataReader.Read())
                    {
                        findedUser.Id =                  (long)sqlDataReader.GetValue(0);
                        findedUser.CountryId =           (int)sqlDataReader.GetValue(1);
                        findedUser.CityId =              (long)sqlDataReader.GetValue(2);
                        findedUser.FullName = new FullName
                        {
                                               Surname = (string)sqlDataReader.GetValue(3),
                                                  Name = (string)sqlDataReader.GetValue(4),
                                            Patronymic = (string)sqlDataReader.GetValue(5)
                        };
                        findedUser.DateOfBirth =         (DateTime)sqlDataReader.GetValue(6);
                        findedUser.Login =               (string)sqlDataReader.GetValue(7);
                        findedUser.Password =            (string)sqlDataReader.GetValue(8);
                        findedUser.PhoneNumber =         (string)sqlDataReader.GetValue(9);
                        findedUser.Email =               (string)sqlDataReader.GetValue(10);
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
            var sqlSaveUser = "INSERT INTO users (country_id, city_id, surname, name, patronymic, date_of_birth, login, " +
                "password, phone_number, email) " +
                "VALUES (@country_id, @city_id, @surname, @name, @patronymic, @date_of_birth, @login, @password, " +
                "@phone_number, @email)";
            
            var saveUserCommand = new SqlCommand(sqlSaveUser, dbConnector);
            saveUserCommand.Parameters.Add("@country_id", System.Data.SqlDbType.Int).Value = user.CountryId;
            saveUserCommand.Parameters.Add("@city_id", System.Data.SqlDbType.BigInt).Value = user.CityId;
            saveUserCommand.Parameters.Add("@surname", System.Data.SqlDbType.VarChar).Value = user.FullName.Surname;
            saveUserCommand.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = user.FullName.Name;
            saveUserCommand.Parameters.Add("@patronymic", System.Data.SqlDbType.VarChar).Value = user.FullName.Patronymic;
            saveUserCommand.Parameters.Add("@date_of_birth", System.Data.SqlDbType.Date).Value = user.DateOfBirth;
            saveUserCommand.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = user.Login;
            saveUserCommand.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = user.Password;
            saveUserCommand.Parameters.Add("@phone_number", System.Data.SqlDbType.VarChar).Value = user.PhoneNumber;
            saveUserCommand.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = user.Email;
            
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
