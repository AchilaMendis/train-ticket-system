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
    public partial class User_Login : Form
    {
        SqlConnection con = new SqlConnection();
        public User_Login()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=ACHILA_MSI;Initial Catalog=TTSystem;Integrated Security=True";
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter The User Id and Password");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=ACHILA_MSI;Initial Catalog=TTSystem;Integrated Security=True";
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from Loginuser where User_Id='" + txtUserName.Text + "'and Password='" + txtPassword.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login sucess Welcome to Main Menu");
                    this.Hide();
                    MainMenu mm = new MainMenu();
                    mm.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("Invalid Login please check User ID and password");
                }
                con.Close();
            }   
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_reg reg1 = new User_reg();
            reg1.ShowDialog();
            this.Close();
;
        }

        private void User_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeToSriLanka W5 = new WelcomeToSriLanka();
            W5.ShowDialog();
            this.Close();
        }
    }
}
