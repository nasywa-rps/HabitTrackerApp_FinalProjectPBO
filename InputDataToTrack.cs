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
    public partial class InputDataToTrack : Form
    {
        private const string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=nasywa;Database=TestHabitTracker";
        public InputDataToTrack()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void optGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            DisplayTracker Check = new DisplayTracker();
            Check.Show();
        }
        /*
        private void UpdateHabit(string activity, int update, DateTime date)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string queryReturn = "RETURNING public.\"Habit\"(\"TotalProgress\") AS latestProgress";

                int total = total + update;

                string queryInsert = "INSERT INTO public.\"Habit\"(\r\n\t\"Name\", \"Progress\", \"TotalProgress\", \"Date\") VALUES (@Name, @Progress, @TotalProgress, @Date)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(queryInsert, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", activity);
                    cmd.Parameters.AddWithValue("@Progress", update);
                    cmd.Parameters.AddWithValue("@TotalProgress", total);
                    cmd.Parameters.AddWithValue("@Date", date);

                    cmd.ExecuteNonQuery();
                }
            }
        }*/
    }
}
