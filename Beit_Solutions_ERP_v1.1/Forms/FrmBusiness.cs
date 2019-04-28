using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;


namespace Beit_Solutions_ERP_v1._1.Forms
{
    public partial class FrmBusiness : Form
    {
        public FrmBusiness()
        {
            InitializeComponent();
        }

        OpenFileDialog openFileDialog;

        private void btnClearChanges_Click(object sender, EventArgs e)
        {
            LoadForm(1);
        }

        private void LoadForm(int CallCode)
        {
            DataConnectionHandlers.ConnectBusiness ConnectBusiness = new DataConnectionHandlers.ConnectBusiness();
            Objects.Business Business = new Objects.Business();
            DataTable BusinessDataTable = new DataTable();
            if (CallCode == 0)
            {
                BusinessDataTable = ConnectBusiness.SelectDataTable(Business, 0);
            }else if(CallCode ==1){
                BusinessDataTable = ConnectBusiness.SelectDataTable(Business, 1);
            }
            if (BusinessDataTable.Rows.Count < 1)
            {
                MessageBox.Show("Business Profile Empty. ");
            }
            else
            {
                Objects.Business ObjectType = new Objects.Business();
                var businessObject = ConnectBusiness.SelectList(ObjectType, 0)[0];
                txtBusinessId.Text = businessObject.BusinessId;
                txtBusinessCity.Text = businessObject.BusinessCity;
                txtBusinessRegisteredName.Text = businessObject.BusinessRegisteredName;
                txtBusinessTradingName.Text = businessObject.BusinessTradingName;

                ////////////////////////////
                if (!string.IsNullOrEmpty(businessObject.BusinessLogo) && !string.IsNullOrWhiteSpace(businessObject.BusinessLogo))
                {
                    if (File.Exists(businessObject.BusinessLogo))
                    {
                        picBoxBusinessLogo.Image = Image.FromFile(businessObject.BusinessLogo);
                    }
                }
                ////////////////////////////

                txtBusinessRegistrationNo.Text = businessObject.BusinessRegistrationNo;
                txtBusinessIncomeTaxNo.Text = businessObject.BusinessIncomeTaxNo;
                txtBusinessVatNo.Text = businessObject.BusinessVatNo;
                txtBusinessPhone1.Text = businessObject.BusinessPhone1;
                txtBusinessPhone2.Text = businessObject.BusinessPhone2;
                txtBusinessPhone3.Text = businessObject.BusinessPhone3;
                txtBusinessPhone4.Text = businessObject.BusinessPhone4;
                txtBusinessPhone5.Text = businessObject.BusinessPhone5;
                txtBusinessEmail1.Text = businessObject.BusinessEmail1;
                txtBusinessEmail2.Text = businessObject.BusinessEmail2;
                txtBusinessEmail3.Text = businessObject.BusinessEmail3;
                txtBusinessEmail4.Text = businessObject.BusinessEmail4;
                txtBusinessEmail5.Text = businessObject.BusinessEmail5;
                txtBusinessAddressLine1.Text = businessObject.BusinessAddressLine1;
                txtBusinessAddressLine2.Text = businessObject.BusinessAddressLine2;
                txtBusinessAddressLine3.Text = businessObject.BusinessAddressLine3;
                txtBusinessAddressLine4.Text = businessObject.BusinessAddressLine4;
                txtBusinessPostCode.Text = businessObject.BusinessPostCode;
                txtBusinessWebsite1.Text = businessObject.BusinessWebsite1;
                txtBusinessWebsite2.Text = businessObject.BusinessWebsite2;
                txtBusinessWebsite3.Text = businessObject.BusinessWebsite3;
                txtBusinessWebsite4.Text = businessObject.BusinessWebsite4;
                txtBusinessWebsite5.Text = businessObject.BusinessWebsite5;
            }
        }

