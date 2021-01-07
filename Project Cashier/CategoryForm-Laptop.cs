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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        // making an object to connect the database we created with the button
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\MARIAM\ONEDRIVE\DESKTOP\PROJECT\PROJECT\SMARKETDB.MDF;Integrated Security=True;Connect Timeout=30");
        private void button5_Click(object sender, EventArgs e)
        {
            //try and catch method https://www.w3schools.com/cs/cs_exceptions.asp
            try
            {
                Con.Open();
                // inserting the values of text boxes into the table by the order of the columns we created
                // https://www.w3schools.com/sql/sql_insert.asp

                string query = "insert into CategoryTable values(" + CatIdTb.Text + ",'" + CatNameTb.Text + "','" + CatDescTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);

                //in c# we need to use the ExecuteNonQuery method to do the (insert, delete and update) commands on our database
                cmd.ExecuteNonQuery();

                MessageBox.Show("category Added successfully");
                Con.Close();
                populate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // this method used to display what is inside the category table each time we change something on it.
        private void populate()
        {
            Con.Open();
            // using this query to select all the rows of our table to be displayed 
            string query = "select * from CategoryTable";

            //excuting the insert query on the database and making the dataAdapter that will be used to fill the data set 
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            //creating the dataset to be displayed
            var ds = new DataSet();

            // fill the dataset we created with the data selected from the table
            sda.Fill(ds);

            //displays the data from the dataset on the form
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // onclicking on any row of the table its content converted to a string in the ID, Name, Discription textboxs
            CatIdTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //try and catch here checking if we could delete fron the table
            try
            {
                if(CatIdTb.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    Con.Open();

                    // this query used to delete a record(row) from our table using the Category ID that is selected
                    //https://www.w3schools.com/sql/sql_delete.asp

                    string query = "delete from CategoryTable where Catd =" + CatIdTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    Con.Close();

                    // to display the change in the table after deleting
                    populate();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // try and catch used to check if the recrod we want to ubdate is there so we can update it
            try
            {
                // checking if any of the fields are empty before updating
                if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Missing Informtion");
                }
                else
                {
                    Con.Open();

                    // this query used to update a certain record after clicking edit button
                    //https://www.w3schools.com/sql/sql_update.asp

                    string query = "update CategoryTable set CatName ='" + CatNameTb.Text + "',CatDesc ='" + CatDescTb.Text + "'where Catd =" + CatIdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated");
                    Con.Close();
                    populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }
    }
}
