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
        private void DisableAllCustomerFields()
        {
            txtCustomerFirstName.Enabled = false;
            txtCustomerLastName.Enabled = false;
            txtCustomerLogin.Enabled = false;
            txtCustomerPassword.Enabled = false;
            txtCustomerEmail.Enabled = false;
            txtCustomerPhone.Enabled = false;
            btnCustomerClose.Text = "Close";

            btnCustomerEdit.Enabled = true;
            btnCustomerDelete.Enabled = true;
            btnCustomerSave.Enabled = false;
        }
        private void EnableAllCustomerFields()
        {
            txtCustomerFirstName.Enabled = true;
            txtCustomerLastName.Enabled = true;
            txtCustomerLogin.Enabled = true;
            txtCustomerPassword.Enabled = true;
            txtCustomerEmail.Enabled = true;
            txtCustomerPhone.Enabled = true;
            btnCustomerClose.Text = "Cancel";

            btnCustomerEdit.Enabled = false;
            btnCustomerDelete.Enabled = false;
            btnCustomerSave.Enabled = true;
        }
        private void DisableAllProductFields()
        {
            txtProductName.Enabled = false;
            txtProductDescription.Enabled = false;
            txtProductPrice.Enabled = false;
            txtProductAvailability.Enabled = false;
            btnProductClose.Text = "Close";

            btnProductBrowse.Enabled = false;
            btnProductClear.Enabled = false;
            btnProductEdit.Enabled = true;
            btnProductDelete.Enabled = true;
            btnProductSave.Enabled = false;
        }
        private void EnableAllProductFields()
        {
            txtProductName.Enabled = true;
            txtProductDescription.Enabled = true;
            txtProductPrice.Enabled = true;
            txtProductAvailability.Enabled = true;
            btnProductClose.Text = "Cancel";

            btnProductBrowse.Enabled = true;
            btnProductClear.Enabled = true;
            btnProductEdit.Enabled = false;
            btnProductDelete.Enabled = false;
            btnProductSave.Enabled = true;
        }
        private void HideAllPanels()
        {
            pnlCustomerList.Hide();
            pnlCustomer.Hide();
            pnlProductList.Hide();
            pnlProduct.Hide();
            pnlCustomerReport.Hide();
            pnlProductReport.Hide();
        }
        public frmTinToy()
        {
            InitializeComponent();
        }
        private void frmTinToy_Load(object sender, EventArgs e)
        {
            this.Width = 710;
            this.Height = 500;
            HideAllPanels();
        }
        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlCustomerList.Dock = DockStyle.Fill;
            pnlCustomerList.Show();

            btnCustomerSearch_Click(this, new EventArgs());
        }
        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlCustomer.Dock = DockStyle.Fill;
            pnlCustomer.Show();

            if (selectedCustomer != 0)
            {
                // view existing customer
                DisableAllCustomerFields();

                boCustomer = new boClsCustomer();
                _errorMessage = new ErrorMessage();

                _customer = boCustomer.GetCustomerByID(selectedCustomer, ref _errorMessage);
                if (_customer.ID != 0)
                {
                    txtCustomerID.Text = _customer.ID.ToString();
                    txtCustomerFirstName.Text = _customer.FirstName;
                    txtCustomerLastName.Text = _customer.LastName;
                    txtCustomerLogin.Text = _customer.Login;
                    txtCustomerPassword.Text = _customer.Password;
                    txtCustomerEmail.Text = _customer.Email;
                    txtCustomerPhone.Text = _customer.Phone;
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
                EnableAllCustomerFields();

                _customer = new Customer();

                txtCustomerID.Text = "";
                txtCustomerFirstName.Text = "";
                txtCustomerLastName.Text = "";
                txtCustomerLogin.Text = "";
                txtCustomerPassword.Text = "";
                txtCustomerEmail.Text = "";
                txtCustomerPhone.Text = "";
            }
        }
        private void btnCustomerListClose_Click(object sender, EventArgs e)
        {
            pnlCustomerList.Hide();
        }    
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            selectedCustomer = Int32.Parse(dgCustomerList.Rows[dgCustomerList.CurrentCell.RowIndex].Cells[0].Value.ToString());
            addNewCustomerToolStripMenuItem_Click(this, new EventArgs());
        }
        private void btnCustomerDelete_Click(object sender, EventArgs e)
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
        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            EnableAllCustomerFields();
        }
        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            if (_customer.ID != 0)
            {
                //edit/update existing customer
                _customer.FirstName = txtCustomerFirstName.Text;
                _customer.LastName = txtCustomerLastName.Text;
                _customer.Login = txtCustomerLogin.Text;
                _customer.Password = txtCustomerPassword.Text;
                _customer.Email = txtCustomerEmail.Text;
                _customer.Phone = txtCustomerPhone.Text;

                boCustomer = new boClsCustomer();
                _errorMessage = new ErrorMessage();

                if (boCustomer.UpdateCustomer(_customer, ref _errorMessage))
                {
                    selectedCustomer = _customer.ID;
                    dgCustomerList.DataSource = null;
                    addNewCustomerToolStripMenuItem_Click(this, new EventArgs());
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
                _customer.FirstName = txtCustomerFirstName.Text;
                _customer.LastName = txtCustomerLastName.Text;
                _customer.Login = txtCustomerLogin.Text;
                _customer.Password = txtCustomerPassword.Text;
                _customer.Email = txtCustomerEmail.Text;
                _customer.Phone = txtCustomerPhone.Text;

                boCustomer = new boClsCustomer();
                _errorMessage = new ErrorMessage();

                int id = boCustomer.CreateCustomer(_customer, ref _errorMessage);
                if (id != 0)
                {
                    selectedCustomer = id;
                    dgCustomerList.DataSource = null;
                    addNewCustomerToolStripMenuItem_Click(this, new EventArgs());
                    MessageBox.Show("New customer created");
                }
                else
                {
                    MessageBox.Show(_errorMessage.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void btnCustomerClose_Click(object sender, EventArgs e)
        {
            if (btnCustomerSave.Enabled == true)
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
        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            _customer = new Customer();
            _customer.FirstName = txtCustomerSearchFirstName.Text;
            _customer.LastName = txtCustomerSearchLastName.Text;
            _customer.Login = txtCustomerSearchLogin.Text;
            _customer.Email = txtCustomerSearchEmail.Text;
            _customer.Phone = txtCustomerSearchPhone.Text;

            boCustomer = new boClsCustomer();
            _errorMessage = new ErrorMessage();

            DataTable dt = boCustomer.SearchCustomer(_customer, ref _errorMessage);
            if (dt == null)
            {
                MessageBox.Show(_errorMessage.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            dgCustomerList.DataSource = dt;
            dgCustomerList.Columns["ID"].Visible = false;
            dgCustomerList.Columns["ActiveFlag"].Visible = false;

            //this will make cursor point at the first row
            dgCustomerList.CurrentCell = dgCustomerList.FirstDisplayedCell;

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
        private void btnCustomerSearchClear_Click(object sender, EventArgs e)
        {
            txtCustomerSearchFirstName.Text = "";
            txtCustomerSearchLastName.Text = "";
            txtCustomerSearchLogin.Text="";
            txtCustomerSearchEmail.Text="";
            txtCustomerSearchPhone.Text="";
        }
        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlProduct.Dock = DockStyle.Fill;
            pnlProduct.Show();

            if (selectedProduct != 0)
            {
                // view existing product
                DisableAllProductFields();

                boProduct = new boClsProduct();
                _errorMessage = new ErrorMessage();

                _product = boProduct.GetProductByID(selectedProduct, ref _errorMessage);
                if (_product.ID != 0)
                {
                    txtProductID.Text = _product.ID.ToString();
                    txtProductName.Text = _product.Name;
                    txtProductDescription.Text = _product.Description;
                    txtProductPrice.Text = _product.Price.ToString();
                    txtProductAvailability.Text = _product.Availability.ToString();

                    if (_product.Image != null)
                    {
                        MemoryStream ms = new MemoryStream(_product.Image);
                        picProduct.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        picProduct.Image = null;
                    }
                    picProduct.Refresh();
                }
                else
                {
                    MessageBox.Show(_errorMessage.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                selectedProduct = 0;
            }
            else
            {
                // add new product
                EnableAllProductFields();

                _product = new Product();

                txtProductID.Text = "";
                txtProductName.Text = _product.Name;
                txtProductDescription.Text = "";
                txtProductPrice.Text = "";
                txtProductAvailability.Text = "";

                picProduct.Image = null;
            }
        }
        private void btnProductBrowse_Click(object sender, EventArgs e)
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
        private void btnProductSave_Click(object sender, EventArgs e)
        {
            if (_product.ID != 0)
            {
                //edit/update existing product
                _product.Name = txtProductName.Text;
                _product.Description = txtProductDescription.Text;
                if (imgloc != "")
                {
                    FileStream FS = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    byte[] img = new byte[FS.Length];
                    FS.Read(img, 0, Convert.ToInt32(FS.Length));
                    _product.Image = img;
                }
                try
                {
                    _product.Price = Decimal.Parse(txtProductPrice.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter correct format for product price", "Incorrect Format");
                    return;
                }
                try
                {
                    _product.Availability = Int32.Parse(txtProductAvailability.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter correct format for availability", "Incorrect Format");
                    return;
                }
                boProduct = new boClsProduct();
                _errorMessage = new ErrorMessage();

                if (boProduct.UpdateProduct(_product, ref _errorMessage))
                {
                    selectedProduct = _product.ID;
                    dgProductList.DataSource = null;
                    addNewProductToolStripMenuItem_Click(this, new EventArgs());
                    MessageBox.Show("Product Updated");
                }
                else
                {
                    MessageBox.Show(_errorMessage.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                //create new product
                _product.Name = txtProductName.Text;
                _product.Description = txtProductDescription.Text;
                if (imgloc != "")
                {
                    FileStream FS = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    byte[] img = new byte[FS.Length];
                    FS.Read(img, 0, Convert.ToInt32(FS.Length));
                    _product.Image = img;
                }
                try
                {
                    _product.Price = Decimal.Parse(txtProductPrice.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter correct format for product price", "Incorrect Format");
                    return;
                }
                try
                {
                    _product.Availability = Int32.Parse(txtProductAvailability.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter correct format for availability", "Incorrect Format");
                    return;
                }
                boProduct = new boClsProduct();
                _errorMessage = new ErrorMessage();

                int id = boProduct.CreateProduct(_product, ref _errorMessage);
                if (id != 0)
                {
                    selectedProduct = id;
                    dgProductList.DataSource = null;
                    addNewProductToolStripMenuItem_Click(this, new EventArgs());
                    MessageBox.Show("New product created");
                }
                else
                {
                    MessageBox.Show(_errorMessage.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }         
        }
        private void btnCustomerReport_Click(object sender, EventArgs e)
        {
            reportCustomerToolStripMenuItem_Click(this, new EventArgs());
        }
        private void btnCustomerReportClose_Click(object sender, EventArgs e)
        {
            pnlCustomerReport.Hide();
            rptCustomerVwr.ReportSource = null;
        }
        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlProductList.Dock = DockStyle.Fill;
            pnlProductList.Show();

            btnProductSearch_Click(this, new EventArgs());
        }
        private void btnProductSearchClear_Click(object sender, EventArgs e)
        {
            txtProductSearchName.Text = "";
            txtProductSearchDescription.Text = "";
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            selectedProduct = Int32.Parse(dgProductList.Rows[dgProductList.CurrentCell.RowIndex].Cells[0].Value.ToString());
            addNewProductToolStripMenuItem_Click(this, new EventArgs());
        }
        private void btnProductListClose_Click(object sender, EventArgs e)
        {
            pnlProductList.Hide();
        }
        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            _product = new Product();
            _product.Name = txtProductSearchName.Text;
            _product.Description = txtProductSearchDescription.Text;

            boProduct = new boClsProduct();
            _errorMessage = new ErrorMessage();

            DataTable dt = boProduct.SearchProduct(_product, ref _errorMessage);
            if (dt == null)
            {
                MessageBox.Show(_errorMessage.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            dgProductList.DataSource = dt;
            dgProductList.Columns["ID"].Visible = false;
            dgProductList.Columns["Image"].Visible = false;
            dgProductList.Columns["ActiveFlag"].Visible = false;

            //this will make cursor point at the first row
            dgProductList.CurrentCell = dgProductList.FirstDisplayedCell;

            lblProductCount.Text = dgProductList.RowCount.ToString() + " record(s) found.";
            if (dgProductList.RowCount == 0)
            {
                btnProduct.Enabled = false;
            }
            else
            {
                btnProduct.Enabled = true;
            }
        }
        private void btnProductClear_Click(object sender, EventArgs e)
        {
            _product.Image = null;
            picProduct.Image = null;
        }
        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            EnableAllProductFields();
        }
        private void btnProductClose_Click(object sender, EventArgs e)
        {
            if (btnProductSave.Enabled == true)
            {
                if (MessageBox.Show("Discard all changes you've just made?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    pnlProduct.Hide();
                    selectedProduct = 0;
                }
            }
            else
            {
                pnlProduct.Hide();
                selectedProduct = 0;
            }
        }
        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this product?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                boProduct = new boClsProduct();
                _errorMessage = new ErrorMessage();

                if (boProduct.DeactivateProduct(_product.ID, ref _errorMessage))
                {
                    MessageBox.Show("Product deleted");
                    dgProductList.DataSource = null;
                    productListToolStripMenuItem_Click(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show(_errorMessage.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }  
        private void dgProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //todo
        }
        private void btnProductReport_Click(object sender, EventArgs e)
        {
            reportProductToolStripMenuItem_Click(this, new EventArgs());
        }
        private void reportProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlProductReport.Dock = DockStyle.Fill;
            pnlProductReport.Show();

            rptProduct rptProd = new rptProduct();
            rptProd.SetDataSource(dgProductList.DataSource);
            rptProductVwr.ReportSource = rptProd;
        }
        private void reportCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlCustomerReport.Dock = DockStyle.Fill;
            pnlCustomerReport.Show();

            rptCustomer rptCus = new rptCustomer();
            rptCus.SetDataSource(dgCustomerList.DataSource);
            rptCustomerVwr.ReportSource = rptCus;
        }
        private void btnProductReportClose_Click(object sender, EventArgs e)
        {
            pnlProductReport.Hide();
            rptProductVwr.ReportSource = null;
        }
    }
}