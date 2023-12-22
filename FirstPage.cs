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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp Check = new SignUp();
            Check.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn Check = new LogIn();
            Check.Show();
            this.Hide();
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {

        }
    }
}
