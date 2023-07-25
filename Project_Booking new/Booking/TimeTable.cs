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
    public partial class TimeTable : Form
    {
        public TimeTable()
        {
            InitializeComponent();
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTSystemDataSet5.Route' table. You can move, or remove it, as needed.
            tTSystemDataSet5.Clear();
            this.routeTableAdapter.Fill(this.tTSystemDataSet5.Route);
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumVioletRed;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeToSriLanka W3 = new WelcomeToSriLanka();
            W3.ShowDialog();
            this.Close();

        }
    }
}
