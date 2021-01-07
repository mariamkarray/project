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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //to make the name of the seller who loged in from the first form appear in the selling form
        public static string sellername = "";

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Owner\Desktop\project\project\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void label4_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PassTb.Text = "";
        }

        private void RoleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter username and/or password");
            }
            else
            { // SelectedIndex returns -1 if no value was selected 
                if (RoleCb.SelectedIndex > -1)
                {
                    { // if the user chooses "Admin" from the select role combobox and enters the correct uname and pw for admin, it opens the products form and hides the current login form
                        if (RoleCb.SelectedItem.ToString() == "Admin")
                        {
                            if (UnameTb.Text == "Admin" && PassTb.Text == "Admin")
                            {
                                CategoryForm Cate = new CategoryForm();
                                Cate.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Enter the correct username and password for admin");
                            }
                        }
                        else
                        {
                            //MessageBox.Show("You're in the sellers section");
                            Con.Open();
                            //searching for the seller account and counting 8 just in case there are multible accounts with the same name and bassword
                            string query = "select count(8) from SellerTable where SellerName ='" + UnameTb.Text + "' and SellerPass ='" + PassTb.Text + "'";
                            
                            //using data adapter to access the first cell by index
                            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                //to make the name of the seller who loged in from the first form appear in the selling form
                                sellername = UnameTb.Text;
                                
                                //making the selling form appear when the correct user name and password entered
                                SellingForm sell = new SellingForm();
                                sell.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Wrong username or password");
                            }
                            Con.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select a role");
                }
            }
        }
    }
}
