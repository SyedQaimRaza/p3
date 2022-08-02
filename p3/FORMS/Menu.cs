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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void productinfo_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form P =new Product();
            P.Size = panel1.Size;
            P.TopLevel =false;
            P.Parent = panel1;
            P.FormBorderStyle = FormBorderStyle.None;

            P.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            Form PA = new Party();
            PA.Size = panel1.Size;
            PA.TopLevel = false;
            PA.Parent = panel1;
            PA.FormBorderStyle = FormBorderStyle.None;
            PA.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form C = new Category();
            
            C.Size = panel1.Size;
            C.TopLevel = false;
            C.Parent = panel1;
            C.FormBorderStyle = FormBorderStyle.None;
            groupBox1.Visible = false;

            C.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form CA = new Company();
            
            CA.Size = panel1.Size;
            CA.TopLevel = false;
            CA.Parent = panel1;
            CA.FormBorderStyle = FormBorderStyle.None;
            groupBox1.Visible = false;
            CA.Show();

        }

        private void purchase_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form P = new FORMS.Purchase();

            P.Size = panel1.Size;
            P.TopLevel = false;
            P.Parent = panel1;
            P.FormBorderStyle = FormBorderStyle.None;
            groupBox1.Visible = false;

            P.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form S = new Sale();

            S.Size = panel1.Size;
            S.TopLevel = false;
            S.Parent = panel1;
            S.FormBorderStyle = FormBorderStyle.None;


            S.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
        /*    SolidBrush B = new SolidBrush(Color.Gray);
            Graphics List = panel2.CreateGraphics();
            List.FillRectangle(B, 10, 10, 25, 25);*/
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
           
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label2_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
