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
        // ini nanti ganti jadi tempatmu lagi ya!
        private const string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=nasywa;Database=HabitTracker"; 
        public SignUp()
        {
            InitializeComponent();
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

                FirstPage Check = new FirstPage();
                Check.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("masukkan credential akun yang dibutuhkan!");
            }
        }
        private void SaveSignUpInfo(string userName, string userEmail, string userGender, string userUname, string userPass)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                //ini nama-nama instancenya versi DB-ku
                string query = "INSERT INTO users (fullname, email, gender, username, pass) VALUES (@userName, @userEmail, @userGender, @userUname, @userPass)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@userEmail", userEmail);
                    cmd.Parameters.AddWithValue("@userGender", userGender);
                    cmd.Parameters.AddWithValue("@userUname", userUname);
                    cmd.Parameters.AddWithValue("userPass", userPass);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
