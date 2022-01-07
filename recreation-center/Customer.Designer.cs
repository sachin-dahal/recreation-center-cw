
using System.Windows.Forms;

namespace coursework
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.openBrowseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addCustomerGroup = new System.Windows.Forms.GroupBox();
            this.noOfPeopleTF = new System.Windows.Forms.TextBox();
            this.noOfPeopleLabel = new System.Windows.Forms.Label();
            this.importTicketsInfo = new System.Windows.Forms.Label();
            this.customerAddressTF = new System.Windows.Forms.TextBox();
            this.ticketCategoriesList = new System.Windows.Forms.ComboBox();
            this.phoneTF = new System.Windows.Forms.TextBox();
            this.ticketCategoryLbl = new System.Windows.Forms.Label();
            this.customerNameTF = new System.Windows.Forms.TextBox();
            this.customerIdTF = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.addressLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.timeOutDatePicker = new System.Windows.Forms.DateTimePicker();
            this.customerIdLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.timeInDatePicker = new System.Windows.Forms.DateTimePicker();
            this.timeInLbl = new System.Windows.Forms.Label();
            this.timeOutLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.customerDetailsGroup = new System.Windows.Forms.GroupBox();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.txtFileTF = new System.Windows.Forms.TextBox();
            this.fileLbl = new System.Windows.Forms.Label();
            this.importBtn = new System.Windows.Forms.Button();
            this.saveCustomerCSV = new System.Windows.Forms.SaveFileDialog();
            this.addCustomerGroup.SuspendLayout();
            this.customerDetailsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // openBrowseFileDialog
            // 
            this.openBrowseFileDialog.FileName = "openFileDialog1";
            // 
            // addCustomerGroup
            // 
            this.addCustomerGroup.Controls.Add(this.noOfPeopleTF);
            this.addCustomerGroup.Controls.Add(this.noOfPeopleLabel);
            this.addCustomerGroup.Controls.Add(this.importTicketsInfo);
            this.addCustomerGroup.Controls.Add(this.customerAddressTF);
            this.addCustomerGroup.Controls.Add(this.ticketCategoriesList);
            this.addCustomerGroup.Controls.Add(this.phoneTF);
            this.addCustomerGroup.Controls.Add(this.ticketCategoryLbl);
            this.addCustomerGroup.Controls.Add(this.customerNameTF);
            this.addCustomerGroup.Controls.Add(this.customerIdTF);
            this.addCustomerGroup.Controls.Add(this.phoneLbl);
            this.addCustomerGroup.Controls.Add(this.datePicker);
            this.addCustomerGroup.Controls.Add(this.addressLbl);
            this.addCustomerGroup.Controls.Add(this.nameLbl);
            this.addCustomerGroup.Controls.Add(this.timeOutDatePicker);
            this.addCustomerGroup.Controls.Add(this.customerIdLbl);
            this.addCustomerGroup.Controls.Add(this.saveBtn);
            this.addCustomerGroup.Controls.Add(this.timeInDatePicker);
            this.addCustomerGroup.Controls.Add(this.timeInLbl);
            this.addCustomerGroup.Controls.Add(this.timeOutLbl);
            this.addCustomerGroup.Controls.Add(this.dateLbl);
            this.addCustomerGroup.Font = new System.Drawing.Font("Convection Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerGroup.ForeColor = System.Drawing.Color.Crimson;
            this.addCustomerGroup.Location = new System.Drawing.Point(12, 251);
            this.addCustomerGroup.Name = "addCustomerGroup";
            this.addCustomerGroup.Size = new System.Drawing.Size(666, 220);
            this.addCustomerGroup.TabIndex = 47;
            this.addCustomerGroup.TabStop = false;
            this.addCustomerGroup.Text = "Add Customer";
            // 
            // noOfPeopleTF
            // 
            this.noOfPeopleTF.Enabled = false;
            this.noOfPeopleTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfPeopleTF.Location = new System.Drawing.Point(476, 58);
            this.noOfPeopleTF.Name = "noOfPeopleTF";
            this.noOfPeopleTF.Size = new System.Drawing.Size(135, 20);
            this.noOfPeopleTF.TabIndex = 56;
            this.noOfPeopleTF.Leave += new System.EventHandler(this.noOfPeopleTF_Leave);
            // 
            // noOfPeopleLabel
            // 
            this.noOfPeopleLabel.AutoSize = true;
            this.noOfPeopleLabel.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfPeopleLabel.ForeColor = System.Drawing.Color.Indigo;
            this.noOfPeopleLabel.Location = new System.Drawing.Point(361, 59);
            this.noOfPeopleLabel.Name = "noOfPeopleLabel";
            this.noOfPeopleLabel.Size = new System.Drawing.Size(90, 16);
            this.noOfPeopleLabel.TabIndex = 57;
            this.noOfPeopleLabel.Text = "No. of People:";
            // 
            // importTicketsInfo
            // 
            this.importTicketsInfo.AutoSize = true;
            this.importTicketsInfo.Font = new System.Drawing.Font("Convection Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importTicketsInfo.Location = new System.Drawing.Point(9, 185);
            this.importTicketsInfo.Name = "importTicketsInfo";
            this.importTicketsInfo.Size = new System.Drawing.Size(331, 18);
            this.importTicketsInfo.TabIndex = 55;
            this.importTicketsInfo.Text = "⚠️ Please import tickets before adding a customer";
            // 
            // customerAddressTF
            // 
            this.customerAddressTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressTF.Location = new System.Drawing.Point(202, 82);
            this.customerAddressTF.Name = "customerAddressTF";
            this.customerAddressTF.Size = new System.Drawing.Size(135, 20);
            this.customerAddressTF.TabIndex = 49;
            // 
            // ticketCategoriesList
            // 
            this.ticketCategoriesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketCategoriesList.FormattingEnabled = true;
            this.ticketCategoriesList.Items.AddRange(new object[] {
            "Single",
            "Group"});
            this.ticketCategoriesList.Location = new System.Drawing.Point(476, 31);
            this.ticketCategoriesList.Name = "ticketCategoriesList";
            this.ticketCategoriesList.Size = new System.Drawing.Size(135, 21);
            this.ticketCategoriesList.TabIndex = 4;
            this.ticketCategoriesList.Text = "Select";
            this.ticketCategoriesList.SelectedIndexChanged += new System.EventHandler(this.ticketCategoriesList_SelectedIndexChanged);
            // 
            // phoneTF
            // 
            this.phoneTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTF.Location = new System.Drawing.Point(202, 110);
            this.phoneTF.Name = "phoneTF";
            this.phoneTF.Size = new System.Drawing.Size(135, 20);
            this.phoneTF.TabIndex = 50;
            // 
            // ticketCategoryLbl
            // 
            this.ticketCategoryLbl.AutoSize = true;
            this.ticketCategoryLbl.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketCategoryLbl.ForeColor = System.Drawing.Color.Indigo;
            this.ticketCategoryLbl.Location = new System.Drawing.Point(361, 31);
            this.ticketCategoryLbl.Name = "ticketCategoryLbl";
            this.ticketCategoryLbl.Size = new System.Drawing.Size(104, 16);
            this.ticketCategoryLbl.TabIndex = 54;
            this.ticketCategoryLbl.Text = "Ticket Category:";
            // 
            // customerNameTF
            // 
            this.customerNameTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTF.Location = new System.Drawing.Point(202, 55);
            this.customerNameTF.Name = "customerNameTF";
            this.customerNameTF.Size = new System.Drawing.Size(135, 20);
            this.customerNameTF.TabIndex = 48;
            // 
            // customerIdTF
            // 
            this.customerIdTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdTF.Location = new System.Drawing.Point(202, 27);
            this.customerIdTF.Name = "customerIdTF";
            this.customerIdTF.Size = new System.Drawing.Size(135, 20);
            this.customerIdTF.TabIndex = 47;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.ForeColor = System.Drawing.Color.Indigo;
            this.phoneLbl.Location = new System.Drawing.Point(106, 113);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(49, 16);
            this.phoneLbl.TabIndex = 54;
            this.phoneLbl.Text = "Phone:";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(476, 144);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(135, 20);
            this.datePicker.TabIndex = 9;
            this.datePicker.Value = new System.DateTime(2022, 1, 2, 2, 16, 4, 0);
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.ForeColor = System.Drawing.Color.Indigo;
            this.addressLbl.Location = new System.Drawing.Point(106, 85);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(59, 16);
            this.addressLbl.TabIndex = 53;
            this.addressLbl.Text = "Address:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.Indigo;
            this.nameLbl.Location = new System.Drawing.Point(106, 58);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(45, 16);
            this.nameLbl.TabIndex = 52;
            this.nameLbl.Text = "Name:";
            // 
            // timeOutDatePicker
            // 
            this.timeOutDatePicker.CustomFormat = "hh:mm tt";
            this.timeOutDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeOutDatePicker.Location = new System.Drawing.Point(476, 112);
            this.timeOutDatePicker.Name = "timeOutDatePicker";
            this.timeOutDatePicker.ShowUpDown = true;
            this.timeOutDatePicker.Size = new System.Drawing.Size(135, 20);
            this.timeOutDatePicker.TabIndex = 8;
            this.timeOutDatePicker.Value = new System.DateTime(2021, 12, 29, 11, 0, 0, 0);
            this.timeOutDatePicker.MouseHover += new System.EventHandler(this.timeOutDatePicker_MouseHover);
            // 
            // customerIdLbl
            // 
            this.customerIdLbl.AutoSize = true;
            this.customerIdLbl.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdLbl.ForeColor = System.Drawing.Color.Indigo;
            this.customerIdLbl.Location = new System.Drawing.Point(106, 30);
            this.customerIdLbl.Name = "customerIdLbl";
            this.customerIdLbl.Size = new System.Drawing.Size(85, 16);
            this.customerIdLbl.TabIndex = 51;
            this.customerIdLbl.Text = "Customer ID:";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(536, 180);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.saveBtn.Size = new System.Drawing.Size(75, 34);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // timeInDatePicker
            // 
            this.timeInDatePicker.CustomFormat = "hh:mm tt";
            this.timeInDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeInDatePicker.Location = new System.Drawing.Point(476, 85);
            this.timeInDatePicker.Name = "timeInDatePicker";
            this.timeInDatePicker.ShowUpDown = true;
            this.timeInDatePicker.Size = new System.Drawing.Size(135, 20);
            this.timeInDatePicker.TabIndex = 7;
            this.timeInDatePicker.Value = new System.DateTime(2021, 12, 28, 10, 0, 0, 0);
            this.timeInDatePicker.ValueChanged += new System.EventHandler(this.timeInDatePicker_ValueChanged_1);
            this.timeInDatePicker.MouseHover += new System.EventHandler(this.timeInDatePicker_MouseHover);
            // 
            // timeInLbl
            // 
            this.timeInLbl.AutoSize = true;
            this.timeInLbl.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInLbl.ForeColor = System.Drawing.Color.Indigo;
            this.timeInLbl.Location = new System.Drawing.Point(361, 87);
            this.timeInLbl.Name = "timeInLbl";
            this.timeInLbl.Size = new System.Drawing.Size(55, 16);
            this.timeInLbl.TabIndex = 48;
            this.timeInLbl.Text = "Time IN:";
            // 
            // timeOutLbl
            // 
            this.timeOutLbl.AutoSize = true;
            this.timeOutLbl.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutLbl.ForeColor = System.Drawing.Color.Indigo;
            this.timeOutLbl.Location = new System.Drawing.Point(361, 114);
            this.timeOutLbl.Name = "timeOutLbl";
            this.timeOutLbl.Size = new System.Drawing.Size(67, 16);
            this.timeOutLbl.TabIndex = 49;
            this.timeOutLbl.Text = "Time OUT:";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Convection", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.Color.Indigo;
            this.dateLbl.Location = new System.Drawing.Point(361, 144);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(39, 16);
            this.dateLbl.TabIndex = 50;
            this.dateLbl.Text = "Date:";
            // 
            // customerDetailsGroup
            // 
            this.customerDetailsGroup.Controls.Add(this.customersDataGridView);
            this.customerDetailsGroup.Controls.Add(this.txtFileTF);
            this.customerDetailsGroup.Controls.Add(this.fileLbl);
            this.customerDetailsGroup.Controls.Add(this.importBtn);
            this.customerDetailsGroup.Font = new System.Drawing.Font("Convection Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDetailsGroup.ForeColor = System.Drawing.Color.Crimson;
            this.customerDetailsGroup.Location = new System.Drawing.Point(12, 12);
            this.customerDetailsGroup.Name = "customerDetailsGroup";
            this.customerDetailsGroup.Size = new System.Drawing.Size(666, 230);
            this.customerDetailsGroup.TabIndex = 53;
            this.customerDetailsGroup.TabStop = false;
            this.customerDetailsGroup.Text = "Customer Details";
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Location = new System.Drawing.Point(9, 62);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.customersDataGridView.Size = new System.Drawing.Size(650, 150);
            this.customersDataGridView.TabIndex = 47;
            // 
            // txtFileTF
            // 
            this.txtFileTF.Font = new System.Drawing.Font("Convection Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileTF.Location = new System.Drawing.Point(48, 26);
            this.txtFileTF.Multiline = true;
            this.txtFileTF.Name = "txtFileTF";
            this.txtFileTF.Size = new System.Drawing.Size(523, 26);
            this.txtFileTF.TabIndex = 43;
            // 
            // fileLbl
            // 
            this.fileLbl.AutoSize = true;
            this.fileLbl.Font = new System.Drawing.Font("Convection", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLbl.ForeColor = System.Drawing.Color.Indigo;
            this.fileLbl.Location = new System.Drawing.Point(6, 27);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(36, 17);
            this.fileLbl.TabIndex = 45;
            this.fileLbl.Text = "File:";
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.importBtn.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.importBtn.Image = ((System.Drawing.Image)(resources.GetObject("importBtn.Image")));
            this.importBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importBtn.Location = new System.Drawing.Point(577, 27);
            this.importBtn.Name = "importBtn";
            this.importBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.importBtn.Size = new System.Drawing.Size(82, 26);
            this.importBtn.TabIndex = 46;
            this.importBtn.Text = "Import";
            this.importBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.viewBtn_Click_1);
            // 
            // saveCustomerCSV
            // 
            this.saveCustomerCSV.FileName = "customer_db.csv";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(683, 478);
            this.Controls.Add(this.customerDetailsGroup);
            this.Controls.Add(this.addCustomerGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coursework App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.addCustomerGroup.ResumeLayout(false);
            this.addCustomerGroup.PerformLayout();
            this.customerDetailsGroup.ResumeLayout(false);
            this.customerDetailsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openBrowseFileDialog;
        private ToolTip timeToolTip;
        private GroupBox addCustomerGroup;
        private ComboBox ticketCategoriesList;
        private Label ticketCategoryLbl;
        private DateTimePicker datePicker;
        private DateTimePicker timeOutDatePicker;
        private Button saveBtn;
        private DateTimePicker timeInDatePicker;
        private Label timeInLbl;
        private Label timeOutLbl;
        private Label dateLbl;
        private GroupBox customerDetailsGroup;
        private TextBox txtFileTF;
        private Label fileLbl;
        private Button importBtn;
        private TextBox customerAddressTF;
        private TextBox phoneTF;
        private TextBox customerNameTF;
        private TextBox customerIdTF;
        private Label phoneLbl;
        private Label addressLbl;
        private Label nameLbl;
        private Label customerIdLbl;
        private DataGridView customersDataGridView;
        private Label importTicketsInfo;
        private SaveFileDialog saveCustomerCSV;
        private TextBox noOfPeopleTF;
        private Label noOfPeopleLabel;
    }
}

