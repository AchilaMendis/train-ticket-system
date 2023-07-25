using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class BuyTicket : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACHILA_MSI;Initial Catalog=TTSystem;Integrated Security=True");


        public static BuyTicket frm;
        public static BuyTicket getformChooseYourTrain
        {
            get
            {
                if (frm == null)
                {
                    frm = new BuyTicket();
                }
                return frm;
            }
        }


        public BuyTicket()
        {
            InitializeComponent();
        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {
            txtTrainNumber.Text = ChooseYourTrain.selectedrow.Cells[1].Value.ToString();
            txtStartStation.Text = ChooseYourTrain.selectedrow.Cells[2].Value.ToString();
            txtEndStation.Text = ChooseYourTrain.selectedrow.Cells[3].Value.ToString();
            txt1st.Text = ChooseYourTrain.selectedrow.Cells[6].Value.ToString();
            txt2nd.Text = ChooseYourTrain.selectedrow.Cells[7].Value.ToString();
            txt3rd.Text = ChooseYourTrain.selectedrow.Cells[8].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn7Previous_Click(object sender, EventArgs e)
        {
            this.Hide();   
            ChooseYourTrain F6 = new ChooseYourTrain();
            F6.ShowDialog();
            this.Close();
        }

        private void btn7Accept_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Tickets values('" + txtTrainNumber.Text + "', '" + txtStartStation.Text + "', '" + txtEndStation.Text + "', '" + txtNoPassengers.Text + "','" + lblDisplayPrice.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully.");
            //Cleardata();
            con.Close();
        }

        private void btn7Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn7Ok_Click(object sender, EventArgs e)
        {
            int passsengers = Convert.ToInt32(this.txtNoPassengers.Text);
            if (radioButton1.Checked)
            {
                int price = passsengers * Convert.ToInt32(this.txt1st.Text);
                lblDisplayPrice.Text = price.ToString();
            }else if (radioButton2.Checked)
            {
                int price = passsengers * Convert.ToInt32(this.txt2nd.Text);
                lblDisplayPrice.Text = price.ToString();
            }else if (radioButton3.Checked)
            {
                int price = passsengers * Convert.ToInt32(this.txt3rd.Text);
                lblDisplayPrice.Text = price.ToString();
            }

        }

        private void lbl7DisplayPrice_Click(object sender, EventArgs e)
        {

        }
        
       

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
