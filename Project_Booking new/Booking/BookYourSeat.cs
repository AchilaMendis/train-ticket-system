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
    public partial class BookYourSeat : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACHILA_MSI;Initial Catalog=TTSystem;Integrated Security=True");

        public static DataGridViewRow selectedrow;
        public BookYourSeat()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbStart.Text = "";
            cmbEnd.Text = " ";
            cmbTime.Text = " ";
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

            cmbStart.DataSource = ds.Tables[0];
            cmbStart.DisplayMember = ds.Tables[0].Columns[0].ToString();

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

            cmbEnd.DataSource = ds.Tables[0];
            cmbEnd.DisplayMember = ds.Tables[0].Columns[0].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startstatioinLoad();
            endstatioinLoad();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*string Start = cmbStart.SelectedItem.ToString();
            string End = cmbEnd.SelectedItem.ToString();
            if( Start == " ")
            {
                MessageBox.Show("Error");
            }*/
            //if(cmbStart.Text =="" || cmbEnd.Text == "")
            //{
            //    MessageBox.Show("Please Enter valided data to get results.....!");
            //}
            //else
            //{
            //    AvailableTrains F2 = new AvailableTrains();
            //    F2.startingStation = cmbStart.Text;
            //    F2.endingStation = cmbEnd.Text;
            //    //F2.AutoValidate = 
            //    F2.Show();
            //    Visible = false;
            //}

            try
            {
                using (SqlCommand cmd = new SqlCommand("select * from Route where Start_Station ='" + cmbStart.Text + "' and End_Station ='" + cmbEnd.Text + "' and StartingStation_Arrival='"+cmbTime.Text+"'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeToSriLanka W2 = new WelcomeToSriLanka();
            W2.ShowDialog();
            this.Close();
        }
        public void BindTime()
        {
            DataSet ds = new DataSet();
            string getTime = "select StartingStation_Arrival from Route where  Start_Station ='" + cmbStart.Text + "' and End_Station ='" + cmbEnd.Text + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(getTime, con);

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

            cmbTime.DataSource = ds.Tables[0];
            cmbTime.DisplayMember = ds.Tables[0].Columns[0].ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbStart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbStart.Text == "" || cmbEnd.Text == "")
            {
                MessageBox.Show("Please Enter valided data to get results.....!");
            }
            else
            {
                BindTime();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedrow = dataGridView1.Rows[e.RowIndex];
                BookingTickets.getformBookYourSeat.ShowDialog();
                Close();

            }
        }
    }
}
