using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beit_Solutions_ERP_v1._1.Forms
{
    public partial class FrmReservations : Form
    {
        List<Objects.Reservation> reservationList;
        public FrmReservations()
        {
            InitializeComponent();
            this.reservationList = new List<Objects.Reservation>();

        }

        Objects.Reservation reservation;
        public void LoadClientForm(Objects.Client Client)
        {
            if (string.IsNullOrEmpty(Client.ClientId) ||string.IsNullOrEmpty(Client.ClientName))
            {
                MessageBox.Show("Client info incomplete. Please complete client info before proceeding.");
            }
            else
            {
                this.reservationList = new List<Objects.Reservation>();
                txtClientIdSearch.Text = Client.ClientId;
                txtClientNameSearch.Text = Client.ClientName;
                txtClientPhoneSearch.Text = Client.PhoneNumber1;
                txtClientEmailSearch.Text = Client.Email;

                comboBoxClientType.Text = Client.ClientType;
                txtClientName.Text = Client.ClientName;

                DateTime Dob = Convert.ToDateTime(Client.Dob);
                datePickerDob.Text = Dob.ToShortDateString();

                txtMaritalStatus.Text = Client.MaritalStatus;
                txtClientId.Text = Client.ClientId;
                txtNationalId.Text = Client.ClientNationalIdNo;
                txtGender.Text = Client.Gender;
                txtClientPhone1.Text = Client.PhoneNumber1;
                txtClientPhone2.Text = Client.PhoneNumber2;
                txtClientEmail.Text = Client.Email;
                txtClientAddress.Text = Client.Address1 + ", " + Client.Address2 + ", " + Client.Address3;
                txtClientId.Text = Client.ClientId;
            }
        }

        private Objects.Client ReturnClient;
        public Objects.Client GetReturnClient()
        {
            return this.ReturnClient;

        }

        public void SetReturnClient(Objects.Client ReturnClient)
        {
            this.ReturnClient = ReturnClient;

        }


        private void FrmReservations_Load(object sender, EventArgs e)
        {

        }

        public Form GetCallingForm()
        {
            return this.CallingForm;
        }


        private Form CallingForm;
        public void SetCallingForm(Form CallingForm)
        {
            this.CallingForm = CallingForm;
        }


        public float calculatePrice(int numberOfExtraBeds, int numberofRooms, int numberOfDays)
        {
            float totalPrice;
            const float pricePerRoom = 650;
            const float pricePerExtraBed = 350;

            totalPrice = (pricePerRoom * numberofRooms) + (numberOfExtraBeds * pricePerExtraBed);
            totalPrice = totalPrice * numberOfDays;

            return totalPrice;
        }

        private void btnCheckRequest_Click(object sender, EventArgs e)
        {
            int numberofRooms, numberOfExtraBeds;
            this.reservation = new Objects.Reservation();

            Int32.TryParse(comboBoxNoOfExtraBeds.Text, out numberOfExtraBeds);
            Int32.TryParse(comboBoxNoOfRooms.Text, out numberofRooms);

            //var newguid = Guid.NewGuid();
            //this.reservation.ReservationId = newguid.ToString();

            this.reservation.ProductId = "";
            this.reservation.ClientId = txtClientId.Text;
            this.reservation.ClientName = txtClientName.Text;
            this.reservation.Narration = "default narration";
            this.reservation.NumberOfRooms = numberofRooms;
            this.reservation.NumberOfExtrabeds = numberOfExtraBeds;
            this.reservation.DateStart = dateTimePickerCheckin.Value;
            this.reservation.DateEnd = dateTimePickerCheckout.Value;

            monthCalendarBookings.SetSelectionRange(this.reservation.DateStart, this.reservation.DateEnd);
            double numberOfDays = Math.Ceiling((this.reservation.DateEnd - this.reservation.DateStart).TotalDays);

            if (numberofRooms < 1)
            {
                txtReservationPrice.Text = "Specify number of rooms";
            }
            else
            {
                this.reservation.ReservationPrice = calculatePrice(numberOfExtraBeds, numberofRooms, Convert.ToInt32(numberOfDays));
                txtReservationPrice.Text = (this.reservation.ReservationPrice).ToString();
            }
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            DataConnectionHandlers.ConnectClients ConnectClients = new DataConnectionHandlers.ConnectClients();
            Objects.Client Client = new Objects.Client();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            

            Client.ClientId = txtClientIdSearch.Text;

            Client.ClientName = txtClientNameSearch.Text;
            Client.ClientSurname = txtClientNameSearch.Text.Substring(txtClientNameSearch.Text.IndexOf(" ") + 1);
            Client.PhoneNumber1 = txtClientPhoneSearch.Text;
            Client.Email = txtClientEmailSearch.Text;

            DataTable dataTable = ConnectClients.SelectDataTable(Client, 6);

            PopUps.FrmSearchClient frmSearchClient = new PopUps.FrmSearchClient();
            frmSearchClient.Text = "Select A Client";
            frmSearchClient.SetClientSearchResultsDataTable(dataTable);
            frmSearchClient.WindowState = FormWindowState.Normal;
            frmSearchClient.StartPosition = FormStartPosition.CenterScreen;
            frmSearchClient.MdiParent = this.CallingForm;
            frmSearchClient.SetCallingForm(this);
            this.Enabled = false;
            frmSearchClient.Show();
        }

        private void FrmReservations_Shown(object sender, EventArgs e)
        {

        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            var newguid = Guid.NewGuid();

            this.reservation.ReservationId = newguid.ToString();

            this.reservationList.Add(this.reservation);
            double numberOfDays;
            foreach (Objects.Reservation reservation in reservationList)
            {
                numberOfDays = Math.Ceiling((this.reservation.DateEnd - this.reservation.DateStart).TotalDays);
                rtbReservationsList.AppendText("\nClient Name:-------------------------------------------  " + txtClientName.Text);
                rtbReservationsList.AppendText("\n\nNumber of bedrooms:--------------------------------  " + this.reservation.NumberOfRooms);
                rtbReservationsList.AppendText("\n\nNumber of Extra beds:-------------------------------  " + this.reservation.NumberOfExtrabeds);
                rtbReservationsList.AppendText("\n\nCheck in:------------------------------------------------  " + this.reservation.DateStart.ToLongDateString());
                rtbReservationsList.AppendText("\n\nCheck out:----------------------------------------------  " + this.reservation.DateEnd.ToLongDateString());
                rtbReservationsList.AppendText("\n\nDuration of stay:--------------------------------------  " + numberOfDays + " days");
                rtbReservationsList.AppendText("\n-----------------------------------------------------------------------------------------------------");
                rtbReservationsList.AppendText("\nPrice:------------------------------------------------------ R " + this.reservation.ReservationPrice);
                rtbReservationsList.AppendText("\n-----------------------------------------------------------------------------------------------------");
            }
        }

        private void btnClearClientDetails_Click(object sender, EventArgs e)
        {
            txtClientIdSearch.Text = "";
            txtClientNameSearch.Text = "";
            txtClientPhoneSearch.Text = "";
            txtClientEmailSearch.Text = "";

            txtClientId.Text = "";
            txtMaritalStatus.Text = "";
            txtNationalId.Text = "";
            txtGender.Text = "";
            txtClientPhone1.Text = "";
            txtClientPhone2.Text = "";
            txtClientEmail.Text = "";
            txtClientAddress.Text = "";
        }

        private void btnClearReservationList_Click(object sender, EventArgs e)
        {
            rtbReservationsList.Text = "";
            reservationList.Clear();
        }

        private void btnGenerateQuote_Click(object sender, EventArgs e)
        {
            string fileName = "Quote_"+txtClientName.Text + "_" + dateTimePickerCheckin.Value.ToString();
            fileName = fileName.Replace("-", "_");
            fileName = fileName.Replace(":", "_");
            FileHandlers.PdfHandler pdfHandler = new FileHandlers.PdfHandler();
            pdfHandler.SetQuoteContent(fileName, rtbReservationsList.Text);
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            string fileName = "Invoice_" + txtClientName.Text + "_" + dateTimePickerCheckin.Value.ToShortDateString();
            fileName = fileName.Replace("-", "_");
            fileName = fileName.Replace(":", "_");
            FileHandlers.PdfHandler pdfHandler = new FileHandlers.PdfHandler();
            pdfHandler.SetInvoiceContent(fileName, rtbReservationsList.Text);
        }

        private void btnConfirmReservation_Click(object sender, EventArgs e)
        {
            DataConnectionHandlers.ConnectReservations connectReservations = new DataConnectionHandlers.ConnectReservations();
            int reservationsCount = connectReservations.Insert(reservation, 0);
            if (reservationsCount > 0)
            {
                MessageBox.Show(reservationsCount + " reservations confirmed");
            }
        }
    }
}
