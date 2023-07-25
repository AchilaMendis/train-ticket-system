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
    public partial class ChooseYourTrain : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACHILA_MSI;Initial Catalog=TTSystem;Integrated Security=True");

        public static DataGridViewRow selectedrow;
        public ChooseYourTrain()
        {
            InitializeComponent();
        }
        public void startstatioinLoad()
        {
            DataSet ds = new DataSet();
            string getStation = "select Station_Name from Station;";
            SqlDataAdapter sda = new SqlDataAdapter(getStation, con);

            try
            {
                con.Open();
                sda.Fill(ds);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                con.Close();
            }

            cmb_Start_Station.DataSource = ds.Tables[0];
            cmb_Start_Station.DisplayMember = ds.Tables[0].Columns[0].ToString();

            

        }
        public void endstatioinLoad()
        {
            DataSet ds = new DataSet();
            string getStation = "select Station_Name from Station;";
            SqlDataAdapter sda = new SqlDataAdapter(getStation, con);

            try
            {
                con.Open();
                sda.Fill(ds);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                con.Close();
            }

            cmb_End_Station.DataSource = ds.Tables[0];
            cmb_End_Station.DisplayMember = ds.Tables[0].Columns[0].ToString();
        }
        private void btn5Reset_Click(object sender, EventArgs e)
        {
            cmb_Start_Station.Text = "";
            cmb_End_Station.Text = "";
        }

        private void btn5Search_Click(object sender, EventArgs e)
        {

            // SqlCommand xmm = new SqlCommand("Select * from Train", con);
            if (cmb_Start_Station.Text == "" || cmb_End_Station.Text == "")
            {
                MessageBox.Show("Please Enter valided data to get results.....!");
            }
            else
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("select * from Route where Start_Station ='" + cmb_Start_Station.Text + "' and End_Station ='" + cmb_End_Station.Text + "' and StartingStation_Arrival>Convert(Time, GetDate())", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGrid6.DataSource = dt;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn5Previous_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeToSriLanka F4 = new WelcomeToSriLanka();
            F4.ShowDialog();
            Visible = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            startstatioinLoad();
            endstatioinLoad();
        }

        private void cmb_Start_Station_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                selectedrow = dataGrid6.Rows[e.RowIndex];
                BuyTicket.getformChooseYourTrain.ShowDialog();
                Close();

            }
            
            
        }

        private void dataGrid6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_End_Station_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
