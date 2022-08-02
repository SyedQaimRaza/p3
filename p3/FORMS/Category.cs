using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace p3
{
    public partial class Category : Form
    {
        static string ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=PROJECT;Integrated Security=True";
        SqlConnection Con = new SqlConnection(ConnectionString);

        public Category()
        {
            InitializeComponent();
        }

      private void Category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categoryData.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.categoryData.CATEGORY);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
                Con.Open();
            if (button1.Text == "Cancel" || btn_save.Text == "Save" || btn_save.Text=="Update")
            {
                try
                {
                    string query = "delete from category where categoryid=" + CaID.Text;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    string query1 = "insert into category (categoryid,categoryname,description) values(" + CaID.Text + ",'" + txt_name.Text + "','" + txt_description.Text + "')";
                    SqlCommand cmd1 = new SqlCommand(query1, Con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Data has been added", "Message");
                    btn_save.Text = "Save";
                    button1.Text = "Add New";
                    this.cATEGORYTableAdapter.Fill(this.categoryData.CATEGORY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Failed to add");
                }
            }
                Con.Close();

 
            
 
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
                Con.Open();
            try
            {
                string query = "delete from category where categoryid="+ CaID.Text ;
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been Delete", "Message");
                btn_save.Text = "Save";
                this.cATEGORYTableAdapter.Fill(this.categoryData.CATEGORY);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to Delete");
            }
                Con.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            
            txt_name.Clear();
            txt_description.Clear();    
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.cATEGORYBindingSource.Filter = "CategoryName like '" + search.Text + "%'";
            this.cATEGORYTableAdapter.Fill(this.categoryData.CATEGORY);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                txt_name. Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                CaID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_description.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               btn_save.Text = "Update";
                btn_delete.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Add New")
            {
                CaID.Text = p3.MainFunction.GetMaxId("SELECT ISNULL(MAX(CategoryID),0) AS ID FROM CATEGORY").ToString();
                button1.Text = "Cancel";
            }
        }
    }
}
