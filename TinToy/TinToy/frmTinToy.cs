using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.IO;

namespace TinToy
{
    public partial class frmTinToy : Form
    {
        private boClsCustomer boCustomer;
        private boClsProduct boProduct;
        private int selectedCustomer = 0;
        private int selectedProduct = 0;
        private Customer _customer;
        private Product _product;
        private ErrorMessage _errorMessage;
        private string imgloc = "";
        private void DisableAllCustomerField()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtLogin.Enabled = false;
            txtPassword.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            btnCloseCustomer.Text = "Close";

            btnEditCustomer.Visible = true;
            btnDeleteCustomer.Visible = true;
            btnSaveCustomer.Visible = false;
        }
        private void EnableAllCustomerField()
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtLogin.Enabled = true;
            txtPassword.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
            btnCloseCustomer.Text = "Cancel";

            btnEditCustomer.Visible = false;
            btnDeleteCustomer.Visible = false;
            btnSaveCustomer.Visible = true;
        }
        private void HideAllPanels()
        {
            pnlCustomerList.Hide();
            pnlCustomer.Hide();
            pnlProduct.Hide();
            pnlCustomerRpt.Hide();
        }
        public frmTinToy()
        {
            InitializeComponent();
        }
        private void frmAAMenu_Load(object sender, EventArgs e)
        {
            HideAllPanels();
        }
        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlCustomerList.Dock = DockStyle.Fill;
            pnlCustomerList.Show();

            btnSearch_Click(this, new EventArgs());
        }
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlCustomer.Dock = DockStyle.Fill;
            pnlCustomer.Show();

            if (selectedCustomer != 0)
            {
                // view existing customer
                DisableAllCustomerField();

                boCustomer = new boClsCustomer();
                _errorMessage = new ErrorMessage();

                _customer = boCustomer.GetCustomerByID(selectedCustomer, ref _errorMessage);
                if (_customer.ID != 0)
                {
                    txtID.Text = _customer.ID.ToString();
                    txtFirstName.Text = _customer.FirstName;
                    txtLastName.Text = _customer.LastName;
                    txtLogin.Text = _customer.Login;
                    txtPassword.Text = _customer.Password;
                    txtEmail.Text = _customer.Email;
                    txtPhone.Text = _customer.Phone;
                }
                else
                {
                    MessageBox.Show(_errorMessage.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                selectedCustomer = 0;
            }
            else
            {
                // add new customer
                EnableAllCustomerField();

                _customer = new Customer();

                txtID.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtLogin.Text = "";
                txtPassword.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
            }
        }
        private void btnCloseCustomerList_Click(object sender, EventArgs e)
        {
            pnlCustomerList.Hide();
        }    
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            selectedCustomer = Int32.Parse(dgCustomerList.Rows[dgCustomerList.CurrentCell.RowIndex].Cells[0].Value.ToString());
            addNewToolStripMenuItem_Click(this, new EventArgs());
        }
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this customer?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                boCustomer = new boClsCustomer();
                _errorMessage = new ErrorMessage();

                if (boCustomer.DeactivateCustomer(_customer.ID, ref _errorMessage))
                {
                    MessageBox.Show("Customer deleted");
                    dgCustomerList.DataSource = null;
                    customerListToolStripMenuItem_Click(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show(_errorMessage.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            EnableAllCustomerField();
        }
        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (_customer.ID != 0)
            {
                //edit/update existing customer
                _customer.FirstName = txtFirstName.Text;
                _customer.LastName = txtLastName.Text;
                _customer.Login = txtLogin.Text;
                _customer.Password = txtPassword.Text;
                _customer.Email = txtEmail.Text;
                _customer.Phone = txtPhone.Text;

                boCustomer = new boClsCustomer();
                _errorMessage = new ErrorMessage();

                if (boCustomer.UpdateCustomer(_customer, ref _errorMessage))
                {
                    selectedCustomer = _customer.ID;
                    dgCustomerList.DataSource = null;
                    addNewToolStripMenuItem_Click(this, new EventArgs());
                    MessageBox.Show("Customer Updated");
                }
                else
                {
                    MessageBox.Show(_errorMessage.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                //create new customer
                _customer.FirstName = txtFirstName.Text;
                _customer.LastName = txtLastName.Text;
                _customer.Login = txtLogin.Text;
                _customer.Password = txtPassword.Text;
                _customer.Email = txtEmail.Text;
                _customer.Phone = txtPhone.Text;

                boCustomer = new boClsCustomer();
                _errorMessage = new ErrorMessage();

                int id = boCustomer.CreateCustomer(_customer, ref _errorMessage);
                if (id != 0)
                {
                    selectedCustomer = id;
                    dgCustomerList.DataSource = null;
                    addNewToolStripMenuItem_Click(this, new EventArgs());
                    MessageBox.Show("New customer created");
                }
                else
                {
                    MessageBox.Show(_errorMessage.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void btnCloseCustomer_Click(object sender, EventArgs e)
        {
            if (btnSaveCustomer.Visible == true)
            {
                if (MessageBox.Show("Discard all changes you've just made?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    pnlCustomer.Hide();
                    selectedCustomer = 0;
                }
            }
            else
            {
                pnlCustomer.Hide();
                selectedCustomer = 0;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _customer = new Customer();
            boCustomer = new boClsCustomer();
            _customer.FirstName = txtSearchCustomerFirstName.Text;
            _customer.LastName = txtSearchCustomerLastName.Text;
            _customer.Login = txtSearchCustomerLogin.Text;
            _customer.Email = txtSearchCustomerEmail.Text;
            _customer.Phone = txtSearchCustomerPhone.Text;

            boCustomer = new boClsCustomer();
            _errorMessage = new ErrorMessage();

            DataTable dt = boCustomer.SearchCustomer(_customer, ref _errorMessage);
            if (dt == null)
            {
                MessageBox.Show(_errorMessage.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            dgCustomerList.DataSource = dt;
            lblCustomerCount.Text = dgCustomerList.RowCount.ToString() + " record(s) found.";
            if (dgCustomerList.RowCount == 0)
            {
                btnCustomer.Enabled = false;
            }
            else
            {
                btnCustomer.Enabled = true;
            }
        }
        private void btnSearchCustomerClear_Click(object sender, EventArgs e)
        {
            txtSearchCustomerFirstName.Text = "";
            txtSearchCustomerLastName.Text = "";
            txtSearchCustomerLogin.Text="";
            txtSearchCustomerEmail.Text="";
            txtSearchCustomerPhone.Text="";
        }
        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlProduct.Dock = DockStyle.Fill;
            pnlProduct.Show();

            _product = new Product();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fD = new OpenFileDialog();
            fD.Filter = "JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|All files (*.*)|*.*";
            fD.Title = "Select Product Image";
            if (fD.ShowDialog() == DialogResult.OK)
            {
                imgloc = fD.FileName.ToString();
                picProduct.ImageLocation = imgloc;
            }
        }
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            _product.Name = txtProductName.Text;
            _product.Description = txtProductDescription.Text;
            if (imgloc != "")
            {
                FileStream FS = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                byte[] img = new byte[FS.Length];
                FS.Read(img, 0, Convert.ToInt32(FS.Length));
                _product.Image = img;
            }
            _product.Price = Decimal.Parse(txtProductPrice.Text);
            _product.Availability = Int32.Parse(txtProductAvailability.Text);

            boProduct = new boClsProduct();            
            _errorMessage = new ErrorMessage();
            
            int id = boProduct.CreateProduct(_product, ref _errorMessage);
            if (id != 0)
            {
                selectedProduct = id;
                MessageBox.Show("New product created");
            }
            else
            {
                MessageBox.Show(_errorMessage.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            boProduct = new boClsProduct();
            _errorMessage = new ErrorMessage();

            _product = boProduct.GetProductByID(33, ref _errorMessage);
            if (_product.ID != 0)
            {
                txtProductID.Text = _product.ID.ToString();
                txtProductName.Text = _product.Name;
                txtProductDescription.Text = _product.Description;
                txtProductPrice.Text = _product.Price.ToString();
                txtProductAvailability.Text = _product.Availability.ToString();

                MemoryStream ms = new MemoryStream(_product.Image);
                picProduct.Image = Image.FromStream(ms);
                picProduct.Refresh();
            }
            else
            {
                MessageBox.Show(_errorMessage.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }            
        }
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlCustomerRpt.Dock = DockStyle.Fill;
            pnlCustomerRpt.Show();

            rptCustomer rptCus = new rptCustomer();
            rptCus.SetDataSource(dgCustomerList.DataSource);
            rptVwrCustomer.ReportSource = rptCus;
        }
        private void btnCustomerReport_Click(object sender, EventArgs e)
        {
            if (dgCustomerList.DataSource != null)
            {
                rptCustomer rptCus = new rptCustomer();
                rptCus.SetDataSource(dgCustomerList.DataSource);
                rptVwrCustomer.ReportSource = rptCus;
            }
        }
        private void btnCustomerRptClose_Click(object sender, EventArgs e)
        {
            pnlCustomerRpt.Hide();
            rptVwrCustomer.ReportSource = null;
        }           
    }
}