using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Beit_Solutions_ERP_v1._1.DataConnectionHandlers
{
    class ConnectReservations : Connection
    {
        public List<Objects.Reservation> SelectList(Objects.Reservation ReservationList, int CallCode)
        {
            var dataTable = SelectDataTable(ReservationList, CallCode);
            Objects.Reservation reservation = new Objects.Reservation();
            List<Objects.Reservation> reservationList = new List<Objects.Reservation>();

            if (dataTable.Rows.Count > 0)
            {
                for (int n = 0; n < dataTable.Rows.Count; n++)
                {
                    var rowArray = dataTable.Rows[n].ItemArray;
                    reservation.ReservationId = rowArray[0].ToString();
                    reservation.ProductId = rowArray[1].ToString();
                    reservation.ClientId = rowArray[2].ToString();
                    reservation.LocationId = rowArray[3].ToString();

                    DateTime DateStart;
                    DateTime DateEnd;
                    DateTime.TryParse(rowArray[4].ToString(), out DateStart);
                    DateTime.TryParse(rowArray[5].ToString(), out DateEnd);
                    reservation.DateStart = DateStart;
                    reservation.DateEnd = DateEnd;

                    reservation.Narration = rowArray[6].ToString();

                    reservationList.Add(reservation);
                }
            }
            return reservationList;
        }

        public DataTable SelectDataTable(Object ObjectType, int CallCode)
        {
            DataTable dataTable = new DataTable();
            StringBuilder query = new StringBuilder();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(); ;

            using (SetConnection())
            {
                var reservationObject = (Objects.Reservation) ObjectType;
                //No search clause
                if (CallCode == 0)
                {
                    query.Append("SELECT * FROM Reservations ORDER BY [DateStart] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);
                }
                //Search by Product ID
                else if (CallCode == 1)
                {
                    query.Append("SELECT * FROM Reservations WHERE [ProductId] = @ProductId ORDER BY [DateStart] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ProductId", reservationObject.ProductId);
                }
                //Search by Date Start
                else if (CallCode == 2)
                {
                    query.Append("SELECT * FROM Reservations WHERE [DateStart] = @DateStart ORDER BY [DateStart] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@DateStart", reservationObject.DateStart);
                }
                //Search by Date End
                else if (CallCode == 3)
                {
                    query.Append("SELECT * FROM Reservations WHERE [DateEnd] = @DateEnd ORDER BY [DateStart] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@DateEnd", reservationObject.DateEnd);
                }
                //Search by ProductId AND DateStart
                else if (CallCode == 4)
                {
                    query.Append("SELECT * FROM Reservations WHERE [ProductId] = @ProductId AND [DateStart] = @DateStart ORDER BY [DateEnd] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ProductId", reservationObject.ProductId);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@DateStart", reservationObject.DateStart);
                }
                //Search by ProductId AND DateEnd
                else if (CallCode == 5)
                {
                    query.Append("SELECT * FROM Reservations WHERE [ProductId] = @ProductId AND [DateEnd] = @DateEnd ORDER BY [DateStart] ASC,  [DateEnd] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ProductId", reservationObject.ProductId);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@DateEnd", reservationObject.DateEnd);
                }
                //Search by DateStart AND DateEnd
                else if (CallCode == 5)
                {
                    query.Append("SELECT * FROM Reservations WHERE [DateStart] = @DateStart AND [DateEnd] = @DateEnd ORDER BY [ProductId]");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@DateStart", reservationObject.DateStart);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@DateEnd", reservationObject.DateEnd);
                }
                //Search by ProductId AND DateStart AND DateEnd
                else if (CallCode == 6)
                {
                    query.Append("SELECT * FROM Reservations WHERE [ProductId] = @ProductId AND [DateStart] = @DateStart AND [DateEnd] = @DateEnd ORDER BY [DateStart] ASC,  [DateEnd] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@DateStart", reservationObject.DateStart);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@DateEnd", reservationObject.DateEnd);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ProductId", reservationObject.ProductId);
                }
                    //Search by clientID
                else if (CallCode == 6)
                {
                    query.Append("SELECT * FROM Reservations WHERE [ClientId] = @ClientId ORDER BY [DateStart] ASC,  [DateEnd] ASC");
                    sqlDataAdapter = new SqlDataAdapter(query.ToString(), SetConnection().ConnectionString);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ClientId", reservationObject.ClientId);

                    try
                    {
                        Connect();
                        sqlDataAdapter.Fill(dataTable);
                        Disconnect();
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                return dataTable;
            }
        }


        public int Insert(Objects.Reservation reservation, int CallCode)
        {
            StringBuilder query = new StringBuilder();
            SqlCommand sqlCommand;

            query.Append("INSERT INTO [Reservations] ([ReservationId], [ProductId], [ClientId], [ClientName], [ReservationPrice], [NumberOfRooms], [NumberOfExtrabeds], [DateStart], [DateEnd])");
            query.Append("VALUES (@ReservationId, @ProductId, @ClientId, @ClientName, @ReservationPrice, @NumberOfRooms, @NumberOfExtrabeds, @DateStart, @DateEnd)");
            //query.Append("VALUES (@ReservationId, @ProductId, @ClientId, @LocationId, @ClientName, @ReservationPrice, @NumberOfRooms, @NumberOfExtrabeds, @DateStart, @DateEnd)");
            
            sqlCommand = new SqlCommand();
//            Objects.Reservation reservation = new Objects.Reservation();
            int countResults = 0;

            sqlCommand.Connection = SetConnection();
            sqlCommand.CommandText = query.ToString();
            sqlCommand.Connection.Open();

            sqlCommand.CommandText = query.ToString();
            sqlCommand.Parameters.AddWithValue("@ReservationId", reservation.ReservationId);
            sqlCommand.Parameters.AddWithValue("@ProductId", reservation.ProductId);
            sqlCommand.Parameters.AddWithValue("@ClientId", reservation.ClientId);
            //sqlCommand.Parameters.AddWithValue("@LocationId", reservation.LocationId);
            sqlCommand.Parameters.AddWithValue("@ClientName", reservation.ClientName);
            sqlCommand.Parameters.AddWithValue("@ReservationPrice", reservation.ReservationPrice);
            sqlCommand.Parameters.AddWithValue("@NumberOfRooms", reservation.NumberOfRooms);
            sqlCommand.Parameters.AddWithValue("@NumberOfExtrabeds", reservation.NumberOfExtrabeds);
            sqlCommand.Parameters.AddWithValue("@DateStart", reservation.DateStart);
            sqlCommand.Parameters.AddWithValue("@DateEnd", reservation.DateEnd);

            countResults += sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            return countResults;
        }

        public int Update(Object ObjectType, int CallCode)
        {
            int objectUpdate = 0;
            return objectUpdate;
        }

        public int Delete(Object ObjectType, int CallCode)
        {
            int objectDelete = 0;
            return objectDelete;
        }
    }
}
