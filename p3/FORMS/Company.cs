using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace p3
{
    public partial class Company : Form
    {
        static string ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=PROJECT;Integrated Security=True";
        SqlConnection Con = new SqlConnection(ConnectionString);
        public Company()
        {
            InitializeComponent();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyData.COMPANY' table. You can move, or remove it, as needed.
            this.cOMPANYTableAdapter.Fill(this.companyData.COMPANY);
           


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
                Con.Open();
           if (button1.Text == "Cancel" || btn_save.Text=="Update" || btn_save.Text=="Save")
            {
                try
                {
                    string query = "insert into company (companyid,companyname) values(" + txt_id.Text + ",'" + txt_name.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been added", "Message");
                    this.cOMPANYTableAdapter.Fill(this.companyData.COMPANY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Failed to add");
                }
            }
                Con.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
                Con.Open();
            try
            {
                string query = "delete from company where companyid="+ txt_id.Text ;
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
               
                MessageBox.Show("Data has been deleted", "Message");
                this.cOMPANYTableAdapter.Fill(this.companyData.COMPANY);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to delete");
            }
                Con.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
           
            txt_name.Clear();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.cOMPANYBindingSource.Filter = "compnayname like '" + search.Text + "%'";
                this.cOMPANYTableAdapter.Fill(this.companyData.COMPANY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Add")
            {
                txt_id.Text = p3.MainFunction.GetMaxId("SELECT ISNULL(MAX(CompanyID),0) AS ID FROM COMPANY").ToString();
                button1.Text = "Cancel";
            }

        }
    }
}
