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
    public partial class Waiter : Form
    {
        public Waiter()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Waiter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";
            String S1 = "Null";
            OleDbConnection obj1 = new OleDbConnection(connection);

            String q2 = "insert into ORDER1 values ('" + textBox9.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +dateTimePicker1.Text+ "','" + textBox7.Text + "','" + textBox5.Text + "','" +S1+ "')";
            obj1.Open();

            try
                {
                    OleDbCommand cm2 = new OleDbCommand(q2, obj1);
                    cm2.ExecuteNonQuery();
                MessageBox.Show("**********Order Placed *********");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox7.Clear();
                obj1.Close();


            }
            catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                
            }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();
            String q2 = "delete from Order1 where Order_ID='" + textBox4.Text + "'";


            try
            {
                OleDbCommand cm2 = new OleDbCommand(q2, obj1);
                cm2.ExecuteNonQuery();
                MessageBox.Show("*********Order Successfully Deleted****************");

                textBox4.Clear();
                String q1 = "select * from Order1";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView1.DataSource = d;

                obj1.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";
            OleDbConnection obj2 = new OleDbConnection(connection);


            obj2.Open();
            try
            {
        
                String q1 = "select * from Order1";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj2);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView1.DataSource = d;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox7.Clear();
                obj2.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";
            OleDbConnection obj2 = new OleDbConnection(connection);


            obj2.Open();
            try
            {

                String q1 = "select * from Order1 where Order_ID='"+textBox8.Text+"'";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj2);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView2.DataSource = d;
                textBox8.Clear();
               
                obj2.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";
            OleDbConnection obj2 = new OleDbConnection(connection);

            String q1 = "select * from Order1";

            obj2.Open();
            try
            {

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj2);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView2.DataSource = d;
                textBox8.Clear();

                obj2.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
