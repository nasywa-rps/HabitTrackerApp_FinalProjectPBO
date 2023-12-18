using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private const string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=nasywa;Database=TestHabitTracker";
        public AddHabit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string activity = txtHabit.Text;
            string unit = optUnit.Text;
            int target = Int32.Parse(txtTarget.Text);


            if (!string.IsNullOrEmpty(txtHabit.Text) && !string.IsNullOrEmpty(optUnit.Text) &&
                !string.IsNullOrEmpty(txtTarget.Text))
            {
                SaveNewHabit(activity, unit, target);

                MainMenu Check = new MainMenu();
                Check.Show();
            }
        }

        private void optGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveNewHabit(string activity, string unit, int target)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO public.\"Habit\"(\r\n\t\"Name\", \"Unit\", \"Target\") VALUES (@Name, @Unit, @Target)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", activity);
                    cmd.Parameters.AddWithValue("@Unit", unit);
                    cmd.Parameters.AddWithValue("@Target", target);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
