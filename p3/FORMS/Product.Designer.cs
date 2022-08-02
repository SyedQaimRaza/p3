namespace p3
{
    partial class Product
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
            this.components = new System.ComponentModel.Container();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_productid = new System.Windows.Forms.TextBox();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.txt_prate = new System.Windows.Forms.TextBox();
            this.txt_munit = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.RATE = new System.Windows.Forms.Label();
            this.sRATE = new System.Windows.Forms.Label();
            this.UNIT = new System.Windows.Forms.Label();
            this.CATEGORY = new System.Windows.Forms.Label();
            this.CNAME = new System.Windows.Forms.Label();
            this.txt_srate = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productData = new p3.ProductData();
            this.btn_del = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_co = new System.Windows.Forms.ComboBox();
            this.cOMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyData = new p3.CompanyData();
            this.cmb_ca = new System.Windows.Forms.ComboBox();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryData = new p3.CategoryData();
            this.dataSETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new p3.ProductDataTableAdapters.PRODUCTTableAdapter();
            this.cATEGORYTableAdapter = new p3.CategoryDataTableAdapters.CATEGORYTableAdapter();
            this.cATEGORYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPANYTableAdapter = new p3.CompanyDataTableAdapters.COMPANYTableAdapter();
            this.fKPRODUCTPRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPRODUCTPRODUCTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKPRODUCTPRODUCTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productData1 = new p3.ProductData();
            this.pRODUCTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRODUCTPRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRODUCTPRODUCTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRODUCTPRODUCTBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_save.Location = new System.Drawing.Point(106, 222);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 32);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.ADD_Click);
            // 
            // txt_productid
            // 
            this.txt_productid.Location = new System.Drawing.Point(106, 38);
            this.txt_productid.Name = "txt_productid";
            this.txt_productid.Size = new System.Drawing.Size(58, 20);
            this.txt_productid.TabIndex = 2;
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(106, 110);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(258, 20);
            this.txt_productname.TabIndex = 3;
            // 
            // txt_prate
            // 
            this.txt_prate.Location = new System.Drawing.Point(106, 146);
            this.txt_prate.Name = "txt_prate";
            this.txt_prate.Size = new System.Drawing.Size(100, 20);
            this.txt_prate.TabIndex = 4;
            // 
            // txt_munit
            // 
            this.txt_munit.Location = new System.Drawing.Point(106, 182);
            this.txt_munit.Name = "txt_munit";
            this.txt_munit.Size = new System.Drawing.Size(100, 20);
            this.txt_munit.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(36, 42);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(64, 16);
            this.ID.TabIndex = 7;
            this.ID.Text = "ProductID";
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.NAME.Location = new System.Drawing.Point(16, 112);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(84, 16);
            this.NAME.TabIndex = 8;
            this.NAME.Text = "ProductName";
            // 
            // RATE
            // 
            this.RATE.AutoSize = true;
            this.RATE.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RATE.Location = new System.Drawing.Point(61, 148);
            this.RATE.Name = "RATE";
            this.RATE.Size = new System.Drawing.Size(39, 16);
            this.RATE.TabIndex = 9;
            this.RATE.Text = "Prate";
            // 
            // sRATE
            // 
            this.sRATE.AutoSize = true;
            this.sRATE.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sRATE.Location = new System.Drawing.Point(220, 146);
            this.sRATE.Name = "sRATE";
            this.sRATE.Size = new System.Drawing.Size(38, 16);
            this.sRATE.TabIndex = 10;
            this.sRATE.Text = "Srate";
            // 
            // UNIT
            // 
            this.UNIT.AutoSize = true;
            this.UNIT.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.UNIT.Location = new System.Drawing.Point(61, 184);
            this.UNIT.Name = "UNIT";
            this.UNIT.Size = new System.Drawing.Size(40, 16);
            this.UNIT.TabIndex = 11;
            this.UNIT.Text = "Munit";
            // 
            // CATEGORY
            // 
            this.CATEGORY.AutoSize = true;
            this.CATEGORY.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.CATEGORY.Location = new System.Drawing.Point(43, 74);
            this.CATEGORY.Name = "CATEGORY";
            this.CATEGORY.Size = new System.Drawing.Size(57, 16);
            this.CATEGORY.TabIndex = 12;
            this.CATEGORY.Text = "Category";
            // 
            // CNAME
            // 
            this.CNAME.AutoSize = true;
            this.CNAME.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.CNAME.Location = new System.Drawing.Point(170, 40);
            this.CNAME.Name = "CNAME";
            this.CNAME.Size = new System.Drawing.Size(58, 16);
            this.CNAME.TabIndex = 13;
            this.CNAME.Text = "Company";
            this.CNAME.Click += new System.EventHandler(this.CNAME_Click);
            // 
            // txt_srate
            // 
            this.txt_srate.Location = new System.Drawing.Point(264, 146);
            this.txt_srate.Name = "txt_srate";
            this.txt_srate.Size = new System.Drawing.Size(100, 20);
            this.txt_srate.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.CategoryName,
            this.CompanyName,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.pRODUCTBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(370, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 180);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.productData;
            // 
            // productData
            // 
            this.productData.DataSetName = "ProductData";
            this.productData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_del.Location = new System.Drawing.Point(248, 225);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(104, 29);
            this.btn_del.TabIndex = 17;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(446, 38);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(280, 22);
            this.txt_search.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(732, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_co
            // 
            this.cmb_co.DataSource = this.cOMPANYBindingSource;
            this.cmb_co.DisplayMember = "CompanyName";
            this.cmb_co.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_co.FormattingEnabled = true;
            this.cmb_co.Location = new System.Drawing.Point(227, 37);
            this.cmb_co.Name = "cmb_co";
            this.cmb_co.Size = new System.Drawing.Size(137, 21);
            this.cmb_co.TabIndex = 20;
            this.cmb_co.ValueMember = "CompanyID";
            // 
            // cOMPANYBindingSource
            // 
            this.cOMPANYBindingSource.DataMember = "COMPANY";
            this.cOMPANYBindingSource.DataSource = this.companyDataBindingSource;
            // 
            // companyDataBindingSource
            // 
            this.companyDataBindingSource.DataSource = this.companyData;
            this.companyDataBindingSource.Position = 0;
            // 
            // companyData
            // 
            this.companyData.DataSetName = "CompanyData";
            this.companyData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_ca
            // 
            this.cmb_ca.DataSource = this.cATEGORYBindingSource;
            this.cmb_ca.DisplayMember = "CategoryName";
            this.cmb_ca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ca.FormattingEnabled = true;
            this.cmb_ca.Location = new System.Drawing.Point(106, 74);
            this.cmb_ca.Name = "cmb_ca";
            this.cmb_ca.Size = new System.Drawing.Size(258, 21);
            this.cmb_ca.TabIndex = 21;
            this.cmb_ca.ValueMember = "CategoryID";
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.categoryDataBindingSource;
            // 
            // categoryDataBindingSource
            // 
            this.categoryDataBindingSource.DataSource = this.categoryData;
            this.categoryDataBindingSource.Position = 0;
            // 
            // categoryData
            // 
            this.categoryData.DataSetName = "CategoryData";
            this.categoryData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // cATEGORYTableAdapter
            // 
            this.cATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // cATEGORYBindingSource1
            // 
            this.cATEGORYBindingSource1.DataMember = "CATEGORY";
            this.cATEGORYBindingSource1.DataSource = this.categoryDataBindingSource;
            // 
            // cOMPANYTableAdapter
            // 
            this.cOMPANYTableAdapter.ClearBeforeFill = true;
            // 
            // fKPRODUCTPRODUCTBindingSource
            // 
            this.fKPRODUCTPRODUCTBindingSource.DataMember = "FK_PRODUCT_PRODUCT";
            this.fKPRODUCTPRODUCTBindingSource.DataSource = this.pRODUCTBindingSource;
            // 
            // fKPRODUCTPRODUCTBindingSource1
            // 
            this.fKPRODUCTPRODUCTBindingSource1.DataMember = "FK_PRODUCT_PRODUCT";
            this.fKPRODUCTPRODUCTBindingSource1.DataSource = this.fKPRODUCTPRODUCTBindingSource;
            // 
            // fKPRODUCTPRODUCTBindingSource2
            // 
            this.fKPRODUCTPRODUCTBindingSource2.DataMember = "FK_PRODUCT_PRODUCT";
            this.fKPRODUCTPRODUCTBindingSource2.DataSource = this.fKPRODUCTPRODUCTBindingSource1;
            // 
            // productData1
            // 
            this.productData1.DataSetName = "ProductData";
            this.productData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTBindingSource1
            // 
            this.pRODUCTBindingSource1.DataMember = "PRODUCT";
            this.pRODUCTBindingSource1.DataSource = this.productData1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "P_RATE";
            this.dataGridViewTextBoxColumn3.HeaderText = "P_RATE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "S_RATE";
            this.dataGridViewTextBoxColumn4.HeaderText = "S_RATE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "categoryID";
            this.dataGridViewTextBoxColumn5.HeaderText = "categoryID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CompanyID";
            this.dataGridViewTextBoxColumn6.HeaderText = "CompanyID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(902, 329);
            this.Controls.Add(this.cmb_ca);
            this.Controls.Add(this.cmb_co);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_srate);
            this.Controls.Add(this.CNAME);
            this.Controls.Add(this.CATEGORY);
            this.Controls.Add(this.UNIT);
            this.Controls.Add(this.sRATE);
            this.Controls.Add(this.RATE);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txt_munit);
            this.Controls.Add(this.txt_prate);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.txt_productid);
            this.Controls.Add(this.btn_save);
            this.Name = "Product";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRODUCTPRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRODUCTPRODUCTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRODUCTPRODUCTBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_productid;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.TextBox txt_prate;
        private System.Windows.Forms.TextBox txt_munit;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Label RATE;
        private System.Windows.Forms.Label sRATE;
        private System.Windows.Forms.Label UNIT;
        private System.Windows.Forms.Label CATEGORY;
        private System.Windows.Forms.Label CNAME;
        private System.Windows.Forms.TextBox txt_srate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_co;
        private System.Windows.Forms.ComboBox cmb_ca;
        private System.Windows.Forms.BindingSource dataSETBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUNITDataGridViewTextBoxColumn;
        private ProductData productData;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private ProductDataTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private CategoryData categoryData;
        private System.Windows.Forms.BindingSource categoryDataBindingSource;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private CategoryDataTableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource1;
        private CompanyData companyData;
        private System.Windows.Forms.BindingSource companyDataBindingSource;
        private System.Windows.Forms.BindingSource cOMPANYBindingSource;
        private CompanyDataTableAdapters.COMPANYTableAdapter cOMPANYTableAdapter;
        private System.Windows.Forms.BindingSource fKPRODUCTPRODUCTBindingSource;
        private System.Windows.Forms.BindingSource fKPRODUCTPRODUCTBindingSource1;
        private System.Windows.Forms.BindingSource fKPRODUCTPRODUCTBindingSource2;
        private ProductData productData1;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

