using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRS_App
{
    public partial class Form1 : Form
    {
        string connectionString = "sql6.freemysqlhosting.net;user id = sql6410796; database=sql6410796;persistsecurityinfo=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (product_cbx.Text.ToLower())
            {

                case "sensodyne":
                    product__imgbx.Image = PHP_SRS_App.Properties.Resources.sensodyne;
                    break;
                case "tissues":
                    product__imgbx.Image = PHP_SRS_App.Properties.Resources.tissues;
                    break;
                default:
                    MessageBox.Show("Please select a valid product");
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sql6410796DataSet2.products_table' table. You can move, or remove it, as needed.
            this.products_tableTableAdapter.Fill(this.sql6410796DataSet2.products_table);
            // TODO: This line of code loads data into the 'sql6410796DataSet.sales_table' table. You can move, or remove it, as needed.
            this.sales_tableTableAdapter.Fill(this.sql6410796DataSet.sales_table);
            

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Please select a valid number");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {


            if (product_cbx.Text == "" || quantity_msktxtbx.Text == "" || quantity_msktxtbx.Text == "0")
            {
                MessageBox.Show("Please select a valid product and quantity");

                return;
            }
            else
            {
                AddMsgToBoard();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void AddMsgToBoard()
        {
            rTextBox.Text += '\n';
            rTextBox.Text += product_cbx.Text + ' ' + quantity_msktxtbx.Text;
        }
    }
}
