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
    public partial class ReportsPage : Form
    {

        string onlyData = "";
        string dataWithLabel = "";
        public WeeklyReportModel[] weeklyReportModels = new WeeklyReportModel[7];

        public ReportsPage()
        {
            InitializeComponent();
        }

        private void viewDailyReportBtn_Click(object sender, EventArgs e)
        {
            if (GlobalData.customersListFilePath == "")
            {
                MessageBox.Show("Please load the customers data for the clarity of report", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (GlobalData.ticketPricesFilePath == "") {
                MessageBox.Show("Please load the ticket prices for the clarity of report", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(GlobalData.customersListFilePath);
                int child = 0;
                int adult = 0;
                int group5 = 0;
                int group10 = 0;
                int group15 = 0;
                int group20 = 0;
                int group25 = 0;
                int group30 = 0;
                int group35 = 0;
                int group40 = 0;
                int group45 = 0;
                int group50 = 0;

                DateTime dailyReportDatevalue = dailyReportDate.Value;
                string date = dailyReportDatevalue.ToString("MM/dd/yyyy");
               
                if (lines.Length > 0)
                {
                    //For Data
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] dataWords = lines[i].Split(',');

                      // MessageBox.Show(date, DateTime.Parse(dataWords[1]).ToString("MM/dd/yyyy"));

                        if (date.Equals(DateTime.Parse(dataWords[1]).ToString("MM/dd/yyyy")))
                        {
                            if (dataWords[5] == "Child")
                            {
                                child += int.Parse(dataWords[6]);
                            }
                            else if (dataWords[5] == "Adult")
                            {
                                adult += int.Parse(dataWords[6]);
                            }
                            else if (dataWords[5] == "Group of 1-5")
                            {
                                group5 += int.Parse(dataWords[6]);
                            }
                            else if (dataWords[5] == "Group of 5-10")
                            {
                                group10 += int.Parse(dataWords[6]);
                            }
                            else if (dataWords[5] == "Group of 10-15")
                            {
                                group15 += int.Parse(dataWords[6]);
                            }
                            else if (dataWords[5] == "Group of 15-20")
                            {
                                group20 += int.Parse(dataWords[6]);
                            }
                            else if (dataWords[5] == "Group of 20-25")
                            {
                                group25 += int.Parse(dataWords[6]);
                            }
                            else if (dataWords[5] == "Group of 25-30")
                            {
                                group30 += int.Parse(dataWords[6]);
                            }
                            else if (dataWords[5] == "Group of 30-35")
                            {
                                group35 += int.Parse(dataWords[6]);
                            }
                            else if (dataWords[5] == "Group of 35-40")
                            {
                                group40 += int.Parse(dataWords[6]);
                            }
                            else if (dataWords[5] == "Group of 40-45")
                            {
                                group45 += int.Parse(dataWords[6]);
                            }
                            else if (dataWords[5] == "Group of 45-50")
                            {
                                group50 += int.Parse(dataWords[6]);
                            }
                        }
                    }

                    string[] allTicketCategoryList = { "Child", "Adult", "Group of 1-5", "Group of 5-10", "Group of 10-15", "Group of 15-20", "Group of 20-25", "Group of 25-30", "Group of 30-35", "Group of 35-40", "Group of 40-45", "Group of 45-50"};
                    int[] allcategoryPeopleList = { child, adult, group5, group10, group15, group20, group25, group30, group35, group40, group45, group50 };

                    DataTable dt = new DataTable();
                    string[] headerLabels = { "Ticket Category", "Total People", "Date" };
                    dataWithLabel = "Category," + "Total People," + "Date" + "\nChild," + child + "," + date + "\nAdult," + adult + "," + date + "\nGroup of 1-5," + group5 + "," + date + "\nGroup of 5-10," + group10 + "," + date + "\nGroup of 10-15," + group15 + "," + date + "\nGroup of 15-20," + group20 + "," + date + "\nGroup of 20-25," + group25 + "," + date + "\nGroup of 25-30," + group30 + "," + date + "\nGroup of 30-35," + group35 + "," + date + "\nGroup of 35-40," + group40 + "," + date + "\nGroup of 40-45," + group45 + "," + date + "\nGroup of 45-50," + group50 + "," + date;
                    onlyData = "Child," + child + "," + date + "\nAdult," + adult + "," + date + "\nGroup of 1-5," + group5 + "," + date + "\nGroup of 5-10," + group10 + "," + date + "\nGroup of 10-15," + group15 + "," + date + "\nGroup of 15-20," + group20 + "," + date + "\nGroup of 20-25," + group25 + "," + date + "\nGroup of 25-30," + group30 + "," + date + "\nGroup of 30-35," + group35 + "," + date + "\nGroup of 35-40," + group40 + "," + date + "\nGroup of 40-45," + group45 + "," + date + "\nGroup of 45-50," + group50 + "," + date;
                    
                    string[] categoryLines = File.ReadAllLines(GlobalData.ticketPricesFilePath);

                    if (categoryLines.Length > 0)
                    {
                        //first line to create header
                        foreach (string headerWord in headerLabels)
                        {
                            dt.Columns.Add(new DataColumn(headerWord));
                        }
                        //For Data
                        for (int i = 1; i <= allcategoryPeopleList.Length; i++)
                        {
                            string[] dataWords = { allTicketCategoryList[i-1], allcategoryPeopleList[i-1].ToString(), date };
                            int columnIndex = 0; 
                            DataRow dr = dt.NewRow();
                            foreach (string headerWord in headerLabels)
                            {
                                dr[headerWord] = dataWords[columnIndex++];
                            }
                            dt.Rows.Add(dr);
                        }
                    }
                    if (dt.Rows.Count > 0)
                    {
                        dailyReportTable.DataSource = dt;
                    }
                    saveDailyReportBtn.Visible = true;
                    MessageBox.Show("Daily Report for " + date + " is created sucessfully.", "Generate Daily Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show("Customer details not found!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindData(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dailyReportTable.DataSource = dt;
            }

        }

        private void saveDailyReportBtn_Click(object sender, EventArgs e)
        {
            saveDailyReportFile.ShowDialog();
            string filePath = saveDailyReportFile.FileName;
            if (File.Exists(filePath))
            {
                string[] reportWords = File.ReadAllLines(filePath);
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    if (reportWords.Length != 0)
                    {
                         sw.WriteLine(dataWithLabel);
                    }
                    else
                    {
                        sw.WriteLine(onlyData);
                    }
                }
            }
            else
            {
                var myFile = File.Create(filePath);
                myFile.Close();

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(dataWithLabel);

                }
            }
            MessageBox.Show("Daily report file saved successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static DateTime GetStartOfWeek(DateTime date, DayOfWeek startDayOfWeek)
        {
            int diff = (7 + (date.DayOfWeek - startDayOfWeek)) % 7;
            return date.AddDays(-1 * diff).Date;
        }

        private void weeklyReportDate_ValueChanged(object sender, EventArgs e)
        {
            fromDatePicker.Value = GetStartOfWeek(weeklyReportDate.Value, DayOfWeek.Sunday);
            tillDatePicker.Value = fromDatePicker.Value.AddDays(6);

        }

        private void viewWeeklyReportBtn_Click(object sender, EventArgs e)
        {
            if (GlobalData.customersListFilePath == "")
            {
                MessageBox.Show("Please load the customers data for the clarity of report", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (GlobalData.ticketPricesFilePath == "")
            {
                MessageBox.Show("Please load the ticket prices for the clarity of report", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(GlobalData.customersListFilePath);
            int peopleOnSun = 0;
            int peopleOnMon = 0;
            int peopleOnTue = 0;
            int peopleOnWed = 0;
            int peopleOnThu = 0;
            int peopleOnFri = 0;
            int peopleOnSat = 0;

            double moneyOnSun = 0;
            double moneyOnMon = 0;
            double moneyOnTue = 0;
            double moneyOnWed = 0;
            double moneyOnThu = 0;
            double moneyOnFri = 0;
            double moneyOnSat = 0;

            string fromDatePickerValue = fromDatePicker.Value.ToString("MM/dd/yyyy");
            string tillDatePickerValue = tillDatePicker.Value.ToString("MM/dd/yyyy");
            DateTime date1 = Convert.ToDateTime(fromDatePickerValue);
            DateTime date2 = Convert.ToDateTime(tillDatePickerValue);


            if (lines.Length > 0)
            {
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DateTime userDate = DateTime.Parse(dataWords[1]);

                        if (userDate.Ticks >= date1.Ticks && userDate.Ticks <= date2.Ticks)
                        {
                        if (userDate.DayOfWeek.ToString() == "Sunday")
                            {
                                peopleOnSun += int.Parse(dataWords[6]);
                                moneyOnSun += double.Parse(dataWords[9]);
                            }
                            else if (userDate.DayOfWeek.ToString() == "Monday")
                            {
                                peopleOnMon += int.Parse(dataWords[6]);
                                moneyOnMon += double.Parse(dataWords[9]);
                            }
                            else if (userDate.DayOfWeek.ToString() == "Tuesday")
                            {
                                peopleOnTue += int.Parse(dataWords[6]);
                                moneyOnTue += double.Parse(dataWords[9]);
                            }
                            else if (userDate.DayOfWeek.ToString() == "Wednesday")
                            {
                                peopleOnWed += int.Parse(dataWords[6]);
                                moneyOnWed += double.Parse(dataWords[9]);
                            }
                            else if (userDate.DayOfWeek.ToString() == "Thursday")
                            {
                                peopleOnThu += int.Parse(dataWords[6]);
                                moneyOnThu += double.Parse(dataWords[9]);
                            }
                            else if (userDate.DayOfWeek.ToString() == "Friday")
                            {
                                peopleOnFri += int.Parse(dataWords[6]);
                                moneyOnFri += double.Parse(dataWords[9]);
                            }
                            else if (userDate.DayOfWeek.ToString() == "Saturday")
                            {
                                peopleOnSat += int.Parse(dataWords[6]);
                                moneyOnSat += double.Parse(dataWords[9]);
                            }
                        }

                }

                string[] allWeekDaysList = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                int[] totalVisitorsList = { peopleOnSun, peopleOnMon, peopleOnTue, peopleOnWed, peopleOnThu, peopleOnFri, peopleOnSat };
                double[] totalIncomeList = { moneyOnSun, moneyOnMon, moneyOnTue, moneyOnWed, moneyOnThu, moneyOnFri, moneyOnSat };

                DataTable dt = new DataTable();
                string[] headerLabels = { "Week Day", "Total Visitors", "Total Income" };
                dataWithLabel = "Week Day," + "Total Vistors," + "Total Income" + "\nSunday," + peopleOnSun + "," + moneyOnSun + "\nMonday," + peopleOnMon + "," + moneyOnMon + "\nTuesday," + peopleOnTue + "," + moneyOnTue + "\nWednesday," + peopleOnWed + "," + moneyOnWed + "\nThursday," + peopleOnThu + "," + moneyOnThu + "\nFriday," + peopleOnFri + "," + moneyOnFri + "\nSaturday," + peopleOnSat + "," + moneyOnSat;
                onlyData = "Sunday," + peopleOnSun + "," + moneyOnSun + "\nMonday," + peopleOnMon + "," + moneyOnMon + "\nTuesday," + peopleOnTue + "," + moneyOnTue + "\nWednesday," + peopleOnWed + "," + moneyOnWed + "\nThursday," + peopleOnThu + "," + moneyOnThu + "\nFriday," + peopleOnFri + "," + moneyOnFri + "\nSaturday," + peopleOnSat + "," + moneyOnSat;

                // adding weekly report models to the array
                for (int i = 0; i < allWeekDaysList.Length; i++) {
                    weeklyReportModels[i] = new WeeklyReportModel(allWeekDaysList[i], totalVisitorsList[i], totalIncomeList[i]);
                    }

                if (lines.Length > 0)
                {
                    //first line to create header
                    foreach (string headerWord in headerLabels)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                    }
                    //For Data
                    for (int i = 1; i <= totalVisitorsList.Length; i++)
                    {
                        string[] dataWords = { allWeekDaysList[i - 1], totalVisitorsList[i - 1].ToString(), totalIncomeList[i-1].ToString()};
                        int columnIndex = 0;
                        DataRow dr = dt.NewRow();
                        foreach (string headerWord in headerLabels)
                        {
                            dr[headerWord] = dataWords[columnIndex++];
                        }
                        dt.Rows.Add(dr);
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    weeklyReportTable.DataSource = dt;
                }
                saveWeeklyReportBtn.Visible = true;
                viewDataInChartBtn.Visible = true;
                MessageBox.Show("Weekly Report for this week is created sucessfully.", "Generate Weekly Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private static WeeklyReportModel[] sortByIncome(WeeklyReportModel[] reportModel)
        { //looping to place the element in correct index
            for (int i = 0; i < reportModel.Length - 1; i++)
            {
                int minPos = i;
                for (int j = i + 1; j < reportModel.Length; j++)
                { 
                    // find the smallest item from the index
                    if (reportModel[j].TotalIncome < reportModel[minPos].TotalIncome)
                    {
                        minPos = j;
                    }
                }
                //swap the elements
                WeeklyReportModel temp = reportModel[i];
                reportModel[i] = reportModel[minPos];
                reportModel[minPos] = temp;
            }
            //returning the sorted array
            return reportModel;
        }


        private static WeeklyReportModel[] sortByVisitors(WeeklyReportModel[] reportModel)
        {
            //looping to place the element in correct index
            for (int i = 0; i < reportModel.Length - 1; i++)
            {
                int minPos = i;
                for (int j = i + 1; j < reportModel.Length; j++)
                {
                    // find the smallest item from the index
                    if (reportModel[j].TotalVisitors < reportModel[minPos].TotalVisitors)
                    {
                        minPos = j;
                    }
                }
                //swap the elements
                WeeklyReportModel temp = reportModel[i];
                reportModel[i] = reportModel[minPos];
                reportModel[minPos] = temp;
            }
            //returning the sorted array
            return reportModel;
        }

        private void viewDataInChartBtn_Click(object sender, EventArgs e)
        {
            ViewChart vc = new ViewChart(this);
            vc.Show();
        }

        private void saveWeeklyReportBtn_Click(object sender, EventArgs e)
        {

            try {
                saveWeeklyReportFile.ShowDialog();
                string filePath = saveWeeklyReportFile.FileName;
                if (File.Exists(filePath))
                {
                    string[] reportWords = File.ReadAllLines(filePath);
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        if (reportWords.Length != 0)
                        {
                            sw.WriteLine(dataWithLabel);
                        }
                        else
                        {
                            sw.WriteLine(onlyData);
                        }
                    }
                }
                else
                {
                    var myFile = File.Create(filePath);
                    myFile.Close();

                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.WriteLine(dataWithLabel);

                    }
                }
                MessageBox.Show("Weekly report file saved successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception) {
                MessageBox.Show("Please try again later", "Something Went Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SortWeeklyReport(bool toSortByVisitors) {

            WeeklyReportModel[] weeklyModelArr = new WeeklyReportModel[7];

            string[] allWeekDaysList = new string[7];
            int[] totalVisitorsList = new int[7];
            double[] totalIncomeList = new double[7];

            if (toSortByVisitors)
            {
                weeklyModelArr = sortByVisitors(weeklyReportModels);
            }
            else
            {
                weeklyModelArr = sortByIncome(weeklyReportModels);
            }

            for (int i = 0; i < weeklyModelArr.Length; i++) {

                allWeekDaysList[i] = weeklyModelArr[i].WeekDay;
                totalVisitorsList[i] = weeklyModelArr[i].TotalVisitors;
                totalIncomeList[i] = weeklyModelArr[i].TotalIncome;

            }

            DataTable dt = new DataTable();
            string[] headerLabels = { "Week Day", "Total Visitors", "Total Income" };
            dataWithLabel = "Week Day," + "Total Vistors," + "Total Income" + $"\n{allWeekDaysList[0]}," + totalVisitorsList[0] + "," + totalIncomeList[0] + $"\n{allWeekDaysList[1]}," + totalVisitorsList[1] + "," + totalIncomeList[1] + $"\n{allWeekDaysList[2]}," + totalVisitorsList[2] + "," + totalIncomeList[2] + $"\n{allWeekDaysList[3]}," + totalVisitorsList[3] + "," + totalIncomeList[3] + $"\n{allWeekDaysList[4]}," + totalVisitorsList[4] + "," + totalIncomeList[4] + $"\n{allWeekDaysList[5]}," + totalVisitorsList[5] + "," + totalIncomeList[5] + $"\n{allWeekDaysList[6]}," + totalVisitorsList[6] + "," + totalIncomeList[6];
            onlyData = $"{allWeekDaysList[0]}," + totalVisitorsList[0] + "," + totalIncomeList[0] + $"\n{allWeekDaysList[1]}," + totalVisitorsList[1] + "," + totalIncomeList[1] + $"\n{allWeekDaysList[2]}," + totalVisitorsList[2] + "," + totalIncomeList[2] + $"\n{allWeekDaysList[3]}," + totalVisitorsList[3] + "," + totalIncomeList[3] + $"\n{allWeekDaysList[4]}," + totalVisitorsList[4] + "," + totalIncomeList[4] + $"\n{allWeekDaysList[5]}," + totalVisitorsList[5] + "," + totalIncomeList[5] + $"\n{allWeekDaysList[6]}," + totalVisitorsList[6] + "," + totalIncomeList[6];
            
            // adding weekly report models to the array
            for (int i = 0; i < allWeekDaysList.Length; i++)
            {
                weeklyReportModels[i] = new WeeklyReportModel(allWeekDaysList[i], totalVisitorsList[i], totalIncomeList[i]);
            }

            if (weeklyReportModels.Length > 0)
            {
                //first line to create header
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i <= totalVisitorsList.Length; i++)
                {
                    string[] dataWords = { allWeekDaysList[i - 1], totalVisitorsList[i - 1].ToString(), totalIncomeList[i - 1].ToString() };
                    int columnIndex = 0;
                    DataRow dr = dt.NewRow();
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                weeklyReportTable.DataSource = dt;
            }
        }



        private void ReportsPage_Load(object sender, EventArgs e)
        {
            fromDatePicker.Value = GetStartOfWeek(weeklyReportDate.Value, DayOfWeek.Sunday);
            tillDatePicker.Value = fromDatePicker.Value.AddDays(6);
        }

        private void sortByCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortByCB.SelectedItem.ToString() == "Total Visitors")
            {
                SortWeeklyReport(true);
            }
            else
            {
                SortWeeklyReport(false);
            }
        }
    }
}
