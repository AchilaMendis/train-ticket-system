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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTSystemDataSet3.Tickets' table. You can move, or remove it, as needed.
           // this.ticketsTableAdapter.Fill(this.tTSystemDataSet3.Tickets);
            tTSystemDataSet3.Clear();
            this.ticketsTableAdapter.Fill(this.tTSystemDataSet3.Tickets);
            //sqlDataAdapter1.Fill(tTSystemDataSet2);
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumVioletRed;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m1 = new MainMenu();
            m1.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
