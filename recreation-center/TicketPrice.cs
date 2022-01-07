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
    public partial class TicketPrice : Form
    {
        DataGridView ticketDataView;
        public TicketPrice()
        {
            InitializeComponent();
        }

        private void importTicketBtn_Click(object sender, EventArgs e)
        {
            openBrowseFileDialog.ShowDialog();
            txtFileTF.Text = openBrowseFileDialog.FileName;
            GlobalData.ticketPricesFilePath = txtFileTF.Text;
            GlobalData.loadTicketData();
            try { 
                BindData(txtFileTF.Text);
                ticketDataView = ticketPricesGridView;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error occurred while importing the data", "Something went wrong!");
            }
        }



        private void addTicketButton_Click(object sender, EventArgs e)
        {
            if (GlobalData.isAdmin) {
                AddTicket addTicket = new AddTicket(this);
                addTicket.Show();
            } else
            {
                MessageBox.Show("Only ADMIN is able to add the ticket rates.", "Permission Error1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TicketPrice_Load(object sender, EventArgs e)
        {
            if (GlobalData.ticketPricesFilePath != "") {
                txtFileTF.Text = GlobalData.ticketPricesFilePath;
                BindData(GlobalData.ticketPricesFilePath);
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
                ticketPricesGridView.DataSource = dt;
            }

        }

        private void deleteTicketButton_Click(object sender, EventArgs e)
        {
            if (GlobalData.isAdmin)
            {
                try
                {
                    int rowIndex = ticketPricesGridView.CurrentCell.RowIndex;
                    ticketPricesGridView.Rows.RemoveAt(rowIndex);

                    updateFile();
                    MessageBox.Show("Deleted the selected data successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong while updating the data!", "Sorry!");
                }
            }
            else
            {
                MessageBox.Show("Only ADMIN is able to add the ticket rates.", "Permission Error1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        public void updateFile()
        {
            int columnCount = ticketPricesGridView.Columns.Count;
            string columnNames = "";
            string[] outputCsv = new string[ticketPricesGridView.Rows.Count + 1];


            for (int i = 0; i < columnCount; i++)
            {
                if (i == columnCount - 1)
                {
                    columnNames += ticketPricesGridView.Columns[i].HeaderText.ToString();
                }
                else {
                    columnNames += ticketPricesGridView.Columns[i].HeaderText.ToString() + ",";
                }
                
            }
            outputCsv[0] += columnNames;

            for (int i = 1; (i - 1) < ticketPricesGridView.Rows.Count; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (ticketPricesGridView.Rows[i - 1].Cells[j].Value != null)
                    {
                        if (j == columnCount - 1)
                        {
                            outputCsv[i] += ticketPricesGridView.Rows[i - 1].Cells[j].Value.ToString();
                        }
                        else
                        {
                            outputCsv[i] += ticketPricesGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
                        }
                    }
                }
            }
            StreamWriter sw = new StreamWriter(GlobalData.ticketPricesFilePath);
            for(int i = 0; i < outputCsv.Length -1; i++)
            {
                sw.WriteLine(outputCsv[i]);
            }
            sw.Close();
        }

    }
}
