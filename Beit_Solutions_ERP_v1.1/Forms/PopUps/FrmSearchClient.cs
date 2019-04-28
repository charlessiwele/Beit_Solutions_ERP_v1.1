using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beit_Solutions_ERP_v1._1.Forms.PopUps
{
    public partial class FrmSearchClient : Form
    {
        public FrmSearchClient()
        {
            InitializeComponent();
        }

        DataTable ClientSearchDataTable;
        public void LoadDataTable(DataTable ClientSearchDataTable)
        {
            this.ClientSearchDataTable = ClientSearchDataTable;
            if (dataGridView1.Columns.Count == 5)
            {
                //dataGridView1.Rows.Clear();
                if (ClientSearchDataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in ClientSearchDataTable.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        
                        //name
                        dataGridView1.Rows[n].Cells[0].Value = row[2].ToString().Trim();

                        //Client Type
                        dataGridView1.Rows[n].Cells[1].Value = row[1].ToString().Trim();

                        //if client type is JP then ID Num = Reg No; Else ID Num = National ID
                        if (dataGridView1.Rows[n].Cells[1].Value.ToString().ToLower() == "juristic person")
                        {
                            dataGridView1.Rows[n].Cells[2].Value = row[10].ToString().Trim();
                        }
                        else
                        {
                            if (dataGridView1.Rows[n].Cells[1].Value.ToString().ToLower() == "natural person")
                            {
                                //if Nationality is SA the ID num; else Passport number
                                if (row[4].ToString() == "South Africa")
                                {
                                    dataGridView1.Rows[n].Cells[2].Value = row[8].ToString().Trim();

                                }
                                else
                                {
                                    dataGridView1.Rows[n].Cells[2].Value = row[9].ToString().Trim();
                                }
                            }
                        }
                        //Phones
                        dataGridView1.Rows[n].Cells[3].Value = row[18].ToString().Trim();
                        if (string.IsNullOrEmpty(row[19].ToString().Trim()))
                        {
                            dataGridView1.Rows[n].Cells[3].Value += (" | " + row[18].ToString().Trim());
                        }

                        //Emails
                        dataGridView1.Rows[n].Cells[4].Value = row[20].ToString().Trim();
                    }
               }
            }
        }

        public void LoadDataForm(DataTable ClientSearchDataTable, int rowNum)
        {
            if (dataGridView1.Columns.Count == 5)
            {
                if (ClientSearchDataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        string clientType = ClientSearchDataTable.Rows[rowNum].ItemArray[1].ToString();
                        lblClientName.Text = ClientSearchDataTable.Rows[rowNum].ItemArray[2].ToString();
                        lblEmail.Text = ClientSearchDataTable.Rows[rowNum].ItemArray[20].ToString();
                        lblNationality.Text = ClientSearchDataTable.Rows[rowNum].ItemArray[4].ToString();
                        lblPhone.Text = ClientSearchDataTable.Rows[rowNum].ItemArray[19].ToString();

                        lblAddressLine1.Text = ClientSearchDataTable.Rows[rowNum].ItemArray[13].ToString();
                        lblAddressLine2.Text = ClientSearchDataTable.Rows[rowNum].ItemArray[14].ToString();
                        lblAddressLine3.Text = ClientSearchDataTable.Rows[rowNum].ItemArray[15].ToString();

                        if (ClientSearchDataTable.Rows[i].ItemArray[1].ToString() == "Juristic Person")
                        {
                            lblDob.Text = "Reg Date: " + ClientSearchDataTable.Rows[rowNum].ItemArray[7].ToString();
                            lblGender.Text = "Juristic Type: " + ClientSearchDataTable.Rows[rowNum].ItemArray[12].ToString();
                            lblNationalId.Text = "Registration No.: " + ClientSearchDataTable.Rows[rowNum].ItemArray[10].ToString();
                        }
                        else
                        {
                            lblDob.Text = "Date of Birth: " + ClientSearchDataTable.Rows[rowNum].ItemArray[7].ToString();
                            lblGender.Text = "Gender: " + ClientSearchDataTable.Rows[rowNum].ItemArray[9].ToString();
                            lblNationalId.Text = "National ID" + ClientSearchDataTable.Rows[rowNum].ItemArray[5].ToString();
                        }
                    }
                }
            }

        }


        public void LoadDataForm(DataTable ClientSearchResultsDataTable)
        {
            if (dataGridView1.Columns.Count == 5)
            {
                if (ClientSearchResultsDataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        string clientType = ClientSearchResultsDataTable.Rows[i].ItemArray[1].ToString();
                        lblClientName.Text = ClientSearchResultsDataTable.Rows[i].ItemArray[2].ToString();
                        lblEmail.Text = ClientSearchResultsDataTable.Rows[i].ItemArray[20].ToString();
                        lblNationality.Text = ClientSearchResultsDataTable.Rows[i].ItemArray[4].ToString();
                        lblPhone.Text = ClientSearchResultsDataTable.Rows[i].ItemArray[19].ToString();

                        lblAddressLine1.Text = ClientSearchResultsDataTable.Rows[i].ItemArray[13].ToString();
                        lblAddressLine2.Text = ClientSearchResultsDataTable.Rows[i].ItemArray[14].ToString();
                        lblAddressLine3.Text = ClientSearchResultsDataTable.Rows[i].ItemArray[15].ToString();

                        if (ClientSearchResultsDataTable.Rows[i].ItemArray[1].ToString() == "Juristic Person")
                        {
                            lblDob.Text = "Reg Date: " + ClientSearchResultsDataTable.Rows[i].ItemArray[7].ToString();
                            lblGender.Text = "Gender: " + ClientSearchResultsDataTable.Rows[i].ItemArray[9].ToString();
                            lblNationalId.Text = "Registration No.: " + ClientSearchResultsDataTable.Rows[i].ItemArray[1].ToString();
                        }
                        else
                        {
                            lblDob.Text = "Date of Birth: " + ClientSearchResultsDataTable.Rows[i].ItemArray[7].ToString();
                            lblGender.Text = "Juristic Type: " + ClientSearchResultsDataTable.Rows[i].ItemArray[12].ToString();
                            lblNationalId.Text = "National ID" + ClientSearchResultsDataTable.Rows[i].ItemArray[5].ToString();
                        }                        
                    }
                }
            }

        }

        public void SetClientSearchResultsDataTable(DataTable ClientSearchDataTable)
        {
            this.ClientSearchDataTable = ClientSearchDataTable;

        }

        public DataTable GetClientSearchResultsDataTable()
        {
            return this.ClientSearchDataTable;
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

        object[] selectedDataRow;
        private void FrmSearchClient_Load(object sender, EventArgs e)
        {
            LoadDataTable(GetClientSearchResultsDataTable());
            SetReturnClient(0);

        }

        private Objects.Client Client = new Objects.Client();
        public void SetReturnClient(int selectedRowIndex)
        {
            selectedDataRow = ClientSearchDataTable.Rows[selectedRowIndex].ItemArray;
            
            this.Client.ClientId = selectedDataRow[0].ToString();
            this.Client.ClientType = selectedDataRow[1].ToString();
            this.Client.ClientNationality = selectedDataRow[4].ToString();
            this.Client.ClientName = selectedDataRow[2].ToString();
            this.Client.ClientSurname = selectedDataRow[3].ToString();
            this.Client.ClientNationality = selectedDataRow[4].ToString();
            this.Client.Dob = selectedDataRow[5].ToString();
            this.Client.MaritalStatus = selectedDataRow[6].ToString();
            this.Client.Gender = selectedDataRow[7].ToString();
            this.Client.ClientNationalIdNo = selectedDataRow[8].ToString();
            this.Client.Email = selectedDataRow[20].ToString();

            this.Client.JuristicRegistrationNo = selectedDataRow[10].ToString();
            this.Client.JuristicTaxNo = selectedDataRow[11].ToString();
            this.Client.JuristicType = selectedDataRow[12].ToString();

            this.Client.Address1 = selectedDataRow[13].ToString();
            this.Client.Address2 = selectedDataRow[14].ToString();
            this.Client.Address3 = selectedDataRow[15].ToString();
            this.Client.Address4 = selectedDataRow[16].ToString();
            this.Client.Address5 = selectedDataRow[17].ToString();

            this.Client.PhoneNumber1 = selectedDataRow[18].ToString();
            this.Client.PhoneNumber2 = selectedDataRow[19].ToString();
            this.Client.Email = selectedDataRow[20].ToString();
            this.Client.LastModified = selectedDataRow[21].ToString();

        }

        public Objects.Client GetReturnClient()
        {
            return this.Client;
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows != null)
            {
                SetReturnClient(dataGridView1.CurrentRow.Index);

                lblPhone.Text = "Contact: ";
                if (!string.IsNullOrEmpty(this.Client.PhoneNumber1) && !string.IsNullOrWhiteSpace(this.Client.PhoneNumber1))
                    lblPhone.Text += this.Client.PhoneNumber1 + " ";

                if (!string.IsNullOrEmpty(this.Client.PhoneNumber2) && !string.IsNullOrWhiteSpace(this.Client.PhoneNumber2))
                    lblPhone.Text += this.Client.PhoneNumber2 + " ";

                lblEmail.Text = "Email: ";
                if (!string.IsNullOrEmpty(this.Client.Email) && !string.IsNullOrWhiteSpace(this.Client.Email))
                {
                    lblEmail.Text += this.Client.Email + " ";
                }
                
                lblNationality.Text = "Nationality: " + Client.ClientNationality;

                lblAddressLine1.Text = "Address Line 1: " + Client.Address1;
                lblAddressLine2.Text = "Address Line 2: " + Client.Address2;
                lblAddressLine3.Text = "Address Line 3: " + Client.Address3;

                lblClientName.Text = "Name: " + Client.ClientName;
                if (Client.ClientType == "Natural Person")
                {
                    lblClientName.Text += " " + Client.ClientSurname;
                    lblDob.Text = "DOB: " + Client.Dob;
                    lblGender.Text = "Gender: " + Client.Gender;
                    lblNationalId.Text = "National ID :" + Client.ClientNationalIdNo;

                }
                else if (Client.ClientType == "Juristic Person")
                {
                    lblDob.Text = "Reg Date: " + Client.Dob;
                    lblGender.Text = "Juristic Type: " + Client.JuristicType;
                    lblNationalId.Text = "Reg No: " + Client.JuristicRegistrationNo;

                }
            }
        }


        Forms.FrmReservations ReservationsForm;
        private void getReservationsForm()
        {
            ReservationsForm = (Forms.FrmReservations)GetCallingForm();
            ReservationsForm.SetReturnClient(GetReturnClient());
            ReservationsForm.Enabled = true;
            ReservationsForm.LoadClientForm(ReservationsForm.GetReturnClient());
            ReservationsForm.Show();
            this.Close();
        }
        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            getReservationsForm();
        }



        private void FrmSearchClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetCallingForm().Enabled = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Forms.FrmClients FrmClients = new Forms.FrmClients();


            FrmClients.Show();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
