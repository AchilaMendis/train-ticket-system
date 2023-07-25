using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class WelcomeToSriLanka : Form
    {
        public WelcomeToSriLanka()
        {
            InitializeComponent();
        }

        private void lblHomeDisplay_Click(object sender, EventArgs e)
        {
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHomeDisplay.Left = lblHomeDisplay.Left - 4;
            if (lblHomeDisplay.Left < -600)
            {
                lblHomeDisplay.Left = 1024;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lblHomeDisplay.Left = 1024;
        }

        private void btnHBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseYourTrain F5 = new ChooseYourTrain();
            F5.ShowDialog();
            Visible = false;
        }

        private void btnHBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookYourSeat F1 = new BookYourSeat();
            F1.ShowDialog();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Login US1 = new User_Login();
            US1.ShowDialog();
            this.Close();

        }

        private void btnHSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimeTable T1 = new TimeTable();
            T1.ShowDialog();
            this.Close();
        }
    }
}
