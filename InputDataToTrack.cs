using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestForm
{
    public partial class InputDataToTrack : Form
    {
        private const string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=nasywa;Database=HabitTracker";
        private int loggedInUserId;
        private int habitsId;
        public InputDataToTrack(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        private int GetLoggedInUserId()
        {
            return loggedInUserId;
        }

        private void InputDataToTrack_Load(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    int userId = GetLoggedInUserId();
                    string query = "SELECT activity_name FROM habits WHERE id_users = (@userId)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string activityName = reader["activity_name"].ToString();
                                optActivity.Items.Add(activityName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(optActivity.Text) && !string.IsNullOrEmpty(txtAmount.Text) &&
                !string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                string activity = optActivity.Text;
                int amount = Int32.Parse(txtAmount.Text);
                string progress_date = dateTimePicker1.Text;

                SaveNewProgress(activity, amount, progress_date);
                MessageBox.Show("Progress berhasil ditambahkan!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Masukkan semua data dengan benar!");
            }
        }

        private int GetHabitsIdFromDatabase(string activity)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_habits FROM habits WHERE activity_name = @activity";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    // Menggunakan parameterized queries untuk membersihkan input
                    cmd.Parameters.AddWithValue("@activity", activity);

                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        private void SaveNewProgress (string activity, int amount, string progress_date)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                int habitsId = GetHabitsIdFromDatabase(activity);

                string query = "INSERT INTO progress (id_habits, amount, progress_date) VALUES (@id_habits, @amount, @progress_date)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id_habits", habitsId);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@progress_date", progress_date);

                    cmd.ExecuteNonQuery();
                }
                

            }
        }
    }
}
