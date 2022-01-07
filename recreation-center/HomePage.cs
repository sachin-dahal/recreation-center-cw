using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class HomePage : Form
    {
        Label selectedLabel;
        public HomePage()
        {
            InitializeComponent();
        }
        public void loadForm(object form)
        {
            if (this.mainPanel.Controls.Count > 0)
            this.mainPanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
        private void onLabelHover(Label label)
        {
            label.BackColor = Color.LimeGreen;
            label.ForeColor = Color.White;
        }
        private void onLabelLeft(Label label)
        {
            label.BackColor = Color.LightGreen;
            label.ForeColor = Color.Black;
        }

        private void onLabelClick(Label label)
        {
            label.BackColor = Color.LimeGreen;
            label.ForeColor = Color.White;
            Label oldL = selectedLabel;
            selectedLabel = label;
            onMouseLeave(oldL);
        }

        private void onMouseLeave(Label label)
        {
            if (selectedLabel != label)
            {
                onLabelLeft(label);
            }
            else
            {
               onLabelHover(label);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customerLabel_MouseEnter(object sender, EventArgs e)
        {
            onLabelHover(customerLabel);
        }

        private void customerLabel_MouseLeave(object sender, EventArgs e)
        {
            onMouseLeave(customerLabel);
        }

        private void viewTicketLabel_MouseEnter(object sender, EventArgs e)
        {
            onLabelHover(ticketPriceLabel);

        }

        private void viewTicketLabel_MouseLeave(object sender, EventArgs e)
        {
            onMouseLeave(ticketPriceLabel);
        }

        private void reportLabel_MouseEnter(object sender, EventArgs e)
        {
            onLabelHover(reportLabel);
        }

        private void reportLabel_MouseLeave(object sender, EventArgs e)
        {
            onMouseLeave(reportLabel);
        }

        private void logoutLabel_MouseEnter(object sender, EventArgs e)
        {
            onLabelHover(logoutLabel);
        }

        private void logoutLabel_MouseLeave(object sender, EventArgs e)
        {
           // onLabelLeft(logoutLabel);
            onMouseLeave(logoutLabel);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void customerLabel_Click(object sender, EventArgs e)
        {
            onLabelClick(customerLabel);
            selectedMenuLabel.Text = "Customer Panel";
            loadForm(new Customer());

        }

        private void viewTicketLabel_Click(object sender, EventArgs e)
        {
            onLabelClick(ticketPriceLabel);
            selectedMenuLabel.Text = "View Ticket Panel";
            loadForm(new TicketPrice());
        }

        private void reportLabel_Click(object sender, EventArgs e)
        {
            onLabelClick(reportLabel);
            selectedMenuLabel.Text = "View Report Panel";
            loadForm(new ReportsPage());
        }


        private void copyrightLabel_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            selectedLabel = customerLabel;
            onLabelClick(customerLabel);
            selectedMenuLabel.Text = "Customer";
            loadForm(new Customer());
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            GlobalData.isAdmin = false;
            this.Hide();
            new LoginPage().Show();
        }
    }
}
