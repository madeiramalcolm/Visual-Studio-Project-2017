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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";
            OleDbConnection obj2 = new OleDbConnection(connection);


            String q1 = "(Select Order_ID,Date_of_Order,Dish_ID,quantity,Rate from (Order1 NATURAL JOIN Item) where status='Approved')";

            obj2.Open();
            try
            {

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj2);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView1.DataSource = d;
            
                obj2.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";
       
            OleDbConnection obj1 = new OleDbConnection(connection);

            String q2 = "insert into payment values ('" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','"+ dateTimePicker1.Value.ToString("dd-MM-yy")+"')";
            obj1.Open();

            try
            {
                OleDbCommand cm2 = new OleDbCommand(q2, obj1);
                cm2.ExecuteNonQuery();
                MessageBox.Show("*********Payment Record Created*********");

             
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                obj1.Close();


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
