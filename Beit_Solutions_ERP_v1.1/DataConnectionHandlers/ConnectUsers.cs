using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Beit_Solutions_ERP_v1._1.DataConnectionHandlers
{
    class ConnectUsers : Connection
    {
        public List<Objects.User> SelectList(Objects.User User, int CallCode)
        {
            var dataTable = SelectDataTable(User, CallCode);
            Objects.User user = new Objects.User();
            List<Objects.User> userList = new List<Objects.User>();

            if (dataTable.Rows.Count > 0)
            {
                for (int n = 0; n < dataTable.Rows.Count; n++)
                {
                    var rowArray = dataTable.Rows[n].ItemArray;
                    user.UserId = rowArray[0].ToString();
                    user.Name = rowArray[1].ToString();
                    user.Surname = rowArray[2].ToString();
                    user.Username = rowArray[3].ToString();
                    user.Password = rowArray[4].ToString();
                    user.Email = rowArray[5].ToString();
                    user.RoleId = rowArray[6].ToString();
                    user.Address = rowArray[7].ToString();
                    user.DateAdded = rowArray[8].ToString();
                    user.LastLogin = rowArray[9].ToString();

                    userList.Add(user);
                }
            }
            return userList;
        }

        public DataTable SelectDataTable(Object ObjectType, int CallCode)
        {
            DataTable dataTable = new DataTable();

            StringBuilder query = new StringBuilder();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(); ;

            using (SetConnection())
            {
                var userObject = (Objects.User)ObjectType;
                //No search clause
                if (CallCode == 0)
                {
                    query.Append("SELECT * FROM Users ORDER BY [Username] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);
                }
                //Search by Username and password
                else if (CallCode == 1)
                {
                    query.Append("SELECT * FROM Users WHERE [Username] = @Username and [Password] = @Password ORDER BY [Username] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);

                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Username", userObject.Username);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Password", userObject.Password);

                }
                //Search by Username
                else if (CallCode == 2)
                {
                    query.Append("SELECT * FROM Users WHERE [Username] = @Username ORDER BY [Username] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);

                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Username", userObject.Username);

                }
                //Search by Name
                else if (CallCode == 3)
                {
                    query.Append("SELECT * FROM Users WHERE [Name] LIKE '%'+ @Name +'%' ORDER BY [Username] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);

                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Name", userObject.Name);

                }
                //Search by Surname
                else if (CallCode == 4)
                {
                    query.Append("SELECT * FROM Users WHERE [Surname] LKE '%'+ @Surname +'%' ORDER BY [Username] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);

                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Username", userObject.Surname);

                }
                //Search by Name and Surname
                else if (CallCode == 5)
                {
                    query.Append("SELECT * FROM Users WHERE [Name] LIKE '%'+ @Name +'%' AND [Surname] LKE '%'+ @Surname +'%' ORDER BY [Username] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);

                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Name", userObject.Name);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Surname", userObject.Surname);
                }
                //Search by UserId
                else if (CallCode == 6)
                {
                    query.Append("SELECT * FROM Users WHERE [UserId] = @UserId ORDER BY [Username] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);

                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@UserId", userObject.UserId);

                }
                //Search by Email
                else if (CallCode == 7)
                {
                    query.Append("SELECT * FROM Users WHERE [Email] = @Email ORDER BY [Username] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);

                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Email", userObject.Email);

                }
                //Search by Role ID
                else if (CallCode == 8)
                {
                    query.Append("SELECT * FROM Users WHERE [RoleId] = @RoleId ORDER BY [Username] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);

                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@RoleId", userObject.RoleId);

                }
                //Search by Name, Surname, Email, Role, Address
                else if (CallCode == 9)
                {
                    query.Append("SELECT * FROM Users WHERE [Name] LIKE '%' + @Name + '%' AND [Surname] LIKE '%' + @Surname + '%' AND [RoleId] LIKE '%' + @RoleId + '%' AND [Username] LIKE '%' + @Username + '%' AND [Email] LIKE '%' + @Email + '%' AND [Address] LIKE '%' + @Address + '%' ORDER BY [Username] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);

                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Name", userObject.Name);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Surname", userObject.Surname);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@RoleId", userObject.RoleId);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Username", userObject.Username);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Email", userObject.Email);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Address", userObject.Address);
                }
                Connect();
                sqlDataAdapter.Fill(dataTable);
                Disconnect();
                return dataTable;
            }
        }
        public int Insert(Object ObjectType, int CallCode)
        {
            SqlCommand sqlCommand = new SqlCommand();
            Objects.User User = (Objects.User) ObjectType;

            string query = "INSERT INTO Users VALUES(@UserId, @Name, @Surname, @Username, @Password, @Email, @RoleId, @Address, @DateAdded, @LastLogin)";
            sqlCommand.Connection = SetConnection();
            sqlCommand.CommandText = query;

            sqlCommand.Parameters.AddWithValue("@UserId", User.UserId);
            sqlCommand.Parameters.AddWithValue("@Name", User.Name);
            sqlCommand.Parameters.AddWithValue("@Surname", User.Surname);
            sqlCommand.Parameters.AddWithValue("@Username", User.Username);
            sqlCommand.Parameters.AddWithValue("@Password", User.Password);
            sqlCommand.Parameters.AddWithValue("@Email", User.Email);
            sqlCommand.Parameters.AddWithValue("@RoleId", User.RoleId);
            sqlCommand.Parameters.AddWithValue("@Address", User.Address);
            sqlCommand.Parameters.AddWithValue("@DateAdded", User.DateAdded);
            sqlCommand.Parameters.AddWithValue("@LastLogin", "");

            //Connect();
            sqlCommand.Connection.Open();
            int objectInsertion = sqlCommand.ExecuteNonQuery();
            Disconnect();
            return objectInsertion;
        }                                                           
                                                                    
        public int Update(Object ObjectType, int CallCode)          
        {
            SqlCommand sqlCommand = new SqlCommand();
            Objects.User User = (Objects.User)ObjectType;

            StringBuilder query = new StringBuilder();
            if(CallCode ==0){
                //UPDATE ALL FIELDS
                query.Append("UPDATE Users SET Name = @Name, Surname = @Surname, Username = @Username, ");
                query.Append("Password = @Password, Email = @Email, RoleId = @RoleId, Address = @Address, LastLogin = @LastLogin WHERE UserId = @UserId");
                sqlCommand.CommandText = query.ToString();

                sqlCommand.Parameters.AddWithValue("@UserId", User.UserId);
                sqlCommand.Parameters.AddWithValue("@Name", User.Name);
                sqlCommand.Parameters.AddWithValue("@Surname", User.Surname);
                sqlCommand.Parameters.AddWithValue("@Username", User.Username);
                sqlCommand.Parameters.AddWithValue("@Password", User.Password);
                sqlCommand.Parameters.AddWithValue("@Email", User.Email);
                sqlCommand.Parameters.AddWithValue("@RoleId", User.RoleId);
                sqlCommand.Parameters.AddWithValue("@Address", User.Address);
                sqlCommand.Parameters.AddWithValue("@DateAdded", User.DateAdded);
                sqlCommand.Parameters.AddWithValue("@LastLogin", User.LastLogin);
            }else if(CallCode ==1){
                //UPDATE LAST LOGIN
                query.Append("UPDATE Users SET LastLogin = @LastLogin WHERE UserId = @UserId OR Username = @Username");

                sqlCommand.CommandText = query.ToString();

                sqlCommand.Parameters.AddWithValue("@UserId", User.UserId);
                sqlCommand.Parameters.AddWithValue("@Username", User.Username);
                sqlCommand.Parameters.AddWithValue("@Password", User.Password);

            }
            else if (CallCode == 2)
            {
                //UPDATE PASSWORD
                query.Append("UPDATE Users SET Password = @Password WHERE UserId = @UserId OR Username = @Username");

                sqlCommand.CommandText = query.ToString();

                sqlCommand.Parameters.AddWithValue("@UserId", User.UserId);
                sqlCommand.Parameters.AddWithValue("@Username", User.Username);
                sqlCommand.Parameters.AddWithValue("@Password", User.Password);

            }
            else if (CallCode == 3)
            {
                //UPDATE ROLE ID
                query.Append("UPDATE Users SET RoleId = @RoleId WHERE UserId = @UserId OR Username = @Username");
                sqlCommand.CommandText = query.ToString();

                sqlCommand.Parameters.AddWithValue("@UserId", User.UserId);
                sqlCommand.Parameters.AddWithValue("@Username", User.Username);
                sqlCommand.Parameters.AddWithValue("@RoleId", User.RoleId);

            }
            else if (CallCode == 4)
            {
                //UPDATE Name, Surname, Email
                query.Append("UPDATE Users SET Name = @Name, Surname = @Surname, Email = @Email WHERE UserId = @UserId OR Username = @Username");
                sqlCommand.CommandText = query.ToString();

                sqlCommand.Parameters.AddWithValue("@UserId", User.UserId);
                sqlCommand.Parameters.AddWithValue("@Name", User.Name);
                sqlCommand.Parameters.AddWithValue("@Surname", User.Surname);
                sqlCommand.Parameters.AddWithValue("@Username", User.Username);
                sqlCommand.Parameters.AddWithValue("@Email", User.Email);
            }

            else if (CallCode == 5)
            {
                //UPDATE Name, Surname, Email, Address, Role
                query.Append("UPDATE Users SET Name = @Name, Surname = @Surname, Email = @Email, RoleId = @RoleId, Address = @Address ");
                query.Append("WHERE UserId = @UserId OR Username = @Username");
                
                sqlCommand.CommandText = query.ToString();

                sqlCommand.Parameters.AddWithValue("@UserId", User.UserId);
                sqlCommand.Parameters.AddWithValue("@Name", User.Name);
                sqlCommand.Parameters.AddWithValue("@Surname", User.Surname);
                sqlCommand.Parameters.AddWithValue("@Username", User.Username);
                sqlCommand.Parameters.AddWithValue("@Email", User.Email);
                sqlCommand.Parameters.AddWithValue("@Address", User.Address);
                sqlCommand.Parameters.AddWithValue("@RoleId", User.RoleId);
            }

            sqlCommand.Connection = SetConnection();

            //Connect();
            sqlCommand.Connection.Open();
            int objectUpdate = sqlCommand.ExecuteNonQuery();
            Disconnect();
            return objectUpdate;
        }

        public int Delete(Object ObjectType, int CallCode)
        {
            
            SqlCommand sqlCommand = new SqlCommand();
            Objects.User User = (Objects.User) ObjectType;

            StringBuilder query = new StringBuilder();
            if (CallCode == 0)
            {
                //DELETE RECORD
                query.Append("DELETE FROM Users WHERE [UserId] = @UserId");
                sqlCommand.CommandText = query.ToString();

                sqlCommand.Parameters.AddWithValue("@UserId", User.UserId);
            }
            else if (CallCode == 1)
            {
                //UPDATE ALL FIELDS
                query.Append("DELETE FROM Users where WHERE [Username] = @Username");
                sqlCommand.CommandText = query.ToString();

                sqlCommand.Parameters.AddWithValue("@Username", User.Username);
            }
            sqlCommand.Connection = SetConnection();

            //Connect();
            sqlCommand.Connection.Open();
            int objectDelete = sqlCommand.ExecuteNonQuery();
            return objectDelete;
        }
    }
}
