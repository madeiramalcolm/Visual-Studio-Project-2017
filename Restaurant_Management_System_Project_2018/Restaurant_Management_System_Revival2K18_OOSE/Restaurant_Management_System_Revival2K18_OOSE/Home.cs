using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System_Revival2K18_OOSE
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            Waiter obj = new Waiter();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            Kitchen obj = new Kitchen();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            LOGIN obj = new LOGIN();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            Payment obj = new Payment();
            obj.Show();
        }
    }
}
