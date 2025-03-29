using System;
using System.Collections.Generic;
using System.Text;
using Tickart.BL;

namespace Tickart.DL
{
    public static class UserCRUD
    {
        //public User GetUserByEmail(string email)
        //{
        //    using (MySqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        string query = "SELECT * FROM users WHERE email = @Email";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@Email", email);
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    return new User
        //                    {
        //                        UserId = reader.GetInt32(0),
        //                        Firstname = reader.GetString(1),
        //                        Lastname = reader.IsDBNull(2) ? null : reader.GetString(2),
        //                        Email = reader.GetString(3),
        //                        Password = reader.GetString(4),
        //                        Role = reader.GetString(5),
        //                        Image = reader.IsDBNull(6) ? null : reader.GetString(6),
        //                        CreatedAt = reader.GetDateTime(7)
        //                    };
        //                }
        //            }
        //        }
        //    }
        //    return null;
        //}

    }
}
