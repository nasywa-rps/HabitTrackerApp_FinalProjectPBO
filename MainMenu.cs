using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayTracker Check = new DisplayTracker();
            Check.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            InputDataToTrack Check = new InputDataToTrack();
            Check.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayTracker Check = new DisplayTracker();
            Check.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddHabit Check = new AddHabit();
            Check.Show();
        }
    }
}
