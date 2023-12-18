using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestForm
{
    public partial class SignUp : Form
    {
        private const string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=nasywa;Database=TestHabitTracker";
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string userEmail = txtEmail.Text;
            string userGender = optGender.Text;
            string userUname = txtUsername.Text;
            string userPass = txtPassword.Text;


            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtEmail.Text) &&
                !string.IsNullOrEmpty(optGender.Text) && !string.IsNullOrEmpty(txtUsername.Text) &&
                !string.IsNullOrEmpty(txtPassword.Text))
            {
                SaveSignUpInfo(userName, userEmail, userGender, userUname, userPass);

                MainMenu Check = new MainMenu();
                Check.Show();
            }
        }
        private void SaveSignUpInfo(string userName, string userEmail, string userGender, string userUname, string userPass)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO public.\"Profile\"(\r\n\t\"Email\", \"Gender\", \"Username\", \"Password\", \"FullName\") VALUES (@Email, @Gender, @Username, @Password, @FullName)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", userEmail);
                    cmd.Parameters.AddWithValue("@Gender", userGender);
                    cmd.Parameters.AddWithValue("@Username", userUname);
                    cmd.Parameters.AddWithValue("@Password", userPass);
                    cmd.Parameters.AddWithValue("@FullName", userName);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void optGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
