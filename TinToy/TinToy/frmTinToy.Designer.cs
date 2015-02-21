namespace TinToy
{
    partial class frmTinToy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCustomerList = new System.Windows.Forms.Panel();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.gbCustomerSearch = new System.Windows.Forms.GroupBox();
            this.btnCustomerReport = new System.Windows.Forms.Button();
            this.btnSearchCustomerClear = new System.Windows.Forms.Button();
            this.lblSearchCustomerPhone = new System.Windows.Forms.Label();
            this.lblSearchCustomerEmail = new System.Windows.Forms.Label();
            this.lblSearchCustomerLogin = new System.Windows.Forms.Label();
            this.lblSearchCustomerLastName = new System.Windows.Forms.Label();
            this.lblSearchCustomerFirstName = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtSearchCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtSearchCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtSearchCustomerLogin = new System.Windows.Forms.TextBox();
            this.txtSearchCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtSearchCustomerFirstName = new System.Windows.Forms.TextBox();
            this.btnCloseCustomerList = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.dgCustomerList = new System.Windows.Forms.DataGridView();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnCloseCustomer = new System.Windows.Forms.Button();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtProductAvailability = new System.Windows.Forms.TextBox();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rptVwrCustomer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnlCustomerRpt = new System.Windows.Forms.Panel();
            this.btnCustomerRptClose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlCustomerList.SuspendLayout();
            this.gbCustomerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerList)).BeginInit();
            this.pnlCustomer.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            this.gbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.pnlCustomerRpt.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.productToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "&Order";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "&Product";
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addNewProductToolStripMenuItem.Text = "&Add New";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerListToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.toolStripSeparator1,
            this.reportToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "&Customer";
            // 
            // customerListToolStripMenuItem
            // 
            this.customerListToolStripMenuItem.Name = "customerListToolStripMenuItem";
            this.customerListToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.customerListToolStripMenuItem.Text = "Customer &List";
            this.customerListToolStripMenuItem.Click += new System.EventHandler(this.customerListToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addNewToolStripMenuItem.Text = "&Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.reportToolStripMenuItem.Text = "&Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // pnlCustomerList
            // 
            this.pnlCustomerList.Controls.Add(this.lblCustomerCount);
            this.pnlCustomerList.Controls.Add(this.gbCustomerSearch);
            this.pnlCustomerList.Controls.Add(this.btnCloseCustomerList);
            this.pnlCustomerList.Controls.Add(this.btnCustomer);
            this.pnlCustomerList.Controls.Add(this.dgCustomerList);
            this.pnlCustomerList.Location = new System.Drawing.Point(180, 27);
            this.pnlCustomerList.Name = "pnlCustomerList";
            this.pnlCustomerList.Size = new System.Drawing.Size(700, 500);
            this.pnlCustomerList.TabIndex = 1;
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCustomerCount.Location = new System.Drawing.Point(548, 156);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(0, 17);
            this.lblCustomerCount.TabIndex = 6;
            // 
            // gbCustomerSearch
            // 
            this.gbCustomerSearch.Controls.Add(this.btnCustomerReport);
            this.gbCustomerSearch.Controls.Add(this.btnSearchCustomerClear);
            this.gbCustomerSearch.Controls.Add(this.lblSearchCustomerPhone);
            this.gbCustomerSearch.Controls.Add(this.lblSearchCustomerEmail);
            this.gbCustomerSearch.Controls.Add(this.lblSearchCustomerLogin);
            this.gbCustomerSearch.Controls.Add(this.lblSearchCustomerLastName);
            this.gbCustomerSearch.Controls.Add(this.lblSearchCustomerFirstName);
            this.gbCustomerSearch.Controls.Add(this.btnSearchCustomer);
            this.gbCustomerSearch.Controls.Add(this.txtSearchCustomerPhone);
            this.gbCustomerSearch.Controls.Add(this.txtSearchCustomerEmail);
            this.gbCustomerSearch.Controls.Add(this.txtSearchCustomerLogin);
            this.gbCustomerSearch.Controls.Add(this.txtSearchCustomerLastName);
            this.gbCustomerSearch.Controls.Add(this.txtSearchCustomerFirstName);
            this.gbCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbCustomerSearch.Location = new System.Drawing.Point(33, 13);
            this.gbCustomerSearch.Name = "gbCustomerSearch";
            this.gbCustomerSearch.Size = new System.Drawing.Size(635, 132);
            this.gbCustomerSearch.TabIndex = 5;
            this.gbCustomerSearch.TabStop = false;
            this.gbCustomerSearch.Text = "Search Customer";
            // 
            // btnCustomerReport
            // 
            this.btnCustomerReport.Location = new System.Drawing.Point(554, 66);
            this.btnCustomerReport.Name = "btnCustomerReport";
            this.btnCustomerReport.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerReport.TabIndex = 12;
            this.btnCustomerReport.Text = "Report";
            this.btnCustomerReport.UseVisualStyleBackColor = true;
            this.btnCustomerReport.Click += new System.EventHandler(this.btnCustomerReport_Click);
            // 
            // btnSearchCustomerClear
            // 
            this.btnSearchCustomerClear.Location = new System.Drawing.Point(356, 99);
            this.btnSearchCustomerClear.Name = "btnSearchCustomerClear";
            this.btnSearchCustomerClear.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCustomerClear.TabIndex = 11;
            this.btnSearchCustomerClear.Text = "Clear";
            this.btnSearchCustomerClear.UseVisualStyleBackColor = true;
            this.btnSearchCustomerClear.Click += new System.EventHandler(this.btnSearchCustomerClear_Click);
            // 
            // lblSearchCustomerPhone
            // 
            this.lblSearchCustomerPhone.AutoSize = true;
            this.lblSearchCustomerPhone.Location = new System.Drawing.Point(353, 66);
            this.lblSearchCustomerPhone.Name = "lblSearchCustomerPhone";
            this.lblSearchCustomerPhone.Size = new System.Drawing.Size(41, 13);
            this.lblSearchCustomerPhone.TabIndex = 10;
            this.lblSearchCustomerPhone.Text = "Phone:";
            // 
            // lblSearchCustomerEmail
            // 
            this.lblSearchCustomerEmail.AutoSize = true;
            this.lblSearchCustomerEmail.Location = new System.Drawing.Point(353, 40);
            this.lblSearchCustomerEmail.Name = "lblSearchCustomerEmail";
            this.lblSearchCustomerEmail.Size = new System.Drawing.Size(35, 13);
            this.lblSearchCustomerEmail.TabIndex = 9;
            this.lblSearchCustomerEmail.Text = "Email:";
            // 
            // lblSearchCustomerLogin
            // 
            this.lblSearchCustomerLogin.AutoSize = true;
            this.lblSearchCustomerLogin.Location = new System.Drawing.Point(133, 93);
            this.lblSearchCustomerLogin.Name = "lblSearchCustomerLogin";
            this.lblSearchCustomerLogin.Size = new System.Drawing.Size(36, 13);
            this.lblSearchCustomerLogin.TabIndex = 8;
            this.lblSearchCustomerLogin.Text = "Login:";
            // 
            // lblSearchCustomerLastName
            // 
            this.lblSearchCustomerLastName.AutoSize = true;
            this.lblSearchCustomerLastName.Location = new System.Drawing.Point(133, 66);
            this.lblSearchCustomerLastName.Name = "lblSearchCustomerLastName";
            this.lblSearchCustomerLastName.Size = new System.Drawing.Size(59, 13);
            this.lblSearchCustomerLastName.TabIndex = 7;
            this.lblSearchCustomerLastName.Text = "Last name:";
            // 
            // lblSearchCustomerFirstName
            // 
            this.lblSearchCustomerFirstName.AutoSize = true;
            this.lblSearchCustomerFirstName.Location = new System.Drawing.Point(133, 41);
            this.lblSearchCustomerFirstName.Name = "lblSearchCustomerFirstName";
            this.lblSearchCustomerFirstName.Size = new System.Drawing.Size(58, 13);
            this.lblSearchCustomerFirstName.TabIndex = 6;
            this.lblSearchCustomerFirstName.Text = "First name:";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(444, 99);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCustomer.TabIndex = 5;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchCustomerPhone
            // 
            this.txtSearchCustomerPhone.Location = new System.Drawing.Point(433, 63);
            this.txtSearchCustomerPhone.Name = "txtSearchCustomerPhone";
            this.txtSearchCustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.txtSearchCustomerPhone.TabIndex = 4;
            // 
            // txtSearchCustomerEmail
            // 
            this.txtSearchCustomerEmail.Location = new System.Drawing.Point(433, 37);
            this.txtSearchCustomerEmail.Name = "txtSearchCustomerEmail";
            this.txtSearchCustomerEmail.Size = new System.Drawing.Size(100, 20);
            this.txtSearchCustomerEmail.TabIndex = 3;
            // 
            // txtSearchCustomerLogin
            // 
            this.txtSearchCustomerLogin.Location = new System.Drawing.Point(202, 89);
            this.txtSearchCustomerLogin.Name = "txtSearchCustomerLogin";
            this.txtSearchCustomerLogin.Size = new System.Drawing.Size(100, 20);
            this.txtSearchCustomerLogin.TabIndex = 2;
            // 
            // txtSearchCustomerLastName
            // 
            this.txtSearchCustomerLastName.Location = new System.Drawing.Point(202, 63);
            this.txtSearchCustomerLastName.Name = "txtSearchCustomerLastName";
            this.txtSearchCustomerLastName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchCustomerLastName.TabIndex = 1;
            // 
            // txtSearchCustomerFirstName
            // 
            this.txtSearchCustomerFirstName.Location = new System.Drawing.Point(202, 37);
            this.txtSearchCustomerFirstName.Name = "txtSearchCustomerFirstName";
            this.txtSearchCustomerFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchCustomerFirstName.TabIndex = 0;
            // 
            // btnCloseCustomerList
            // 
            this.btnCloseCustomerList.Location = new System.Drawing.Point(609, 381);
            this.btnCloseCustomerList.Name = "btnCloseCustomerList";
            this.btnCloseCustomerList.Size = new System.Drawing.Size(75, 23);
            this.btnCloseCustomerList.TabIndex = 4;
            this.btnCloseCustomerList.Text = "Close";
            this.btnCloseCustomerList.UseVisualStyleBackColor = true;
            this.btnCloseCustomerList.Click += new System.EventHandler(this.btnCloseCustomerList_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(465, 381);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(138, 23);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "View Customer Detail";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // dgCustomerList
            // 
            this.dgCustomerList.AllowUserToAddRows = false;
            this.dgCustomerList.AllowUserToDeleteRows = false;
            this.dgCustomerList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerList.Location = new System.Drawing.Point(15, 180);
            this.dgCustomerList.MultiSelect = false;
            this.dgCustomerList.Name = "dgCustomerList";
            this.dgCustomerList.ReadOnly = true;
            this.dgCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomerList.Size = new System.Drawing.Size(669, 190);
            this.dgCustomerList.TabIndex = 0;
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.gbCustomer);
            this.pnlCustomer.Location = new System.Drawing.Point(0, 27);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(700, 500);
            this.pnlCustomer.TabIndex = 2;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.txtLastName);
            this.gbCustomer.Controls.Add(this.lblPhone);
            this.gbCustomer.Controls.Add(this.txtFirstName);
            this.gbCustomer.Controls.Add(this.lblEmail);
            this.gbCustomer.Controls.Add(this.txtLogin);
            this.gbCustomer.Controls.Add(this.lblPassword);
            this.gbCustomer.Controls.Add(this.txtPassword);
            this.gbCustomer.Controls.Add(this.lblLogin);
            this.gbCustomer.Controls.Add(this.txtEmail);
            this.gbCustomer.Controls.Add(this.lblLastName);
            this.gbCustomer.Controls.Add(this.txtPhone);
            this.gbCustomer.Controls.Add(this.lblFirstName);
            this.gbCustomer.Controls.Add(this.btnDeleteCustomer);
            this.gbCustomer.Controls.Add(this.txtID);
            this.gbCustomer.Controls.Add(this.btnEditCustomer);
            this.gbCustomer.Controls.Add(this.btnCloseCustomer);
            this.gbCustomer.Controls.Add(this.btnSaveCustomer);
            this.gbCustomer.Location = new System.Drawing.Point(38, 32);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(451, 254);
            this.gbCustomer.TabIndex = 20;
            this.gbCustomer.TabStop = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(157, 87);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(71, 194);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(157, 61);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(71, 168);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(157, 113);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(71, 142);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(157, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(71, 118);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 16;
            this.lblLogin.Text = "Login:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(71, 90);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Last name:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(157, 191);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(71, 64);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(58, 13);
            this.lblFirstName.TabIndex = 14;
            this.lblFirstName.Text = "First name:";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(314, 89);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCustomer.TabIndex = 9;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(157, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 13;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(314, 118);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnEditCustomer.TabIndex = 10;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnCloseCustomer
            // 
            this.btnCloseCustomer.Location = new System.Drawing.Point(314, 190);
            this.btnCloseCustomer.Name = "btnCloseCustomer";
            this.btnCloseCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCloseCustomer.TabIndex = 12;
            this.btnCloseCustomer.Text = "Close";
            this.btnCloseCustomer.UseVisualStyleBackColor = true;
            this.btnCloseCustomer.Click += new System.EventHandler(this.btnCloseCustomer_Click);
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(314, 161);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCustomer.TabIndex = 11;
            this.btnSaveCustomer.Text = "Save";
            this.btnSaveCustomer.UseVisualStyleBackColor = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.gbProduct);
            this.pnlProduct.Location = new System.Drawing.Point(148, 27);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(700, 500);
            this.pnlProduct.TabIndex = 3;
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.txtProductName);
            this.gbProduct.Controls.Add(this.button1);
            this.gbProduct.Controls.Add(this.txtProductAvailability);
            this.gbProduct.Controls.Add(this.btnSaveProduct);
            this.gbProduct.Controls.Add(this.txtProductPrice);
            this.gbProduct.Controls.Add(this.btnBrowse);
            this.gbProduct.Controls.Add(this.txtProductDescription);
            this.gbProduct.Controls.Add(this.picProduct);
            this.gbProduct.Controls.Add(this.txtProductID);
            this.gbProduct.Controls.Add(this.lblAvailability);
            this.gbProduct.Controls.Add(this.lblPrice);
            this.gbProduct.Controls.Add(this.lblName);
            this.gbProduct.Controls.Add(this.lblDescription);
            this.gbProduct.Location = new System.Drawing.Point(47, 32);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(589, 254);
            this.gbProduct.TabIndex = 36;
            this.gbProduct.TabStop = false;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(179, 61);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtProductAvailability
            // 
            this.txtProductAvailability.Location = new System.Drawing.Point(177, 169);
            this.txtProductAvailability.Name = "txtProductAvailability";
            this.txtProductAvailability.Size = new System.Drawing.Size(100, 20);
            this.txtProductAvailability.TabIndex = 26;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Location = new System.Drawing.Point(191, 201);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProduct.TabIndex = 34;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(177, 143);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 20);
            this.txtProductPrice.TabIndex = 25;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(346, 192);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 33;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(179, 87);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(100, 50);
            this.txtProductDescription.TabIndex = 24;
            // 
            // picProduct
            // 
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Location = new System.Drawing.Point(306, 34);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(150, 152);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduct.TabIndex = 32;
            this.picProduct.TabStop = false;
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(179, 34);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 22;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(112, 172);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(59, 13);
            this.lblAvailability.TabIndex = 31;
            this.lblAvailability.Text = "Availability:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(113, 146);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 13);
            this.lblPrice.TabIndex = 30;
            this.lblPrice.Text = "Price($):";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(112, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(113, 90);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 29;
            this.lblDescription.Text = "Description:";
            // 
            // rptVwrCustomer
            // 
            this.rptVwrCustomer.ActiveViewIndex = -1;
            this.rptVwrCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptVwrCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptVwrCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.rptVwrCustomer.Location = new System.Drawing.Point(0, 0);
            this.rptVwrCustomer.Name = "rptVwrCustomer";
            this.rptVwrCustomer.Size = new System.Drawing.Size(700, 349);
            this.rptVwrCustomer.TabIndex = 7;
            this.rptVwrCustomer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pnlCustomerRpt
            // 
            this.pnlCustomerRpt.Controls.Add(this.rptVwrCustomer);
            this.pnlCustomerRpt.Controls.Add(this.btnCustomerRptClose);
            this.pnlCustomerRpt.Location = new System.Drawing.Point(0, 27);
            this.pnlCustomerRpt.Name = "pnlCustomerRpt";
            this.pnlCustomerRpt.Size = new System.Drawing.Size(700, 500);
            this.pnlCustomerRpt.TabIndex = 4;
            // 
            // btnCustomerRptClose
            // 
            this.btnCustomerRptClose.Location = new System.Drawing.Point(591, 366);
            this.btnCustomerRptClose.Name = "btnCustomerRptClose";
            this.btnCustomerRptClose.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerRptClose.TabIndex = 8;
            this.btnCustomerRptClose.Text = "Close";
            this.btnCustomerRptClose.UseVisualStyleBackColor = true;
            this.btnCustomerRptClose.Click += new System.EventHandler(this.btnCustomerRptClose_Click);
            // 
            // frmAAMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 462);
            this.Controls.Add(this.pnlCustomerRpt);
            this.Controls.Add(this.pnlCustomerList);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlCustomer);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAAMenu";
            this.Text = "Tin Toy Administration";
            this.Load += new System.EventHandler(this.frmAAMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlCustomerList.ResumeLayout(false);
            this.pnlCustomerList.PerformLayout();
            this.gbCustomerSearch.ResumeLayout(false);
            this.gbCustomerSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerList)).EndInit();
            this.pnlCustomer.ResumeLayout(false);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.pnlProduct.ResumeLayout(false);
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.pnlCustomerRpt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.Panel pnlCustomerList;
        private System.Windows.Forms.DataGridView dgCustomerList;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnCloseCustomerList;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCloseCustomer;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gbCustomerSearch;
        private System.Windows.Forms.TextBox txtSearchCustomerPhone;
        private System.Windows.Forms.TextBox txtSearchCustomerEmail;
        private System.Windows.Forms.TextBox txtSearchCustomerLogin;
        private System.Windows.Forms.TextBox txtSearchCustomerLastName;
        private System.Windows.Forms.TextBox txtSearchCustomerFirstName;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Label lblSearchCustomerPhone;
        private System.Windows.Forms.Label lblSearchCustomerEmail;
        private System.Windows.Forms.Label lblSearchCustomerLogin;
        private System.Windows.Forms.Label lblSearchCustomerLastName;
        private System.Windows.Forms.Label lblSearchCustomerFirstName;
        private System.Windows.Forms.Button btnSearchCustomerClear;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductAvailability;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.Button btnCustomerReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptVwrCustomer;
        private System.Windows.Forms.Panel pnlCustomerRpt;
        private System.Windows.Forms.Button btnCustomerRptClose;
    }
}