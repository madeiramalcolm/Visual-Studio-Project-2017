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
    public partial class Kitchen : Form
    {
        public Kitchen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";
            OleDbConnection obj1 = new OleDbConnection(connection);

            String q2 = "insert into Item values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            obj1.Open();

            try
            {
                OleDbCommand cm2 = new OleDbCommand(q2, obj1);
                cm2.ExecuteNonQuery();
                MessageBox.Show("************Item Inserted Successfully*********");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            String q1 = "select * from Item";

            OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
            DataTable d = new DataTable();
            da.Fill(d);
            dataGridView1.DataSource = d;
            obj1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";
            OleDbConnection obj1 = new OleDbConnection(connection);

            String q1 = "select * from Item";
            OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
            DataTable d = new DataTable();
            da.Fill(d);
            dataGridView1.DataSource = d;
            obj1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";
            OleDbConnection obj2 = new OleDbConnection(connection);


            obj2.Open();
            String q2 = "update Item set Dish_Name='" + textBox5.Text + "',Rate='" + textBox4.Text + "' where Dish_ID='" + textBox6.Text + "'";
            try
            {
                OleDbCommand cm2 = new OleDbCommand(q2, obj2);
                Int32 i = cm2.ExecuteNonQuery();
                if (i > 0)
                { MessageBox.Show("ITEM Record Updated"); }
                textBox1.Clear();
                String q1 = "select * from Item";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj2);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView1.DataSource = d;
                textBox5.Clear();
                textBox6.Clear();
                textBox4.Clear();
               
                obj2.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();
            String q2 = "delete from Item where Dish_ID='" + textBox9.Text + "'";


            try
            {
                OleDbCommand cm2 = new OleDbCommand(q2, obj1);
                cm2.ExecuteNonQuery();
                MessageBox.Show("*********Item Deleted from Database****************");

                textBox9.Clear();
                String q1 = "select * from Item";

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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";
            OleDbConnection obj2 = new OleDbConnection(connection);

            obj2.Open();
            try
            {
               
                String q1 = "select Order_ID,Dish_name,Status from (Order1 NATURAL JOIN Item)";
              
                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj2);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView2.DataSource = d;
         

                obj2.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj2 = new OleDbConnection(connection);


            obj2.Open();
            String q2 = "update Order1 set Status='" + textBox8.Text + "' where Order_ID='" + textBox7.Text + "'";

            try
            {
                OleDbCommand cm2 = new OleDbCommand(q2, obj2);
                Int32 i = cm2.ExecuteNonQuery();
                if (i > 0)
                { MessageBox.Show("Status of Order Updated"); }
                textBox1.Clear();
                String q1 = "select Cust_ID,Order_ID,Status from Order1 where ORDER_ID='"+textBox7.Text+"'";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj2);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView3.DataSource = d;
                
                textBox7.Clear();
                textBox8.Clear();

                obj2.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

