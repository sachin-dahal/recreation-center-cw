using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class ViewChart : Form
    {
        ReportsPage rp;
        public ViewChart(ReportsPage rp)
        {
            InitializeComponent();
            this.rp = rp;
        }

        private void loadChartBtn_Click(object sender, EventArgs e)
        {
            this.dayVsVisitors.Series["Day vs Visitors"].Points.Clear();
            this.dayVsIncome.Series["Day vs Income"].Points.Clear();
            try
            {
                if (rp.weeklyReportModels.Length > 0)
                {

                    for (int i = 1; i < rp.weeklyReportModels.Length; i++)
                    {
                        string chart_day = rp.weeklyReportModels[i].WeekDay;
                        int chart_people = rp.weeklyReportModels[i].TotalVisitors;
                        double chart_income = rp.weeklyReportModels[i].TotalIncome;

                        this.dayVsVisitors.Series["Day vs Visitors"].Points.AddXY(chart_day, chart_people);
                        this.dayVsIncome.Series["Day vs Income"].Points.AddXY(chart_day, chart_income);
                    }
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show("Weekly report not found!", "Error");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ViewChart_Load(object sender, EventArgs e)
        {

        }
    }
}
