
namespace coursework
{
    partial class ReportsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsPage));
            this.dailyReportLbl = new System.Windows.Forms.Label();
            this.dailyReportDate = new System.Windows.Forms.DateTimePicker();
            this.viewDailyReportBtn = new System.Windows.Forms.Button();
            this.dailyReportTable = new System.Windows.Forms.DataGridView();
            this.weeklyReportLbl = new System.Windows.Forms.Label();
            this.fromDateLbl = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tillDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tillDateLbl = new System.Windows.Forms.Label();
            this.sortByCB = new System.Windows.Forms.ComboBox();
            this.sortByLbl = new System.Windows.Forms.Label();
            this.weeklyReportTable = new System.Windows.Forms.DataGridView();
            this.dateLbl = new System.Windows.Forms.Label();
            this.viewWeeklyReportBtn = new System.Windows.Forms.Button();
            this.saveDailyReportBtn = new System.Windows.Forms.Button();
            this.saveWeeklyReportBtn = new System.Windows.Forms.Button();
            this.saveDailyReportFile = new System.Windows.Forms.SaveFileDialog();
            this.saveWeeklyReportFile = new System.Windows.Forms.SaveFileDialog();
            this.viewDataInChartBtn = new System.Windows.Forms.Button();
            this.date2Lbl = new System.Windows.Forms.Label();
            this.weeklyReportDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dailyReportLbl
            // 
            this.dailyReportLbl.AutoSize = true;
            this.dailyReportLbl.Font = new System.Drawing.Font("Convection", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyReportLbl.ForeColor = System.Drawing.Color.Indigo;
            this.dailyReportLbl.Location = new System.Drawing.Point(7, 9);
            this.dailyReportLbl.Name = "dailyReportLbl";
            this.dailyReportLbl.Size = new System.Drawing.Size(87, 17);
            this.dailyReportLbl.TabIndex = 46;
            this.dailyReportLbl.Text = "Daily Report";
            // 
            // dailyReportDate
            // 
            this.dailyReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dailyReportDate.Location = new System.Drawing.Point(560, 37);
            this.dailyReportDate.Name = "dailyReportDate";
            this.dailyReportDate.Size = new System.Drawing.Size(118, 20);
            this.dailyReportDate.TabIndex = 47;
            // 
            // viewDailyReportBtn
            // 
            this.viewDailyReportBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.viewDailyReportBtn.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDailyReportBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewDailyReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewDailyReportBtn.Image")));
            this.viewDailyReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewDailyReportBtn.Location = new System.Drawing.Point(606, 64);
            this.viewDailyReportBtn.Name = "viewDailyReportBtn";
            this.viewDailyReportBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.viewDailyReportBtn.Size = new System.Drawing.Size(75, 26);
            this.viewDailyReportBtn.TabIndex = 48;
            this.viewDailyReportBtn.Text = "View";
            this.viewDailyReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewDailyReportBtn.UseVisualStyleBackColor = false;
            this.viewDailyReportBtn.Click += new System.EventHandler(this.viewDailyReportBtn_Click);
            // 
            // dailyReportTable
            // 
            this.dailyReportTable.AllowUserToAddRows = false;
            this.dailyReportTable.AllowUserToDeleteRows = false;
            this.dailyReportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dailyReportTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dailyReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyReportTable.Location = new System.Drawing.Point(10, 37);
            this.dailyReportTable.Name = "dailyReportTable";
            this.dailyReportTable.ReadOnly = true;
            this.dailyReportTable.Size = new System.Drawing.Size(485, 164);
            this.dailyReportTable.TabIndex = 49;
            // 
            // weeklyReportLbl
            // 
            this.weeklyReportLbl.AutoSize = true;
            this.weeklyReportLbl.Font = new System.Drawing.Font("Convection", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyReportLbl.ForeColor = System.Drawing.Color.Indigo;
            this.weeklyReportLbl.Location = new System.Drawing.Point(7, 213);
            this.weeklyReportLbl.Name = "weeklyReportLbl";
            this.weeklyReportLbl.Size = new System.Drawing.Size(103, 17);
            this.weeklyReportLbl.TabIndex = 50;
            this.weeklyReportLbl.Text = "Weekly Report";
            // 
            // fromDateLbl
            // 
            this.fromDateLbl.AutoSize = true;
            this.fromDateLbl.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.fromDateLbl.Location = new System.Drawing.Point(514, 308);
            this.fromDateLbl.Name = "fromDateLbl";
            this.fromDateLbl.Size = new System.Drawing.Size(38, 14);
            this.fromDateLbl.TabIndex = 51;
            this.fromDateLbl.Text = "From:";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Enabled = false;
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDatePicker.Location = new System.Drawing.Point(500, 328);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(82, 20);
            this.fromDatePicker.TabIndex = 52;
            this.fromDatePicker.Value = new System.DateTime(2022, 1, 3, 0, 0, 0, 0);
            // 
            // tillDatePicker
            // 
            this.tillDatePicker.Enabled = false;
            this.tillDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tillDatePicker.Location = new System.Drawing.Point(599, 328);
            this.tillDatePicker.Name = "tillDatePicker";
            this.tillDatePicker.Size = new System.Drawing.Size(82, 20);
            this.tillDatePicker.TabIndex = 54;
            this.tillDatePicker.Value = new System.DateTime(2022, 1, 3, 0, 0, 0, 0);
            // 
            // tillDateLbl
            // 
            this.tillDateLbl.AutoSize = true;
            this.tillDateLbl.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tillDateLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.tillDateLbl.Location = new System.Drawing.Point(623, 308);
            this.tillDateLbl.Name = "tillDateLbl";
            this.tillDateLbl.Size = new System.Drawing.Size(27, 14);
            this.tillDateLbl.TabIndex = 53;
            this.tillDateLbl.Text = "Till:";
            // 
            // sortByCB
            // 
            this.sortByCB.FormattingEnabled = true;
            this.sortByCB.Items.AddRange(new object[] {
            "Total Visitors",
            "Total Earnings"});
            this.sortByCB.Location = new System.Drawing.Point(563, 232);
            this.sortByCB.Name = "sortByCB";
            this.sortByCB.Size = new System.Drawing.Size(118, 21);
            this.sortByCB.TabIndex = 55;
            this.sortByCB.Text = "Select";
            this.sortByCB.SelectedIndexChanged += new System.EventHandler(this.sortByCB_SelectedIndexChanged);
            // 
            // sortByLbl
            // 
            this.sortByLbl.AutoSize = true;
            this.sortByLbl.Font = new System.Drawing.Font("Convection", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByLbl.ForeColor = System.Drawing.Color.Indigo;
            this.sortByLbl.Location = new System.Drawing.Point(497, 233);
            this.sortByLbl.Name = "sortByLbl";
            this.sortByLbl.Size = new System.Drawing.Size(57, 17);
            this.sortByLbl.TabIndex = 56;
            this.sortByLbl.Text = "Sort By:";
            // 
            // weeklyReportTable
            // 
            this.weeklyReportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.weeklyReportTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.weeklyReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyReportTable.Location = new System.Drawing.Point(12, 232);
            this.weeklyReportTable.Name = "weeklyReportTable";
            this.weeklyReportTable.Size = new System.Drawing.Size(483, 217);
            this.weeklyReportTable.TabIndex = 57;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Convection", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.Color.Indigo;
            this.dateLbl.Location = new System.Drawing.Point(512, 38);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(42, 17);
            this.dateLbl.TabIndex = 58;
            this.dateLbl.Text = "Date:";
            // 
            // viewWeeklyReportBtn
            // 
            this.viewWeeklyReportBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.viewWeeklyReportBtn.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewWeeklyReportBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewWeeklyReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewWeeklyReportBtn.Image")));
            this.viewWeeklyReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewWeeklyReportBtn.Location = new System.Drawing.Point(609, 364);
            this.viewWeeklyReportBtn.Name = "viewWeeklyReportBtn";
            this.viewWeeklyReportBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.viewWeeklyReportBtn.Size = new System.Drawing.Size(75, 26);
            this.viewWeeklyReportBtn.TabIndex = 59;
            this.viewWeeklyReportBtn.Text = "View";
            this.viewWeeklyReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewWeeklyReportBtn.UseVisualStyleBackColor = false;
            this.viewWeeklyReportBtn.Click += new System.EventHandler(this.viewWeeklyReportBtn_Click);
            // 
            // saveDailyReportBtn
            // 
            this.saveDailyReportBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveDailyReportBtn.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDailyReportBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveDailyReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveDailyReportBtn.Image")));
            this.saveDailyReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveDailyReportBtn.Location = new System.Drawing.Point(606, 112);
            this.saveDailyReportBtn.Name = "saveDailyReportBtn";
            this.saveDailyReportBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.saveDailyReportBtn.Size = new System.Drawing.Size(75, 26);
            this.saveDailyReportBtn.TabIndex = 60;
            this.saveDailyReportBtn.Text = "Save";
            this.saveDailyReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveDailyReportBtn.UseVisualStyleBackColor = false;
            this.saveDailyReportBtn.Visible = false;
            this.saveDailyReportBtn.Click += new System.EventHandler(this.saveDailyReportBtn_Click);
            // 
            // saveWeeklyReportBtn
            // 
            this.saveWeeklyReportBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveWeeklyReportBtn.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveWeeklyReportBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveWeeklyReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveWeeklyReportBtn.Image")));
            this.saveWeeklyReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveWeeklyReportBtn.Location = new System.Drawing.Point(527, 364);
            this.saveWeeklyReportBtn.Name = "saveWeeklyReportBtn";
            this.saveWeeklyReportBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.saveWeeklyReportBtn.Size = new System.Drawing.Size(75, 26);
            this.saveWeeklyReportBtn.TabIndex = 61;
            this.saveWeeklyReportBtn.Text = "Save";
            this.saveWeeklyReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveWeeklyReportBtn.UseVisualStyleBackColor = false;
            this.saveWeeklyReportBtn.Visible = false;
            this.saveWeeklyReportBtn.Click += new System.EventHandler(this.saveWeeklyReportBtn_Click);
            // 
            // saveDailyReportFile
            // 
            this.saveDailyReportFile.FileName = "daily_report.csv";
            // 
            // saveWeeklyReportFile
            // 
            this.saveWeeklyReportFile.FileName = "weekly_report.csv";
            // 
            // viewDataInChartBtn
            // 
            this.viewDataInChartBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.viewDataInChartBtn.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDataInChartBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewDataInChartBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewDataInChartBtn.Image")));
            this.viewDataInChartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewDataInChartBtn.Location = new System.Drawing.Point(524, 404);
            this.viewDataInChartBtn.Name = "viewDataInChartBtn";
            this.viewDataInChartBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.viewDataInChartBtn.Size = new System.Drawing.Size(154, 36);
            this.viewDataInChartBtn.TabIndex = 62;
            this.viewDataInChartBtn.Text = "View in Chart";
            this.viewDataInChartBtn.UseVisualStyleBackColor = false;
            this.viewDataInChartBtn.Visible = false;
            this.viewDataInChartBtn.Click += new System.EventHandler(this.viewDataInChartBtn_Click);
            // 
            // date2Lbl
            // 
            this.date2Lbl.AutoSize = true;
            this.date2Lbl.Font = new System.Drawing.Font("Convection", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2Lbl.ForeColor = System.Drawing.Color.Indigo;
            this.date2Lbl.Location = new System.Drawing.Point(514, 274);
            this.date2Lbl.Name = "date2Lbl";
            this.date2Lbl.Size = new System.Drawing.Size(42, 17);
            this.date2Lbl.TabIndex = 63;
            this.date2Lbl.Text = "Date:";
            // 
            // weeklyReportDate
            // 
            this.weeklyReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.weeklyReportDate.Location = new System.Drawing.Point(562, 274);
            this.weeklyReportDate.Name = "weeklyReportDate";
            this.weeklyReportDate.Size = new System.Drawing.Size(118, 20);
            this.weeklyReportDate.TabIndex = 64;
            this.weeklyReportDate.ValueChanged += new System.EventHandler(this.weeklyReportDate_ValueChanged);
            // 
            // ReportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(690, 452);
            this.Controls.Add(this.weeklyReportDate);
            this.Controls.Add(this.date2Lbl);
            this.Controls.Add(this.viewDataInChartBtn);
            this.Controls.Add(this.saveWeeklyReportBtn);
            this.Controls.Add(this.saveDailyReportBtn);
            this.Controls.Add(this.viewWeeklyReportBtn);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.weeklyReportTable);
            this.Controls.Add(this.sortByLbl);
            this.Controls.Add(this.sortByCB);
            this.Controls.Add(this.tillDatePicker);
            this.Controls.Add(this.tillDateLbl);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.fromDateLbl);
            this.Controls.Add(this.weeklyReportLbl);
            this.Controls.Add(this.dailyReportTable);
            this.Controls.Add(this.viewDailyReportBtn);
            this.Controls.Add(this.dailyReportDate);
            this.Controls.Add(this.dailyReportLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsPage";
            this.Text = "ReportsPage";
            this.Load += new System.EventHandler(this.ReportsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dailyReportLbl;
        private System.Windows.Forms.DateTimePicker dailyReportDate;
        private System.Windows.Forms.Button viewDailyReportBtn;
        private System.Windows.Forms.DataGridView dailyReportTable;
        private System.Windows.Forms.Label weeklyReportLbl;
        private System.Windows.Forms.Label fromDateLbl;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DateTimePicker tillDatePicker;
        private System.Windows.Forms.Label tillDateLbl;
        private System.Windows.Forms.ComboBox sortByCB;
        private System.Windows.Forms.Label sortByLbl;
        private System.Windows.Forms.DataGridView weeklyReportTable;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Button viewWeeklyReportBtn;
        private System.Windows.Forms.Button saveDailyReportBtn;
        private System.Windows.Forms.Button saveWeeklyReportBtn;
        private System.Windows.Forms.SaveFileDialog saveDailyReportFile;
        private System.Windows.Forms.SaveFileDialog saveWeeklyReportFile;
        private System.Windows.Forms.Button viewDataInChartBtn;
        private System.Windows.Forms.Label date2Lbl;
        private System.Windows.Forms.DateTimePicker weeklyReportDate;
    }
}