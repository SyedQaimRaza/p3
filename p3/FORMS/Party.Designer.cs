namespace p3
{
    partial class Party
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
            this.btn_del = new System.Windows.Forms.Button();
            this.Sale = new System.Windows.Forms.Label();
            this.sRATE = new System.Windows.Forms.Label();
            this.RATE = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.txt_partyaddress = new System.Windows.Forms.TextBox();
            this.txt_partyname = new System.Windows.Forms.TextBox();
            this.txt_partyid = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.DG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pARTIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partyData = new p3.PartyData();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.salecheck = new System.Windows.Forms.CheckBox();
            this.purchasecheck = new System.Windows.Forms.CheckBox();
            this.search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pARTIESTableAdapter = new p3.PartyDataTableAdapters.PARTIESTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyData)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(257, 205);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(82, 31);
            this.btn_del.TabIndex = 33;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Sale
            // 
            this.Sale.AutoSize = true;
            this.Sale.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sale.Location = new System.Drawing.Point(121, 168);
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(32, 16);
            this.Sale.TabIndex = 28;
            this.Sale.Text = "Sale";
            // 
            // sRATE
            // 
            this.sRATE.AutoSize = true;
            this.sRATE.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sRATE.Location = new System.Drawing.Point(199, 170);
            this.sRATE.Name = "sRATE";
            this.sRATE.Size = new System.Drawing.Size(62, 16);
            this.sRATE.TabIndex = 27;
            this.sRATE.Text = "Purchase";
            // 
            // RATE
            // 
            this.RATE.AutoSize = true;
            this.RATE.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.RATE.Location = new System.Drawing.Point(10, 123);
            this.RATE.Name = "RATE";
            this.RATE.Size = new System.Drawing.Size(80, 16);
            this.RATE.TabIndex = 26;
            this.RATE.Text = "PartyAddress";
            this.RATE.Click += new System.EventHandler(this.RATE_Click);
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.NAME.Location = new System.Drawing.Point(23, 86);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(69, 16);
            this.NAME.TabIndex = 25;
            this.NAME.Text = "PartyName";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.ID.Location = new System.Drawing.Point(43, 46);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(49, 16);
            this.ID.TabIndex = 24;
            this.ID.Text = "PartyID";
            // 
            // txt_partyaddress
            // 
            this.txt_partyaddress.Location = new System.Drawing.Point(98, 123);
            this.txt_partyaddress.Name = "txt_partyaddress";
            this.txt_partyaddress.Size = new System.Drawing.Size(258, 20);
            this.txt_partyaddress.TabIndex = 21;
            // 
            // txt_partyname
            // 
            this.txt_partyname.Location = new System.Drawing.Point(98, 85);
            this.txt_partyname.Name = "txt_partyname";
            this.txt_partyname.Size = new System.Drawing.Size(258, 20);
            this.txt_partyname.TabIndex = 20;
            // 
            // txt_partyid
            // 
            this.txt_partyid.Location = new System.Drawing.Point(98, 44);
            this.txt_partyid.Name = "txt_partyid";
            this.txt_partyid.Size = new System.Drawing.Size(58, 20);
            this.txt_partyid.TabIndex = 19;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(155, 205);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(83, 31);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = " Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // DG
            // 
            this.DG.AllowUserToAddRows = false;
            this.DG.AutoGenerateColumns = false;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2});
            this.DG.DataSource = this.pARTIESBindingSource;
            this.DG.Location = new System.Drawing.Point(362, 86);
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.Size = new System.Drawing.Size(515, 155);
            this.DG.TabIndex = 34;
            this.DG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DG.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PARTY_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PARTY_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PARTY_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "PARTY_NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PARTY_ADDRESS";
            this.dataGridViewTextBoxColumn3.HeaderText = "PARTY_ADDRESS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PHONE";
            this.dataGridViewTextBoxColumn4.HeaderText = "PHONE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "PURCHASE";
            this.dataGridViewCheckBoxColumn1.HeaderText = "PURCHASE";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "SALE";
            this.dataGridViewCheckBoxColumn2.HeaderText = "SALE";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // pARTIESBindingSource
            // 
            this.pARTIESBindingSource.DataMember = "PARTIES";
            this.pARTIESBindingSource.DataSource = this.partyData;
            // 
            // partyData
            // 
            this.partyData.DataSetName = "PartyData";
            this.partyData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Phone";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(240, 47);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(116, 20);
            this.txt_phone.TabIndex = 36;
            // 
            // salecheck
            // 
            this.salecheck.AutoSize = true;
            this.salecheck.Location = new System.Drawing.Point(166, 168);
            this.salecheck.Name = "salecheck";
            this.salecheck.Size = new System.Drawing.Size(15, 14);
            this.salecheck.TabIndex = 37;
            this.salecheck.UseVisualStyleBackColor = true;
            this.salecheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // purchasecheck
            // 
            this.purchasecheck.AutoSize = true;
            this.purchasecheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasecheck.Location = new System.Drawing.Point(267, 170);
            this.purchasecheck.Name = "purchasecheck";
            this.purchasecheck.Size = new System.Drawing.Size(15, 14);
            this.purchasecheck.TabIndex = 38;
            this.purchasecheck.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(389, 53);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(297, 22);
            this.search.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(692, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 27);
            this.button1.TabIndex = 40;
            this.button1.Text = "Search ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pARTIESTableAdapter
            // 
            this.pARTIESTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(57, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 31);
            this.button2.TabIndex = 41;
            this.button2.Text = "Add New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Party
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(889, 287);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.purchasecheck);
            this.Controls.Add(this.salecheck);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.Sale);
            this.Controls.Add(this.sRATE);
            this.Controls.Add(this.RATE);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txt_partyaddress);
            this.Controls.Add(this.txt_partyname);
            this.Controls.Add(this.txt_partyid);
            this.Controls.Add(this.btn_save);
            this.Name = "Party";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label Sale;
        private System.Windows.Forms.Label sRATE;
        private System.Windows.Forms.Label RATE;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txt_partyaddress;
        private System.Windows.Forms.TextBox txt_partyname;
        private System.Windows.Forms.TextBox txt_partyid;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.CheckBox salecheck;
        private System.Windows.Forms.CheckBox purchasecheck;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARTYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARTYNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARTYADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pURCHASEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sALEDataGridViewCheckBoxColumn;
        private PartyData partyData;
        private System.Windows.Forms.BindingSource pARTIESBindingSource;
        private PartyDataTableAdapters.PARTIESTableAdapter pARTIESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.Button button2;
    }
}