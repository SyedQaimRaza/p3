using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;

   
namespace p3.FORMS
{
    public partial class Purchase : Form
    {
        static string ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=PROJECT;Integrated Security=True";
        SqlConnection Con = new SqlConnection(ConnectionString);
        public Purchase()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
           if (btn_new.Text == "Cancel")
           {
             Con.Open(); 
                try
                {
                    try
                    {
                        string q2 = "insert into PurchaseMaster (InvNo,PartyID,Date,Billno,Description) values(" + txt_invno.Text + "," + txt_partyid.Text + ",'" + date1.Text + "','" + txt_billno.Text + "','" + txt_party + "')";
                        SqlCommand cmd1 = new SqlCommand(q2, Con);
                        cmd1.ExecuteNonQuery();
                    }
                    catch (Exception ex){ MessageBox.Show(ex.Message, "Select the Party"); }

                    for (int i = 0; i < ManualDG.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd = new SqlCommand(@"insert into PurchaseDetail (InvNo,ProductID,Munit,Quantity,Rate) values(" + txt_partyid.Text + ",'" + ManualDG.Rows[i].Cells[0].Value + "','" + ManualDG.Rows[i].Cells[2].Value + "','" + ManualDG.Rows[i].Cells[3].Value + "','" + ManualDG.Rows[i].Cells[4].Value + "')", Con);
                        cmd.ExecuteNonQuery();
                    }
                    ManualDG.Rows.Clear();
                    
                    MessageBox.Show("Data Has been save", "MESSAGE");
                    btn_new.Text = "Add New";

                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message, "Data has not Saved");
                }
                Con.Close();
            }
            else
            {
                MessageBox.Show("Add a new Invoice to add a Product", "ERROR");
            }
           
        }
        
        
        

        private void btn_delete_Click(object sender, EventArgs e)
        {

            Con.Open();
            try
            {


                string Query = "delete from tmpDetail where ProductID=" + txt_productid.Text;
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been Delete", "MESSAGE");
                this.tmpDetailTableAdapter.Fill(this.tmpDetail._tmpDetail);


            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "Data has not Deleted");
            }

            Con.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_productid.Clear();
            txt_productname.Clear();
            txt_munit.Clear();
            txt_qty.Clear();
            txt_rate.Clear();


        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_qty.Text.Length > 0 && txt_rate.Text.Length > 0)
                {

                    txt_amount.Text = Convert.ToString(Convert.ToInt32(txt_qty.Text) * Convert.ToInt32(txt_rate.Text));



                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Data not saved");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }

        private void btn_partyname_Click(object sender, EventArgs e)
        {

            this.pARTIESBindingSource.Filter = "party_Name like '" + this.txt_searchparty.Text + "%'";
            this.pARTIESTableAdapter.Fill(this.partyData.PARTIES);
        }

        private void g2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (g2.CurrentRow.Index != -1)
            {
                txt_partyid.Text = g2.CurrentRow.Cells[0].Value.ToString();
                txt_party.Text = g2.CurrentRow.Cells[1].Value.ToString();


            }
        }

        private void btn_seacrh_Click(object sender, EventArgs e)
        {
           // p3.MainFunction.searchItem(this.pRODUCTBindingSource, "ProductName like'", txt_secarchproduct);
           // this.productDataBindingSource.Filter = "ProductName like'" + txt_productname + "%'";
            this.pRODUCTTableAdapter.Fill(this.productData.PRODUCT);
        }
        private void g3_DoubleClick(object sender, EventArgs e)
        {
            if (g3.CurrentRow.Index != -1)
            {
                txt_productid.Text = g3.CurrentRow.Cells[0].Value.ToString();
                txt_productname.Text = g3.CurrentRow.Cells[1].Value.ToString();
                txt_munit.Text = g3.CurrentRow.Cells[3].Value.ToString();
                txt_rate.Text = g3.CurrentRow.Cells[2].Value.ToString();

            }
        }

        private void Purchase_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'pD.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter1.Fill(this.pD.PRODUCT);
            // TODO: This line of code loads data into the 'productData.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.productData.PRODUCT);
            // TODO: This line of code loads data into the 'partyData.PARTIES' table. You can move, or remove it, as needed.
            this.pARTIESTableAdapter.Fill(this.partyData.PARTIES);

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (btn_new.Text == "Add New")
            {
                txt_invno.Text = p3.MainFunction.GetMaxId("SELECT ISNULL(MAX(invno),0) AS ID FROM purchasemaster").ToString();
                btn_new.Text = "Cancel";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < ManualDG.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(ManualDG.Rows[i].Cells[3].Value);
            }
           txt_tqty.Text = sum.ToString();

        }

        private void Amount_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < ManualDG.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(ManualDG.Rows[i].Cells[5].Value);
            }
            textBox3.Text = sum.ToString();
        }

        private void g2_DoubleClick(object sender, EventArgs e)
        {

            if (g2.CurrentRow.Index != -1)
            {
                txt_partyid.Text = g2.CurrentRow.Cells[0].Value.ToString();
                txt_party.Text = g2.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void txt_rate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Con.Open();
                try
                {
                    ManualDG.Rows.Add(txt_productid.Text, txt_productname.Text, txt_munit.Text, txt_qty.Text, txt_rate.Text, txt_amount.Text);
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message, "Data has not Saved");
                }
                txt_productid.Clear();
                txt_productname.Clear();
                txt_munit.Clear();
                txt_qty.Clear();
                txt_rate.Clear();
                txt_productid.Focus();
                Con.Close();
            }
        }



        private void txt_productid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                {


                    SqlDataReader f = p3.MainFunction.SelecttData("Select productname,m_unit,p_rate from product where productid=" + txt_productid.Text);
                    while (f.Read())
                    {
                        txt_productname.Text = f.GetValue(0).ToString();
                        txt_munit.Text = f.GetValue(1).ToString();
                        txt_rate.Text = f.GetValue(2).ToString();
                    }

                    f.Close();
                    txt_qty.Focus();
                }
            }
        }


        private void button1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                panel1.Visible = false;
            }
        }

        private void Purchase_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Modifiers)
            {
                panel1.Visible = false;
            }
        }



        private void button2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                panel2.Visible = false;
            }
        }


        private void txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_rate.Focus();
            }
        }
    }
}
