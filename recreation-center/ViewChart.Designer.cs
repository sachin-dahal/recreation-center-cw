
namespace coursework
{
    partial class ViewChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.weeklyChartLbl = new System.Windows.Forms.Label();
            this.dayVsVisitors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dayVsIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadChartBtn = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dayVsVisitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayVsIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // weeklyChartLbl
            // 
            this.weeklyChartLbl.AutoSize = true;
            this.weeklyChartLbl.Font = new System.Drawing.Font("Convection", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyChartLbl.ForeColor = System.Drawing.Color.Indigo;
            this.weeklyChartLbl.Location = new System.Drawing.Point(12, 9);
            this.weeklyChartLbl.Name = "weeklyChartLbl";
            this.weeklyChartLbl.Size = new System.Drawing.Size(102, 17);
            this.weeklyChartLbl.TabIndex = 47;
            this.weeklyChartLbl.Text = "Weekly Charts";
            // 
            // dayVsVisitors
            // 
            chartArea1.Name = "ChartArea1";
            this.dayVsVisitors.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.dayVsVisitors.Legends.Add(legend1);
            this.dayVsVisitors.Location = new System.Drawing.Point(7, 44);
            this.dayVsVisitors.Name = "dayVsVisitors";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Day vs Visitors";
            this.dayVsVisitors.Series.Add(series1);
            this.dayVsVisitors.Size = new System.Drawing.Size(335, 205);
            this.dayVsVisitors.TabIndex = 48;
            this.dayVsVisitors.Text = "chart1";
            // 
            // dayVsIncome
            // 
            chartArea2.Name = "ChartArea1";
            this.dayVsIncome.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.dayVsIncome.Legends.Add(legend2);
            this.dayVsIncome.Location = new System.Drawing.Point(349, 44);
            this.dayVsIncome.Name = "dayVsIncome";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Day vs Income";
            this.dayVsIncome.Series.Add(series2);
            this.dayVsIncome.Size = new System.Drawing.Size(335, 205);
            this.dayVsIncome.TabIndex = 49;
            this.dayVsIncome.Text = "chart2";
            // 
            // loadChartBtn
            // 
            this.loadChartBtn.Font = new System.Drawing.Font("Convection", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadChartBtn.Location = new System.Drawing.Point(294, 269);
            this.loadChartBtn.Name = "loadChartBtn";
            this.loadChartBtn.Size = new System.Drawing.Size(100, 33);
            this.loadChartBtn.TabIndex = 50;
            this.loadChartBtn.Text = "Load Chart";
            this.loadChartBtn.UseVisualStyleBackColor = true;
            this.loadChartBtn.Click += new System.EventHandler(this.loadChartBtn_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkRed;
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(658, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(31, 30);
            this.exitButton.TabIndex = 51;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 323);
            this.panel1.TabIndex = 52;
            // 
            // ViewChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(690, 324);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loadChartBtn);
            this.Controls.Add(this.dayVsIncome);
            this.Controls.Add(this.dayVsVisitors);
            this.Controls.Add(this.weeklyChartLbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewChart";
            this.Load += new System.EventHandler(this.ViewChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dayVsVisitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayVsIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weeklyChartLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart dayVsVisitors;
        private System.Windows.Forms.DataVisualization.Charting.Chart dayVsIncome;
        private System.Windows.Forms.Button loadChartBtn;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
    }
}