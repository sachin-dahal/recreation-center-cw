
namespace coursework
{
    partial class TicketPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketPrice));
            this.ticketPricesGridView = new System.Windows.Forms.DataGridView();
            this.txtFileTF = new System.Windows.Forms.TextBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.importTicketBtn = new System.Windows.Forms.Button();
            this.openBrowseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.deleteTicketButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketPricesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketPricesGridView
            // 
            this.ticketPricesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ticketPricesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketPricesGridView.Location = new System.Drawing.Point(12, 43);
            this.ticketPricesGridView.Name = "ticketPricesGridView";
            this.ticketPricesGridView.Size = new System.Drawing.Size(666, 277);
            this.ticketPricesGridView.TabIndex = 40;
            // 
            // txtFileTF
            // 
            this.txtFileTF.Font = new System.Drawing.Font("Convection Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileTF.Location = new System.Drawing.Point(51, 11);
            this.txtFileTF.Multiline = true;
            this.txtFileTF.Name = "txtFileTF";
            this.txtFileTF.Size = new System.Drawing.Size(539, 26);
            this.txtFileTF.TabIndex = 43;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Font = new System.Drawing.Font("Convection", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.ForeColor = System.Drawing.Color.Indigo;
            this.fileLabel.Location = new System.Drawing.Point(9, 12);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(36, 17);
            this.fileLabel.TabIndex = 45;
            this.fileLabel.Text = "File:";
            // 
            // importTicketBtn
            // 
            this.importTicketBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.importTicketBtn.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importTicketBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.importTicketBtn.Image = ((System.Drawing.Image)(resources.GetObject("importTicketBtn.Image")));
            this.importTicketBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importTicketBtn.Location = new System.Drawing.Point(596, 12);
            this.importTicketBtn.Name = "importTicketBtn";
            this.importTicketBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.importTicketBtn.Size = new System.Drawing.Size(82, 26);
            this.importTicketBtn.TabIndex = 46;
            this.importTicketBtn.Text = "Import";
            this.importTicketBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importTicketBtn.UseVisualStyleBackColor = false;
            this.importTicketBtn.Click += new System.EventHandler(this.importTicketBtn_Click);
            // 
            // openBrowseFileDialog
            // 
            this.openBrowseFileDialog.FileName = "openFileDialog1";
            // 
            // addTicketButton
            // 
            this.addTicketButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addTicketButton.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTicketButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addTicketButton.Image = ((System.Drawing.Image)(resources.GetObject("addTicketButton.Image")));
            this.addTicketButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTicketButton.Location = new System.Drawing.Point(170, 354);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.addTicketButton.Size = new System.Drawing.Size(104, 35);
            this.addTicketButton.TabIndex = 47;
            this.addTicketButton.Text = "Add Ticket";
            this.addTicketButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addTicketButton.UseVisualStyleBackColor = false;
            this.addTicketButton.Click += new System.EventHandler(this.addTicketButton_Click);
            // 
            // deleteTicketButton
            // 
            this.deleteTicketButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteTicketButton.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTicketButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteTicketButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteTicketButton.Image")));
            this.deleteTicketButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteTicketButton.Location = new System.Drawing.Point(373, 354);
            this.deleteTicketButton.Name = "deleteTicketButton";
            this.deleteTicketButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.deleteTicketButton.Size = new System.Drawing.Size(118, 35);
            this.deleteTicketButton.TabIndex = 48;
            this.deleteTicketButton.Text = "Delete Ticket";
            this.deleteTicketButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteTicketButton.UseVisualStyleBackColor = false;
            this.deleteTicketButton.Click += new System.EventHandler(this.deleteTicketButton_Click);
            // 
            // TicketPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.deleteTicketButton);
            this.Controls.Add(this.addTicketButton);
            this.Controls.Add(this.ticketPricesGridView);
            this.Controls.Add(this.txtFileTF);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.importTicketBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketPrice";
            this.Text = "TicketPrice";
            this.Load += new System.EventHandler(this.TicketPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketPricesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView ticketPricesGridView;
        public System.Windows.Forms.TextBox txtFileTF;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button importTicketBtn;
        private System.Windows.Forms.OpenFileDialog openBrowseFileDialog;
        private System.Windows.Forms.Button addTicketButton;
        private System.Windows.Forms.Button deleteTicketButton;
    }
}