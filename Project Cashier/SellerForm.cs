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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        // making an object to connect the database we created with the button
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Owner\Desktop\project\project\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button3_Click(object sender, EventArgs e)
        {
            CategoryForm Category = new CategoryForm();
            Category.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // onclicking on any row of the table its content converted to a string in the ID, Name, age, phone, password textboxs
           SellerIDTab.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellerNameTab.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            SellerAgeTab.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            SellerPhoneTab.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            SellerPwTab.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
         
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            //try and catch method https://www.w3schools.com/cs/cs_exceptions.asp
            try
            {
                Con.Open();
                // inserting the values of text boxes into the table by the order of the columns we created
                // https://www.w3schools.com/sql/sql_insert.asp

                string query = "insert into SellerTable values(" + SellerIDTab.Text + ",'" + SellerNameTab.Text + "','" + SellerAgeTab.Text + "','" + SellerPhoneTab.Text + "','" + SellerPwTab.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);

                //in c# we need to use the ExecuteNonQuery method to do the (insert, delete and update) commands on our database
                cmd.ExecuteNonQuery();

                MessageBox.Show("category Added successfully");
                Con.Close();
                populate();
                // to make the tabs blank after successfuly adding/deleting an item in the db
                SellerIDTab.Text = "";
                SellerNameTab.Text = "";
                SellerAgeTab.Text = "";
                SellerPhoneTab.Text = "";
                SellerPwTab.Text = "";
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
        // this method used to display what is inside the category table each time we change something on it.
        private void populate()
        {
            Con.Open();
            // using this query to select all the rows of our table to be displayed 
            string query = "select * from SellerTable";

            //excuting the insert query on the database and making the dataAdapter that will be used to fill the data set 
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            //creating the dataset to be displayed
            var ds = new DataSet();

            // fill the dataset we created with the data selected from the table
            sda.Fill(ds);

            //displays the data from the dataset on the form
            SellerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //try and catch here checking if we could delete fron the table
            try
            {
                if (SellerIDTab.Text == "")
                {
                    MessageBox.Show("Select The Seller to Delete");
                }
                else
                {
                    Con.Open();

                    // this query used to delete a record(row) from our table using the Category ID that is selected
                    //https://www.w3schools.com/sql/sql_delete.asp

                    string query = "delete from SellerTable where SellerID =" + SellerIDTab.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    Con.Close();

                    // to display the change in the table after deleting
                    populate();
                    // to make the tabs blank after successfuly adding/deleting an item in the db
                    SellerIDTab.Text = "";
                    SellerNameTab.Text = "";
                    SellerAgeTab.Text = "";
                    SellerPhoneTab.Text = "";
                    SellerPwTab.Text = "";
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

        private void button6_Click(object sender, EventArgs e)
        {
            // try and catch used to check if the recrod we want to ubdate is there so we can update it
            try
            {
                // checking if any of the fields are empty before updating
                if (SellerNameTab.Text == "" || SellerAgeTab.Text == "" || SellerPhoneTab.Text == "" || SellerIDTab.Text == "" || SellerPwTab.Text == "")
                {
                    MessageBox.Show("Missing Informtion");
                }
                else
                {
                    Con.Open();

                    // this query used to update a certain record after clicking edit button
                    //https://www.w3schools.com/sql/sql_update.asp

                    string query = "update SellerTable set SellerName ='" + SellerNameTab.Text + "',SellerAge =" + SellerAgeTab.Text + ", SellerPhone ='" + SellerPhoneTab.Text + "', SellerPass ='" + SellerPwTab.Text + "'where SellerID =" + SellerIDTab.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Successfully Updated");
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

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
        