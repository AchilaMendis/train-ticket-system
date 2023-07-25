namespace Booking
{
    partial class BookinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookinForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startStationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofPassengersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTSystemDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTSystemDataSet4 = new Booking.TTSystemDataSet4();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new Booking.TTSystemDataSet4TableAdapters.BookingTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainNoDataGridViewTextBoxColumn,
            this.startStationDataGridViewTextBoxColumn,
            this.endStationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.noofPassengersDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Booking";
            this.dataGridView1.DataSource = this.tTSystemDataSet4BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(353, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 261);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // trainNoDataGridViewTextBoxColumn
            // 
            this.trainNoDataGridViewTextBoxColumn.DataPropertyName = "Train_No";
            this.trainNoDataGridViewTextBoxColumn.HeaderText = "Train_No";
            this.trainNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainNoDataGridViewTextBoxColumn.Name = "trainNoDataGridViewTextBoxColumn";
            this.trainNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // startStationDataGridViewTextBoxColumn
            // 
            this.startStationDataGridViewTextBoxColumn.DataPropertyName = "Start_Station";
            this.startStationDataGridViewTextBoxColumn.HeaderText = "Start_Station";
            this.startStationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startStationDataGridViewTextBoxColumn.Name = "startStationDataGridViewTextBoxColumn";
            this.startStationDataGridViewTextBoxColumn.Width = 125;
            // 
            // endStationDataGridViewTextBoxColumn
            // 
            this.endStationDataGridViewTextBoxColumn.DataPropertyName = "End_Station";
            this.endStationDataGridViewTextBoxColumn.HeaderText = "End_Station";
            this.endStationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endStationDataGridViewTextBoxColumn.Name = "endStationDataGridViewTextBoxColumn";
            this.endStationDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // noofPassengersDataGridViewTextBoxColumn
            // 
            this.noofPassengersDataGridViewTextBoxColumn.DataPropertyName = "No_of_Passengers";
            this.noofPassengersDataGridViewTextBoxColumn.HeaderText = "No_of_Passengers";
            this.noofPassengersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noofPassengersDataGridViewTextBoxColumn.Name = "noofPassengersDataGridViewTextBoxColumn";
            this.noofPassengersDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // tTSystemDataSet4BindingSource
            // 
            this.tTSystemDataSet4BindingSource.DataSource = this.tTSystemDataSet4;
            this.tTSystemDataSet4BindingSource.Position = 0;
            // 
            // tTSystemDataSet4
            // 
            this.tTSystemDataSet4.DataSetName = "TTSystemDataSet4";
            this.tTSystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Booking.*\r\nFROM     Booking";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ACHILA_MSI;Initial Catalog=TTSystem;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Booking] ([Train_No], [Start_Station], [End_Station], [Date], [No_of" +
    "_Passengers], [Price]) VALUES (@Train_No, @Start_Station, @End_Station, @Date, @" +
    "No_of_Passengers, @Price)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Train_No", System.Data.SqlDbType.VarChar, 0, "Train_No"),
            new System.Data.SqlClient.SqlParameter("@Start_Station", System.Data.SqlDbType.VarChar, 0, "Start_Station"),
            new System.Data.SqlClient.SqlParameter("@End_Station", System.Data.SqlDbType.VarChar, 0, "End_Station"),
            new System.Data.SqlClient.SqlParameter("@Date", System.Data.SqlDbType.Date, 0, "Date"),
            new System.Data.SqlClient.SqlParameter("@No_of_Passengers", System.Data.SqlDbType.Int, 0, "No_of_Passengers"),
            new System.Data.SqlClient.SqlParameter("@Price", System.Data.SqlDbType.Int, 0, "Price")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Booking", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Train_No", "Train_No"),
                        new System.Data.Common.DataColumnMapping("Start_Station", "Start_Station"),
                        new System.Data.Common.DataColumnMapping("End_Station", "End_Station"),
                        new System.Data.Common.DataColumnMapping("Date", "Date"),
                        new System.Data.Common.DataColumnMapping("No_of_Passengers", "No_of_Passengers"),
                        new System.Data.Common.DataColumnMapping("Price", "Price")})});
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.tTSystemDataSet4;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(886, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(595, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 49);
            this.label2.TabIndex = 3;
            this.label2.Text = "Booking Chart";
            // 
            // BookinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookinForm";
            this.Text = "BookinForm";
            this.Load += new System.EventHandler(this.BookinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private TTSystemDataSet4 tTSystemDataSet4;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private TTSystemDataSet4TableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startStationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endStationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofPassengersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tTSystemDataSet4BindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}