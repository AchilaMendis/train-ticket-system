using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class User_reg : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACHILA_MSI;Initial Catalog=TTSystem;Integrated Security=True");
        public User_reg()
        {
            InitializeComponent();
        }

        private void User_reg_Load(object sender, EventArgs e)
        {

        }

        private void Cleardata()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEmail.Text == "" || txtPassword.Text =="" || txtName.Text == "" || txtId.Text == "")
                {
                    MessageBox.Show("Please insert All the Details...!");
                }
                else
                {
                    if (txtPassword.Text == txtPassword2.Text)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Loginuser values( '" + txtId.Text + "', '" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtPassword.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Inserted Successfully! Login to the System");
                        Cleardata();
                        //DisplayData();
                        con.Close();

                        this.Hide();
                        User_Login U2 = new User_Login();
                        U2.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Please Re-enter Coorect Password");
                    }
                }
              
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            User_Login U3 = new User_Login();
            U3.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
