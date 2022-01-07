
namespace coursework
{
    partial class AddTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTicket));
            this.fourHourTF = new System.Windows.Forms.TextBox();
            this.twoHourTF = new System.Windows.Forms.TextBox();
            this.ticketTypeList = new System.Windows.Forms.ComboBox();
            this.threeHourTF = new System.Windows.Forms.TextBox();
            this.timeLabel4 = new System.Windows.Forms.Label();
            this.oneHourTF = new System.Windows.Forms.TextBox();
            this.noOfPeopleLabel = new System.Windows.Forms.Label();
            this.timeLabel3 = new System.Windows.Forms.Label();
            this.timeLabel2 = new System.Windows.Forms.Label();
            this.wholeDayTF = new System.Windows.Forms.TextBox();
            this.timeLabel1 = new System.Windows.Forms.Label();
            this.ticketTypeLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.timeLabel5 = new System.Windows.Forms.Label();
            this.ticketPricesGroup = new System.Windows.Forms.GroupBox();
            this.meroRecreationCenterLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addNewTicketLbl = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.noOfPeopleCB = new System.Windows.Forms.ComboBox();
            this.chooseFilePathDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fourHourTF
            // 
            this.fourHourTF.Location = new System.Drawing.Point(80, 304);
            this.fourHourTF.Name = "fourHourTF";
            this.fourHourTF.Size = new System.Drawing.Size(61, 20);
            this.fourHourTF.TabIndex = 70;
            this.fourHourTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hourPricesTF_KeyPress);
            // 
            // twoHourTF
            // 
            this.twoHourTF.Location = new System.Drawing.Point(131, 234);
            this.twoHourTF.Name = "twoHourTF";
            this.twoHourTF.Size = new System.Drawing.Size(61, 20);
            this.twoHourTF.TabIndex = 62;
            this.twoHourTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hourPricesTF_KeyPress);
            // 
            // ticketTypeList
            // 
            this.ticketTypeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketTypeList.FormattingEnabled = true;
            this.ticketTypeList.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Group"});
            this.ticketTypeList.Location = new System.Drawing.Point(138, 80);
            this.ticketTypeList.Name = "ticketTypeList";
            this.ticketTypeList.Size = new System.Drawing.Size(135, 21);
            this.ticketTypeList.TabIndex = 56;
            this.ticketTypeList.Text = "Select";
            this.ticketTypeList.SelectedIndexChanged += new System.EventHandler(this.ticketTypeList_SelectedIndexChanged);
            // 
            // threeHourTF
            // 
            this.threeHourTF.Location = new System.Drawing.Point(224, 234);
            this.threeHourTF.Name = "threeHourTF";
            this.threeHourTF.Size = new System.Drawing.Size(61, 20);
            this.threeHourTF.TabIndex = 63;
            this.threeHourTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hourPricesTF_KeyPress);
            // 
            // timeLabel4
            // 
            this.timeLabel4.AutoSize = true;
            this.timeLabel4.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel4.ForeColor = System.Drawing.Color.Indigo;
            this.timeLabel4.Location = new System.Drawing.Point(84, 280);
            this.timeLabel4.Name = "timeLabel4";
            this.timeLabel4.Size = new System.Drawing.Size(57, 16);
            this.timeLabel4.TabIndex = 68;
            this.timeLabel4.Text = "4 Hours:";
            // 
            // oneHourTF
            // 
            this.oneHourTF.Location = new System.Drawing.Point(37, 234);
            this.oneHourTF.Name = "oneHourTF";
            this.oneHourTF.Size = new System.Drawing.Size(61, 20);
            this.oneHourTF.TabIndex = 61;
            this.oneHourTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hourPricesTF_KeyPress);
            // 
            // noOfPeopleLabel
            // 
            this.noOfPeopleLabel.AutoSize = true;
            this.noOfPeopleLabel.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfPeopleLabel.ForeColor = System.Drawing.Color.Indigo;
            this.noOfPeopleLabel.Location = new System.Drawing.Point(42, 125);
            this.noOfPeopleLabel.Name = "noOfPeopleLabel";
            this.noOfPeopleLabel.Size = new System.Drawing.Size(90, 16);
            this.noOfPeopleLabel.TabIndex = 64;
            this.noOfPeopleLabel.Text = "No. of People:";
            // 
            // timeLabel3
            // 
            this.timeLabel3.AutoSize = true;
            this.timeLabel3.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel3.ForeColor = System.Drawing.Color.Indigo;
            this.timeLabel3.Location = new System.Drawing.Point(228, 210);
            this.timeLabel3.Name = "timeLabel3";
            this.timeLabel3.Size = new System.Drawing.Size(57, 16);
            this.timeLabel3.TabIndex = 69;
            this.timeLabel3.Text = "3 Hours:";
            // 
            // timeLabel2
            // 
            this.timeLabel2.AutoSize = true;
            this.timeLabel2.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel2.ForeColor = System.Drawing.Color.Indigo;
            this.timeLabel2.Location = new System.Drawing.Point(135, 210);
            this.timeLabel2.Name = "timeLabel2";
            this.timeLabel2.Size = new System.Drawing.Size(57, 16);
            this.timeLabel2.TabIndex = 67;
            this.timeLabel2.Text = "2 Hours:";
            // 
            // wholeDayTF
            // 
            this.wholeDayTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholeDayTF.Location = new System.Drawing.Point(199, 304);
            this.wholeDayTF.Name = "wholeDayTF";
            this.wholeDayTF.Size = new System.Drawing.Size(61, 20);
            this.wholeDayTF.TabIndex = 58;
            this.wholeDayTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hourPricesTF_KeyPress);
            // 
            // timeLabel1
            // 
            this.timeLabel1.AutoSize = true;
            this.timeLabel1.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel1.ForeColor = System.Drawing.Color.Indigo;
            this.timeLabel1.Location = new System.Drawing.Point(42, 210);
            this.timeLabel1.Name = "timeLabel1";
            this.timeLabel1.Size = new System.Drawing.Size(51, 16);
            this.timeLabel1.TabIndex = 66;
            this.timeLabel1.Text = "1 Hour:";
            // 
            // ticketTypeLabel
            // 
            this.ticketTypeLabel.AutoSize = true;
            this.ticketTypeLabel.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketTypeLabel.ForeColor = System.Drawing.Color.Indigo;
            this.ticketTypeLabel.Location = new System.Drawing.Point(42, 82);
            this.ticketTypeLabel.Name = "ticketTypeLabel";
            this.ticketTypeLabel.Size = new System.Drawing.Size(79, 16);
            this.ticketTypeLabel.TabIndex = 65;
            this.ticketTypeLabel.Text = "Ticket Type:";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(129, 345);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.saveBtn.Size = new System.Drawing.Size(72, 25);
            this.saveBtn.TabIndex = 59;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // timeLabel5
            // 
            this.timeLabel5.AutoSize = true;
            this.timeLabel5.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel5.ForeColor = System.Drawing.Color.Indigo;
            this.timeLabel5.Location = new System.Drawing.Point(196, 280);
            this.timeLabel5.Name = "timeLabel5";
            this.timeLabel5.Size = new System.Drawing.Size(77, 16);
            this.timeLabel5.TabIndex = 60;
            this.timeLabel5.Text = "Whole Day:";
            // 
            // ticketPricesGroup
            // 
            this.ticketPricesGroup.Location = new System.Drawing.Point(10, 174);
            this.ticketPricesGroup.Name = "ticketPricesGroup";
            this.ticketPricesGroup.Size = new System.Drawing.Size(318, 161);
            this.ticketPricesGroup.TabIndex = 71;
            this.ticketPricesGroup.TabStop = false;
            this.ticketPricesGroup.Text = "Ticket Prices";
            // 
            // meroRecreationCenterLabel
            // 
            this.meroRecreationCenterLabel.Font = new System.Drawing.Font("Convection", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meroRecreationCenterLabel.ForeColor = System.Drawing.Color.Green;
            this.meroRecreationCenterLabel.Location = new System.Drawing.Point(48, 9);
            this.meroRecreationCenterLabel.Name = "meroRecreationCenterLabel";
            this.meroRecreationCenterLabel.Size = new System.Drawing.Size(155, 29);
            this.meroRecreationCenterLabel.TabIndex = 73;
            this.meroRecreationCenterLabel.Text = "Mero Recreation Center";
            this.meroRecreationCenterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // addNewTicketLbl
            // 
            this.addNewTicketLbl.Font = new System.Drawing.Font("Convection", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewTicketLbl.Location = new System.Drawing.Point(94, 41);
            this.addNewTicketLbl.Name = "addNewTicketLbl";
            this.addNewTicketLbl.Size = new System.Drawing.Size(166, 29);
            this.addNewTicketLbl.TabIndex = 74;
            this.addNewTicketLbl.Text = "ADD NEW TICKET PRICE";
            this.addNewTicketLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DarkRed;
            this.closeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButton.Location = new System.Drawing.Point(310, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 25);
            this.closeButton.TabIndex = 75;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.noOfPeopleCB);
            this.panel1.Controls.Add(this.ticketPricesGroup);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 386);
            this.panel1.TabIndex = 76;
            // 
            // noOfPeopleCB
            // 
            this.noOfPeopleCB.Enabled = false;
            this.noOfPeopleCB.FormattingEnabled = true;
            this.noOfPeopleCB.Items.AddRange(new object[] {
            "1",
            "1-5",
            "5-10",
            "10-15",
            "15-20",
            "20-25",
            "25-30",
            "30-35",
            "35-40",
            "40-45",
            "45-50"});
            this.noOfPeopleCB.Location = new System.Drawing.Point(136, 123);
            this.noOfPeopleCB.Name = "noOfPeopleCB";
            this.noOfPeopleCB.Size = new System.Drawing.Size(135, 21);
            this.noOfPeopleCB.TabIndex = 0;
            // 
            // chooseFilePathDialog
            // 
            this.chooseFilePathDialog.FileName = "ticket_db.csv";
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(342, 387);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addNewTicketLbl);
            this.Controls.Add(this.meroRecreationCenterLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fourHourTF);
            this.Controls.Add(this.twoHourTF);
            this.Controls.Add(this.ticketTypeList);
            this.Controls.Add(this.threeHourTF);
            this.Controls.Add(this.timeLabel4);
            this.Controls.Add(this.oneHourTF);
            this.Controls.Add(this.noOfPeopleLabel);
            this.Controls.Add(this.timeLabel3);
            this.Controls.Add(this.timeLabel2);
            this.Controls.Add(this.wholeDayTF);
            this.Controls.Add(this.timeLabel1);
            this.Controls.Add(this.ticketTypeLabel);
            this.Controls.Add(this.timeLabel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fourHourTF;
        private System.Windows.Forms.TextBox twoHourTF;
        private System.Windows.Forms.ComboBox ticketTypeList;
        private System.Windows.Forms.TextBox threeHourTF;
        private System.Windows.Forms.Label timeLabel4;
        private System.Windows.Forms.TextBox oneHourTF;
        private System.Windows.Forms.Label noOfPeopleLabel;
        private System.Windows.Forms.Label timeLabel3;
        private System.Windows.Forms.Label timeLabel2;
        private System.Windows.Forms.TextBox wholeDayTF;
        private System.Windows.Forms.Label timeLabel1;
        private System.Windows.Forms.Label ticketTypeLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label timeLabel5;
        private System.Windows.Forms.GroupBox ticketPricesGroup;
        private System.Windows.Forms.Label meroRecreationCenterLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label addNewTicketLbl;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog chooseFilePathDialog;
        private System.Windows.Forms.ComboBox noOfPeopleCB;
    }
}