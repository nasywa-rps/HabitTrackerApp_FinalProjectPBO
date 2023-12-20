using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;

namespace TestForm
{
    public partial class AddHabit : Form
    {
        private const string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=nasywa;Database=HabitTracker";
        private int loggedInUserId;
        public AddHabit(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        private int GetLoggedInUserId()
        {
            return loggedInUserId;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string activity = txtHabit.Text;
            string unit = optUnit.Text;
            int target = Int32.Parse(txtTarget.Text);


            if (!string.IsNullOrEmpty(txtHabit.Text) && !string.IsNullOrEmpty(optUnit.Text) &&
                !string.IsNullOrEmpty(txtTarget.Text))
            {
                SaveNewHabit(activity, unit, target);
                MessageBox.Show("Aktivitas berhasil ditambahkan!");
                this.Close();
            }
            else 
            {
                MessageBox.Show("Masukkan semua data dengan benar!");
            }
        }

        private void SaveNewHabit(string activity, string unit, int target)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                int userId = GetLoggedInUserId();

                //string query = "INSERT INTO public.\"Habit\"(\r\n\t\"Name\", \"Unit\", \"Target\") VALUES (@Name, @Unit, @Target)";
                string query = "INSERT INTO habits (id_users, activity_name, unit, target) VALUES (@userId, @activity, @unit, @target)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@activity", activity);
                    cmd.Parameters.AddWithValue("@unit", unit);
                    cmd.Parameters.AddWithValue("@target", target);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
