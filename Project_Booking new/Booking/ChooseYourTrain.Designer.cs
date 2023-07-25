
namespace Booking
{
    partial class ChooseYourTrain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseYourTrain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Start_Station = new System.Windows.Forms.ComboBox();
            this.cmb_End_Station = new System.Windows.Forms.ComboBox();
            this.btn5Search = new System.Windows.Forms.Button();
            this.btn5Reset = new System.Windows.Forms.Button();
            this.btn5Previous = new System.Windows.Forms.Button();
            this.dataGrid6 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(201, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Your Train";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(69, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Starting Station";
            // 
            // cmb_Start_Station
            // 
            this.cmb_Start_Station.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Start_Station.FormattingEnabled = true;
            this.cmb_Start_Station.Items.AddRange(new object[] {
            "Colombo Fort",
            "Maradana",
            "Dematagoda",
            "Kelaniya",
            "Wanawasala",
            "Ragama",
            "Ganemulla",
            "Kandy",
            "Badulla"});
            this.cmb_Start_Station.Location = new System.Drawing.Point(387, 115);
            this.cmb_Start_Station.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Start_Station.Name = "cmb_Start_Station";
            this.cmb_Start_Station.Size = new System.Drawing.Size(160, 30);
            this.cmb_Start_Station.TabIndex = 3;
            this.cmb_Start_Station.SelectedIndexChanged += new System.EventHandler(this.cmb_Start_Station_SelectedIndexChanged);
            // 
            // cmb_End_Station
            // 
            this.cmb_End_Station.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_End_Station.FormattingEnabled = true;
            this.cmb_End_Station.Items.AddRange(new object[] {
            "Colombo Fort",
            "Maradana",
            "Dematagoda",
            "Kelaniya",
            "Wanawasala",
            "Ragama",
            "Ganemulla",
            "Kandy",
            "Badulla",
            "Gampha"});
            this.cmb_End_Station.Location = new System.Drawing.Point(387, 168);
            this.cmb_End_Station.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_End_Station.Name = "cmb_End_Station";
            this.cmb_End_Station.Size = new System.Drawing.Size(160, 30);
            this.cmb_End_Station.TabIndex = 4;
            this.cmb_End_Station.SelectedIndexChanged += new System.EventHandler(this.cmb_End_Station_SelectedIndexChanged);
            // 
            // btn5Search
            // 
            this.btn5Search.BackColor = System.Drawing.Color.SeaGreen;
            this.btn5Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5Search.Location = new System.Drawing.Point(74, 225);
            this.btn5Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn5Search.Name = "btn5Search";
            this.btn5Search.Size = new System.Drawing.Size(126, 44);
            this.btn5Search.TabIndex = 7;
            this.btn5Search.Text = "Search";
            this.btn5Search.UseVisualStyleBackColor = false;
            this.btn5Search.Click += new System.EventHandler(this.btn5Search_Click);
            // 
            // btn5Reset
            // 
            this.btn5Reset.BackColor = System.Drawing.Color.Orange;
            this.btn5Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5Reset.Location = new System.Drawing.Point(74, 593);
            this.btn5Reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn5Reset.Name = "btn5Reset";
            this.btn5Reset.Size = new System.Drawing.Size(136, 38);
            this.btn5Reset.TabIndex = 8;
            this.btn5Reset.Text = "Reset";
            this.btn5Reset.UseVisualStyleBackColor = false;
            this.btn5Reset.Click += new System.EventHandler(this.btn5Reset_Click);
            // 
            // btn5Previous
            // 
            this.btn5Previous.BackColor = System.Drawing.Color.Indigo;
            this.btn5Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Previous.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5Previous.Location = new System.Drawing.Point(333, 593);
            this.btn5Previous.Margin = new System.Windows.Forms.Padding(4);
            this.btn5Previous.Name = "btn5Previous";
            this.btn5Previous.Size = new System.Drawing.Size(136, 38);
            this.btn5Previous.TabIndex = 9;
            this.btn5Previous.Text = "Previous";
            this.btn5Previous.UseVisualStyleBackColor = false;
            this.btn5Previous.Click += new System.EventHandler(this.btn5Previous_Click);
            // 
            // dataGrid6
            // 
            this.dataGrid6.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGrid6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid6.Location = new System.Drawing.Point(25, 277);
            this.dataGrid6.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid6.Name = "dataGrid6";
            this.dataGrid6.RowHeadersWidth = 51;
            this.dataGrid6.Size = new System.Drawing.Size(620, 294);
            this.dataGrid6.TabIndex = 10;
            this.dataGrid6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid6_CellContentClick);
            this.dataGrid6.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid6_CellMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(69, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ending Station";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 649);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ChooseYourTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGrid6);
            this.Controls.Add(this.btn5Previous);
            this.Controls.Add(this.btn5Reset);
            this.Controls.Add(this.btn5Search);
            this.Controls.Add(this.cmb_End_Station);
            this.Controls.Add(this.cmb_Start_Station);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChooseYourTrain";
            this.Text = "Choose Your Train";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Start_Station;
        private System.Windows.Forms.ComboBox cmb_End_Station;
        private System.Windows.Forms.Button btn5Search;
        private System.Windows.Forms.Button btn5Reset;
        private System.Windows.Forms.Button btn5Previous;
        private System.Windows.Forms.DataGridView dataGrid6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}