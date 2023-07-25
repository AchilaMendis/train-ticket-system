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
    public partial class BookinForm : Form
    {
        public BookinForm()
        {
            InitializeComponent();
        }

        private void BookinForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTSystemDataSet4.Booking' table. You can move, or remove it, as needed.
            tTSystemDataSet4.Clear();
            this.bookingTableAdapter.Fill(this.tTSystemDataSet4.Booking);
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumVioletRed;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu M3 = new MainMenu();
            M3.ShowDialog();   
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
