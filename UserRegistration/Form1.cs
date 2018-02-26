using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UserRegistration
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = UserRegistrationDB; Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please fill the mandatory field");
            else if (txtPassword.Text != txtPassword2.Text)
                MessageBox.Show("Password and confirm do not match");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Date", txtDate.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Country", txtCountry.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Successful!");
                    Clear();
                }
            }
      
        }

        void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtDate.Text = txtAddress.Text = txtCountry.Text = txtEmail.Text = txtUsername.Text = txtPassword.Text = txtPassword2.Text = "";
        }
    }
}
