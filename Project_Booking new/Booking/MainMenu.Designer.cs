namespace Booking
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_root = new System.Windows.Forms.Button();
            this.btn_train = new System.Windows.Forms.Button();
            this.btn_ticket = new System.Windows.Forms.Button();
            this.btn_booking = new System.Windows.Forms.Button();
            this.btn_welcome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(686, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // btn_root
            // 
            this.btn_root.BackColor = System.Drawing.Color.Navy;
            this.btn_root.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_root.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_root.Location = new System.Drawing.Point(693, 128);
            this.btn_root.Name = "btn_root";
            this.btn_root.Size = new System.Drawing.Size(196, 44);
            this.btn_root.TabIndex = 1;
            this.btn_root.Text = "View Root";
            this.btn_root.UseVisualStyleBackColor = false;
            this.btn_root.Click += new System.EventHandler(this.btn_root_Click);
            // 
            // btn_train
            // 
            this.btn_train.BackColor = System.Drawing.Color.Navy;
            this.btn_train.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_train.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_train.Location = new System.Drawing.Point(693, 291);
            this.btn_train.Name = "btn_train";
            this.btn_train.Size = new System.Drawing.Size(196, 44);
            this.btn_train.TabIndex = 2;
            this.btn_train.Text = "View Train";
            this.btn_train.UseVisualStyleBackColor = false;
            this.btn_train.Click += new System.EventHandler(this.btn_train_Click);
            // 
            // btn_ticket
            // 
            this.btn_ticket.BackColor = System.Drawing.Color.Navy;
            this.btn_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ticket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ticket.Location = new System.Drawing.Point(693, 206);
            this.btn_ticket.Name = "btn_ticket";
            this.btn_ticket.Size = new System.Drawing.Size(196, 45);
            this.btn_ticket.TabIndex = 3;
            this.btn_ticket.Text = "View Ticket";
            this.btn_ticket.UseVisualStyleBackColor = false;
            this.btn_ticket.Click += new System.EventHandler(this.btn_ticket_Click);
            // 
            // btn_booking
            // 
            this.btn_booking.BackColor = System.Drawing.Color.Navy;
            this.btn_booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_booking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_booking.Location = new System.Drawing.Point(693, 389);
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.Size = new System.Drawing.Size(196, 45);
            this.btn_booking.TabIndex = 4;
            this.btn_booking.Text = "View Booking";
            this.btn_booking.UseVisualStyleBackColor = false;
            this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
            // 
            // btn_welcome
            // 
            this.btn_welcome.BackColor = System.Drawing.Color.Orange;
            this.btn_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_welcome.ForeColor = System.Drawing.Color.White;
            this.btn_welcome.Location = new System.Drawing.Point(895, 495);
            this.btn_welcome.Name = "btn_welcome";
            this.btn_welcome.Size = new System.Drawing.Size(170, 36);
            this.btn_welcome.TabIndex = 5;
            this.btn_welcome.Text = "Welcome Page";
            this.btn_welcome.UseVisualStyleBackColor = false;
            this.btn_welcome.Click += new System.EventHandler(this.btn_welcome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 582);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 582);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_welcome);
            this.Controls.Add(this.btn_booking);
            this.Controls.Add(this.btn_ticket);
            this.Controls.Add(this.btn_train);
            this.Controls.Add(this.btn_root);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_root;
        private System.Windows.Forms.Button btn_train;
        private System.Windows.Forms.Button btn_ticket;
        private System.Windows.Forms.Button btn_booking;
        private System.Windows.Forms.Button btn_welcome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}