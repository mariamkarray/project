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

namespace Project_Cashier
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Owner\Desktop\project\project\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            // using this query to select all the rows of our table to be displayed 
            string query = "select ProdName,ProdPrice from ProductTable";

            //excuting the insert query on the database and making the dataAdapter that will be used to fill the data set 
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            //creating the dataset to be displayed
            var ds = new DataSet();

            // fill the dataset we created with the data selected from the table
            sda.Fill(ds);

            //displays the data from the dataset on the form
            ProdDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populatebills()
        {
            Con.Open();
            // using this query to select all the rows of our table to be displayed 
            string query = "select * from BillTbl";

            //excuting the insert query on the database and making the dataAdapter that will be used to fill the data set 
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            //creating the dataset to be displayed
            var ds = new DataSet();

            // fill the dataset we created with the data selected from the table
            sda.Fill(ds);

            //displays the data from the dataset on the form
            BillsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void fillcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTable", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();

            //creating a new table to put the column of categories we need in it.
            DataTable dt = new DataTable();

            // adding the CatName column to the table as its name and type
            dt.Columns.Add("CatName", typeof(string));

            // loading the actual column data into the table from the original category table
            dt.Load(rdr);

            //search
           // comboBox1.ValueMember = "catName";

            //setting the data of the table we created into the list of the combobox
            //comboBox1.DataSource = dt;

            comboBox2.ValueMember = "catName";
            comboBox2.DataSource = dt;
            Con.Close();
            rdr.Close();
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            fillcombo();
            SellerNamelbl.Text = Form1.sellername;
        }
        
        private void ProdDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // making the product name and product price equal to the selected product row so its non editable by the seller
            ProdName.Text = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
            ProdPrice.Text = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //showing the date of each bill
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            populate();
        }
        int grdtotal = 0;
        int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {   // adding the productes to the cart box and keeping track of the total bill for each id without a database
            if (ProdName.Text == "" || ProdQty.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                
                int total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ORDERDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdName.Text;
                newRow.Cells[2].Value = ProdPrice.Text;
                newRow.Cells[3].Value = ProdQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                ORDERDGV.Rows.Add(newRow);
                n++;
                grdtotal = grdtotal + total;
                Amtlbl.Text = ""+grdtotal;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (BillID.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {
                //try and catch method https://www.w3schools.com/cs/cs_exceptions.asp
                try
                {
                    Con.Open();
                    // inserting the values of text boxes into the table by the order of the columns we created
                    // https://www.w3schools.com/sql/sql_insert.asp

                    string query = "insert into BillTbl values(" + BillID.Text + ",'" + SellerNamelbl.Text + "','" + Datelbl.Text + "'," + Amtlbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    //in c# we need to use the ExecuteNonQuery method to do the (insert, delete and update) commands on our database
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Order Added Successfully");
                    Con.Close();
                    populatebills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Con.Close();
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //setting the format of the print page
            e.Graphics.DrawString("FAMILYGROCERY", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(230));
            e.Graphics.DrawString("Bill ID:"+BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100,70));
            e.Graphics.DrawString("Seller Name:" + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Date:" + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount:" + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("CodeSpace", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Black, new Point(270,230));
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select ProdName, ProdPrice from ProductTable where ProdCat ='" + comboBox2.SelectedValue.ToString() +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ORDERDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