        private void FrmBusiness_Load(object sender, EventArgs e)
        {
            LoadForm(1);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataConnectionHandlers.ConnectBusiness ConnectBusiness = new DataConnectionHandlers.ConnectBusiness();
            Objects.Business businessObject = new Objects.Business();
         
            businessObject.BusinessId = txtBusinessId.Text;
            businessObject.BusinessCity = txtBusinessCity.Text;
            businessObject.BusinessRegisteredName = txtBusinessRegisteredName.Text;
            businessObject.BusinessTradingName = txtBusinessTradingName.Text;
            businessObject.BusinessRegistrationNo = txtBusinessRegistrationNo.Text;
            businessObject.BusinessIncomeTaxNo = txtBusinessIncomeTaxNo.Text;
            businessObject.BusinessVatNo = txtBusinessVatNo.Text;
            businessObject.BusinessPhone1 = txtBusinessPhone1.Text;
            businessObject.BusinessPhone2 = txtBusinessPhone2.Text;
            businessObject.BusinessPhone3 = txtBusinessPhone3.Text;
            businessObject.BusinessPhone4 = txtBusinessPhone4.Text;
            businessObject.BusinessPhone5 = txtBusinessPhone5.Text;
            businessObject.BusinessEmail1 = txtBusinessEmail1.Text;
            businessObject.BusinessEmail2 = txtBusinessEmail2.Text;
            businessObject.BusinessEmail3 = txtBusinessEmail3.Text;
            businessObject.BusinessEmail4 = txtBusinessEmail4.Text;
            businessObject.BusinessEmail5 = txtBusinessEmail5.Text;
            businessObject.BusinessAddressLine1 = txtBusinessAddressLine1.Text;
            businessObject.BusinessAddressLine2 = txtBusinessAddressLine2.Text;
            businessObject.BusinessAddressLine3 = txtBusinessAddressLine3.Text;
            businessObject.BusinessAddressLine4 = txtBusinessAddressLine4.Text;
            businessObject.BusinessPostCode = txtBusinessPostCode.Text;
            businessObject.BusinessWebsite1 = txtBusinessWebsite1.Text;
            businessObject.BusinessWebsite2 = txtBusinessWebsite2.Text;
            businessObject.BusinessWebsite3 = txtBusinessWebsite3.Text;
            businessObject.BusinessWebsite4 = txtBusinessWebsite4.Text;
            businessObject.BusinessWebsite5 = txtBusinessWebsite5.Text;
            businessObject.DateModified = DateTime.Now.ToString();

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\BusinessLogo\";
            if (picBoxBusinessLogo.Image != null && openFileDialog != null)
            {
                if (!Directory.Exists(appPath))
                {
                    Directory.CreateDirectory(appPath);
                }
                File.Copy(openFileDialog.FileName, appPath + openFileDialog.SafeFileName, true);
                businessObject.BusinessLogo = appPath + openFileDialog.SafeFileName;
            }

            if (string.IsNullOrEmpty(businessObject.BusinessLogo))
            {
                var fileDirectory = Directory.GetFiles(appPath);
                if (fileDirectory.Length >= 1)
                {
                    businessObject.BusinessLogo = fileDirectory[0].ToString();
                }
                else
                {
                    businessObject.BusinessLogo = "";
                }
            }

            int executeCount = 0;
            if (ConnectBusiness.SelectDataTable(businessObject, 1).Rows.Count > 0)
            {
                executeCount = ConnectBusiness.Update(businessObject, 0);
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
               executeCount = ConnectBusiness.Insert(businessObject, 0);
               if (executeCount > 0)
               {
                   MessageBox.Show("Successfully added new business info");
               }
               else
               {
                   MessageBox.Show("Failed to successfully added new business info!");
               }
               LoadForm(1);
            }
        }

        private void picBoxBusinessLogo_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JPEG (*.jpg)|*.jpg;*.jpeg|PNG (*.png)|*.png";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picBoxBusinessLogo.Image = Image.FromFile(openFileDialog.FileName);
                picBoxBusinessLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
