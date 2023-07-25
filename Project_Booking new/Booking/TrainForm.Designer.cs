namespace Booking
{
    partial class TrainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofFirstClassSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofSecondClassSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofThirdClassSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTSystemDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTSystemDataSet1 = new Booking.TTSystemDataSet1();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainTableAdapter = new Booking.TTSystemDataSet1TableAdapters.TrainTableAdapter();
            this.tTSystemDataSet = new Booking.TTSystemDataSet();
            this.tTSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet.Route)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(303, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Train Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainNoDataGridViewTextBoxColumn,
            this.trainNameDataGridViewTextBoxColumn,
            this.trainTypeDataGridViewTextBoxColumn,
            this.noofFirstClassSeatsDataGridViewTextBoxColumn,
            this.noofSecondClassSeatsDataGridViewTextBoxColumn,
            this.noofThirdClassSeatsDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Train";
            this.dataGridView1.DataSource = this.tTSystemDataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(787, 351);
            this.dataGridView1.TabIndex = 1;
            // 
            // trainNoDataGridViewTextBoxColumn
            // 
            this.trainNoDataGridViewTextBoxColumn.DataPropertyName = "Train_No";
            this.trainNoDataGridViewTextBoxColumn.HeaderText = "Train_No";
            this.trainNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainNoDataGridViewTextBoxColumn.Name = "trainNoDataGridViewTextBoxColumn";
            this.trainNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainNameDataGridViewTextBoxColumn
            // 
            this.trainNameDataGridViewTextBoxColumn.DataPropertyName = "Train_Name";
            this.trainNameDataGridViewTextBoxColumn.HeaderText = "Train_Name";
            this.trainNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainNameDataGridViewTextBoxColumn.Name = "trainNameDataGridViewTextBoxColumn";
            this.trainNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainTypeDataGridViewTextBoxColumn
            // 
            this.trainTypeDataGridViewTextBoxColumn.DataPropertyName = "Train_Type";
            this.trainTypeDataGridViewTextBoxColumn.HeaderText = "Train_Type";
            this.trainTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainTypeDataGridViewTextBoxColumn.Name = "trainTypeDataGridViewTextBoxColumn";
            this.trainTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // noofFirstClassSeatsDataGridViewTextBoxColumn
            // 
            this.noofFirstClassSeatsDataGridViewTextBoxColumn.DataPropertyName = "No_of_FirstClassSeats";
            this.noofFirstClassSeatsDataGridViewTextBoxColumn.HeaderText = "No_of_FirstClassSeats";
            this.noofFirstClassSeatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noofFirstClassSeatsDataGridViewTextBoxColumn.Name = "noofFirstClassSeatsDataGridViewTextBoxColumn";
            this.noofFirstClassSeatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // noofSecondClassSeatsDataGridViewTextBoxColumn
            // 
            this.noofSecondClassSeatsDataGridViewTextBoxColumn.DataPropertyName = "No_of_SecondClassSeats";
            this.noofSecondClassSeatsDataGridViewTextBoxColumn.HeaderText = "No_of_SecondClassSeats";
            this.noofSecondClassSeatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noofSecondClassSeatsDataGridViewTextBoxColumn.Name = "noofSecondClassSeatsDataGridViewTextBoxColumn";
            this.noofSecondClassSeatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // noofThirdClassSeatsDataGridViewTextBoxColumn
            // 
            this.noofThirdClassSeatsDataGridViewTextBoxColumn.DataPropertyName = "No_of_ThirdClassSeats";
            this.noofThirdClassSeatsDataGridViewTextBoxColumn.HeaderText = "No_of_ThirdClassSeats";
            this.noofThirdClassSeatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noofThirdClassSeatsDataGridViewTextBoxColumn.Name = "noofThirdClassSeatsDataGridViewTextBoxColumn";
            this.noofThirdClassSeatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // tTSystemDataSet1BindingSource
            // 
            this.tTSystemDataSet1BindingSource.DataSource = this.tTSystemDataSet1;
            this.tTSystemDataSet1BindingSource.Position = 0;
            // 
            // tTSystemDataSet1
            // 
            this.tTSystemDataSet1.DataSetName = "TTSystemDataSet1";
            this.tTSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Train.*\r\nFROM     Train";
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
            new System.Data.SqlClient.SqlParameter("@Train_No", System.Data.SqlDbType.VarChar, 0, "Train_No"),
            new System.Data.SqlClient.SqlParameter("@Train_Name", System.Data.SqlDbType.VarChar, 0, "Train_Name"),
            new System.Data.SqlClient.SqlParameter("@Train_Type", System.Data.SqlDbType.VarChar, 0, "Train_Type"),
            new System.Data.SqlClient.SqlParameter("@No_of_FirstClassSeats", System.Data.SqlDbType.Int, 0, "No_of_FirstClassSeats"),
            new System.Data.SqlClient.SqlParameter("@No_of_SecondClassSeats", System.Data.SqlDbType.Int, 0, "No_of_SecondClassSeats"),
            new System.Data.SqlClient.SqlParameter("@No_of_ThirdClassSeats", System.Data.SqlDbType.Int, 0, "No_of_ThirdClassSeats")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Train_No", System.Data.SqlDbType.VarChar, 0, "Train_No"),
            new System.Data.SqlClient.SqlParameter("@Train_Name", System.Data.SqlDbType.VarChar, 0, "Train_Name"),
            new System.Data.SqlClient.SqlParameter("@Train_Type", System.Data.SqlDbType.VarChar, 0, "Train_Type"),
            new System.Data.SqlClient.SqlParameter("@No_of_FirstClassSeats", System.Data.SqlDbType.Int, 0, "No_of_FirstClassSeats"),
            new System.Data.SqlClient.SqlParameter("@No_of_SecondClassSeats", System.Data.SqlDbType.Int, 0, "No_of_SecondClassSeats"),
            new System.Data.SqlClient.SqlParameter("@No_of_ThirdClassSeats", System.Data.SqlDbType.Int, 0, "No_of_ThirdClassSeats"),
            new System.Data.SqlClient.SqlParameter("@Original_Train_No", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Train_No", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Train_Name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Train_Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Train_Type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Train_Type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_No_of_FirstClassSeats", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No_of_FirstClassSeats", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_No_of_SecondClassSeats", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No_of_SecondClassSeats", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_No_of_ThirdClassSeats", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No_of_ThirdClassSeats", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Train_No", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Train_No", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Train_Name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Train_Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Train_Type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Train_Type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_No_of_FirstClassSeats", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No_of_FirstClassSeats", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_No_of_SecondClassSeats", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No_of_SecondClassSeats", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_No_of_ThirdClassSeats", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No_of_ThirdClassSeats", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Train", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Train_No", "Train_No"),
                        new System.Data.Common.DataColumnMapping("Train_Name", "Train_Name"),
                        new System.Data.Common.DataColumnMapping("Train_Type", "Train_Type"),
                        new System.Data.Common.DataColumnMapping("No_of_FirstClassSeats", "No_of_FirstClassSeats"),
                        new System.Data.Common.DataColumnMapping("No_of_SecondClassSeats", "No_of_SecondClassSeats"),
                        new System.Data.Common.DataColumnMapping("No_of_ThirdClassSeats", "No_of_ThirdClassSeats")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.Orange;
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Location = new System.Drawing.Point(895, 494);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(147, 37);
            this.btn_menu.TabIndex = 11;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Navy;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(895, 364);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(156, 44);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Navy;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(895, 268);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(156, 48);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Navy;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(895, 179);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(156, 44);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add/Edit";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.Navy;
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.ForeColor = System.Drawing.Color.White;
            this.btn_Load.Location = new System.Drawing.Point(895, 80);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(156, 46);
            this.btn_Load.TabIndex = 7;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataMember = "Train";
            this.trainBindingSource.DataSource = this.tTSystemDataSet1;
            // 
            // trainTableAdapter
            // 
            this.trainTableAdapter.ClearBeforeFill = true;
            // 
            // tTSystemDataSet
            // 
            this.tTSystemDataSet.DataSetName = "TTSystemDataSet";
            // 
            // 
            // 
            this.tTSystemDataSet.Route.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Root_No"}, true)});
            this.tTSystemDataSet.Route.TableName = "Root";
            this.tTSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTSystemDataSetBindingSource
            // 
            this.tTSystemDataSetBindingSource.DataSource = this.tTSystemDataSet;
            this.tTSystemDataSetBindingSource.Position = 0;
            // 
            // TrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "TrainForm";
            this.Text = "TrainForm";
            this.Load += new System.EventHandler(this.TrainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet.Route)).EndInit();
       //     ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Load;
        private TTSystemDataSet1 tTSystemDataSet1;
        private System.Windows.Forms.BindingSource trainBindingSource;
        private TTSystemDataSet1TableAdapters.TrainTableAdapter trainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofFirstClassSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofSecondClassSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofThirdClassSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tTSystemDataSet1BindingSource;
        private TTSystemDataSet tTSystemDataSet;
        private System.Windows.Forms.BindingSource tTSystemDataSetBindingSource;
    }
}