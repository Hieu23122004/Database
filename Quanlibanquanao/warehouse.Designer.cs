namespace Quanlibanquanao
{
    partial class warehouse
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
            this.btn = new System.Windows.Forms.TabControl();
            this.product = new System.Windows.Forms.TabPage();
            this.groupBoxProduct1 = new System.Windows.Forms.GroupBox();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnimage = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbcolor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtimageData = new System.Windows.Forms.TextBox();
            this.txtproductName = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtstockQuantity = new System.Windows.Forms.TextBox();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.groupboxFilter = new System.Windows.Forms.GroupBox();
            this.txtminPrice = new System.Windows.Forms.TextBox();
            this.btnfilter = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtmaxPrice = new System.Windows.Forms.TextBox();
            this.txtcategory1 = new System.Windows.Forms.TextBox();
            this.groupboxImageProduct = new System.Windows.Forms.GroupBox();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.groupboxproduct = new System.Windows.Forms.GroupBox();
            this.btnexitProduct = new System.Windows.Forms.Button();
            this.btneditproduct = new System.Windows.Forms.Button();
            this.btncreateProduct = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtproductId = new System.Windows.Forms.TextBox();
            this.btnsearchProduct = new System.Windows.Forms.Button();
            this.btndeleteProduct = new System.Windows.Forms.Button();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.orderDetails = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnexitOrderDetails = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.txtorderDetailId = new System.Windows.Forms.TextBox();
            this.btnsearchOrderDetailId = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.dgvorderDetails = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtpassword1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnupdatepw = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnexitPassword1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusername1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnewPassword = new System.Windows.Forms.TextBox();
            this.txtconfirmpw = new System.Windows.Forms.TextBox();
            this.btn.SuspendLayout();
            this.product.SuspendLayout();
            this.groupBoxProduct1.SuspendLayout();
            this.groupboxFilter.SuspendLayout();
            this.groupboxImageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.groupboxproduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            this.orderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderDetails)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Controls.Add(this.product);
            this.btn.Controls.Add(this.orderDetails);
            this.btn.Controls.Add(this.tabPage1);
            this.btn.Location = new System.Drawing.Point(2, 1);
            this.btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn.Name = "btn";
            this.btn.SelectedIndex = 0;
            this.btn.Size = new System.Drawing.Size(782, 413);
            this.btn.TabIndex = 2;
            // 
            // product
            // 
            this.product.Controls.Add(this.groupBoxProduct1);
            this.product.Controls.Add(this.groupboxFilter);
            this.product.Controls.Add(this.groupboxImageProduct);
            this.product.Controls.Add(this.groupboxproduct);
            this.product.Controls.Add(this.dgvproduct);
            this.product.Controls.Add(this.label6);
            this.product.Location = new System.Drawing.Point(4, 22);
            this.product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.product.Name = "product";
            this.product.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.product.Size = new System.Drawing.Size(774, 387);
            this.product.TabIndex = 1;
            this.product.Text = "Product";
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click_1);
            // 
            // groupBoxProduct1
            // 
            this.groupBoxProduct1.Controls.Add(this.txtcategory);
            this.groupBoxProduct1.Controls.Add(this.label20);
            this.groupBoxProduct1.Controls.Add(this.label19);
            this.groupBoxProduct1.Controls.Add(this.label18);
            this.groupBoxProduct1.Controls.Add(this.btnimage);
            this.groupBoxProduct1.Controls.Add(this.label16);
            this.groupBoxProduct1.Controls.Add(this.label15);
            this.groupBoxProduct1.Controls.Add(this.cbbcolor);
            this.groupBoxProduct1.Controls.Add(this.label14);
            this.groupBoxProduct1.Controls.Add(this.txtprice);
            this.groupBoxProduct1.Controls.Add(this.label13);
            this.groupBoxProduct1.Controls.Add(this.txtimageData);
            this.groupBoxProduct1.Controls.Add(this.txtproductName);
            this.groupBoxProduct1.Controls.Add(this.txtdescription);
            this.groupBoxProduct1.Controls.Add(this.txtstockQuantity);
            this.groupBoxProduct1.Controls.Add(this.txtsize);
            this.groupBoxProduct1.Location = new System.Drawing.Point(7, 9);
            this.groupBoxProduct1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxProduct1.Name = "groupBoxProduct1";
            this.groupBoxProduct1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxProduct1.Size = new System.Drawing.Size(463, 140);
            this.groupBoxProduct1.TabIndex = 32;
            this.groupBoxProduct1.TabStop = false;
            this.groupBoxProduct1.Text = "Infomation";
            // 
            // txtcategory
            // 
            this.txtcategory.Location = new System.Drawing.Point(99, 51);
            this.txtcategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(120, 20);
            this.txtcategory.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 22);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Product Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 55);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Category";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(241, 21);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Price";
            // 
            // btnimage
            // 
            this.btnimage.Location = new System.Drawing.Point(243, 112);
            this.btnimage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnimage.Name = "btnimage";
            this.btnimage.Size = new System.Drawing.Size(50, 20);
            this.btnimage.TabIndex = 23;
            this.btnimage.Text = "Image Data";
            this.btnimage.UseVisualStyleBackColor = true;
            this.btnimage.Click += new System.EventHandler(this.btnimage_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(241, 53);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Stock Quantity";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 85);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Size";
            // 
            // cbbcolor
            // 
            this.cbbcolor.AutoCompleteCustomSource.AddRange(new string[] {
            "Emerald Green",
            "Lavender",
            "Rose Gold",
            "Midnight Blue",
            "Coral",
            "Peach",
            "Mustard Yellow",
            "Teal",
            "Burgundy",
            "Mint Green"});
            this.cbbcolor.FormattingEnabled = true;
            this.cbbcolor.Items.AddRange(new object[] {
            "Emerald Green",
            "Lavender",
            "Rose Gold",
            "Midnight Blue",
            "Coral",
            "Peach",
            "Mustard Yellow",
            "Teal",
            "Burgundy",
            "Mint Green"});
            this.cbbcolor.Location = new System.Drawing.Point(99, 114);
            this.cbbcolor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbcolor.Name = "cbbcolor";
            this.cbbcolor.Size = new System.Drawing.Size(120, 21);
            this.cbbcolor.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(241, 84);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Description";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(330, 16);
            this.txtprice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(120, 20);
            this.txtprice.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 120);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Color";
            // 
            // txtimageData
            // 
            this.txtimageData.Location = new System.Drawing.Point(330, 113);
            this.txtimageData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtimageData.Name = "txtimageData";
            this.txtimageData.Size = new System.Drawing.Size(120, 20);
            this.txtimageData.TabIndex = 17;
            // 
            // txtproductName
            // 
            this.txtproductName.Location = new System.Drawing.Point(99, 18);
            this.txtproductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtproductName.Name = "txtproductName";
            this.txtproductName.Size = new System.Drawing.Size(120, 20);
            this.txtproductName.TabIndex = 14;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(330, 80);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(120, 20);
            this.txtdescription.TabIndex = 17;
            // 
            // txtstockQuantity
            // 
            this.txtstockQuantity.Location = new System.Drawing.Point(330, 49);
            this.txtstockQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtstockQuantity.Name = "txtstockQuantity";
            this.txtstockQuantity.Size = new System.Drawing.Size(120, 20);
            this.txtstockQuantity.TabIndex = 20;
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(99, 81);
            this.txtsize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(120, 20);
            this.txtsize.TabIndex = 16;
            // 
            // groupboxFilter
            // 
            this.groupboxFilter.Controls.Add(this.txtminPrice);
            this.groupboxFilter.Controls.Add(this.btnfilter);
            this.groupboxFilter.Controls.Add(this.label21);
            this.groupboxFilter.Controls.Add(this.label12);
            this.groupboxFilter.Controls.Add(this.label22);
            this.groupboxFilter.Controls.Add(this.txtmaxPrice);
            this.groupboxFilter.Controls.Add(this.txtcategory1);
            this.groupboxFilter.Location = new System.Drawing.Point(94, 156);
            this.groupboxFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupboxFilter.Name = "groupboxFilter";
            this.groupboxFilter.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupboxFilter.Size = new System.Drawing.Size(670, 44);
            this.groupboxFilter.TabIndex = 31;
            this.groupboxFilter.TabStop = false;
            this.groupboxFilter.Text = "Product Filter";
            // 
            // txtminPrice
            // 
            this.txtminPrice.Location = new System.Drawing.Point(282, 16);
            this.txtminPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtminPrice.Name = "txtminPrice";
            this.txtminPrice.Size = new System.Drawing.Size(90, 20);
            this.txtminPrice.TabIndex = 17;
            // 
            // btnfilter
            // 
            this.btnfilter.Location = new System.Drawing.Point(592, 15);
            this.btnfilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(50, 20);
            this.btnfilter.TabIndex = 30;
            this.btnfilter.Text = "Filter";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 20);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Category";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(219, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Min Price";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(400, 20);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "Max Price";
            // 
            // txtmaxPrice
            // 
            this.txtmaxPrice.Location = new System.Drawing.Point(463, 16);
            this.txtmaxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmaxPrice.Name = "txtmaxPrice";
            this.txtmaxPrice.Size = new System.Drawing.Size(90, 20);
            this.txtmaxPrice.TabIndex = 17;
            // 
            // txtcategory1
            // 
            this.txtcategory1.Location = new System.Drawing.Point(85, 16);
            this.txtcategory1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcategory1.Name = "txtcategory1";
            this.txtcategory1.Size = new System.Drawing.Size(107, 20);
            this.txtcategory1.TabIndex = 17;
            // 
            // groupboxImageProduct
            // 
            this.groupboxImageProduct.Controls.Add(this.pictureBoxProduct);
            this.groupboxImageProduct.Location = new System.Drawing.Point(699, 38);
            this.groupboxImageProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupboxImageProduct.Name = "groupboxImageProduct";
            this.groupboxImageProduct.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupboxImageProduct.Size = new System.Drawing.Size(66, 101);
            this.groupboxImageProduct.TabIndex = 29;
            this.groupboxImageProduct.TabStop = false;
            this.groupboxImageProduct.Text = "Image";
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Location = new System.Drawing.Point(2, 14);
            this.pictureBoxProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(63, 84);
            this.pictureBoxProduct.TabIndex = 0;
            this.pictureBoxProduct.TabStop = false;
            // 
            // groupboxproduct
            // 
            this.groupboxproduct.Controls.Add(this.btnexitProduct);
            this.groupboxproduct.Controls.Add(this.btneditproduct);
            this.groupboxproduct.Controls.Add(this.btncreateProduct);
            this.groupboxproduct.Controls.Add(this.label17);
            this.groupboxproduct.Controls.Add(this.txtproductId);
            this.groupboxproduct.Controls.Add(this.btnsearchProduct);
            this.groupboxproduct.Controls.Add(this.btndeleteProduct);
            this.groupboxproduct.Location = new System.Drawing.Point(484, 38);
            this.groupboxproduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupboxproduct.Name = "groupboxproduct";
            this.groupboxproduct.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupboxproduct.Size = new System.Drawing.Size(211, 103);
            this.groupboxproduct.TabIndex = 28;
            this.groupboxproduct.TabStop = false;
            this.groupboxproduct.Text = "Function";
            // 
            // btnexitProduct
            // 
            this.btnexitProduct.Location = new System.Drawing.Point(149, 75);
            this.btnexitProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexitProduct.Name = "btnexitProduct";
            this.btnexitProduct.Size = new System.Drawing.Size(50, 20);
            this.btnexitProduct.TabIndex = 34;
            this.btnexitProduct.Text = "Exit";
            this.btnexitProduct.UseVisualStyleBackColor = true;
            this.btnexitProduct.Click += new System.EventHandler(this.btnexitProduct_Click);
            // 
            // btneditproduct
            // 
            this.btneditproduct.Location = new System.Drawing.Point(13, 75);
            this.btneditproduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btneditproduct.Name = "btneditproduct";
            this.btneditproduct.Size = new System.Drawing.Size(50, 20);
            this.btneditproduct.TabIndex = 24;
            this.btneditproduct.Text = "Edit";
            this.btneditproduct.UseVisualStyleBackColor = true;
            this.btneditproduct.Click += new System.EventHandler(this.btneditproduct_Click);
            // 
            // btncreateProduct
            // 
            this.btncreateProduct.Location = new System.Drawing.Point(31, 46);
            this.btncreateProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncreateProduct.Name = "btncreateProduct";
            this.btncreateProduct.Size = new System.Drawing.Size(50, 20);
            this.btncreateProduct.TabIndex = 23;
            this.btncreateProduct.Text = "Create";
            this.btncreateProduct.UseVisualStyleBackColor = true;
            this.btncreateProduct.Click += new System.EventHandler(this.btncreateProduct_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 23);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Product Id";
            // 
            // txtproductId
            // 
            this.txtproductId.Location = new System.Drawing.Point(83, 21);
            this.txtproductId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtproductId.Name = "txtproductId";
            this.txtproductId.Size = new System.Drawing.Size(105, 20);
            this.txtproductId.TabIndex = 19;
            // 
            // btnsearchProduct
            // 
            this.btnsearchProduct.Location = new System.Drawing.Point(83, 75);
            this.btnsearchProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsearchProduct.Name = "btnsearchProduct";
            this.btnsearchProduct.Size = new System.Drawing.Size(50, 20);
            this.btnsearchProduct.TabIndex = 26;
            this.btnsearchProduct.Text = "Search";
            this.btnsearchProduct.UseVisualStyleBackColor = true;
            this.btnsearchProduct.Click += new System.EventHandler(this.btnsearchProduct_Click);
            // 
            // btndeleteProduct
            // 
            this.btndeleteProduct.Location = new System.Drawing.Point(107, 46);
            this.btndeleteProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndeleteProduct.Name = "btndeleteProduct";
            this.btndeleteProduct.Size = new System.Drawing.Size(50, 20);
            this.btndeleteProduct.TabIndex = 25;
            this.btndeleteProduct.Text = "Delete";
            this.btndeleteProduct.UseVisualStyleBackColor = true;
            this.btndeleteProduct.Click += new System.EventHandler(this.btndeleteProduct_Click);
            // 
            // dgvproduct
            // 
            this.dgvproduct.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Location = new System.Drawing.Point(4, 213);
            this.dgvproduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.RowHeadersWidth = 62;
            this.dgvproduct.RowTemplate.Height = 28;
            this.dgvproduct.Size = new System.Drawing.Size(763, 174);
            this.dgvproduct.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(501, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Product Management";
            // 
            // orderDetails
            // 
            this.orderDetails.Controls.Add(this.dataGridView1);
            this.orderDetails.Controls.Add(this.groupBox3);
            this.orderDetails.Controls.Add(this.label34);
            this.orderDetails.Controls.Add(this.dgvorderDetails);
            this.orderDetails.Location = new System.Drawing.Point(4, 22);
            this.orderDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.Size = new System.Drawing.Size(774, 387);
            this.orderDetails.TabIndex = 4;
            this.orderDetails.Text = "Order details";
            this.orderDetails.UseVisualStyleBackColor = true;
            this.orderDetails.Click += new System.EventHandler(this.orderDetails_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(573, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(200, 386);
            this.dataGridView1.TabIndex = 48;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnexitOrderDetails);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.txtorderDetailId);
            this.groupBox3.Controls.Add(this.btnsearchOrderDetailId);
            this.groupBox3.Location = new System.Drawing.Point(160, 9);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(409, 47);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function";
            // 
            // btnexitOrderDetails
            // 
            this.btnexitOrderDetails.Location = new System.Drawing.Point(342, 16);
            this.btnexitOrderDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexitOrderDetails.Name = "btnexitOrderDetails";
            this.btnexitOrderDetails.Size = new System.Drawing.Size(50, 20);
            this.btnexitOrderDetails.TabIndex = 48;
            this.btnexitOrderDetails.Text = "Exit";
            this.btnexitOrderDetails.UseVisualStyleBackColor = true;
            this.btnexitOrderDetails.Click += new System.EventHandler(this.btnexitOrderDetails_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 21);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(80, 13);
            this.label33.TabIndex = 6;
            this.label33.Text = "Order Details Id";
            // 
            // txtorderDetailId
            // 
            this.txtorderDetailId.Location = new System.Drawing.Point(103, 17);
            this.txtorderDetailId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtorderDetailId.Name = "txtorderDetailId";
            this.txtorderDetailId.Size = new System.Drawing.Size(157, 20);
            this.txtorderDetailId.TabIndex = 19;
            // 
            // btnsearchOrderDetailId
            // 
            this.btnsearchOrderDetailId.Location = new System.Drawing.Point(280, 16);
            this.btnsearchOrderDetailId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsearchOrderDetailId.Name = "btnsearchOrderDetailId";
            this.btnsearchOrderDetailId.Size = new System.Drawing.Size(50, 20);
            this.btnsearchOrderDetailId.TabIndex = 26;
            this.btnsearchOrderDetailId.Text = "Search";
            this.btnsearchOrderDetailId.UseVisualStyleBackColor = true;
            this.btnsearchOrderDetailId.Click += new System.EventHandler(this.btnsearchOrderDetailId_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Blue;
            this.label34.Location = new System.Drawing.Point(12, 21);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(137, 22);
            this.label34.TabIndex = 45;
            this.label34.Text = "Order Details ";
            // 
            // dgvorderDetails
            // 
            this.dgvorderDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvorderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorderDetails.Location = new System.Drawing.Point(3, 68);
            this.dgvorderDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvorderDetails.Name = "dgvorderDetails";
            this.dgvorderDetails.RowHeadersWidth = 62;
            this.dgvorderDetails.RowTemplate.Height = 28;
            this.dgvorderDetails.Size = new System.Drawing.Size(565, 319);
            this.dgvorderDetails.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(774, 387);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Update Pasword";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 46;
            this.label1.Text = "Update Password";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.txtpassword1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnupdatepw);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnexitPassword1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtusername1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtnewPassword);
            this.groupBox4.Controls.Add(this.txtconfirmpw);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(228, 94);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(321, 203);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Infomation";
            // 
            // txtpassword1
            // 
            this.txtpassword1.Location = new System.Drawing.Point(98, 62);
            this.txtpassword1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpassword1.Multiline = true;
            this.txtpassword1.Name = "txtpassword1";
            this.txtpassword1.PasswordChar = '*';
            this.txtpassword1.Size = new System.Drawing.Size(194, 20);
            this.txtpassword1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Confirm PW";
            // 
            // btnupdatepw
            // 
            this.btnupdatepw.Location = new System.Drawing.Point(175, 164);
            this.btnupdatepw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnupdatepw.Name = "btnupdatepw";
            this.btnupdatepw.Size = new System.Drawing.Size(50, 23);
            this.btnupdatepw.TabIndex = 4;
            this.btnupdatepw.Text = "Update";
            this.btnupdatepw.UseVisualStyleBackColor = true;
            this.btnupdatepw.Click += new System.EventHandler(this.btnupdatepw_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "New PW";
            // 
            // btnexitPassword1
            // 
            this.btnexitPassword1.Location = new System.Drawing.Point(241, 164);
            this.btnexitPassword1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexitPassword1.Name = "btnexitPassword1";
            this.btnexitPassword1.Size = new System.Drawing.Size(50, 23);
            this.btnexitPassword1.TabIndex = 3;
            this.btnexitPassword1.Text = "Exit";
            this.btnexitPassword1.UseVisualStyleBackColor = true;
            this.btnexitPassword1.Click += new System.EventHandler(this.btnexitPassword1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // txtusername1
            // 
            this.txtusername1.Location = new System.Drawing.Point(98, 27);
            this.txtusername1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtusername1.Multiline = true;
            this.txtusername1.Name = "txtusername1";
            this.txtusername1.Size = new System.Drawing.Size(194, 20);
            this.txtusername1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username";
            // 
            // txtnewPassword
            // 
            this.txtnewPassword.Location = new System.Drawing.Point(98, 99);
            this.txtnewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnewPassword.Multiline = true;
            this.txtnewPassword.Name = "txtnewPassword";
            this.txtnewPassword.PasswordChar = '*';
            this.txtnewPassword.Size = new System.Drawing.Size(194, 20);
            this.txtnewPassword.TabIndex = 5;
            // 
            // txtconfirmpw
            // 
            this.txtconfirmpw.Location = new System.Drawing.Point(98, 131);
            this.txtconfirmpw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtconfirmpw.Multiline = true;
            this.txtconfirmpw.Name = "txtconfirmpw";
            this.txtconfirmpw.PasswordChar = '*';
            this.txtconfirmpw.Size = new System.Drawing.Size(194, 20);
            this.txtconfirmpw.TabIndex = 5;
            // 
            // warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 413);
            this.Controls.Add(this.btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "warehouse";
            this.Text = "Home";
            this.btn.ResumeLayout(false);
            this.product.ResumeLayout(false);
            this.product.PerformLayout();
            this.groupBoxProduct1.ResumeLayout(false);
            this.groupBoxProduct1.PerformLayout();
            this.groupboxFilter.ResumeLayout(false);
            this.groupboxFilter.PerformLayout();
            this.groupboxImageProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.groupboxproduct.ResumeLayout(false);
            this.groupboxproduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.orderDetails.ResumeLayout(false);
            this.orderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderDetails)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl btn;
        private System.Windows.Forms.TabPage product;
        private System.Windows.Forms.GroupBox groupBoxProduct1;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnimage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbbcolor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtimageData;
        private System.Windows.Forms.TextBox txtproductName;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtstockQuantity;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.GroupBox groupboxFilter;
        private System.Windows.Forms.TextBox txtminPrice;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtmaxPrice;
        private System.Windows.Forms.TextBox txtcategory1;
        private System.Windows.Forms.GroupBox groupboxImageProduct;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.GroupBox groupboxproduct;
        private System.Windows.Forms.Button btnexitProduct;
        private System.Windows.Forms.Button btneditproduct;
        private System.Windows.Forms.Button btncreateProduct;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtproductId;
        private System.Windows.Forms.Button btnsearchProduct;
        private System.Windows.Forms.Button btndeleteProduct;
        private System.Windows.Forms.DataGridView dgvproduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage orderDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnexitOrderDetails;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtorderDetailId;
        private System.Windows.Forms.Button btnsearchOrderDetailId;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.DataGridView dgvorderDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtpassword1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnupdatepw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnexitPassword1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusername1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnewPassword;
        private System.Windows.Forms.TextBox txtconfirmpw;
    }
}