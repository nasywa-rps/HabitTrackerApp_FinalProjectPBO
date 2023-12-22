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

namespace TestForm
{
    public partial class MainMenu : Form
    {
        private const string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=nasywa;Database=HabitTracker";
        private int loggedInUserId;
        public MainMenu(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            UpdateUsernameLabel();
        }

        private void UpdateUsernameLabel()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT username, fullname, email, gender FROM users WHERE id_users = @userId";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", loggedInUserId);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string username = reader["username"].ToString();
                                string fullname = reader["fullname"].ToString();
                                string email = reader["email"].ToString();
                                string gender = reader["gender"].ToString();

                                lblUsername.Text = $"{username}";
                                lblFullname.Text = $"{fullname}";
                                lblEmail.Text = $"{email}";
                                lblGender.Text = $"{gender}";
                            }
                            else
                            {
                                // handle kalau pengguna tidak ditemukan
                                lblUsername.Text = "Unknown User";
                                lblFullname.Text = "";
                                lblEmail.Text = "";
                                lblGender.Text = "";
                            }
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddHabit Check = new AddHabit(loggedInUserId);
            Check.Show();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            InputDataToTrack Check = new InputDataToTrack(loggedInUserId);
            Check.Show();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            DisplayTracker Check = new DisplayTracker(loggedInUserId);
            Check.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FirstPage Check = new FirstPage();
            Check.Show();
            this.Close();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblFullname_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }
    }
}
