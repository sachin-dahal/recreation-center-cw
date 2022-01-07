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
    public partial class AddTicket : Form
    {
        string selectedTicketCategory;
        TicketPrice tp;
        public AddTicket(TicketPrice tp)
        {
            InitializeComponent();
            this.tp = tp;
        }

        private void ticketTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTicketCategory = ticketTypeList.SelectedText;
            if (ticketTypeList.SelectedItem.ToString() == "Group")
            {
                noOfPeopleCB.Text = "Select";
                noOfPeopleCB.Enabled = true;
            }
            else
            {
                noOfPeopleCB.SelectedIndex = 0;
                noOfPeopleCB.Enabled = false;
            }

        }

        private void noOfPeopleTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            List<TextBox> hourlyPricesTFList = new List<TextBox>() { oneHourTF, twoHourTF, threeHourTF, fourHourTF, wholeDayTF };

            if (ticketTypeList.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first to continue");
                ticketTypeList.Focus();
                return;
            }

            foreach (TextBox tfVal in hourlyPricesTFList)
            {
                if (tfVal.Text == "")
                {
                    MessageBox.Show("Enter valid amount in the fields to continue");
                    tfVal.Focus();
                    return;
                }
            }

            try
            {
                string ticketType = ticketTypeList.SelectedItem.ToString();
                double oneHourPrice = double.Parse(oneHourTF.Text);
                double twoHourPrice = double.Parse(twoHourTF.Text);
                double threeHourPrice = double.Parse(threeHourTF.Text);
                double fourHourPrice = double.Parse(fourHourTF.Text);
                double wholeDayPrice= double.Parse(wholeDayTF.Text);

                string numberOfPeople = "";
                int noOfMinimumPeople = 0;
                int noOfMaximumPeople = 0;
                string ticketTypeLabel = ticketType;

                if (ticketTypeList.SelectedItem.ToString() == "Group")
                {
                    if (noOfPeopleCB.Text == "Select")
                    {
                        MessageBox.Show("Select valid number of people for this group to continue...", "ERROR!");
                        noOfPeopleCB.Focus();
                        return;
                    }

                    switch (noOfPeopleCB.SelectedItem.ToString()) {
                        case "1-5":
                            noOfMinimumPeople = 1;
                            noOfMaximumPeople = 5;
                            break;
                        case "5-10":
                            noOfMinimumPeople = 5;
                            noOfMaximumPeople = 10;
                            break;
                        case "10-15":
                            noOfMinimumPeople = 10;
                            noOfMaximumPeople = 15;
                            break;
                        case "15-20":
                            noOfMinimumPeople = 15;
                            noOfMaximumPeople = 20;
                            break;
                        case "20-25":
                            noOfMinimumPeople = 20;
                            noOfMaximumPeople = 25;
                            break;
                        case "25-30":
                            noOfMinimumPeople = 25;
                            noOfMaximumPeople = 30;
                            break;
                        case "30-35":
                            noOfMinimumPeople = 30;
                            noOfMaximumPeople = 35;
                            break;
                        case "35-40":
                            noOfMinimumPeople = 35;
                            noOfMaximumPeople = 40;
                            break;
                        case "40-45":
                            noOfMinimumPeople = 40;
                            noOfMaximumPeople = 45;
                            break;
                        case "45-50":
                            noOfMinimumPeople = 45;
                            noOfMaximumPeople = 50;
                            break;
                        default:
                            noOfMinimumPeople = 1;
                            noOfMaximumPeople = 1;
                            break;
                    }
                }
                else {
                    noOfMinimumPeople = 1;
                    noOfMaximumPeople = 1;
                }

                numberOfPeople = noOfPeopleCB.SelectedItem.ToString();
                ticketTypeLabel = $"Group of {noOfPeopleCB.SelectedItem.ToString()}";

                string filePath = GlobalData.ticketPricesFilePath;

                if (filePath == "")
                {
                    chooseFilePathDialog.ShowDialog();
                    filePath = chooseFilePathDialog.FileName;
                    GlobalData.ticketPricesFilePath = filePath;
                    tp.txtFileTF.Text = filePath;
                }

                string rowdata = ticketTypeLabel + "," + oneHourPrice + "," + twoHourPrice + "," + threeHourPrice + "," + fourHourPrice + "," + wholeDayPrice + "," + numberOfPeople + "," + noOfMinimumPeople + "," + noOfMaximumPeople;

                if (!File.Exists(filePath))
                {
                    StreamWriter data = new StreamWriter(filePath, append: true);
                    data.WriteLine("Ticket Type, One hour, Two Hours, Three Hours, Four Hours, Whole Day, No. of people, Min People, Max People");
                    data.WriteLine(rowdata);
                    MessageBox.Show("New ticket price added successfully.", "Add Ticket");

                    data.Close();
                }
                else
                {
                    StreamWriter data = new StreamWriter(filePath, append: true);
                    data.WriteLine(rowdata);
                   
                    MessageBox.Show("New ticket price added successfully.", "Add Ticket");

                    data.Close();
                }

                clearAddTicketFields();

                this.Hide();
                BindData(GlobalData.ticketPricesFilePath);
                GlobalData.loadTicketData();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Please enter valid details.", "Something went wrong!");
            }
        }



        private void BindData(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
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
                tp.ticketPricesGridView.DataSource = dt;
            }

        }
        public void clearAddTicketFields()
        {
            ticketTypeList.Text = "Select";
            noOfPeopleCB.Text = "Select";
            oneHourTF.Clear();
            twoHourTF.Clear();
            threeHourTF.Clear();
            fourHourTF.Clear();
            wholeDayTF.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            clearAddTicketFields();
            this.Hide();
        }

        private void hourPricesTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
