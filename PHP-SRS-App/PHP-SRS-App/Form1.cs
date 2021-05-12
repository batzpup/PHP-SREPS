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
using System.Text.RegularExpressions;



namespace PHP_SRS_App
{
    public partial class Form1 : Form
    {
        //"server=sql6.freemysqlhosting.net; user id = sql6410796; password=7IDwjMhNCw;database=sql6410796;persistsecurityinfo=True;";
        string unbuiltString = "server=localhost;user id=root;persistsecurityinfo=True;database=phpdatabase";
        string connectionString = "Server=sql6.freemysqlhosting.net,3306;User id = sql6410796; database=sql6410796; Password=7IDwjMhNCw;Convert Zero Datetime=True;";
        List<CartItem> CartItems = new List<CartItem>();

        public Form1()
        {
            InitializeComponent();
            dgvSalesRecord.CellEndEdit += dgvSalesRecord_CellEndEdit;
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
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM sales_table", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvSalesRecord.DataSource = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvSalesRecord_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("ive changed a cell sucessfully");

            if (dgvSalesRecord.CurrentRow != null)
            {
                try
                {
                    using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        DataGridViewRow dgvRow = dgvSalesRecord.CurrentRow;
                        MySqlCommand sqlCmd = new MySqlCommand("AddEditSale", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        //update
                        sqlCmd.Parameters.AddWithValue("p_Order_Number", Convert.ToInt32(dgvRow.Cells["Order_Number"].Value));
                        sqlCmd.Parameters.AddWithValue("p_Product_ID", Convert.ToInt32(dgvRow.Cells["Product_ID"].Value));
                        sqlCmd.Parameters.AddWithValue("p_Datetime", Convert.ToDateTime(dgvRow.Cells["Datetime"].Value));
                        sqlCmd.Parameters.AddWithValue("p_Quantity", Convert.ToInt32(dgvRow.Cells["Quantity"].Value));
                        sqlCmd.ExecuteNonQuery();
                        PopulateDataGridView();

                    }
                }
                catch 
                {
                    MessageBox.Show("You cannot edit a sales that doesnt exist");
                }

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (product_cbx.Text.ToLower())
            {

                case "sensodyne":
                    product__imgbx.Image = Properties.Resources.sensodyne;
                    break;
                case "tissues":
                    product__imgbx.Image = Properties.Resources.tissues;
                    break;
                case "sunscreen":
                    product__imgbx.Image = Properties.Resources.sunscreen;
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

            int lastOrderNumber = 0;


            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
                {

                    string getLastOrder = " SELECT MAX(Order_Number) FROM sales_table;";
                    string x;
                    sqlCon.Open();
                    MySqlCommand cmd = new MySqlCommand(getLastOrder, sqlCon);
                    x = cmd.ExecuteScalar().ToString();
                    sqlCon.Close();
                    lastOrderNumber = Int32.Parse(x);
                    lastOrderNumber += 1;

                    string[] RichTextBoxLines = rTextBox.Lines;
                    string lastline = RichTextBoxLines.Last();

                    foreach (string line in RichTextBoxLines)
                    {
                        MySqlDataReader MyReader;

                        if (line != lastline)
                        {
                            string linecopy = line.Clone().ToString();

                            var quantity = Regex.Replace(linecopy.Split()[1], @"[^0-9a-zA-Z\ ]+", "");

                            var output = Regex.Replace(line.Split()[0], @"[^0-9a-zA-Z\ ]+", "");
                            int product_id = GetProductId(output); //needs revision.


                            string query = "insert into sales_table(Order_Number,Product_ID,Datetime,Quantity) " +
                                "values('" + lastOrderNumber + "','" + product_id + "','" + "NOW()" + "','" + quantity + "');";


                            MySqlCommand MyCommand2 = new MySqlCommand(query, sqlCon);

                            sqlCon.Open();
                            MyReader = MyCommand2.ExecuteReader();  // Here our query will be executed and data saved into the database.  

                            while (MyReader.Read())
                            {
                            }
                            sqlCon.Close();
                        }

                    }
                    MessageBox.Show("Save Data");

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
            bool found = false;
            if (product_cbx.Text == "" || quantity_msktxtbx.Text == "" || quantity_msktxtbx.Text == "0")
            {
                MessageBox.Show("Please select a valid product and quantity");
                return;
            }
            else
            {

                if (CartItems.Count != 0)
                {
                    foreach (CartItem item in CartItems.ToList())
                    {
                        if (item._name == product_cbx.Text)
                        {

                            item._quantity = Int32.Parse(quantity_msktxtbx.Text) + item._quantity;
                            found = true;
                            break;
                        }

                    }
                    if (!found)
                    {

                        CartItems.Add(new CartItem(product_cbx.Text, 10, Int32.Parse(quantity_msktxtbx.Text)));
                    }
                }
                else
                {
                    CartItems.Add(new CartItem(product_cbx.Text, 10, Int32.Parse(quantity_msktxtbx.Text)));
                }


                AddMsgToBoard();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddMsgToBoard()
        {
            rTextBox.Text = "";
            Console.WriteLine(rTextBox.TextLength);
            foreach (CartItem item in CartItems.ToList())
            {
                rTextBox.Text += item._name + " " + item._quantity + "\n";
            }
        }


        private void dgvSalesRecord_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("called: dgv_CellEndEdit");
            dgvSalesRecord.BindingContext[dgvSalesRecord.DataSource].EndCurrentEdit();
            dgvSalesRecord_CellValueChanged(sender, e);
        }

        private int GetProductId(string productname)
        {
            int product_id = 0;
            switch (productname.ToLower())
            {

                case "sensodyne":
                    product_id = 1;
                    break;
                case "tissues":
                    product_id = 2;
                    break;
                case "sunscreen":
                    product_id = 3;
                    break;
            }
            Console.WriteLine("Product id: " + product_id);
            if (product_id == 0)
            {
                throw new InvalidOperationException("Product id of 0 is not valid");

            }

            return product_id;
        }

    }
}
