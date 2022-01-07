
namespace coursework
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loginTocontinueLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTF = new System.Windows.Forms.TextBox();
            this.passwordTF = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.staffRB = new System.Windows.Forms.RadioButton();
            this.adminRB = new System.Windows.Forms.RadioButton();
            this.selectRoleLabel = new System.Windows.Forms.Label();
            this.authPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Convection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(275, 19);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Mero Recreation Center";
            // 
            // loginTocontinueLabel
            // 
            this.loginTocontinueLabel.AutoSize = true;
            this.loginTocontinueLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.loginTocontinueLabel.Font = new System.Drawing.Font("Convection", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTocontinueLabel.ForeColor = System.Drawing.Color.Black;
            this.loginTocontinueLabel.Location = new System.Drawing.Point(26, 11);
            this.loginTocontinueLabel.Name = "loginTocontinueLabel";
            this.loginTocontinueLabel.Size = new System.Drawing.Size(128, 17);
            this.loginTocontinueLabel.TabIndex = 1;
            this.loginTocontinueLabel.Text = "Login to Continue...";
            this.loginTocontinueLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.usernameLabel.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(26, 54);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(67, 14);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.passwordLabel.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(26, 88);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(65, 14);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameTF
            // 
            this.usernameTF.Location = new System.Drawing.Point(108, 53);
            this.usernameTF.Name = "usernameTF";
            this.usernameTF.Size = new System.Drawing.Size(168, 20);
            this.usernameTF.TabIndex = 4;
            // 
            // passwordTF
            // 
            this.passwordTF.Location = new System.Drawing.Point(108, 87);
            this.passwordTF.Name = "passwordTF";
            this.passwordTF.PasswordChar = '*';
            this.passwordTF.Size = new System.Drawing.Size(168, 20);
            this.passwordTF.TabIndex = 5;
            this.passwordTF.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(108, 150);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 25);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(201, 150);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 25);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.staffRB);
            this.panel1.Controls.Add(this.adminRB);
            this.panel1.Controls.Add(this.selectRoleLabel);
            this.panel1.Controls.Add(this.authPictureBox);
            this.panel1.Controls.Add(this.usernameTF);
            this.panel1.Controls.Add(this.loginTocontinueLabel);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.passwordTF);
            this.panel1.Location = new System.Drawing.Point(34, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 193);
            this.panel1.TabIndex = 8;
            // 
            // staffRB
            // 
            this.staffRB.AutoSize = true;
            this.staffRB.Location = new System.Drawing.Point(190, 121);
            this.staffRB.Name = "staffRB";
            this.staffRB.Size = new System.Drawing.Size(47, 17);
            this.staffRB.TabIndex = 11;
            this.staffRB.TabStop = true;
            this.staffRB.Text = "Staff";
            this.staffRB.UseVisualStyleBackColor = true;
            // 
            // adminRB
            // 
            this.adminRB.AutoSize = true;
            this.adminRB.Location = new System.Drawing.Point(108, 121);
            this.adminRB.Name = "adminRB";
            this.adminRB.Size = new System.Drawing.Size(54, 17);
            this.adminRB.TabIndex = 10;
            this.adminRB.TabStop = true;
            this.adminRB.Text = "Admin";
            this.adminRB.UseVisualStyleBackColor = true;
            // 
            // selectRoleLabel
            // 
            this.selectRoleLabel.AutoSize = true;
            this.selectRoleLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.selectRoleLabel.Font = new System.Drawing.Font("Convection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRoleLabel.Location = new System.Drawing.Point(26, 121);
            this.selectRoleLabel.Name = "selectRoleLabel";
            this.selectRoleLabel.Size = new System.Drawing.Size(74, 14);
            this.selectRoleLabel.TabIndex = 9;
            this.selectRoleLabel.Text = "Select Role:";
            // 
            // authPictureBox
            // 
            this.authPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("authPictureBox.Image")));
            this.authPictureBox.Location = new System.Drawing.Point(293, 17);
            this.authPictureBox.Name = "authPictureBox";
            this.authPictureBox.Size = new System.Drawing.Size(132, 149);
            this.authPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.authPictureBox.TabIndex = 8;
            this.authPictureBox.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(494, 271);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.panel1);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label loginTocontinueLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTF;
        private System.Windows.Forms.TextBox passwordTF;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox authPictureBox;
        private System.Windows.Forms.RadioButton staffRB;
        private System.Windows.Forms.RadioButton adminRB;
        private System.Windows.Forms.Label selectRoleLabel;
    }
}