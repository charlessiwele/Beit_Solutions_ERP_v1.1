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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public Form CallingForm
        {
            get;
            set;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.SelectAll(); 
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Password";
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataConnectionHandlers.ConnectUsers connectUsers = new DataConnectionHandlers.ConnectUsers();
            Objects.User User = new Objects.User();

            User.Username = txtUsername.Text;
            User.Password = txtPassword.Text;

            if (connectUsers.SelectList(User, 1).Count > 0)
            {
                MessageBox.Show("Login Successful", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMain formMain = (FormMain)CallingForm;
                formMain.EnableOperationsMenuStripItems(true);
                formMain.EnableBusinessSetupMenuStripItems(true);
                formMain.EnableReportsMenuStripItems(true);
                formMain.EnableUsersMenuStripItems(true, true, true, true);
                this.Close();
            }
            else
            {
                MessageBox.Show("Login attempt failed", "Login Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
