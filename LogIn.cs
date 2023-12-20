using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace TestForm
{
    public partial class LogIn : Form
    {
        // Connection string konstan yang akan digunakan
        private const string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=nasywa;Database=HabitTracker";
        private int loggedInUserId; // variabel untuk menyimpan user id yang masuk

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                string userUname = txtUsername.Text;
                string userPass = txtPassword.Text;

                // Memanggil metode GetUserIdFromDatabase untuk mendapatkan user id dari database
                loggedInUserId = GetUserIdFromDatabase(userUname, userPass);

                // Menampilkan form MainMenu jika user id valid
                if (loggedInUserId != -1)
                {
                    MainMenu mainMenuForm = new MainMenu(loggedInUserId);
                    mainMenuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah!");
                }
            }
            else
            {
                MessageBox.Show("Masukkan username dan password!");
            }
        }

        private int GetUserIdFromDatabase(string userUname, string userPass)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_users FROM users WHERE username = @userUname AND pass = @userPass";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    // Menggunakan parameterized queries untuk membersihkan input
                    cmd.Parameters.AddWithValue("@userUname", userUname);
                    cmd.Parameters.AddWithValue("@userPass", userPass);

                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }
    }
}
