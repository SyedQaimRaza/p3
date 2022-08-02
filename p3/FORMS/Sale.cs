using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p3
{
    public partial class Sale : Form
    {
        private Label lbl_Amount;
        private Button btn_Snew;
        private Button button2;
        private DataGridView dataGridView1;
        private Button btn_Sreset;
        private Button btn_Sdelete;
        private TextBox txt_Stamount;
        private TextBox txt_Samount;
        private TextBox txt_Stqty;
        private TextBox txt_Srate;
        private TextBox txt_Sqty;
        private TextBox txt_Smunit;
        private Label label6;
        private TextBox txt_Sproductid;
        private Label lbl_prate;
        private Label lbl_qty;
        private Label lbl_total;
        private Label lbl_munit;
        private Label lbl_priductid;
        private Label lab_pcode;
        private TextBox txt_Sproductname;
        private TextBox txt_Sparty;
        private TextBox txt_Sbillno;
        private Label label1;
        private TextBox txt_Spartyid;
        private DateTimePicker date1;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private SaleDetail saleDetail;
        private BindingSource saleDetaillBindingSource;
        private IContainer components;
        private SaleDetailTableAdapters.SaleDetaillTableAdapter saleDetaillTableAdapter;
        private DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn munitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private Button btn_Ssave;

        public Sale()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.btn_Snew = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Sreset = new System.Windows.Forms.Button();
            this.btn_Sdelete = new System.Windows.Forms.Button();
            this.txt_Stamount = new System.Windows.Forms.TextBox();
            this.txt_Samount = new System.Windows.Forms.TextBox();
            this.txt_Stqty = new System.Windows.Forms.TextBox();
            this.txt_Srate = new System.Windows.Forms.TextBox();
            this.txt_Sqty = new System.Windows.Forms.TextBox();
            this.txt_Smunit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Sproductid = new System.Windows.Forms.TextBox();
            this.lbl_prate = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_munit = new System.Windows.Forms.Label();
            this.lbl_priductid = new System.Windows.Forms.Label();
            this.lab_pcode = new System.Windows.Forms.Label();
            this.txt_Sproductname = new System.Windows.Forms.TextBox();
            this.btn_Ssave = new System.Windows.Forms.Button();
            this.txt_Sparty = new System.Windows.Forms.TextBox();
            this.txt_Sbillno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Spartyid = new System.Windows.Forms.TextBox();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saleDetail = new p3.SaleDetail();
            this.saleDetaillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleDetaillTableAdapter = new p3.SaleDetailTableAdapters.SaleDetaillTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetaillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_Amount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Amount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Amount.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lbl_Amount.Location = new System.Drawing.Point(597, 382);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(90, 26);
            this.lbl_Amount.TabIndex = 44;
            this.lbl_Amount.Text = "Amount";
            this.lbl_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Amount.Click += new System.EventHandler(this.lbl_Amount_Click);
            // 
            // btn_Snew
            // 
            this.btn_Snew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Snew.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Snew.Location = new System.Drawing.Point(6, 376);
            this.btn_Snew.Name = "btn_Snew";
            this.btn_Snew.Size = new System.Drawing.Size(78, 37);
            this.btn_Snew.TabIndex = 43;
            this.btn_Snew.Text = "New";
            this.btn_Snew.UseVisualStyleBackColor = false;
            this.btn_Snew.Click += new System.EventHandler(this.btn_Snew_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 20);
            this.button2.TabIndex = 42;
            this.button2.Text = "--";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.munitDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.saleRateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.saleDetaillBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(788, 193);
            this.dataGridView1.TabIndex = 41;
            // 
            // btn_Sreset
            // 
            this.btn_Sreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Sreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sreset.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sreset.ForeColor = System.Drawing.Color.Black;
            this.btn_Sreset.Location = new System.Drawing.Point(261, 376);
            this.btn_Sreset.Name = "btn_Sreset";
            this.btn_Sreset.Size = new System.Drawing.Size(75, 37);
            this.btn_Sreset.TabIndex = 40;
            this.btn_Sreset.Text = "Reset";
            this.btn_Sreset.UseVisualStyleBackColor = false;
            this.btn_Sreset.Click += new System.EventHandler(this.btn_Sreset_Click);
            // 
            // btn_Sdelete
            // 
            this.btn_Sdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Sdelete.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Sdelete.Location = new System.Drawing.Point(180, 375);
            this.btn_Sdelete.Name = "btn_Sdelete";
            this.btn_Sdelete.Size = new System.Drawing.Size(75, 38);
            this.btn_Sdelete.TabIndex = 39;
            this.btn_Sdelete.Text = "Delete";
            this.btn_Sdelete.UseVisualStyleBackColor = false;
            this.btn_Sdelete.Click += new System.EventHandler(this.btn_Sdelete_Click);
            // 
            // txt_Stamount
            // 
            this.txt_Stamount.Location = new System.Drawing.Point(693, 383);
            this.txt_Stamount.Multiline = true;
            this.txt_Stamount.Name = "txt_Stamount";
            this.txt_Stamount.Size = new System.Drawing.Size(101, 25);
            this.txt_Stamount.TabIndex = 38;
            // 
            // txt_Samount
            // 
            this.txt_Samount.Enabled = false;
            this.txt_Samount.Location = new System.Drawing.Point(674, 149);
            this.txt_Samount.Name = "txt_Samount";
            this.txt_Samount.Size = new System.Drawing.Size(93, 20);
            this.txt_Samount.TabIndex = 37;
            // 
            // txt_Stqty
            // 
            this.txt_Stqty.Location = new System.Drawing.Point(484, 382);
            this.txt_Stqty.Multiline = true;
            this.txt_Stqty.Name = "txt_Stqty";
            this.txt_Stqty.Size = new System.Drawing.Size(101, 25);
            this.txt_Stqty.TabIndex = 35;
            // 
            // txt_Srate
            // 
            this.txt_Srate.Location = new System.Drawing.Point(574, 149);
            this.txt_Srate.Name = "txt_Srate";
            this.txt_Srate.Size = new System.Drawing.Size(88, 20);
            this.txt_Srate.TabIndex = 36;
            this.txt_Srate.Text = "0";
            // 
            // txt_Sqty
            // 
            this.txt_Sqty.Location = new System.Drawing.Point(480, 148);
            this.txt_Sqty.Name = "txt_Sqty";
            this.txt_Sqty.Size = new System.Drawing.Size(88, 20);
            this.txt_Sqty.TabIndex = 34;
            this.txt_Sqty.Text = "0";
            // 
            // txt_Smunit
            // 
            this.txt_Smunit.Location = new System.Drawing.Point(385, 148);
            this.txt_Smunit.Name = "txt_Smunit";
            this.txt_Smunit.Size = new System.Drawing.Size(89, 20);
            this.txt_Smunit.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(662, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Sproductid
            // 
            this.txt_Sproductid.Location = new System.Drawing.Point(43, 148);
            this.txt_Sproductid.Name = "txt_Sproductid";
            this.txt_Sproductid.Size = new System.Drawing.Size(73, 20);
            this.txt_Sproductid.TabIndex = 32;
            // 
            // lbl_prate
            // 
            this.lbl_prate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_prate.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lbl_prate.Location = new System.Drawing.Point(560, 123);
            this.lbl_prate.Name = "lbl_prate";
            this.lbl_prate.Size = new System.Drawing.Size(107, 19);
            this.lbl_prate.TabIndex = 30;
            this.lbl_prate.Text = "Rate";
            this.lbl_prate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_qty
            // 
            this.lbl_qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_qty.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lbl_qty.Location = new System.Drawing.Point(470, 123);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(98, 19);
            this.lbl_qty.TabIndex = 29;
            this.lbl_qty.Text = "Quantity";
            this.lbl_qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total
            // 
            this.lbl_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_total.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_total.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lbl_total.Location = new System.Drawing.Point(380, 383);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(101, 24);
            this.lbl_total.TabIndex = 28;
            this.lbl_total.Text = "Total";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_total.Click += new System.EventHandler(this.lbl_total_Click);
            // 
            // lbl_munit
            // 
            this.lbl_munit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_munit.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lbl_munit.Location = new System.Drawing.Point(385, 123);
            this.lbl_munit.Name = "lbl_munit";
            this.lbl_munit.Size = new System.Drawing.Size(101, 19);
            this.lbl_munit.TabIndex = 27;
            this.lbl_munit.Text = "Munit";
            this.lbl_munit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_priductid
            // 
            this.lbl_priductid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_priductid.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lbl_priductid.Location = new System.Drawing.Point(139, 123);
            this.lbl_priductid.Name = "lbl_priductid";
            this.lbl_priductid.Size = new System.Drawing.Size(258, 19);
            this.lbl_priductid.TabIndex = 26;
            this.lbl_priductid.Text = "Product Name";
            // 
            // lab_pcode
            // 
            this.lab_pcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lab_pcode.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pcode.Location = new System.Drawing.Point(12, 123);
            this.lab_pcode.Name = "lab_pcode";
            this.lab_pcode.Size = new System.Drawing.Size(135, 19);
            this.lab_pcode.TabIndex = 25;
            this.lab_pcode.Text = "ProductID";
            this.lab_pcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Sproductname
            // 
            this.txt_Sproductname.Location = new System.Drawing.Point(120, 148);
            this.txt_Sproductname.Name = "txt_Sproductname";
            this.txt_Sproductname.Size = new System.Drawing.Size(259, 20);
            this.txt_Sproductname.TabIndex = 24;
            // 
            // btn_Ssave
            // 
            this.btn_Ssave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Ssave.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Ssave.Location = new System.Drawing.Point(90, 375);
            this.btn_Ssave.Name = "btn_Ssave";
            this.btn_Ssave.Size = new System.Drawing.Size(84, 38);
            this.btn_Ssave.TabIndex = 23;
            this.btn_Ssave.Text = "Save";
            this.btn_Ssave.UseVisualStyleBackColor = false;
            this.btn_Ssave.Click += new System.EventHandler(this.btn_Ssave_Click);
            // 
            // txt_Sparty
            // 
            this.txt_Sparty.Location = new System.Drawing.Point(114, 57);
            this.txt_Sparty.Name = "txt_Sparty";
            this.txt_Sparty.Size = new System.Drawing.Size(253, 20);
            this.txt_Sparty.TabIndex = 53;
            // 
            // txt_Sbillno
            // 
            this.txt_Sbillno.Location = new System.Drawing.Point(114, 19);
            this.txt_Sbillno.Name = "txt_Sbillno";
            this.txt_Sbillno.Size = new System.Drawing.Size(99, 20);
            this.txt_Sbillno.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(53, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "BillNo";
            // 
            // txt_Spartyid
            // 
            this.txt_Spartyid.Location = new System.Drawing.Point(282, 19);
            this.txt_Spartyid.Name = "txt_Spartyid";
            this.txt_Spartyid.Size = new System.Drawing.Size(85, 20);
            this.txt_Spartyid.TabIndex = 45;
            // 
            // date1
            // 
            this.date1.CustomFormat = "dd-MMM-yyyy";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(673, 16);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(103, 20);
            this.date1.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(612, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Party Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(219, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "PartyID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date1);
            this.groupBox1.Controls.Add(this.txt_Sparty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Spartyid);
            this.groupBox1.Controls.Add(this.txt_Sbillno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 100);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
           
            // 
            // saleDetail
            // 
            this.saleDetail.DataSetName = "SaleDetail";
            this.saleDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleDetaillBindingSource
            // 
            this.saleDetaillBindingSource.DataMember = "SaleDetaill";
            this.saleDetaillBindingSource.DataSource = this.saleDetail;
            // 
            // saleDetaillTableAdapter
            // 
            this.saleDetaillTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // munitDataGridViewTextBoxColumn
            // 
            this.munitDataGridViewTextBoxColumn.DataPropertyName = "Munit";
            this.munitDataGridViewTextBoxColumn.HeaderText = "Munit";
            this.munitDataGridViewTextBoxColumn.Name = "munitDataGridViewTextBoxColumn";
            this.munitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleRateDataGridViewTextBoxColumn
            // 
            this.saleRateDataGridViewTextBoxColumn.DataPropertyName = "SaleRate";
            this.saleRateDataGridViewTextBoxColumn.HeaderText = "SaleRate";
            this.saleRateDataGridViewTextBoxColumn.Name = "saleRateDataGridViewTextBoxColumn";
            this.saleRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Sale
            // 
            this.ClientSize = new System.Drawing.Size(803, 425);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.btn_Snew);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Sreset);
            this.Controls.Add(this.btn_Sdelete);
            this.Controls.Add(this.txt_Stamount);
            this.Controls.Add(this.txt_Samount);
            this.Controls.Add(this.txt_Stqty);
            this.Controls.Add(this.txt_Srate);
            this.Controls.Add(this.txt_Sqty);
            this.Controls.Add(this.txt_Smunit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Sproductid);
            this.Controls.Add(this.lbl_prate);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_munit);
            this.Controls.Add(this.lbl_priductid);
            this.Controls.Add(this.lab_pcode);
            this.Controls.Add(this.txt_Sproductname);
            this.Controls.Add(this.btn_Ssave);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetaillBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private void Sale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleDetail.SaleDetaill' table. You can move, or remove it, as needed.
            this.saleDetaillTableAdapter.Fill(this.saleDetail.SaleDetaill);

        }

        private void btn_Ssave_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sdelete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sreset_Click(object sender, EventArgs e)
        {

        }

        private void btn_Snew_Click(object sender, EventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Amount_Click(object sender, EventArgs e)
        {

        }
    }
}
