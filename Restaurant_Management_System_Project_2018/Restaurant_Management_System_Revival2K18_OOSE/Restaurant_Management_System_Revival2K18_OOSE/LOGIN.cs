using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Restaurant_Management_System_Revival2K18_OOSE
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Flag=0;
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();

            string s1 = comboBox1.SelectedItem.ToString();

            try
            {
        
                OleDbDataAdapter sda = new OleDbDataAdapter("SELECT COUNT(*) AS val from Login where User_ID= '" + textBox1.Text + "' AND Password ='" + textBox2.Text + "'AND Account_type='"+s1+"'", connection);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Flag = 1;
                    
                }

                if (Flag == 1)
                {
                    if (comboBox1.SelectedItem.ToString() == "Administrator")
                    {
                        MessageBox.Show("LOGIN SUCCESSFUL");
                        this.Hide();
                        ADMIN obj = new ADMIN();
                        obj.Show();

                    }


                    else if (comboBox1.SelectedItem.ToString() == "Customer")
                    {
                        MessageBox.Show("LOGIN SUCCESSFUL");
                        this.Hide();
                        customer obj = new customer();
                        obj.Show();

                    }

                    else if (comboBox1.SelectedItem.ToString() == "Employee")
                    {
                        MessageBox.Show("LOGIN SUCCESSFUL");
                        this.Hide();
                        Home obj = new Home();
                        obj.Show();

                    }
                }

                else
                {
                    this.Hide();
                    MessageBox.Show("INVALID Username OR Password");
                    LOGIN obj = new LOGIN();
                    obj.Show();

                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration obj = new Registration();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LOGIN SUCCESSFUL");
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 