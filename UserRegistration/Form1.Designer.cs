namespace UserRegistration
{
    partial class Form1
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
            this.FirstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(22, 59);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(106, 25);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Registration Form";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(206, 62);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(234, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(206, 93);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(234, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(206, 164);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(324, 76);
            this.txtAddress.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(206, 343);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(234, 22);
            this.txtPassword.TabIndex = 14;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(206, 314);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(234, 22);
            this.txtUsername.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(206, 283);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(206, 374);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(234, 22);
            this.txtPassword2.TabIndex = 16;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(206, 413);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(187, 53);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(24, 93);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(106, 25);
            this.LastName.TabIndex = 19;
            this.LastName.Text = "Last Name";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(20, 164);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(85, 25);
            this.Address.TabIndex = 20;
            this.Address.Text = "Address";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country.Location = new System.Drawing.Point(24, 247);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(81, 25);
            this.Country.TabIndex = 21;
            this.Country.Text = "Country";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.Location = new System.Drawing.Point(23, 371);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(167, 25);
            this.ConfirmPassword.TabIndex = 25;
            this.ConfirmPassword.Text = "* Password Again";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(24, 339);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(111, 25);
            this.Password.TabIndex = 24;
            this.Password.Text = "* Password";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(23, 310);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(115, 25);
            this.UserName.TabIndex = 23;
            this.UserName.Text = "* Username";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(22, 279);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(97, 25);
            this.Email.TabIndex = 22;
            this.Email.Text = "* Email ID";
            // 
            // txtCountry
            // 
            this.txtCountry.FormattingEnabled = true;
            this.txtCountry.Items.AddRange(new object[] {
            "Nigeria",
            "Niue",
            "Norfolk Island",
            "Northern Mariana Islands",
            "Norway",
            "Others"});
            this.txtCountry.Location = new System.Drawing.Point(206, 247);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(234, 24);
            this.txtCountry.TabIndex = 26;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(206, 133);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(250, 22);
            this.txtDate.TabIndex = 27;
            this.txtDate.Value = new System.DateTime(2000, 2, 25, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "DOB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(825, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstName);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.ComboBox txtCountry;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label label1;
    }
}

