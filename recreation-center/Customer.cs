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
    public partial class Customer : Form
    {
        double ticketPrice;
        public Customer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timeInDatePicker.Value = DateTime.Parse("10:00 AM");
            timeOutDatePicker.Value = DateTime.Parse("11:00 AM");
            if (GlobalData.ticketPricesFilePath == "")
            {
                customerIdTF.Enabled = false;
                customerNameTF.Enabled = false;
                customerAddressTF.Enabled = false;
                phoneTF.Enabled = false;
                ticketCategoriesList.Enabled = false;
                timeInDatePicker.Enabled = false;
                timeOutDatePicker.Enabled = false;
                datePicker.Enabled = false;
                importTicketsInfo.Visible = true;
            }
            else {
                customerIdTF.Enabled = true;
                customerNameTF.Enabled = true;
                customerAddressTF.Enabled = true;
                phoneTF.Enabled = true;
                ticketCategoriesList.Enabled = true;
                timeInDatePicker.Enabled = true;
                timeOutDatePicker.Enabled = true;
                datePicker.Enabled = true;
                importTicketsInfo.Visible = false;
            }

            if (GlobalData.ticketCategories != null) {
                ticketCategoriesList.Items.Clear();
                foreach (var ticket in GlobalData.ticketCategories) {
                    ticketCategoriesList.Items.Add(ticket);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                customersDataGridView.DataSource = dt;
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (GlobalData.ticketPricesFilePath == "") {
                MessageBox.Show("Please load the ticket prices first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<TextBox> userDataFields = new List<TextBox>() { customerIdTF, customerNameTF, customerAddressTF, phoneTF};

            foreach (TextBox tfVal in userDataFields)
            {
                if(tfVal.Text == ""){
                    MessageBox.Show("Enter valid value in the fields to continue", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tfVal.Focus();
                    return;
                }
            }

            if (ticketCategoriesList.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ticketCategoriesList.Focus();
                return;

            }

            if (noOfPeopleTF.Text == "")
            {
                MessageBox.Show($"Number of people cannot be empty", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                noOfPeopleTF.Clear();
                noOfPeopleTF.Focus();
            }

            if (timeInDatePicker.Value.TimeOfDay < DateTime.Parse("10:00 AM").TimeOfDay || timeInDatePicker.Value.TimeOfDay > DateTime.Parse("18:00 PM").TimeOfDay)
            {

                MessageBox.Show("Time IN must be between 10:00 AM - 6:00 PM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timeInDatePicker.Focus();
                return;

            }
            else if (timeOutDatePicker.Value.TimeOfDay < DateTime.Parse("10:00 AM").TimeOfDay || timeOutDatePicker.Value.TimeOfDay > DateTime.Parse("18:00 PM").TimeOfDay)
            {
                MessageBox.Show("Time OUT must be between 10:00 AM - 6:00 PM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timeOutDatePicker.Focus();
                return;
            }

            try {
                int customerID = int.Parse(customerIdTF.Text);
                string customerName = customerNameTF.Text;
                string customerAddress = customerAddressTF.Text;
                string customerPhone = phoneTF.Text;
                string selectedCategory = ticketCategoriesList.SelectedItem.ToString();
                int numberofPeople = int.Parse(noOfPeopleTF.Text);
                DateTime timeIn = timeInDatePicker.Value;
                DateTime timeOut = timeOutDatePicker.Value;
                string date = datePicker.Text;

                double totalMinutesSpent = (timeOut.Subtract(timeIn).TotalHours) * 60;
                int hours = (int) totalMinutesSpent / 60;
                double remainingMin = totalMinutesSpent - (hours * 60);

               // MessageBox.Show($"Hours: {hours}\nTotal Minutes: {totalMinutesSpent}\nRemaining Minutes: {remainingMin}");
                double totalPrice = calculateTotalCost(hours, remainingMin);
                
                string filePath = GlobalData.customersListFilePath;

                if (filePath == "")
                {
                    saveCustomerCSV.ShowDialog();
                    filePath = saveCustomerCSV.FileName;
                    GlobalData.customersListFilePath = filePath;
                    txtFileTF.Text = filePath;
                }

                string rowdata = customerID + "," + date + "," + customerName + "," + customerAddress + "," + customerPhone + "," + selectedCategory + "," + numberofPeople.ToString() + "," + timeInDatePicker.Text + "," + timeOutDatePicker.Text + "," + String.Format("{0:0.00}", totalPrice);

                if (!File.Exists(filePath))
                {
                    StreamWriter data = new StreamWriter(filePath, append: true);
                    data.WriteLine("ID, Date, Name, Address, Phone, Category, No. of People, IN Time, OUT Time, Total");
                    data.WriteLine(rowdata);
                    MessageBox.Show("Customer Data Inserted Successfully.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    data.Close();
                }
                else
                {
                    StreamWriter data = new StreamWriter(filePath, append: true);
                    data.WriteLine(rowdata);
                    MessageBox.Show("Customer Data Inserted Successfully.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    data.Close();
                }
                clearAllFields();

                txtFileTF.Text = filePath;
                BindData(filePath);
            }
            catch (Exception exp) {
                MessageBox.Show("Please enter valid details.", "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double calculateTotalCost(int hour, double minute)
        {
            String pricing = GlobalData.ticketPrices[ticketCategoriesList.SelectedIndex];
            String[] prices = pricing.Split(',');

            double totalPrice = 0;
            if (hour <= 1) {
                double price = double.Parse(prices[1]);
                totalPrice = price;
            }
            else if (hour > 1 && hour < 2) { 
                double price = double.Parse(prices[1]);
                double extraMinutePrice = price * (minute / 60);
                totalPrice = price + extraMinutePrice;
            }
            else if (hour >= 2 && hour < 3) { 
                double price = double.Parse(prices[2]);
                double extraMinutePrice = (price / 2) * (minute / 60);
                totalPrice = price + extraMinutePrice;
            }
            else if (hour >= 3 && hour < 4) { 
                double price = double.Parse(prices[3]);
                double extraMinutePrice = (price / 3) * (minute / 60);
                totalPrice = price + extraMinutePrice;
            }
            else if (hour >= 4 && hour < 5)
            {
                double price = double.Parse(prices[4]);
                double extraMinutePrice = (price / 3) * (minute / 60);
                totalPrice = price + extraMinutePrice;
            }
            else { 
                double price = double.Parse(prices[5]);
                totalPrice = price;
            }
            return totalPrice;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void timeInDatePicker_ValueChanged(object sender, EventArgs e)
        {
            timeInDatePicker.Format = DateTimePickerFormat.Custom;
        }

        private void timeOutDatePicker_ValueChanged(object sender, EventArgs e)
        {
            timeInDatePicker.Format = DateTimePickerFormat.Custom;

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            timeInDatePicker.Format = DateTimePickerFormat.Custom;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            //System.Windows.Forms.Application.Exit();
            if (ticketCategoriesList.SelectedItem == null)
            {
                Console.WriteLine("it is null");
            }
            else {

                Console.WriteLine(ticketCategoriesList.SelectedItem.ToString());
            }
            
            Console.WriteLine(String.Format("{0:0.00}", DateTime.Parse((timeOutDatePicker.Value.TimeOfDay - timeInDatePicker.Value.TimeOfDay).ToString()).TimeOfDay.TotalHours));
            
            Console.ReadLine();

            
        }

        private void viewBtn_Click_1(object sender, EventArgs e)
        {
            openBrowseFileDialog.ShowDialog();
            txtFileTF.Text = openBrowseFileDialog.FileName;
            GlobalData.customersListFilePath = txtFileTF.Text;
            try { 
                BindData(txtFileTF.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error occurred while importing the data", "Something went wrong!");
            }
        }


        public void clearAllFields() {
            customerIdTF.Clear();
            customerNameTF.Clear();
            customerAddressTF.Clear();
            phoneTF.Clear();
            ticketCategoriesList.Text = "Select";
            timeInDatePicker.Value = DateTime.Parse("10:00 AM");
            timeOutDatePicker.Value = DateTime.Parse("11:00 AM");
            datePicker.Value = DateTime.Now;
        }

        private void timeInDatePicker_MouseHover(object sender, EventArgs e)
        {
            timeToolTip.Show("Time Spent for more than 4 hours will be calculated as a Whole Day", timeInDatePicker);
        }

        private void timeOutDatePicker_MouseHover(object sender, EventArgs e)
        {
            timeToolTip.Show("Time Spent for more than 4 hours will be calculated as a Whole Day", timeOutDatePicker);
        }

        private void timeInDatePicker_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void ticketCategoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //noOfPeopleTF.Text = GlobalData.noOfPeopleAllowed[ticketCategoriesList.SelectedIndex].ToString();

            if (ticketCategoriesList.SelectedItem.ToString() == "Child" || ticketCategoriesList.SelectedItem.ToString() == "Adult")
            {
                noOfPeopleTF.Text = "1";
                noOfPeopleTF.Enabled = false;
            }
            else
            {
                noOfPeopleTF.Clear();
                noOfPeopleTF.Enabled = true;
            }
        }

        private void noOfPeopleTF_Leave(object sender, EventArgs e)
        {
            
            if (int.Parse(noOfPeopleTF.Text) <= GlobalData.minimumPeopleAllowedList[ticketCategoriesList.SelectedIndex])
            {
                MessageBox.Show($"Number of people must be more than {GlobalData.minimumPeopleAllowedList[ticketCategoriesList.SelectedIndex]}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                noOfPeopleTF.Clear();
                noOfPeopleTF.Focus();
            }
            else if (int.Parse(noOfPeopleTF.Text) > GlobalData.maximumPeopleAllowedList[ticketCategoriesList.SelectedIndex])
            {
                MessageBox.Show($"Number of people must be less than {GlobalData.maximumPeopleAllowedList[ticketCategoriesList.SelectedIndex]}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                noOfPeopleTF.Clear();
                noOfPeopleTF.Focus();
            }
        }

    }
}
