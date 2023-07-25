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
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
        }

        private void RootForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTSystemDataSet2.Route' table. You can move, or remove it, as needed.
            //this.routeTableAdapter.Fill(this.tTSystemDataSet2.Route);
            //// TODO: This line of code loads data into the 'ttSystemDataSet1.Root' table. You can move, or remove it, as needed.
            //this.routeTableAdapter.Fill(this.tTSystemDataSet2.Route);
            //// TODO: This line of code loads data into the 'tTSystemDataSet.Root' table. You can move, or remove it, as needed.
            //sqlDataAdapter1.Fill(ttSystemDataSet1);

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            tTSystemDataSet2.Clear();
            this.routeTableAdapter.Fill(this.tTSystemDataSet2.Route);
            //sqlDataAdapter1.Fill(tTSystemDataSet2);
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumVioletRed;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;


        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            btn_save.Enabled = true;
            btn_Add.Enabled = false;
            btn_Delete.Enabled = false;

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to delete this row ? ", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    sqlDataAdapter1.Update(tTSystemDataSet2);
                    }
            }
            catch
            {
                MessageBox.Show("Please select the whole row instead of a cell");
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(tTSystemDataSet2);
            dataGridView1.ReadOnly = true;
            btn_save.Enabled = false;
            btn_Add.Enabled = true;
            btn_Delete.Enabled = true;

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu M1 = new MainMenu();
            M1.ShowDialog();
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
