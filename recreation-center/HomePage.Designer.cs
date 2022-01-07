
namespace coursework
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.reportLabel = new System.Windows.Forms.Label();
            this.ticketPriceLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.appName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.selectedMenuLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.copyrightLabel);
            this.panel1.Controls.Add(this.logoutLabel);
            this.panel1.Controls.Add(this.reportLabel);
            this.panel1.Controls.Add(this.ticketPriceLabel);
            this.panel1.Controls.Add(this.customerLabel);
            this.panel1.Controls.Add(this.locationLbl);
            this.panel1.Controls.Add(this.appName);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 508);
            this.panel1.TabIndex = 0;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Font = new System.Drawing.Font("Convection", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.Image = ((System.Drawing.Image)(resources.GetObject("copyrightLabel.Image")));
            this.copyrightLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyrightLabel.Location = new System.Drawing.Point(13, 479);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.copyrightLabel.Size = new System.Drawing.Size(179, 23);
            this.copyrightLabel.TabIndex = 53;
            this.copyrightLabel.Text = "       2021-2022. All Rights Reserved";
            this.copyrightLabel.Click += new System.EventHandler(this.copyrightLabel_Click);
            // 
            // logoutLabel
            // 
            this.logoutLabel.Font = new System.Drawing.Font("Convection", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.Location = new System.Drawing.Point(3, 439);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(190, 40);
            this.logoutLabel.TabIndex = 7;
            this.logoutLabel.Text = "Log Out";
            this.logoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutLabel.Click += new System.EventHandler(this.logoutLabel_Click);
            this.logoutLabel.MouseEnter += new System.EventHandler(this.logoutLabel_MouseEnter);
            this.logoutLabel.MouseLeave += new System.EventHandler(this.logoutLabel_MouseLeave);
            // 
            // reportLabel
            // 
            this.reportLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.reportLabel.Font = new System.Drawing.Font("Convection", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.Location = new System.Drawing.Point(3, 236);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(190, 40);
            this.reportLabel.TabIndex = 6;
            this.reportLabel.Text = "Report";
            this.reportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reportLabel.Click += new System.EventHandler(this.reportLabel_Click);
            this.reportLabel.MouseEnter += new System.EventHandler(this.reportLabel_MouseEnter);
            this.reportLabel.MouseLeave += new System.EventHandler(this.reportLabel_MouseLeave);
            // 
            // ticketPriceLabel
            // 
            this.ticketPriceLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.ticketPriceLabel.Font = new System.Drawing.Font("Convection", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketPriceLabel.Location = new System.Drawing.Point(4, 172);
            this.ticketPriceLabel.Name = "ticketPriceLabel";
            this.ticketPriceLabel.Size = new System.Drawing.Size(190, 40);
            this.ticketPriceLabel.TabIndex = 5;
            this.ticketPriceLabel.Text = "Ticket Price";
            this.ticketPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ticketPriceLabel.Click += new System.EventHandler(this.viewTicketLabel_Click);
            this.ticketPriceLabel.MouseEnter += new System.EventHandler(this.viewTicketLabel_MouseEnter);
            this.ticketPriceLabel.MouseLeave += new System.EventHandler(this.viewTicketLabel_MouseLeave);
            // 
            // customerLabel
            // 
            this.customerLabel.BackColor = System.Drawing.Color.LightGreen;
            this.customerLabel.Font = new System.Drawing.Font("Convection", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customerLabel.Location = new System.Drawing.Point(3, 110);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(190, 40);
            this.customerLabel.TabIndex = 3;
            this.customerLabel.Text = "Customer";
            this.customerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customerLabel.Click += new System.EventHandler(this.customerLabel_Click);
            this.customerLabel.MouseEnter += new System.EventHandler(this.customerLabel_MouseEnter);
            this.customerLabel.MouseLeave += new System.EventHandler(this.customerLabel_MouseLeave);
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Location = new System.Drawing.Point(85, 50);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(77, 13);
            this.locationLbl.TabIndex = 2;
            this.locationLbl.Text = "Itahari, Sunsari";
            // 
            // appName
            // 
            this.appName.Font = new System.Drawing.Font("Convection", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.Location = new System.Drawing.Point(64, 14);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(122, 39);
            this.appName.TabIndex = 1;
            this.appName.Text = "MERO RECREATION CENTER";
            this.appName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.appName.Click += new System.EventHandler(this.label1_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(9, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(54, 49);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkRed;
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(861, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(21, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // selectedMenuLabel
            // 
            this.selectedMenuLabel.Font = new System.Drawing.Font("Convection", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedMenuLabel.Location = new System.Drawing.Point(455, 4);
            this.selectedMenuLabel.Name = "selectedMenuLabel";
            this.selectedMenuLabel.Size = new System.Drawing.Size(149, 24);
            this.selectedMenuLabel.TabIndex = 10;
            this.selectedMenuLabel.Text = "Customer";
            this.selectedMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(198, 29);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(684, 477);
            this.mainPanel.TabIndex = 11;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(885, 509);
            this.Controls.Add(this.selectedMenuLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffMainPage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.Label ticketPriceLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label selectedMenuLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label copyrightLabel;
    }
}