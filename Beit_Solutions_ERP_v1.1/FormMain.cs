using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beit_Solutions_ERP_v1._1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public void EnableUsersMenuStripItems(bool loginMenuItemState, bool maintainUsersMenuItemState, bool removeUsersMenuItemState, bool registerUsersMenuItemState)
        {
            loginToolStripMenuItem.Enabled = loginMenuItemState;
            maintainUsersToolStripMenuItem.Enabled = maintainUsersMenuItemState;

            registerUsersToolStripMenuItem.Enabled = registerUsersMenuItemState;
        }

        public void EnableBusinessSetupMenuStripItems(bool MenuStripState)
        {
            businessSetupToolStripMenuItem.Enabled = MenuStripState;
        }

        public void EnableOperationsMenuStripItems(bool MenuStripState)
        {
            operationsToolStripMenuItem.Enabled = MenuStripState;
        }

        public void EnableReportsMenuStripItems(bool MenuStripState)
        {
            reportsToolStripMenuItem.Enabled = MenuStripState;
        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmReservations frmReservations = new Forms.FrmReservations();
            frmReservations.Text = "Reservations Manager";
            frmReservations.SetCallingForm(this);
            frmReservations.MdiParent = this;
            frmReservations.StartPosition = FormStartPosition.CenterScreen;
            frmReservations.WindowState = FormWindowState.Normal;
            frmReservations.Show();
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Users.FrmLogin frmLogin = new Forms.Users.FrmLogin();
            frmLogin.CallingForm = this;
            frmLogin.MdiParent = this;
            frmLogin.Text = "User Login";
            frmLogin.StartPosition = FormStartPosition.CenterScreen;
            frmLogin.WindowState = FormWindowState.Normal;
            frmLogin.Show();
        }

        private void maintainUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Users.FrmUsers frmUsers = new Forms.Users.FrmUsers();
            frmUsers.SetButtonsEnabled(true, false, true, true, true);
            frmUsers.SetButtonsVisibility(true, false, true, true, true); 
            frmUsers.SetTextControlsVisibility(true, true, true, true, true, true, true, true);
            frmUsers.SetTextControlsEnabled(false, true, true, false, false, true, true, true);
            frmUsers.Text = "User Maintenance";
            frmUsers.StartPosition = FormStartPosition.CenterScreen;
            frmUsers.WindowState = FormWindowState.Normal;
            frmUsers.MdiParent = this;
            frmUsers.Show();
        }

        private void businessSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmBusiness frmBusiness = new Forms.FrmBusiness();
            frmBusiness.Text = "Business Information";
            frmBusiness.StartPosition = FormStartPosition.CenterScreen;
            frmBusiness.WindowState = FormWindowState.Normal;
            frmBusiness.MdiParent = this;
            frmBusiness.Show();
        }

        private void registerUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Users.FrmUsers frmUsers = new Forms.Users.FrmUsers();
            frmUsers.SetButtonsEnabled(true, true, false, true, false);
            frmUsers.SetButtonsVisibility(true, true, false, true, false);
            frmUsers.SetTextControlsVisibility(true, true, true, true, true, true, true, true);
            frmUsers.SetTextControlsEnabled(false, true, true, false, true, true, true, true);
            frmUsers.Text = "Register Users";
            frmUsers.SetCallingForm(this);
            frmUsers.StartPosition = FormStartPosition.CenterScreen;
            frmUsers.WindowState = FormWindowState.Normal;
            frmUsers.MdiParent = this;
            frmUsers.Show();
 
        }

        private void manageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmClients FrmClients = new Forms.FrmClients();
            FrmClients.MdiParent = this;
            FrmClients.Text = "Manage Clients";
            FrmClients.SetCallingForm(this);

            FrmClients.StartPosition = FormStartPosition.CenterScreen;
            FrmClients.WindowState = FormWindowState.Normal;

            FrmClients.Show();
        }

    }
}
