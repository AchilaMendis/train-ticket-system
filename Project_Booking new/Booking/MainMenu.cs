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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_root_Click(object sender, EventArgs e)
        {
            this.Hide();
            RootForm R1 = new RootForm();
            R1.ShowDialog();
            this.Close();
        }

        private void btn_train_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainForm T1 = new TrainForm();
            T1.ShowDialog();
            this.Close();
        }

        private void btn_ticket_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicketForm TT1 = new TicketForm();
            TT1.ShowDialog();
            this.Close();
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookinForm B1 = new BookinForm();
            B1.ShowDialog();
            this.Close();
        }

        private void btn_welcome_Click(object sender, EventArgs e)
        {

            this.Hide();
            WelcomeToSriLanka W1 = new WelcomeToSriLanka();
            W1.ShowDialog();
            this.Close();
           
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
