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
using MySql.Data.MySqlClient;




namespace PHP_SRS_App
{
    public partial class Form1 : Form
    {
        //"server=sql6.freemysqlhosting.net; user id = sql6410796; password=7IDwjMhNCw;database=sql6410796;persistsecurityinfo=True;";
        string unbuiltString = "server=localhost;user id=root;persistsecurityinfo=True;database=phpdatabase";
        string connectionString = "Server=sql6.freemysqlhosting.net,3306;User id = sql6410796; database=sql6410796; Password=7IDwjMhNCw;Convert Zero Datetime=True;";


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sql6410796DataSet.products_table' table. You can move, or remove it, as needed.
            this.products_tableTableAdapter.Fill(this.sql6410796DataSet.products_table);

            // SqlConnectionStringBuilder builder =new SqlConnectionStringBuilder(unbuiltString);
            // connectionString = builder.ConnectionString;
            //Console.WriteLine(connectionString);
            PopulateDataGridView();


        }
        void PopulateDataGridView()
        {
            using (MySql.Data.MySqlClient.MySqlConnection sqlCon = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            { 
                sqlCon.Open();
                Console.WriteLine("hello i connected");
                MySql.Data.MySqlClient.MySqlDataAdapter sqlDa = new MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM sales_table", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvSalesRecord.DataSource = dtbl;
            }
        }

        private void dgvSalesRecord_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("ive changed a cell sucessfully");
            if (dgvSalesRecord.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dgvSalesRecord.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("SalesEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    //update
                    sqlCmd.Parameters.AddWithValue("@Order_Number", Convert.ToInt32(dgvRow.Cells["Order_Number"].Value));
                    sqlCmd.Parameters.AddWithValue("@Product_ID", Convert.ToInt32(dgvRow.Cells["Product_ID"].Value));
                    sqlCmd.Parameters.AddWithValue("@Datetime", Convert.ToDateTime(dgvRow.Cells["Datetime"].Value));
                    sqlCmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(dgvRow.Cells["Quantity"].Value));
                    sqlCmd.ExecuteNonQuery();
                    PopulateDataGridView();
                }
            }
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
                    Console.WriteLine("ChangedComboBox");
                    MessageBox.Show("Please select a valid product");
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            try
            {
                using (MySql.Data.MySqlClient.MySqlConnection sqlCon = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    MySqlDataReader MyReader;
    
                    string query = "insert into sales_table(Product_ID,Datetime,Quantity) " +
                        "values(1, NOW()," + this.quantity_msktxtbx.Text + ");";

                    MySqlCommand MyCommand2 = new MySqlCommand(query, sqlCon);
                    
                    sqlCon.Open();
                    MyReader = MyCommand2.ExecuteReader();  // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Save Data");
                    while (MyReader.Read())
                    {
                    }
                    sqlCon.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            PopulateDataGridView();
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
