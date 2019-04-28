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

namespace Beit_Solutions_ERP_v1._1.Forms.PopUps
{
    public partial class FrmNewClients : Form
    {
        public FrmNewClients()
        {
            InitializeComponent();
        }

        private Form CallingForm;
        public void SetCallingForm(Form CallingForm)
        {
            this.CallingForm = CallingForm;
        }

        public Form GetCallingForm()
        {
            return this.CallingForm;
        }


        public void LoadDataTable(DataTable dataTable)
        {
            dataGridView1.Rows.Clear();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = row["ClientId"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[1].Value = row["ClientType"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[2].Value = row["ClientName"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[3].Value = row["ClientSurname"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[4].Value = row["ClientNationality"].ToString().Trim(); ;
                    dataGridView1.Rows[n].Cells[5].Value = row["ClientNationalIdNo"].ToString().Trim(); ;
                    dataGridView1.Rows[n].Cells[6].Value = row["PassportNo"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[7].Value = row["Dob"].ToString().Trim();

                    dataGridView1.Rows[n].Cells[8].Value = row["MaritalStatus"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[9].Value = row["Gender"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[10].Value = row["JuristicRegistrationNo"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[11].Value = row["JuristicTaxNo"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[12].Value = row["JuristicType"].ToString().Trim();

                    dataGridView1.Rows[n].Cells[13].Value = row["PhoneNumber1"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[14].Value = row["PhoneNumber2"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[15].Value = row["Email"].ToString().Trim();
                }
            }
        }

        private void FrmClients_Load(object sender, EventArgs e)
        {
            this.Text = "Manage Clients";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        public void FillClientForm()
        {

            comboBoxClientType.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtClientName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxNationality.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            try
            {
                dateTimePickerDob.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception)
            {
                dateTimePickerDob.Text = DateTime.Now.ToLongDateString();
            }
            txtPhone1.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtPhone2.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            Objects.Client client = new Objects.Client();

            client.ClientId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DataConnectionHandlers.ConnectClients ConnectClients = new DataConnectionHandlers.ConnectClients();

            var ItemArray = ConnectClients.SelectDataTable(client, 1);

            txtAddress1.Text = ItemArray.Rows[0].ItemArray[13].ToString();
            txtAddress2.Text = ItemArray.Rows[0].ItemArray[14].ToString();
            txtAddress3.Text = ItemArray.Rows[0].ItemArray[15].ToString();

            try
            {
                DateTime Dob = DateTime.Parse(dataGridView1.CurrentRow.Cells[7].ToString());
                dateTimePickerDob.Text = Dob.ToLongDateString();

                if (dateTimePickerDob.Text == Dob.ToLongDateString()) { }
            }
            catch (Exception)
            {
                dateTimePickerDob.Text = DateTime.Now.ToLongDateString();
            }


            if (comboBoxClientType.Text == "Juristic Person")
            {
                ClientTypeChanged(1);
                //Surname = JuristicRegistrationNo
                txtClientSurname.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                //NationalIdNo = JuristicTaxNo
                txtNationalIdNo.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                //MaritalStatus= JuristicType 
                comboBoxMaritalStatus.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            }
            else
            {
                ClientTypeChanged(0);
                //Surname = Surname
                txtClientSurname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //NationalIdNo = NationalIdNo
                txtNationalIdNo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                //MaritalStatus= MaritalStatus
                comboBoxMaritalStatus.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                //Gender = Gender
                comboBoxGender.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
        }

        private void ComboBoxClientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClientType.Text == "Natural Person")
            {
                ClientTypeChanged(0);

            }
            else if (comboBoxClientType.Text == "Juristic Person")
            {
                ClientTypeChanged(1);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataConnectionHandlers.ConnectClients ConnectClients = new DataConnectionHandlers.ConnectClients();
            Objects.Client Client = new Objects.Client();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            if (string.IsNullOrEmpty(Client.ClientId) && string.IsNullOrEmpty(Client.ClientName))
            {
                //search without search clause
                dataTable = ConnectClients.SelectDataTable(Client, 0);
            }
            else if (!string.IsNullOrEmpty(Client.ClientId) && string.IsNullOrEmpty(Client.ClientName))
            {
                //search with clientID search clause
                dataTable = ConnectClients.SelectDataTable(Client, 1);
            }
            else if (string.IsNullOrEmpty(Client.ClientId) && !string.IsNullOrEmpty(Client.ClientName))
            {
                //search with clientName search clause
                dataTable = ConnectClients.SelectDataTable(Client, 2);
            }
            else if (!string.IsNullOrEmpty(Client.ClientId) && !string.IsNullOrEmpty(Client.ClientName))
            {
                //search with clientName AND clientID search clause
                dataTable = ConnectClients.SelectDataTable(Client, 3);
            }
            LoadDataTable(dataTable);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress1.Text = string.Empty;
            txtAddress2.Text = string.Empty;
            txtAddress3.Text = string.Empty;
            txtClientName.Text = string.Empty;
            txtClientSurname.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNationalIdNo.Text = string.Empty;
            txtPhone1.Text = string.Empty;
            txtPhone2.Text = string.Empty;
            comboBoxClientType.Text = string.Empty;
            comboBoxNationality.Text = "South Africa";
            comboBoxMaritalStatus.Text = string.Empty;
            comboBoxGender.Text = string.Empty;
            dateTimePickerDob.Text = DateTime.Now.ToLongDateString();


        }

        public void ClientTypeChanged(int callCode)
        {
            if (callCode == 0)
            //Natural Person
            {
                lblClientName.Text = "Client Name:";
                lblClienSurname.Text = "Surname:";
                lblNationalIdNo.Text = "National ID No.:";
                lblMaritalStatus.Text = " Marital Status Status";
                comboBoxMaritalStatus.Items.Clear();
                comboBoxMaritalStatus.Items.Add("");
                comboBoxMaritalStatus.Items.Add("Single");
                comboBoxMaritalStatus.Items.Add("Married");
                comboBoxMaritalStatus.Items.Add("Divorced");
                comboBoxMaritalStatus.Items.Add("Widowed");
                comboBoxGender.Text = "";
                comboBoxGender.Enabled = true;
            }
            else if (callCode == 1)
            {
                //Juristic Person
                lblClientName.Text = "Organization Name:";
                lblClienSurname.Text = "Registration No.:";
                lblNationalIdNo.Text = "Juristic Tax/VAT No.:";
                lblDob.Text = "Org Registration Date:";
                lblMaritalStatus.Text = "Organization Type";
                comboBoxMaritalStatus.Items.Clear();
                comboBoxMaritalStatus.Items.Add("Association");
                comboBoxMaritalStatus.Items.Add("Close Coporation");
                comboBoxMaritalStatus.Items.Add("Partnership");
                comboBoxMaritalStatus.Items.Add("Private Company");
                comboBoxMaritalStatus.Items.Add("Public Company");
                comboBoxGender.Text = "Other";
                comboBoxGender.Enabled = false;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                FillClientForm();
            }
        }

        private Objects.Client TipifyClient(Objects.Client clientObject, int callCode)
        {

            if (callCode == 0)
            {
                clientObject.ClientSurname = txtClientSurname.Text;
                clientObject.ClientNationality = comboBoxNationality.Text;
                clientObject.ClientNationalIdNo = txtNationalIdNo.Text;
                clientObject.Dob = dateTimePickerDob.Text;
                clientObject.MaritalStatus = comboBoxMaritalStatus.Text;
            }
            else if (callCode == 1)
            {
                clientObject.JuristicRegistrationNo = txtClientSurname.Text;
                clientObject.ClientNationality = comboBoxNationality.Text;
                clientObject.JuristicTaxNo = txtNationalIdNo.Text;
                clientObject.JuristicType = comboBoxMaritalStatus.Text;
            }

            return clientObject;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataConnectionHandlers.ConnectClients ConnectClients = new DataConnectionHandlers.ConnectClients();
            Objects.Client clientObject = new Objects.Client();
            DataTable dataTable;
            clientObject.ClientId = Guid.NewGuid().ToString();
            clientObject.ClientType = comboBoxClientType.Text;
            clientObject.ClientName = txtClientName.Text;
            clientObject.Dob = dateTimePickerDob.Text;
            clientObject.Email = txtEmail.Text;
            clientObject.Address1 = txtAddress1.Text;
            clientObject.Address2 = txtAddress2.Text;
            clientObject.Address3 = txtAddress3.Text;
            clientObject.Gender = comboBoxGender.Text;
            clientObject.PhoneNumber1 = txtPhone1.Text;
            clientObject.PhoneNumber2 = txtPhone2.Text;

            if (comboBoxClientType.Text == "Natural Person")
            {
                clientObject = TipifyClient(clientObject, 0);

            }
            else if (comboBoxClientType.Text == "Juristic Person")
            {
                clientObject = TipifyClient(clientObject, 1);

            }

            int executeCount = 0;
            dataTable = ConnectClients.SelectDataTable(clientObject, 1);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Record Already Exists, Consider Edit Option");
            }
            else
            {
                executeCount = ConnectClients.Insert(clientObject, 0);
                if (executeCount > 0)
                {
                    MessageBox.Show("Successfully added new client info");
                }
                else
                {
                    MessageBox.Show("Failed to successfully added new client info!");
                }
                dataTable = ConnectClients.SelectDataTable(clientObject, 1);
                LoadDataTable(dataTable);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataConnectionHandlers.ConnectClients ConnectClients = new DataConnectionHandlers.ConnectClients();
            Objects.Client clientObject = new Objects.Client();
            DataTable dataTable;
            clientObject.ClientType = comboBoxClientType.Text;
            clientObject.ClientName = txtClientName.Text;
            clientObject.Dob = dateTimePickerDob.Text;
            clientObject.Email = txtEmail.Text;
            clientObject.Address1 = txtAddress1.Text;
            clientObject.Address2 = txtAddress2.Text;
            clientObject.Address3 = txtAddress3.Text;
            clientObject.Gender = comboBoxGender.Text;
            clientObject.PhoneNumber1 = txtPhone1.Text;
            clientObject.PhoneNumber2 = txtPhone2.Text;

            if (comboBoxClientType.Text == "Natural Person")
            {
                clientObject = TipifyClient(clientObject, 0);

            }
            else if (comboBoxClientType.Text == "Juristic Person")
            {
                clientObject = TipifyClient(clientObject, 1);

            }

            int executeCount = 0;
            dataTable = ConnectClients.SelectDataTable(clientObject, 1);
            if (dataTable.Rows.Count > 0)
            {
                executeCount = ConnectClients.Update(clientObject, 0);
                if (executeCount > 0)
                {
                    MessageBox.Show("Update Successful");
                }
                else
                {
                    MessageBox.Show("Update Failed!");
                }
            }
            else
            {
                MessageBox.Show("Select a valid client record to edit, or consider adding a new record.");
            }
            dataTable = ConnectClients.SelectDataTable(clientObject, 1);
            LoadDataTable(dataTable);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataConnectionHandlers.ConnectClients ConnectClients = new DataConnectionHandlers.ConnectClients();
            Objects.Client clientObject = new Objects.Client();

            clientObject.ClientId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            DataTable dataTable = ConnectClients.SelectDataTable(clientObject, 1); ;

            int executeCount = 0;
            dataTable = ConnectClients.SelectDataTable(clientObject, 1);
            if (dataTable.Rows.Count > 0)
            {
                executeCount = ConnectClients.Delete(clientObject, 0);
                if (executeCount > 0)
                {
                    MessageBox.Show("Delete Successful");
                }
                else
                {
                    MessageBox.Show("Delete Failed!");
                }
            }
            else
            {
                MessageBox.Show("Select a valid client record to delete.");
            }
            dataTable = ConnectClients.SelectDataTable(clientObject, 1);
            LoadDataTable(dataTable);
        }
    }
}
