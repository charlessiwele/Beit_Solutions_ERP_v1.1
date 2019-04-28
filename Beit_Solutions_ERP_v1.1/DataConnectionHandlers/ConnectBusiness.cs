using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Beit_Solutions_ERP_v1._1.DataConnectionHandlers
{
    class ConnectBusiness : Connection
    {
        public List<Objects.Business> SelectList(Objects.Business ObjectType, int CallCode)
        {
            var dataTable = SelectDataTable(ObjectType, CallCode);
            Objects.Business Business = new Objects.Business();
            List<Objects.Business> businessList = new List<Objects.Business>();

            if (dataTable.Rows.Count > 0)
            {
                for (int n = 0; n < dataTable.Rows.Count; n++)
                {
                    var rowArray = dataTable.Rows[n].ItemArray;
                    Business.BusinessId = rowArray[0].ToString();
                    Business.BusinessRegisteredName = rowArray[1].ToString();
                    Business.BusinessTradingName = rowArray[2].ToString();
                    Business.BusinessRegistrationNo = rowArray[3].ToString(); 
                    Business.BusinessIncomeTaxNo = rowArray[4].ToString(); 
                    Business.BusinessVatNo = rowArray[5].ToString(); 
                    Business.BusinessCity = rowArray[6].ToString();
                    Business.BusinessAddressLine1 = rowArray[7].ToString();
                    Business.BusinessAddressLine2 = rowArray[8].ToString();
                    Business.BusinessAddressLine3 = rowArray[9].ToString();
                    Business.BusinessAddressLine4 = rowArray[10].ToString(); 
                    Business.BusinessPostCode = rowArray[11].ToString();
                    Business.BusinessPhone1 = rowArray[12].ToString(); 
                    Business.BusinessPhone2 = rowArray[13].ToString(); 
                    Business.BusinessPhone3 = rowArray[14].ToString(); 
                    Business.BusinessPhone4 = rowArray[15].ToString(); 
                    Business.BusinessPhone5 = rowArray[16].ToString(); 
                    Business.BusinessEmail1 = rowArray[17].ToString(); 
                    Business.BusinessEmail2 = rowArray[18].ToString(); 
                    Business.BusinessEmail3 = rowArray[19].ToString(); 
                    Business.BusinessEmail4 = rowArray[20].ToString(); 
                    Business.BusinessEmail5 = rowArray[21].ToString(); 
                    Business.BusinessWebsite1 = rowArray[22].ToString(); 
                    Business.BusinessWebsite2 = rowArray[23].ToString(); 
                    Business.BusinessWebsite3 = rowArray[24].ToString(); 
                    Business.BusinessWebsite4 = rowArray[25].ToString(); 
                    Business.BusinessWebsite5 = rowArray[26].ToString(); 

                    Business.DateModified = rowArray[27].ToString();
                    Business.BusinessLogo = rowArray[28].ToString();

                    businessList.Add(Business);
                }
            }
            return businessList;
        }

       public DataTable SelectDataTable(Object ObjectType, int CallCode)
       {
            DataTable dataTable = new DataTable();
            StringBuilder query = new StringBuilder();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            using (SetConnection())
            {
                var businessObject = (Objects.Business) ObjectType;

                if (CallCode == 0)
                {
                    query.Append("SELECT * FROM [Business] WHERE [BusinessId] LIKE '%' + @BusinessId + '%' ");
                    query.Append("AND [BusinessCity] LIKE '%' + @BusinessCity + '%' ");

                    query.Append("AND [RegisteredBusinessName] LIKE '%' + @RegisteredBusinessName+ '%' ");
                    query.Append("AND [BusinessTradeName] LIKE '%' + @BusinessTradeName + '%' ");
                    query.Append("AND [BusinessLogo] LIKE '%' + @BusinessLogo+ '%' ");
                    
                    query.Append("AND [BusinessRegNo] LIKE '%' + @BusinessRegistrationNo + '%' ");
                    query.Append("AND [BusinessIncomeTaxNo] LIKE '%' + @BusinessIncomeTaxNo + '%' ");
                    query.Append("AND [BusinessVatNo] LIKE '%' + @BusinessVatNo + '%' ");
                    
                    query.Append("AND [Phone1] LIKE '%' + @Phone1 + '%' ");
                    query.Append("AND [Phone2] LIKE '%' + @Phone2+ '%' ");
                    query.Append("AND [Phone3] LIKE '%' + @Phone3+ '%' ");
                    query.Append("AND [Phone4] LIKE '%' + @Phone4+ '%' ");
                    query.Append("AND [Phone5] LIKE '%' + @Phone5+ '%' ");

                    query.Append("AND [Email1] LIKE '%' + @Email1+ '%' ");
                    query.Append("AND [Email2] LIKE '%' + @Email2+ '%' ");
                    query.Append("AND [Email3] LIKE '%' + @Email3+ '%' ");
                    query.Append("AND [Email4] LIKE '%' + @Email4+ '%' ");
                    query.Append("AND [Email5] LIKE '%' + @Email5+ '%' ");

                    query.Append("AND [Address1] LIKE '%' + @Address1 + '%' ");
                    query.Append("AND [Address2] LIKE '%' + @Address2 + '%' ");
                    query.Append("AND [Address3] LIKE '%' + @Address3 + '%' ");
                    query.Append("AND [Address4] LIKE '%' + @Address4 + '%' ");
                    query.Append("AND [PostCode] LIKE '%' + @PostCode + '%' ");
                    
                    query.Append("AND [Website1] LIKE '%' + @Website1+ '%' ");
                    query.Append("AND [Website2] LIKE '%' + @Website2+ '%' ");
                    query.Append("AND [Website3] LIKE '%' + @Website3+ '%' ");
                    query.Append("AND [Website4] LIKE '%' + @Website4+ '%' ");
                    query.Append("AND [Website5] LIKE '%' + @Website5+ '%' ");
                    
                    query.Append("AND [DateModified] LIKE '%' + @DateModified+ '%' ");
                    
                    query.Append("ORDER BY [RegisteredBusinessName] ASC");

                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);

                    if (string.IsNullOrEmpty(businessObject.BusinessId)) { businessObject.BusinessId = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@BusinessId", businessObject.BusinessId);

                    if (string.IsNullOrEmpty(businessObject.BusinessCity)) { businessObject.BusinessCity = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@BusinessCity", businessObject.BusinessCity);


                    if (string.IsNullOrEmpty(businessObject.BusinessRegisteredName)) { businessObject.BusinessRegisteredName = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@RegisteredBusinessName", businessObject.BusinessRegisteredName);

                    if (string.IsNullOrEmpty(businessObject.BusinessTradingName)) { businessObject.BusinessTradingName = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@BusinessTradeName", businessObject.BusinessTradingName);

                    if (businessObject.BusinessLogo == null) { businessObject.BusinessLogo = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@BusinessLogo", businessObject.BusinessLogo);

                    if (string.IsNullOrEmpty(businessObject.BusinessRegistrationNo)) { businessObject.BusinessRegistrationNo = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@BusinessRegistrationNo", businessObject.BusinessRegistrationNo);

                    if (string.IsNullOrEmpty(businessObject.BusinessIncomeTaxNo)) { businessObject.BusinessIncomeTaxNo = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@BusinessIncomeTaxNo", businessObject.BusinessIncomeTaxNo);

                    if (string.IsNullOrEmpty(businessObject.BusinessVatNo)) { businessObject.BusinessVatNo = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@BusinessVatNo", businessObject.BusinessVatNo);

                    if (string.IsNullOrEmpty(businessObject.BusinessPhone1)) { businessObject.BusinessPhone1 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Phone1", businessObject.BusinessPhone1);

                    if (string.IsNullOrEmpty(businessObject.BusinessPhone2)) { businessObject.BusinessPhone2 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Phone2", businessObject.BusinessPhone2);

                    if (string.IsNullOrEmpty(businessObject.BusinessPhone3)) { businessObject.BusinessPhone3 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Phone3", businessObject.BusinessPhone3);

                    if (string.IsNullOrEmpty(businessObject.BusinessPhone4)) { businessObject.BusinessPhone4 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Phone4", businessObject.BusinessPhone4);

                    if (string.IsNullOrEmpty(businessObject.BusinessPhone5)) { businessObject.BusinessPhone5 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Phone5", businessObject.BusinessPhone5);

                    if (string.IsNullOrEmpty(businessObject.BusinessEmail1)) { businessObject.BusinessEmail1 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Email1", businessObject.BusinessEmail1);

                    if (string.IsNullOrEmpty(businessObject.BusinessEmail2)) { businessObject.BusinessEmail2 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Email2", businessObject.BusinessEmail2);

                    if (string.IsNullOrEmpty(businessObject.BusinessEmail3)) { businessObject.BusinessEmail3 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Email3", businessObject.BusinessEmail3);

                    if (string.IsNullOrEmpty(businessObject.BusinessEmail4)) { businessObject.BusinessEmail4 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Email4", businessObject.BusinessEmail4);

                    if (string.IsNullOrEmpty(businessObject.BusinessEmail5)) { businessObject.BusinessEmail5 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Email5", businessObject.BusinessEmail5);

                    if (string.IsNullOrEmpty(businessObject.BusinessAddressLine1)) { businessObject.BusinessAddressLine1 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Address1", businessObject.BusinessAddressLine1);

                    if (string.IsNullOrEmpty(businessObject.BusinessAddressLine2)) { businessObject.BusinessAddressLine2 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Address2", businessObject.BusinessAddressLine2);

                    if (string.IsNullOrEmpty(businessObject.BusinessAddressLine3)) { businessObject.BusinessAddressLine3 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Address3", businessObject.BusinessAddressLine3);

                    if (string.IsNullOrEmpty(businessObject.BusinessAddressLine4)) { businessObject.BusinessAddressLine4 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Address4", businessObject.BusinessAddressLine4);

                    if (string.IsNullOrEmpty(businessObject.BusinessPostCode)) { businessObject.BusinessPostCode = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@PostCode", businessObject.BusinessPostCode);

                    if (string.IsNullOrEmpty(businessObject.BusinessWebsite1)) { businessObject.BusinessWebsite1 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Website1", businessObject.BusinessWebsite1);

                    if (string.IsNullOrEmpty(businessObject.BusinessWebsite2)) { businessObject.BusinessWebsite2 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Website2", businessObject.BusinessWebsite2);

                    if (string.IsNullOrEmpty(businessObject.BusinessWebsite3)) { businessObject.BusinessWebsite3 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Website3", businessObject.BusinessWebsite3);

                    if (string.IsNullOrEmpty(businessObject.BusinessWebsite4)) { businessObject.BusinessWebsite4 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Website4", businessObject.BusinessWebsite4);

                    if (string.IsNullOrEmpty(businessObject.BusinessWebsite5)) { businessObject.BusinessWebsite5 = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Website5", businessObject.BusinessWebsite5);

                    if (string.IsNullOrEmpty(businessObject.DateModified)) { businessObject.DateModified = ""; }
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@DateModified", businessObject.DateModified);
                }
                else if (CallCode == 1)
                {
                    query.Append("SELECT * FROM [Business]");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);
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
            Objects.Business businessObject = (Objects.Business)ObjectType;
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO Business VALUES(@BusinessId, @RegisteredBusinessName, @BusinessTradeName, @BusinessRegistrationNo, ");
            query.Append("@BusinessIncomeTaxNo, @BusinessVatNo, @BusinessCity, @Address1, @Address2, @Address3, @Address4, ");
            query.Append("@PostCode, @Phone1, @Phone2, @Phone3, @Phone4, @Phone5, @Email1, @Email2, @Email3, @Email4, ");
            query.Append("@Email5, @Website1, @Website2, @Website3, @Website4, @Website5, @DateModified, @BusinessLogo)");
            sqlCommand.Connection = SetConnection();
            sqlCommand.CommandText = query.ToString();

            sqlCommand.Parameters.AddWithValue("@BusinessId", businessObject.BusinessId);
            sqlCommand.Parameters.AddWithValue("@BusinessCity", businessObject.BusinessCity);
            sqlCommand.Parameters.AddWithValue("@RegisteredBusinessName", businessObject.BusinessRegisteredName);
            sqlCommand.Parameters.AddWithValue("@BusinessTradeName", businessObject.BusinessTradingName);
            sqlCommand.Parameters.AddWithValue("@BusinessRegistrationNo", businessObject.BusinessRegistrationNo);
            sqlCommand.Parameters.AddWithValue("@BusinessIncomeTaxNo", businessObject.BusinessIncomeTaxNo);
            sqlCommand.Parameters.AddWithValue("@BusinessVatNo", businessObject.BusinessVatNo);
            sqlCommand.Parameters.AddWithValue("@Phone1", businessObject.BusinessPhone1);
            sqlCommand.Parameters.AddWithValue("@Phone2", businessObject.BusinessPhone2);
            sqlCommand.Parameters.AddWithValue("@Phone3", businessObject.BusinessPhone3);
            sqlCommand.Parameters.AddWithValue("@Phone4", businessObject.BusinessPhone4);
            sqlCommand.Parameters.AddWithValue("@Phone5", businessObject.BusinessPhone5);
            sqlCommand.Parameters.AddWithValue("@Email1", businessObject.BusinessEmail1);
            sqlCommand.Parameters.AddWithValue("@Email2", businessObject.BusinessEmail2);
            sqlCommand.Parameters.AddWithValue("@Email3", businessObject.BusinessEmail3);
            sqlCommand.Parameters.AddWithValue("@Email4", businessObject.BusinessEmail4);
            sqlCommand.Parameters.AddWithValue("@Email5", businessObject.BusinessEmail5);
            sqlCommand.Parameters.AddWithValue("@Address1", businessObject.BusinessAddressLine1);
            sqlCommand.Parameters.AddWithValue("@Address2", businessObject.BusinessAddressLine2);
            sqlCommand.Parameters.AddWithValue("@Address3", businessObject.BusinessAddressLine3);
            sqlCommand.Parameters.AddWithValue("@Address4", businessObject.BusinessAddressLine4);
            sqlCommand.Parameters.AddWithValue("@PostCode", businessObject.BusinessPostCode);
            sqlCommand.Parameters.AddWithValue("@Website1", businessObject.BusinessWebsite1);
            sqlCommand.Parameters.AddWithValue("@Website2", businessObject.BusinessWebsite2);
            sqlCommand.Parameters.AddWithValue("@Website3", businessObject.BusinessWebsite3);
            sqlCommand.Parameters.AddWithValue("@Website4", businessObject.BusinessWebsite4);
            sqlCommand.Parameters.AddWithValue("@Website5", businessObject.BusinessWebsite5);
            sqlCommand.Parameters.AddWithValue("@DateModified", businessObject.DateModified);
            sqlCommand.Parameters.AddWithValue("@BusinessLogo", businessObject.BusinessLogo);

            //Connect();
            sqlCommand.Connection.Open();
            int objectInsertion = sqlCommand.ExecuteNonQuery();
            Disconnect();
            return objectInsertion;
        }

        public int Update(Objects.Business ObjectType, int CallCode)
        {

            SqlCommand sqlCommand = new SqlCommand();
            Objects.Business businessObject = (Objects.Business) ObjectType;
            StringBuilder query = new StringBuilder();
            query.Append("UPDATE Business SET [BusinessId] = @BusinessId, [RegisteredBusinessName] = @RegisteredBusinessName, [BusinessTradeName] = @BusinessTradeName, ");
            query.Append("[BusinessRegNo] = @BusinessRegistrationNo, [BusinessIncomeTaxNo] = @BusinessIncomeTaxNo, [BusinessVatNo] = @BusinessVatNo, [BusinessCity] = @BusinessCity, ");
            query.Append("[Address1] = @Address1, [Address2] = @Address2, [Address3] = @Address3, [Address4] = @Address4, [PostCode] = @PostCode, [Phone1] = @Phone1, ");
            query.Append("[Phone2] = @Phone2, [Phone3] = @Phone3, [Phone4] = @Phone4, [Phone5] = @Phone5, [Email1] = @Email1, [Email2] = @Email2, [Email3] = @Email3, ");
            query.Append("[Email4] = @Email4 , [Email5] = @Email5, [Website1] = @Website1, [Website2] = @Website2, [Website3] = @Website3, [Website4] = @Website4, [Website5] = @Website5, ");
            query.Append("[DateModified] = @DateModified, [BusinessLogo] = @BusinessLogo");

            sqlCommand.Connection = SetConnection();
            sqlCommand.CommandText = query.ToString();

            sqlCommand.Parameters.AddWithValue("@BusinessId", businessObject.BusinessId);
            sqlCommand.Parameters.AddWithValue("@BusinessCity", businessObject.BusinessCity);
            sqlCommand.Parameters.AddWithValue("@RegisteredBusinessName", businessObject.BusinessRegisteredName);
            sqlCommand.Parameters.AddWithValue("@BusinessTradeName", businessObject.BusinessTradingName);
            sqlCommand.Parameters.AddWithValue("@BusinessLogo", businessObject.BusinessLogo);
            sqlCommand.Parameters.AddWithValue("@BusinessRegistrationNo", businessObject.BusinessRegistrationNo);
            sqlCommand.Parameters.AddWithValue("@BusinessIncomeTaxNo", businessObject.BusinessIncomeTaxNo);
            sqlCommand.Parameters.AddWithValue("@BusinessVatNo", businessObject.BusinessVatNo);
            sqlCommand.Parameters.AddWithValue("@Phone1", businessObject.BusinessPhone1);
            sqlCommand.Parameters.AddWithValue("@Phone2", businessObject.BusinessPhone2);
            sqlCommand.Parameters.AddWithValue("@Phone3", businessObject.BusinessPhone3);
            sqlCommand.Parameters.AddWithValue("@Phone4", businessObject.BusinessPhone4);
            sqlCommand.Parameters.AddWithValue("@Phone5", businessObject.BusinessPhone5);
            sqlCommand.Parameters.AddWithValue("@Email1", businessObject.BusinessEmail1);
            sqlCommand.Parameters.AddWithValue("@Email2", businessObject.BusinessEmail2);
            sqlCommand.Parameters.AddWithValue("@Email3", businessObject.BusinessEmail3);
            sqlCommand.Parameters.AddWithValue("@Email4", businessObject.BusinessEmail4);
            sqlCommand.Parameters.AddWithValue("@Email5", businessObject.BusinessEmail5);
            sqlCommand.Parameters.AddWithValue("@Address1", businessObject.BusinessAddressLine1);
            sqlCommand.Parameters.AddWithValue("@Address2", businessObject.BusinessAddressLine2);
            sqlCommand.Parameters.AddWithValue("@Address3", businessObject.BusinessAddressLine3);
            sqlCommand.Parameters.AddWithValue("@Address4", businessObject.BusinessAddressLine4);
            sqlCommand.Parameters.AddWithValue("@PostCode", businessObject.BusinessPostCode);
            sqlCommand.Parameters.AddWithValue("@Website1", businessObject.BusinessWebsite1);
            sqlCommand.Parameters.AddWithValue("@Website2", businessObject.BusinessWebsite2);
            sqlCommand.Parameters.AddWithValue("@Website3", businessObject.BusinessWebsite3);
            sqlCommand.Parameters.AddWithValue("@Website4", businessObject.BusinessWebsite4);
            sqlCommand.Parameters.AddWithValue("@Website5", businessObject.BusinessWebsite5);
            sqlCommand.Parameters.AddWithValue("@DateModified", businessObject.DateModified);

            //Connect();
            sqlCommand.Connection.Open();
            int objectUpdate = sqlCommand.ExecuteNonQuery();
            Disconnect();
            return objectUpdate;
        }

        int Delete(Objects.Business ObjectType, int CallCode)
        {
            SqlCommand sqlCommand = new SqlCommand();
            Objects.Business businessObject = (Objects.Business)ObjectType;
            StringBuilder query = new StringBuilder();
            query.Append("DELETE FROM Business");
            sqlCommand.Connection = SetConnection();
            sqlCommand.CommandText = query.ToString();

            sqlCommand.Connection.Open();
            int objectDelete = sqlCommand.ExecuteNonQuery();
            Disconnect();
            return objectDelete;
        }
    }
}
