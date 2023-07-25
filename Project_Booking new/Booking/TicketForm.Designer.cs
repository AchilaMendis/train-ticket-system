namespace Booking
{
    partial class TicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
            this.label1 = new System.Windows.Forms.Label();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.tTSystemDataSet3 = new Booking.TTSystemDataSet3();
            this.ticketsTableAdapter = new Booking.TTSystemDataSet3TableAdapters.TicketsTableAdapter();
            this.ticketsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startStationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfPassengersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(655, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Chart";
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Tickets.*\r\nFROM     Tickets";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ACHILA_MSI;Initial Catalog=TTSystem;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Tickets] ([Train_No], [Start_Station], [End_Station], [NoOfPassenger" +
    "s], [Total_Price]) VALUES (@Train_No, @Start_Station, @End_Station, @NoOfPasseng" +
    "ers, @Total_Price)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Train_No", System.Data.SqlDbType.VarChar, 0, "Train_No"),
            new System.Data.SqlClient.SqlParameter("@Start_Station", System.Data.SqlDbType.VarChar, 0, "Start_Station"),
            new System.Data.SqlClient.SqlParameter("@End_Station", System.Data.SqlDbType.VarChar, 0, "End_Station"),
            new System.Data.SqlClient.SqlParameter("@NoOfPassengers", System.Data.SqlDbType.Int, 0, "NoOfPassengers"),
            new System.Data.SqlClient.SqlParameter("@Total_Price", System.Data.SqlDbType.Int, 0, "Total_Price")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tickets", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Train_No", "Train_No"),
                        new System.Data.Common.DataColumnMapping("Start_Station", "Start_Station"),
                        new System.Data.Common.DataColumnMapping("End_Station", "End_Station"),
                        new System.Data.Common.DataColumnMapping("NoOfPassengers", "NoOfPassengers"),
                        new System.Data.Common.DataColumnMapping("Total_Price", "Total_Price")})});
            // 
            // tTSystemDataSet3
            // 
            this.tTSystemDataSet3.DataSetName = "TTSystemDataSet3";
            this.tTSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // ticketsBindingSource3
            // 
            this.ticketsBindingSource3.DataMember = "Tickets";
            this.ticketsBindingSource3.DataSource = this.tTSystemDataSet3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainNoDataGridViewTextBoxColumn,
            this.startStationDataGridViewTextBoxColumn,
            this.endStationDataGridViewTextBoxColumn,
            this.noOfPassengersDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Tickets";
            this.dataGridView1.DataSource = this.tTSystemDataSet3;
            this.dataGridView1.Location = new System.Drawing.Point(416, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(694, 321);
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
            // noOfPassengersDataGridViewTextBoxColumn
            // 
            this.noOfPassengersDataGridViewTextBoxColumn.DataPropertyName = "NoOfPassengers";
            this.noOfPassengersDataGridViewTextBoxColumn.HeaderText = "NoOfPassengers";
            this.noOfPassengersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noOfPassengersDataGridViewTextBoxColumn.Name = "noOfPassengersDataGridViewTextBoxColumn";
            this.noOfPassengersDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "Total_Price";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total_Price";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(894, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private TTSystemDataSet3 tTSystemDataSet3;
        private TTSystemDataSet3TableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.BindingSource ticketsBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startStationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endStationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfPassengersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}