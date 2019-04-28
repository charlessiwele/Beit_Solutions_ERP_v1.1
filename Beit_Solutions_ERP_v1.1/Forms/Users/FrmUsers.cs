using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beit_Solutions_ERP_v1._1.Forms.Users
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
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

        public bool ValidateFields(int valCode)
        {
            bool flag = false;
            if(valCode == 0){
                //Validate User ID field
                if (string.IsNullOrEmpty(txtUserId.Text))
                {
                    errorProvider1.SetError(txtUserId, "Field Cannot be Empty");
                }
                else if (string.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "Field Cannot be Empty");
                }
                else if (string.IsNullOrEmpty(txtSurname.Text))
                {
                    errorProvider1.SetError(txtSurname, "Field Cannot be Empty");
                }
                else if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    errorProvider1.SetError(txtUsername, "Field Cannot be Empty");
                }
                else if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Field Cannot be Empty");
                }
                else if (string.IsNullOrEmpty(comboBoxRole.Text))
                {
                    errorProvider1.SetError(comboBoxRole, "Field Cannot be Empty");
                }
                else if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    errorProvider1.SetError(txtAddress, "Field Cannot be Empty");
                }
                else{
                    flag = true;
                }
            }
            else if(valCode ==1){
                //Dont validate User ID field
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "Field Cannot be Empty");
                }
                else if (string.IsNullOrEmpty(txtSurname.Text))
                {
                    errorProvider1.SetError(txtSurname, "Field Cannot be Empty");
                }
                else if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    errorProvider1.SetError(txtUsername, "Field Cannot be Empty");
                }
                else if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Field Cannot be Empty");
                }
                else if (string.IsNullOrEmpty(comboBoxRole.Text))
                {
                    errorProvider1.SetError(comboBoxRole, "Field Cannot be Empty");
                }
                else if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    errorProvider1.SetError(txtAddress, "Field Cannot be Empty");
                }
                else{
                    flag = true;
                }
            }
            return flag;
        }

                //callCode = 1: Do not display actual Password
        public void LoadDataGrid(DataTable dataTable)
        {
            dataGridView1.Rows.Clear();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = row["Name"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[1].Value = row["Surname"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[2].Value = row["Username"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[3].Value = "[Password Hidden]";//row["Password"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[4].Value = row["Email"].ToString().Trim(); ;
                    dataGridView1.Rows[n].Cells[5].Value = row["RoleId"].ToString().Trim();
                    dataGridView1.Rows[n].Cells[6].Value = row["Address"].ToString().Trim();
                }
            }
        }


        public void SetTextControlsVisibility(bool txtUserIdState, bool txtNameState, bool txtSurnameState,
            bool txtUsernameState, bool txtPasswordState, bool txtEmailState, bool comboBoxRoleState, bool txtAddressState)
        {
            txtUserId.Visible = txtUserIdState;
            txtName.Visible = txtNameState;
            txtSurname.Visible = txtSurnameState;
            txtUsername.Visible = txtUsernameState;
            txtPassword.Visible = txtPasswordState;
            txtEmail.Visible = txtEmailState;
            comboBoxRole.Visible = comboBoxRoleState;
            txtAddress.Visible = txtAddressState;
        }

        public void SetTextControlsEnabled(bool txtUserIdState, bool txtNameState, bool txtSurnameState,
            bool txtUsernameState, bool txtPasswordState, bool txtEmailState, bool comboBoxRoleState, bool txtAddressState)
        {
            txtUserId.Enabled = txtUserIdState;
            txtName.Enabled = txtNameState;
            txtSurname.Enabled = txtSurnameState;
            txtUsername.Enabled = txtUsernameState;
            txtPassword.Enabled = txtPasswordState;
            txtEmail.Enabled = txtEmailState;
            comboBoxRole.Enabled = comboBoxRoleState;
            txtAddress.Enabled = txtAddressState;
        }

        public void SetButtonsVisibility(bool btnSearchState, bool btnSaveState, bool btnDeleteState, bool btnClearState, bool btnUpdateState)
        {
            btnSearch.Visible = btnSearchState;
            btnSave.Visible = btnSaveState;
            btnDelete.Visible = btnDeleteState;
            btnClear.Visible = btnClearState;
            btnUpdate.Visible = btnUpdateState;
        }

        public void SetButtonsEnabled(bool btnSearchState, bool btnSaveState, bool btnDeleteState, bool btnClearState, bool btnUpdateState)
        {
            btnSearch.Enabled = btnSearchState;
            btnSave.Enabled = btnSaveState;
            btnDelete.Enabled = btnDeleteState;
            btnClear.Enabled = btnClearState;
            btnUpdate.Visible = btnUpdateState;
        }



        private void FrmUsers_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text)) { txtUserId.Text = ""; }
            if (string.IsNullOrWhiteSpace(txtName.Text)) { txtName.Text = ""; }
            if (string.IsNullOrWhiteSpace(txtSurname.Text)) { txtSurname.Text = ""; }
            if (string.IsNullOrWhiteSpace(txtUsername.Text)) { txtUsername.Text = ""; }
            if (string.IsNullOrWhiteSpace(txtPassword.Text)) { txtPassword.Text = ""; }
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) { txtEmail.Text = ""; }
            if (string.IsNullOrWhiteSpace(comboBoxRole.Text)) { comboBoxRole.Text = ""; }
            if (string.IsNullOrWhiteSpace(txtAddress.Text)) { txtAddress.Text = ""; }

            Objects.User User = new Objects.User();
            User.Name = txtName.Text;
            User.Surname = txtSurname.Text;
            User.Username = txtUsername.Text;
            User.Password = txtPassword.Text;
            User.Email = txtEmail.Text;
            User.RoleId = comboBoxRole.SelectedText;
            User.Address = txtAddress.Text;

            DataConnectionHandlers.ConnectUsers connectUsers = new DataConnectionHandlers.ConnectUsers();

            LoadDataGrid(connectUsers.SelectDataTable(User, 9));
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Objects.User User = new Objects.User();
            DataConnectionHandlers.ConnectUsers ConnectUsers = new DataConnectionHandlers.ConnectUsers();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridView1.CurrentRow != null)
            {
                User.Name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                User.Surname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                User.Username = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                User.Email = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                User.RoleId = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                User.Address = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                var userList = ConnectUsers.SelectList(User, 9);

                txtUserId.Text = userList[0].UserId;
                txtName.Text = userList[0].Name;
                txtSurname.Text = userList[0].Surname;
                txtUsername.Text = userList[0].Username;
                txtPassword.Text = userList[0].Password;
                txtEmail.Text = userList[0].Email;
                comboBoxRole.Text = userList[0].RoleId;
                txtAddress.Text = userList[0].Address;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUserId.Text)){
                MessageBox.Show("Record With This User ID Already Exists. Please Clear Fields and Start Again");
            }
            else
            {
                DataConnectionHandlers.ConnectUsers ConnectUsers = new DataConnectionHandlers.ConnectUsers();
                Objects.User User = new Objects.User();
                int count = ConnectUsers.SelectDataTable(User, 0).Rows.Count;
                User.Username = txtName.Text.Substring(0, 1) + txtSurname.Text + count;
                txtUsername.Text = User.Username;
                if(ValidateFields(1)){

                    User.UserId = Guid.NewGuid().ToString().Substring(0, 8) + count.ToString();
                    User.Name = txtName.Text;
                    User.Surname =txtSurname.Text;
                    User.Password =txtPassword.Text;
                    User.Email =txtEmail.Text;
                    User.RoleId =comboBoxRole.Text;
                    User.Address =txtAddress.Text;
                    User.DateAdded = DateTime.Now.ToLongDateString();

                    //DataConnectionHandlers.ConnectUsers ConnectUsers = new DataConnectionHandlers.ConnectUsers();

                    if (ConnectUsers.Insert(User, 0) > 0)
                    {
                        MessageBox.Show("New User Added");
                        LoadDataGrid(ConnectUsers.SelectDataTable(User, 6));
                    }else{
                        MessageBox.Show("Failed to add new user, please try again later");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserId.Text))
            {
                MessageBox.Show("Please select a record to delete");
            }
            else
            {
                if (ValidateFields(0))
                {
                    Objects.User User = new Objects.User();
                    User.UserId = txtUserId.Text;
                    User.Name = txtName.Text;
                    User.Surname = txtSurname.Text;
                    User.Username = txtUsername.Text;
                    User.Password = txtPassword.Text;
                    User.Email = txtEmail.Text;
                    User.RoleId = comboBoxRole.Text;
                    User.Address = txtAddress.Text;

                    DataConnectionHandlers.ConnectUsers ConnectUsers = new DataConnectionHandlers.ConnectUsers();
                    if (ConnectUsers.Delete(User, 0) > 0)
                    {
                        MessageBox.Show("User " + User.Username + "/" + User.Name + User.Surname + " was successfully removed");
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserId.Text))
            {
                MessageBox.Show("Please select a valid record to change");
            }
            else
            {
                if (ValidateFields(1))
                {
                    Objects.User User = new Objects.User();
                    User.UserId = txtUserId.Text;
                    User.Name = txtName.Text;
                    User.Surname = txtSurname.Text;
                    User.Username = txtUsername.Text;
                    User.Password = txtPassword.Text;
                    User.Email = txtEmail.Text;
                    User.RoleId = comboBoxRole.Text;
                    User.Address = txtAddress.Text;

                    DataConnectionHandlers.ConnectUsers ConnectUsers = new DataConnectionHandlers.ConnectUsers();

                    if (ConnectUsers.Update(User, 5) > 0)
                    {
                        MessageBox.Show("User Info Updated");
                        LoadDataGrid(ConnectUsers.SelectDataTable(User, 6));

                    }
                }

            } 

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserId.Text = ""; 
            txtName.Text = ""; 
            txtSurname.Text = ""; 
            txtUsername.Text = ""; 
            txtPassword.Text = ""; 
            txtEmail.Text = ""; 
            comboBoxRole.SelectedIndex = 0; 
            txtAddress.Text = "";

            dataGridView1.ClearSelection();

        }
    }
}
