using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Beit_Solutions_ERP_v1._1.DataConnectionHandlers
{
    class ConnectClients: Connection
    {
        public List<Objects.Client> SelectList(Objects.Client ObjectType, int CallCode)
        {
            var dataTable = SelectDataTable(ObjectType, CallCode);
            Objects.Client Client = new Objects.Client();
            List<Objects.Client> clientList = new List<Objects.Client>();

            if (dataTable.Rows.Count > 0)
            {
                for (int n = 0; n < dataTable.Rows.Count; n++)
                {
                    var rowArray = dataTable.Rows[n].ItemArray;
                    Client.ClientId = rowArray[0].ToString();
                    Client.ClientType = rowArray[1].ToString();
                    Client.ClientName = rowArray[2].ToString();
                    Client.ClientSurname = rowArray[3].ToString();
                    Client.ClientNationality = rowArray[4].ToString();
                    Client.ClientNationalIdNo = rowArray[5].ToString();
                    Client.PassportNo = rowArray[6].ToString();
                    Client.Dob = rowArray[7].ToString();
                    Client.MaritalStatus = rowArray[8].ToString();
                    Client.Gender = rowArray[9].ToString();
                    Client.JuristicRegistrationNo = rowArray[10].ToString();
                    Client.JuristicTaxNo = rowArray[11].ToString();
                    Client.JuristicType = rowArray[12].ToString();
                    Client.Address1 = rowArray[13].ToString();
                    Client.Address2 = rowArray[14].ToString();
                    Client.Address3 = rowArray[15].ToString();
                    Client.Address4 = rowArray[16].ToString();
                    Client.PhoneNumber1 = rowArray[17].ToString();
                    Client.PhoneNumber2 = rowArray[18].ToString();
                    Client.Email = rowArray[19].ToString();
                    Client.LastModified = rowArray[20].ToString();

                    clientList.Add(Client);
                }
            }
            return clientList;
        }

        public Objects.Client CleanseParams(Objects.Client clientObject) 
        {
            if (string.IsNullOrEmpty(clientObject.ClientId)) { clientObject.ClientId = ""; }
            if (string.IsNullOrEmpty(clientObject.ClientType)) { clientObject.ClientType = ""; }
            if (string.IsNullOrEmpty(clientObject.ClientName)) { clientObject.ClientName = ""; }
            if (string.IsNullOrEmpty(clientObject.ClientSurname)) { clientObject.ClientSurname = ""; }
            if (string.IsNullOrEmpty(clientObject.ClientNationality)) { clientObject.ClientNationality = ""; }
            if (string.IsNullOrEmpty(clientObject.ClientNationalIdNo)) { clientObject.ClientNationalIdNo = ""; }
            if (string.IsNullOrEmpty(clientObject.PassportNo)) { clientObject.PassportNo = ""; }
            if (string.IsNullOrEmpty(clientObject.Dob)) { clientObject.Dob = ""; }
            if (string.IsNullOrEmpty(clientObject.MaritalStatus)) { clientObject.MaritalStatus = ""; }
            if (string.IsNullOrEmpty(clientObject.Gender)) { clientObject.Gender = ""; }
            if (string.IsNullOrEmpty(clientObject.JuristicRegistrationNo)) { clientObject.JuristicRegistrationNo = ""; }
            if (string.IsNullOrEmpty(clientObject.JuristicTaxNo)) { clientObject.JuristicTaxNo = ""; }
            if (string.IsNullOrEmpty(clientObject.JuristicType)) { clientObject.JuristicType = ""; }
            if (string.IsNullOrEmpty(clientObject.Address1)) { clientObject.Address1 = ""; }
            if (string.IsNullOrEmpty(clientObject.Address2)) { clientObject.Address2 = ""; }
            if (string.IsNullOrEmpty(clientObject.Address3)) { clientObject.Address3 = ""; }
            if (string.IsNullOrEmpty(clientObject.Address4)) { clientObject.Address4 = ""; }
            if (string.IsNullOrEmpty(clientObject.Address5)) { clientObject.Address5 = ""; }
            if (string.IsNullOrEmpty(clientObject.PhoneNumber1)) { clientObject.PhoneNumber1 = ""; }
            if (string.IsNullOrEmpty(clientObject.PhoneNumber2)) { clientObject.PhoneNumber2 = ""; }
            if (string.IsNullOrEmpty(clientObject.Email)) { clientObject.Email = ""; }
            if (string.IsNullOrEmpty(clientObject.LastModified)) { clientObject.LastModified = ""; }

            return clientObject;

        }

        public SqlDataAdapter sqlDataAdapterParametizer(SqlDataAdapter sqlDataAdapter, Objects.Client clientObject)
        {

                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ClientId", clientObject.ClientId);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ClientType", clientObject.ClientType);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ClientName", clientObject.ClientName);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ClientSurname", clientObject.ClientSurname);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ClientNationality", clientObject.ClientNationality);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ClientNationalIdNo", clientObject.ClientNationalIdNo);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@PassportNo", clientObject.PassportNo);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Dob", clientObject.Dob);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@MaritalStatus", clientObject.MaritalStatus);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Gender", clientObject.Gender);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@JuristicRegistrationNo", clientObject.JuristicRegistrationNo);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@JuristicTaxNo", clientObject.JuristicTaxNo);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@JuristicType", clientObject.JuristicType);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Address1", clientObject.Address1);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Address2", clientObject.Address2);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Address3", clientObject.Address3);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Address4", clientObject.Address4);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Address5", clientObject.Address5);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@PhoneNumber1", clientObject.PhoneNumber1);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@PhoneNumber2", clientObject.PhoneNumber2);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Email", clientObject.Email);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@LastModified", clientObject.LastModified);

                    return sqlDataAdapter;
        }

        public SqlCommand sqlCommandParametizer(SqlCommand sqlCommand, Objects.Client clientObject)
        {

            sqlCommand.Parameters.AddWithValue("@ClientId", clientObject.ClientId);
            sqlCommand.Parameters.AddWithValue("@ClientType", clientObject.ClientType);
            sqlCommand.Parameters.AddWithValue("@ClientName", clientObject.ClientName);
            sqlCommand.Parameters.AddWithValue("@ClientSurname", clientObject.ClientSurname);
            sqlCommand.Parameters.AddWithValue("@ClientNationality", clientObject.ClientNationality);
            sqlCommand.Parameters.AddWithValue("@ClientNationalIdNo", clientObject.ClientNationalIdNo);
            sqlCommand.Parameters.AddWithValue("@PassportNo", clientObject.PassportNo);
            sqlCommand.Parameters.AddWithValue("@Dob", clientObject.Dob);
            sqlCommand.Parameters.AddWithValue("@MaritalStatus", clientObject.MaritalStatus);
            sqlCommand.Parameters.AddWithValue("@Gender", clientObject.Gender);
            sqlCommand.Parameters.AddWithValue("@JuristicRegistrationNo", clientObject.JuristicRegistrationNo);
            sqlCommand.Parameters.AddWithValue("@JuristicTaxNo", clientObject.JuristicTaxNo);
            sqlCommand.Parameters.AddWithValue("@JuristicType", clientObject.JuristicType);
            sqlCommand.Parameters.AddWithValue("@Address1", clientObject.Address1);
            sqlCommand.Parameters.AddWithValue("@Address2", clientObject.Address2);
            sqlCommand.Parameters.AddWithValue("@Address3", clientObject.Address3);
            sqlCommand.Parameters.AddWithValue("@Address4", clientObject.Address4);
            sqlCommand.Parameters.AddWithValue("@Address5", clientObject.Address5);
            sqlCommand.Parameters.AddWithValue("@PhoneNumber1", clientObject.PhoneNumber1);
            sqlCommand.Parameters.AddWithValue("@PhoneNumber2", clientObject.PhoneNumber2);
            sqlCommand.Parameters.AddWithValue("@Email", clientObject.Email);
            sqlCommand.Parameters.AddWithValue("@LastModified", clientObject.LastModified);

            return sqlCommand;
        }

        public DataTable SelectDataTable(Object ObjectType, int CallCode)
        {
            DataTable dataTable = new DataTable();
            StringBuilder query = new StringBuilder();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            using (SetConnection())
            {
                var clientObject = (Objects.Client) ObjectType;
                clientObject = CleanseParams(clientObject);
                if (CallCode == 0)
                {
                    //search without search clause
                    query.Append("SELECT * FROM [Clients] ");
                    query.Append("ORDER BY [ClientName] ASC");

                }else{
                    query.Append("SELECT * FROM [Clients] WHERE ");
                    if (CallCode == 1)
                    {
                        //search with clientID search clause
                        query.Append("[ClientId] = @ClientId ");

                    }
                    else if (CallCode == 2)
                    {
                        //search with clientName search clause
                        query.Append("[ClientName] LIKE '%' + @ClientName+ '%' ");
                        query.Append("OR [ClientSurname] LIKE '%' + @ClientSurname+ '%' ");

                        //sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ClientType", clientObject.ClientType);
                    }else if (CallCode == 3)
                    {
                        //search with clientName AND clientID search clause
                        query.Append("[ClientName] LIKE '%' + @ClientName+ '%' ");
                        query.Append("AND [ClientId] LIKE '%' + @ClientId + '%' ");

                    }
                    else if (CallCode == 4)
                    {
                        //Fluffy search with all fields search clause
                        query.Append("[ClientId] LIKE '%' + @ClientId + '%' ");
                        query.Append("OR [ClientType] LIKE '%' + @ClientType+ '%' ");
                        query.Append("OR [ClientName] LIKE '%' + @ClientName+ '%' ");
                        query.Append("OR [ClientSurname] LIKE '%' + @ClientSurname+ '%' ");
                        query.Append("OR [ClientNationality] LIKE '%' + @ClientNationality+ '%' ");
                        query.Append("OR [ClientNationalIdNo] LIKE '%' + @ClientNationalIdNo + '%' ");
                        query.Append("OR [PassportNo] LIKE '%' + @PassportNo + '%' ");
                        query.Append("OR [Dob] LIKE '%' + @Dob + '%' ");
                        query.Append("OR [MaritalStatus] LIKE '%' + @MaritalStatus+ '%' ");
                        query.Append("OR [Gender] LIKE '%' + @Gender+ '%' ");
                        query.Append("OR [JuristicRegistrationNo] LIKE '%' + @JuristicRegistrationNo+ '%' ");
                        query.Append("OR [JuristicTaxNo] LIKE '%' + @JuristicTaxNo+ '%' ");
                        query.Append("OR [JuristicType] LIKE '%' + @JuristicType+ '%' ");
                        query.Append("OR [Address1] LIKE '%' + @Address1+ '%' ");
                        query.Append("OR [Address2] LIKE '%' + @Address2+ '%' ");
                        query.Append("OR [Address3] LIKE '%' + @Address3+ '%' ");
                        query.Append("OR [Address4] LIKE '%' + @Address4+ '%' ");
                        query.Append("OR [Address5] LIKE '%' + @Address5+ '%' ");
                        query.Append("OR [PhoneNumber1] LIKE '%' + @PhoneNumber1+ '%' ");
                        query.Append("OR [PhoneNumber2] LIKE '%' + @PhoneNumber2+ '%' ");
                        query.Append("OR [Email] LIKE '%' + @Email+ '%' ");
                        query.Append("OR [LastModified] LIKE '%' + @LastModified+ '%' ");

                    }
                    else if (CallCode == 5)
                    {
                        //Semi-strict search with all fields search clause
                        query.Append("[ClientId] LIKE '%' + @ClientId + '%' ");
                        query.Append("AND [ClientType] LIKE '%' + @ClientType+ '%' ");
                        query.Append("AND [ClientName] LIKE '%' + @ClientName+ '%' ");
                        query.Append("AND [ClientSurname] LIKE '%' + @ClientSurname+ '%' ");
                        query.Append("AND [ClientNationality] LIKE '%' + @ClientNationality+ '%' ");
                        query.Append("AND [ClientNationalIdNo] LIKE '%' + @ClientNationalIdNo + '%' ");
                        query.Append("AND [PassportNo] LIKE '%' + @PassportNo + '%' ");
                        query.Append("AND [Dob] LIKE '%' + @Dob + '%' ");
                        query.Append("AND [MaritalStatus] LIKE '%' + @MaritalStatus+ '%' ");
                        query.Append("AND [Gender] LIKE '%' + @Gender+ '%' ");
                        query.Append("AND [JuristicRegistrationNo] LIKE '%' + @JuristicRegistrationNo+ '%' ");
                        query.Append("AND [JuristicTaxNo] LIKE '%' + @JuristicTaxNo+ '%' ");
                        query.Append("AND [JuristicType] LIKE '%' + @JuristicType+ '%' ");
                        query.Append("AND [Address1] LIKE '%' + @Address1+ '%' ");
                        query.Append("AND [Address2] LIKE '%' + @Address2+ '%' ");
                        query.Append("AND [Address3] LIKE '%' + @Address3+ '%' ");
                        query.Append("AND [Address4] LIKE '%' + @Address4+ '%' ");
                        query.Append("AND [Address5] LIKE '%' + @Address5+ '%' ");
                        query.Append("AND [PhoneNumber1] LIKE '%' + @PhoneNumber1+ '%' ");
                        query.Append("AND [PhoneNumber2] LIKE '%' + @PhoneNumber2+ '%' ");
                        query.Append("AND [Email] LIKE '%' + @Email+ '%' ");
                        query.Append("AND [LastModified] LIKE '%' + @LastModified+ '%' ");

                    }
                    else if (CallCode == 6)
                    {
                        //Semi-strict search with all fields (excl: Dob, ) search clause
                        query.Append("[ClientId] LIKE '%' + @ClientId + '%' ");
                        query.Append("AND ([PhoneNumber1] LIKE '%' + @PhoneNumber1+ '%' ");
                        query.Append("OR [PhoneNumber1] LIKE '%' + @PhoneNumber2+ '%') ");
                        query.Append("AND ([ClientName] LIKE '%' + @ClientName+ '%' ");
                        query.Append("OR [ClientName] LIKE '%' + @ClientSurname+ '%') ");
                        query.Append("AND [Email] LIKE '%' + @Email+ '%' ");

                    }
                    query.Append("ORDER BY [ClientName] ASC");
                }

                sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);
                sqlDataAdapter = sqlDataAdapterParametizer(sqlDataAdapter, clientObject);
                //Connect();
                using (sqlDataAdapter.SelectCommand.Connection)
                {
                    sqlDataAdapter.SelectCommand.Connection.Open();
                    sqlDataAdapter.Fill(dataTable);
                    //Disconnect();
                    sqlDataAdapter.SelectCommand.Connection.Close();
                }
                return dataTable;
            }
        }

        public int Insert(Object ObjectType, int CallCode)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO Clients VALUES(@ClientId, @ClientType, @ClientName, @ClientSurname, ");
            query.Append("@ClientNationality, @Dob, @MaritalStatus,  @Gender, @ClientNationalIdNo, @PassportNo, ");
            query.Append("@JuristicRegistrationNo, @JuristicTaxNo, @JuristicType, @Address1, @Address2, @Address3, ");
            query.Append("@Address4, @Address5, @PhoneNumber1, @PhoneNumber2, @Email, @LastModified)");


            SqlCommand sqlCommand = new SqlCommand();
            Objects.Client clientObject = (Objects.Client)ObjectType;
            sqlCommand.Connection = SetConnection();
            sqlCommand.CommandText = query.ToString();

            sqlCommand = sqlCommandParametizer(sqlCommand, clientObject);

            sqlCommand.Connection.Open();
            int objectInsertion = sqlCommand.ExecuteNonQuery();
            Disconnect();
            return objectInsertion;
        }

        public int Update(Objects.Client ObjectType, int CallCode)
        {
            SqlCommand sqlCommand = new SqlCommand();
            Objects.Client clientObject = (Objects.Client)ObjectType;
            StringBuilder query = new StringBuilder();
            query.Append("UPDATE Clients SET [ClientType] = @ClientType, [ClientName] = @ClientName, ");
            query.Append("[ClientSurname] = @ClientSurname, [ClientNationality] = @ClientNationality, [ClientNationalIdNo] = @ClientNationalIdNo, [PassportNo] = @PassportNo, ");
            query.Append("[Dob] = @Dob, [MaritalStatus] = @MaritalStatus, [Gender] = @Gender, [JuristicRegistrationNo] = @JuristicRegistrationNo, [JuristicTaxNo] = @JuristicTaxNo, [JuristicType] = @JuristicType, ");
            query.Append("[Address1] = @Address1, [Address2] = @Address2, [Address3] = @Address3, [Address4] = @Address4, [Address5] = @Address5, [PhoneNumber1] = @PhoneNumber1, ");
            query.Append("[PhoneNumber2] = @PhoneNumber2 , [Email] = @Email, [LastModified] = @LastModified ");
            query.Append("WHERE [ClientId] = @ClientId");

            sqlCommand.Connection = SetConnection();
            sqlCommand.CommandText = query.ToString();

            sqlCommand = sqlCommandParametizer(sqlCommand, clientObject);

            //Connect();
            sqlCommand.Connection.Open();
            int objectUpdate = sqlCommand.ExecuteNonQuery();
            //Disconnect();
            sqlCommand.Connection.Close();
            return objectUpdate;
        }

        public int Delete(Objects.Client ObjectType, int CallCode)
        {
            SqlCommand sqlCommand = new SqlCommand();
            Objects.Client clientObject = (Objects.Client) ObjectType;
            StringBuilder query = new StringBuilder();
            query.Append("DELETE FROM Clients ");
            query.Append("WHERE [ClientId] = @ClientId");

            sqlCommand.CommandText = query.ToString();
            sqlCommand = sqlCommandParametizer(sqlCommand, clientObject);

            sqlCommand.Connection = SetConnection();
            sqlCommand.Connection.Open();

            int objectDelete = sqlCommand.ExecuteNonQuery();

            sqlCommand.Connection.Close();
            return objectDelete;
        }
    }
}
