using System;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace p3
{
    public partial class Party : Form
    {
        public Party()
        {
            InitializeComponent();
        }
           static string ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=PROJECT;Integrated Security=True";
            SqlConnection Con = new SqlConnection(ConnectionString);

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'partyData.PARTIES' table. You can move, or remove it, as needed.
            this.pARTIESTableAdapter.Fill(this.partyData.PARTIES);


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            Con.Open();
            string Query = "insert into PARTIES (PARTY_ID,PARTY_NAME,PARTY_ADDRESS,PHONE,PURCHASE,SALE) values(" + txt_partyid.Text + ",'" + txt_partyname.Text + "','" + txt_partyaddress.Text + "'," + txt_phone.Text + ",'" + salecheck.Checked + "','" + purchasecheck.Checked  +"')";

            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            this.pARTIESTableAdapter.Fill(this.partyData.PARTIES);


        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "delete from PARTIES where PARTY_ID="+ txt_partyid.Text;

            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            this.pARTIESTableAdapter.Fill(this.partyData.PARTIES);

        }

        private void RATE_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            this.pARTIESBindingSource.Filter = "party_Name like '" + this.search.Text + "%'";
            this.pARTIESTableAdapter.Fill(this.partyData.PARTIES);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DG_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DG.CurrentRow.Index != -1)
            {
                  txt_partyid.Text = DG.CurrentRow.Cells[0].Value.ToString();
                  txt_partyname.Text = DG.CurrentRow.Cells[1].Value.ToString();
                txt_partyaddress.Text = DG.CurrentRow.Cells[2].Value.ToString();
                  txt_phone.Text = DG.CurrentRow.Cells[3].Value.ToString();
                purchasecheck.Checked=Convert.ToBoolean(DG.CurrentRow.Cells[4].Value);
                salecheck.Checked=Convert.ToBoolean(DG.CurrentRow.Cells[5].Value);
           
             
                btn_save.Text = "Update";
                btn_del.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
              txt_partyid.Text = p3.MainFunction.GetMaxId("SELECT ISNULL(MAX(PARTY_ID),0) AS ID FROM PARTIES").ToString();
               
            
        }
    }
}
