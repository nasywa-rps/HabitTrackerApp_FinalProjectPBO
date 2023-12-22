using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace TestForm
{
    public partial class DisplayTracker : Form
    {
        private const string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=nasywa;Database=HabitTracker";
        private int loggedInUserId;

        public DisplayTracker(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;

            // Panggil metode untuk memuat data saat form dimuat
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT habits.activity_name, progress.progress_date, progress.amount, habits.target " +
                                   "FROM habits " +
                                   "JOIN progress ON habits.id_habits = progress.id_habits " +
                                   "WHERE habits.id_users = @loggedInUserId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@loggedInUserId", loggedInUserId);

                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Mengaitkan DataTable dengan DataGridView
                            dgvProgress.DataSource = dataTable;
                            /*
                            // Tambahkan kolom Progress pada bagian paling kanan
                            DataGridViewTextBoxColumn progressColumn = new DataGridViewTextBoxColumn();
                            progressColumn.Name = "progressColumn";
                            progressColumn.HeaderText = "Progress";

                            if (dgvProgress.Columns["progressColumn"] == null)
                            {
                                dgvProgress.Columns.Add(progressColumn);
                            }

                            // Atur nilai progress visual dengan karakter "|"
                            int columnIndexAmount = dgvProgress.Columns["amount"]?.Index ?? -1;
                            int columnIndexTarget = dgvProgress.Columns["target"]?.Index ?? -1;

                            foreach (DataGridViewRow row in dgvProgress.Rows)
                            {
                                int amount = row.Cells[columnIndexAmount].Value != DBNull.Value ? Convert.ToInt32(row.Cells[columnIndexAmount].Value) : 0;
                                int target = row.Cells[columnIndexTarget].Value != DBNull.Value ? Convert.ToInt32(row.Cells[columnIndexTarget].Value) : 0;

                                // Hitung nilai progress dalam persentase
                                int progressValue = Math.Min(100, Math.Max(0, (int)((double)amount / target * 100)));

                                string progressTxt = progressValue + "%";

                                row.Cells["progressColumn"].Value = progressTxt;
                            }*/
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

        private void dgvProgress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
