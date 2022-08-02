using System;

using System.Data;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace p3
{
    public partial class Product : Form
    {
       static string ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=PROJECT;Integrated Security=True";
        SqlConnection Con = new SqlConnection(ConnectionString);
        public Product()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
                    Con.Open();
            try
            {
                if (btn_save.Text == "Save" || btn_save.Text == "Update")
                {

                    string Query = "insert into product (productid,productname,p_rate,s_rate,m_unit,CompanyID,categoryID) values(" + txt_productid.Text + ",'" + txt_productname.Text + "'," + txt_prate.Text + "," + txt_srate.Text + ",'" + txt_munit.Text + "'," + cmb_co.SelectedValue.ToString() + "," + cmb_ca.SelectedValue.ToString() + ")";

                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Has been save", "MESSAGE");
                    this.pRODUCTTableAdapter.Fill(this.productData.PRODUCT);
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "Data has not Saved");
            }
                    Con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productData1.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.productData1.PRODUCT);
            // TODO: This line of code loads data into the 'productData.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.productData.PRODUCT);
            // TODO: This line of code loads data into the 'productData.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.productData.PRODUCT);
            // TODO: This line of code loads data into the 'productData.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.productData.PRODUCT);
            // TODO: This line of code loads data into the 'companyData.COMPANY' table. You can move, or remove it, as needed.
            this.cOMPANYTableAdapter.Fill(this.companyData.COMPANY);
            // TODO: This line of code loads data into the 'categoryData.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.categoryData.CATEGORY);
            // TODO: This line of code loads data into the 'productData.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.productData.PRODUCT);


        }

        private void btn_del_Click(object sender, EventArgs e)
        {
                Con.Open();
            try
            {


                string Query = "delete from product where productid=" + txt_productid.Text;
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been Delete","MESSAGE");
                this.pRODUCTTableAdapter.Fill(this.productData.PRODUCT);

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "Data has not Deleted");
            }

                Con.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.pRODUCTBindingSource.Filter= "productname like '" + txt_search.Text + "%'";
            this.pRODUCTTableAdapter.Fill(this.productData.PRODUCT);

        }

       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                txt_productid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_productname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                            cmb_co.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cmb_ca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
              
                txt_srate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_prate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
               // txt_munit.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
    
                btn_save.Text = "Update";
                btn_del.Enabled = true;
            }
        }

        private void CNAME_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
