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
    public partial class BookingTickets : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACHILA_MSI;Initial Catalog=TTSystem;Integrated Security=True");

        public BookingTickets()
        {
            InitializeComponent();
        }

         public static BookingTickets frm;

        public static BookingTickets getformBookYourSeat
        {
            get
            {
                if (frm == null)
                {
                    frm = new BookingTickets();
                }
                return frm;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtTrainNumber.Text = BookYourSeat.selectedrow.Cells[1].Value.ToString();
            txtStartStation.Text = BookYourSeat.selectedrow.Cells[2].Value.ToString();
            txtEndStation.Text = BookYourSeat.selectedrow.Cells[3].Value.ToString();

            txt1st.Text = BookYourSeat.selectedrow.Cells[6].Value.ToString();
            txt2nd.Text = BookYourSeat.selectedrow.Cells[7].Value.ToString();
            txt3rd.Text = BookYourSeat.selectedrow.Cells[8].Value.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();    
            BookYourSeat F2 = new BookYourSeat();
            F2.ShowDialog();
            Visible = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Booking values('" + txtTrainNumber.Text + "', '" + txtStartStation.Text + "', '" + txtEndStation.Text + "', '" + null + "','" + txtNoPassengers.Text + "','" + lblTotal.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully.");
            //Cleardata();
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int passsengers = Convert.ToInt32(this.txtNoPassengers.Text);
            if (radioButton1.Checked)
            {
                int price = passsengers * Convert.ToInt32(this.txt1st.Text);
                lblTotal.Text = price.ToString();
            }
            else if (radioButton2.Checked)
            {
                int price = passsengers * Convert.ToInt32(this.txt2nd.Text);
                lblTotal.Text = price.ToString();
            }
            else if (radioButton3.Checked)
            {
                int price = passsengers * Convert.ToInt32(this.txt3rd.Text);
                lblTotal.Text = price.ToString();
            }

            /*
                        if ()
                        {
                            MessageBox.Show("Please select number of seats you want to book", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }*/
        }

        private void lblNeed1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
