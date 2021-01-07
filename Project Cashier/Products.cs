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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Owner\Desktop\project\project\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            // using this query to select all the rows of our table to be displayed 
            string query = "select * from ProductTable";

            //excuting the insert query on the database and making the dataAdapter that will be used to fill the data set 
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            //creating the dataset to be displayed
            var ds = new DataSet();

            // fill the dataset we created with the data selected from the table
            sda.Fill(ds);

            //displays the data from the dataset on the form
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        //this method will bind the Combobox with the database
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
            comboBox1.ValueMember = "catName";

            //setting the data of the table we created into the list of the combobox
            comboBox1.DataSource = dt;

            comboBox2.ValueMember = "catName";
            comboBox2.DataSource = dt;
            Con.Close();
            rdr.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //on cliking on category button we load the category form by making an object from it and then show the form
            // then we hide any current form is opened
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            //try and catch method https://www.w3schools.com/cs/cs_exceptions.asp
            try
            {
                Con.Open();
                // inserting the values of text boxes into the table by the order of the columns we created
                // https://www.w3schools.com/sql/sql_insert.asp

                string query = "insert into ProductTable values(" + ProductID.Text + ",'" + ProdName.Text + "'," + ProdQty.Text + "," + ProdPrice.Text + ",'" + comboBox1.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);

                //in c# we need to use the ExecuteNonQuery method to do the (insert, delete and update) commands on our database
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Added Successfully");
                Con.Close();
                populate();
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

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // onclicking on any row of the table its content converted to a string in the ID, Name, Discription textboxs
            ProductID.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // try and catch used to check if the recrod we want to ubdate is there so we can update it
            try
            {
                // checking if any of the fields are empty before updating
                if (ProductID.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text == "")
                {
                    MessageBox.Show("Missing Informtion");
                }
                else
                {
                    Con.Open();

                    // this query used to update a certain record after clicking edit button
                    //https://www.w3schools.com/sql/sql_update.asp

                    string query = "update ProductTable set ProdName ='" + ProdName.Text + "',ProdQty ='" + ProdQty.Text + " ', ProdPrice =' " + ProdPrice.Text + " ', ProdCat ='" + comboBox1.SelectedValue.ToString() + "'where ProdID =" + ProductID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated");
                    Con.Close();
                    populate();
                }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from ProductTable where ProdCat ='" + comboBox2.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductID.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    Con.Open();

                    // this query used to delete a record(row) from our table using the Category ID that is selected
                    //https://www.w3schools.com/sql/sql_delete.asp

                    string query = "delete from ProductTable where ProdID =" + ProductID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    Con.Close();
                    // to display the change in the table after deleting
                    populate();
                }
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

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

