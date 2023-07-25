
namespace Booking
{
    partial class WelcomeToSriLanka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeToSriLanka));
            this.lblHomeDisplay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnHSearch = new System.Windows.Forms.Button();
            this.btnHBuy = new System.Windows.Forms.Button();
            this.btnHBook = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_loginform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHomeDisplay
            // 
            this.lblHomeDisplay.AutoSize = true;
            this.lblHomeDisplay.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHomeDisplay.Location = new System.Drawing.Point(298, 23);
            this.lblHomeDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomeDisplay.Name = "lblHomeDisplay";
            this.lblHomeDisplay.Size = new System.Drawing.Size(524, 40);
            this.lblHomeDisplay.TabIndex = 0;
            this.lblHomeDisplay.Text = "Welcome To Sri Lanka Railways";
            this.lblHomeDisplay.Click += new System.EventHandler(this.lblHomeDisplay_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnHSearch
            // 
            this.btnHSearch.BackColor = System.Drawing.Color.Silver;
            this.btnHSearch.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHSearch.Location = new System.Drawing.Point(75, 490);
            this.btnHSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnHSearch.Name = "btnHSearch";
            this.btnHSearch.Size = new System.Drawing.Size(193, 49);
            this.btnHSearch.TabIndex = 2;
            this.btnHSearch.Text = "Search";
            this.btnHSearch.UseVisualStyleBackColor = false;
            this.btnHSearch.Click += new System.EventHandler(this.btnHSearch_Click);
            // 
            // btnHBuy
            // 
            this.btnHBuy.BackColor = System.Drawing.Color.Silver;
            this.btnHBuy.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHBuy.Location = new System.Drawing.Point(336, 491);
            this.btnHBuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHBuy.Name = "btnHBuy";
            this.btnHBuy.Size = new System.Drawing.Size(176, 48);
            this.btnHBuy.TabIndex = 3;
            this.btnHBuy.Text = "Buy Tickets";
            this.btnHBuy.UseVisualStyleBackColor = false;
            this.btnHBuy.Click += new System.EventHandler(this.btnHBuy_Click);
            // 
            // btnHBook
            // 
            this.btnHBook.BackColor = System.Drawing.Color.Silver;
            this.btnHBook.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHBook.Location = new System.Drawing.Point(619, 490);
            this.btnHBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnHBook.Name = "btnHBook";
            this.btnHBook.Size = new System.Drawing.Size(160, 48);
            this.btnHBook.TabIndex = 4;
            this.btnHBook.Text = "Booking";
            this.btnHBook.UseVisualStyleBackColor = false;
            this.btnHBook.Click += new System.EventHandler(this.btnHBook_Click);
            // 
            // btn_loginform
            // 
            this.btn_loginform.BackColor = System.Drawing.Color.Silver;
            this.btn_loginform.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loginform.Location = new System.Drawing.Point(865, 490);
            this.btn_loginform.Margin = new System.Windows.Forms.Padding(4);
            this.btn_loginform.Name = "btn_loginform";
            this.btn_loginform.Size = new System.Drawing.Size(160, 48);
            this.btn_loginform.TabIndex = 5;
            this.btn_loginform.Text = "Login";
            this.btn_loginform.UseVisualStyleBackColor = false;
            this.btn_loginform.Click += new System.EventHandler(this.button1_Click);
            // 
            // WelcomeToSriLanka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.btn_loginform);
            this.Controls.Add(this.btnHBook);
            this.Controls.Add(this.btnHBuy);
            this.Controls.Add(this.btnHSearch);
            this.Controls.Add(this.lblHomeDisplay);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WelcomeToSriLanka";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnHSearch;
        private System.Windows.Forms.Button btnHBuy;
        private System.Windows.Forms.Button btnHBook;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_loginform;
    }
}