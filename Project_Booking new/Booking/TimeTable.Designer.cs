namespace Booking
{
    partial class TimeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTable));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rootNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startStationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingStationArrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStationArrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price1stClasssDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price2ndClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price3rdClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTSystemDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTSystemDataSet5 = new Booking.TTSystemDataSet5();
            this.button1 = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeTableAdapter = new Booking.TTSystemDataSet5TableAdapters.RouteTableAdapter();
            this.routeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.routeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Route Time Table";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rootNoDataGridViewTextBoxColumn,
            this.trainNoDataGridViewTextBoxColumn,
            this.startStationDataGridViewTextBoxColumn,
            this.endStationDataGridViewTextBoxColumn,
            this.startingStationArrivalDataGridViewTextBoxColumn,
            this.endStationArrivalDataGridViewTextBoxColumn,
            this.price1stClasssDataGridViewTextBoxColumn,
            this.price2ndClassDataGridViewTextBoxColumn,
            this.price3rdClassDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Route";
            this.dataGridView1.DataSource = this.tTSystemDataSet5BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 277);
            this.dataGridView1.TabIndex = 1;
            // 
            // rootNoDataGridViewTextBoxColumn
            // 
            this.rootNoDataGridViewTextBoxColumn.DataPropertyName = "Root_No";
            this.rootNoDataGridViewTextBoxColumn.HeaderText = "Root_No";
            this.rootNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rootNoDataGridViewTextBoxColumn.Name = "rootNoDataGridViewTextBoxColumn";
            this.rootNoDataGridViewTextBoxColumn.Width = 125;
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
            // startingStationArrivalDataGridViewTextBoxColumn
            // 
            this.startingStationArrivalDataGridViewTextBoxColumn.DataPropertyName = "StartingStation_Arrival";
            this.startingStationArrivalDataGridViewTextBoxColumn.HeaderText = "StartingStation_Arrival";
            this.startingStationArrivalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startingStationArrivalDataGridViewTextBoxColumn.Name = "startingStationArrivalDataGridViewTextBoxColumn";
            this.startingStationArrivalDataGridViewTextBoxColumn.Width = 125;
            // 
            // endStationArrivalDataGridViewTextBoxColumn
            // 
            this.endStationArrivalDataGridViewTextBoxColumn.DataPropertyName = "EndStation_Arrival";
            this.endStationArrivalDataGridViewTextBoxColumn.HeaderText = "EndStation_Arrival";
            this.endStationArrivalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endStationArrivalDataGridViewTextBoxColumn.Name = "endStationArrivalDataGridViewTextBoxColumn";
            this.endStationArrivalDataGridViewTextBoxColumn.Width = 125;
            // 
            // price1stClasssDataGridViewTextBoxColumn
            // 
            this.price1stClasssDataGridViewTextBoxColumn.DataPropertyName = "Price_1stClasss";
            this.price1stClasssDataGridViewTextBoxColumn.HeaderText = "Price_1stClasss";
            this.price1stClasssDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.price1stClasssDataGridViewTextBoxColumn.Name = "price1stClasssDataGridViewTextBoxColumn";
            this.price1stClasssDataGridViewTextBoxColumn.Width = 125;
            // 
            // price2ndClassDataGridViewTextBoxColumn
            // 
            this.price2ndClassDataGridViewTextBoxColumn.DataPropertyName = "Price_2ndClass";
            this.price2ndClassDataGridViewTextBoxColumn.HeaderText = "Price_2ndClass";
            this.price2ndClassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.price2ndClassDataGridViewTextBoxColumn.Name = "price2ndClassDataGridViewTextBoxColumn";
            this.price2ndClassDataGridViewTextBoxColumn.Width = 125;
            // 
            // price3rdClassDataGridViewTextBoxColumn
            // 
            this.price3rdClassDataGridViewTextBoxColumn.DataPropertyName = "Price_3rdClass";
            this.price3rdClassDataGridViewTextBoxColumn.HeaderText = "Price_3rdClass";
            this.price3rdClassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.price3rdClassDataGridViewTextBoxColumn.Name = "price3rdClassDataGridViewTextBoxColumn";
            this.price3rdClassDataGridViewTextBoxColumn.Width = 125;
            // 
            // tTSystemDataSet5BindingSource
            // 
            this.tTSystemDataSet5BindingSource.DataSource = this.tTSystemDataSet5;
            this.tTSystemDataSet5BindingSource.Position = 0;
            // 
            // tTSystemDataSet5
            // 
            this.tTSystemDataSet5.DataSetName = "TTSystemDataSet5";
            this.tTSystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(820, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Welcome Page";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Route.*\r\nFROM     Route";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ACHILA_MSI;Initial Catalog=TTSystem;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Root_No", System.Data.SqlDbType.VarChar, 0, "Root_No"),
            new System.Data.SqlClient.SqlParameter("@Train_No", System.Data.SqlDbType.VarChar, 0, "Train_No"),
            new System.Data.SqlClient.SqlParameter("@Start_Station", System.Data.SqlDbType.VarChar, 0, "Start_Station"),
            new System.Data.SqlClient.SqlParameter("@End_Station", System.Data.SqlDbType.VarChar, 0, "End_Station"),
            new System.Data.SqlClient.SqlParameter("@StartingStation_Arrival", System.Data.SqlDbType.Time, 0, "StartingStation_Arrival"),
            new System.Data.SqlClient.SqlParameter("@EndStation_Arrival", System.Data.SqlDbType.Time, 0, "EndStation_Arrival"),
            new System.Data.SqlClient.SqlParameter("@Price_1stClasss", System.Data.SqlDbType.Int, 0, "Price_1stClasss"),
            new System.Data.SqlClient.SqlParameter("@Price_2ndClass", System.Data.SqlDbType.Int, 0, "Price_2ndClass"),
            new System.Data.SqlClient.SqlParameter("@Price_3rdClass", System.Data.SqlDbType.Int, 0, "Price_3rdClass")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Root_No", System.Data.SqlDbType.VarChar, 0, "Root_No"),
            new System.Data.SqlClient.SqlParameter("@Train_No", System.Data.SqlDbType.VarChar, 0, "Train_No"),
            new System.Data.SqlClient.SqlParameter("@Start_Station", System.Data.SqlDbType.VarChar, 0, "Start_Station"),
            new System.Data.SqlClient.SqlParameter("@End_Station", System.Data.SqlDbType.VarChar, 0, "End_Station"),
            new System.Data.SqlClient.SqlParameter("@StartingStation_Arrival", System.Data.SqlDbType.Time, 0, "StartingStation_Arrival"),
            new System.Data.SqlClient.SqlParameter("@EndStation_Arrival", System.Data.SqlDbType.Time, 0, "EndStation_Arrival"),
            new System.Data.SqlClient.SqlParameter("@Price_1stClasss", System.Data.SqlDbType.Int, 0, "Price_1stClasss"),
            new System.Data.SqlClient.SqlParameter("@Price_2ndClass", System.Data.SqlDbType.Int, 0, "Price_2ndClass"),
            new System.Data.SqlClient.SqlParameter("@Price_3rdClass", System.Data.SqlDbType.Int, 0, "Price_3rdClass"),
            new System.Data.SqlClient.SqlParameter("@Original_Root_No", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Root_No", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Train_No", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Train_No", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Start_Station", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Start_Station", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_End_Station", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "End_Station", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_StartingStation_Arrival", System.Data.SqlDbType.Time, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StartingStation_Arrival", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EndStation_Arrival", System.Data.SqlDbType.Time, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EndStation_Arrival", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Price_1stClasss", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price_1stClasss", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Price_2ndClass", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price_2ndClass", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Price_3rdClass", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price_3rdClass", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Root_No", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Root_No", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Train_No", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Train_No", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Start_Station", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Start_Station", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_End_Station", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "End_Station", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_StartingStation_Arrival", System.Data.SqlDbType.Time, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StartingStation_Arrival", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EndStation_Arrival", System.Data.SqlDbType.Time, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EndStation_Arrival", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Price_1stClasss", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price_1stClasss", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Price_2ndClass", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price_2ndClass", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Price_3rdClass", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price_3rdClass", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Route", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Root_No", "Root_No"),
                        new System.Data.Common.DataColumnMapping("Train_No", "Train_No"),
                        new System.Data.Common.DataColumnMapping("Start_Station", "Start_Station"),
                        new System.Data.Common.DataColumnMapping("End_Station", "End_Station"),
                        new System.Data.Common.DataColumnMapping("StartingStation_Arrival", "StartingStation_Arrival"),
                        new System.Data.Common.DataColumnMapping("EndStation_Arrival", "EndStation_Arrival"),
                        new System.Data.Common.DataColumnMapping("Price_1stClasss", "Price_1stClasss"),
                        new System.Data.Common.DataColumnMapping("Price_2ndClass", "Price_2ndClass"),
                        new System.Data.Common.DataColumnMapping("Price_3rdClass", "Price_3rdClass")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.tTSystemDataSet5;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // routeBindingSource1
            // 
            this.routeBindingSource1.DataMember = "Route";
            this.routeBindingSource1.DataSource = this.tTSystemDataSet5;
            // 
            // routeBindingSource2
            // 
            this.routeBindingSource2.DataMember = "Route";
            this.routeBindingSource2.DataSource = this.tTSystemDataSet5;
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "TimeTable";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TimeTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private TTSystemDataSet5 tTSystemDataSet5;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private TTSystemDataSet5TableAdapters.RouteTableAdapter routeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rootNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startStationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endStationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingStationArrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endStationArrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price1stClasssDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price2ndClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price3rdClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tTSystemDataSet5BindingSource;
        private System.Windows.Forms.BindingSource routeBindingSource1;
        private System.Windows.Forms.BindingSource routeBindingSource2;
    }
}