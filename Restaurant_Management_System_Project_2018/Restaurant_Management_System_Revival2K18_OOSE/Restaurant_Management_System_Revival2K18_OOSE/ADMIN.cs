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
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();

        }

        private void ADMIN_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();

            String q2 = "update CUSTOMER set Address='" + textBox7.Text + "', Name='" + textBox6.Text + "',Contact_No='" + textBox8.Text + "' where _ID='" + textBox5.Text + "'";
            try
            {
                OleDbCommand cm2 = new OleDbCommand(q2, obj1);
                Int32 i = cm2.ExecuteNonQuery();
                if (i > 0)
                { MessageBox.Show("Record Updated"); }



                String q1 = "select * from CUSTOMER where User_ID='" + textBox5.Text + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView1.DataSource = d;
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();

                obj1.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();

            try
            {

                String q1 = "select * from CUSTOMER ";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
                DataTable d = new DataTable();
                da.Fill(d);
                textBox1.Clear();
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

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();
            String q2 = "delete from customer where cid='" + textBox9.Text + "'";


            try
            {
                OleDbCommand cm2 = new OleDbCommand(q2, obj1);
                cm2.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");

                textBox9.Clear();
                String q1 = "select * from customer";

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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();

            try
            {

                String q1 = "select * from CUSTOMER where User_ID='" + textBox1.Text + "'";

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();

            String q2 = "update EMPLOYEE set Address='" + textBox10.Text + "', Name='" + textBox11.Text + "',Contact_No='" + textBox4.Text + "' where Emp_ID='" + textBox12.Text + "'";
            try
            {
                OleDbCommand cm2 = new OleDbCommand(q2, obj1);
                Int32 i = cm2.ExecuteNonQuery();
                if (i > 0)
                { MessageBox.Show("Record Updated"); }



                String q1 = "select * from EMPLOYEE where EMP_ID='" + textBox12.Text + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView2.DataSource = d;
                textBox12.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox4.Clear();

                obj1.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            VScrollBar vScroller = new VScrollBar();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";
            OleDbConnection obj1 = new OleDbConnection(connection);

            String q2 = "insert into STOCK values ('" + textBox16.Text + "','" + textBox15.Text + "','" + textBox14.Text + "','" + textBox13.Text + "')";
            obj1.Open();

            try
            {
                OleDbCommand cm2 = new OleDbCommand(q2, obj1);
                cm2.ExecuteNonQuery();
                MessageBox.Show("************Record Insert Successfully*********");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            String q1 = "select * from STOCK";

            OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
            DataTable d = new DataTable();
            da.Fill(d);
            dataGridView4.DataSource = d;
            obj1.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();



            try
            {

                String q1 = "select * from stock";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView4.DataSource = d;

                obj1.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj2 = new OleDbConnection(connection);


            obj2.Open();
            String q2 = "update STOCK set itemname='" + textBox19.Text + "', quantity='" + textBox18.Text + "',price='" + textBox17.Text + "' where itemid='" + textBox20.Text + "'";
            try
            {
                OleDbCommand cm2 = new OleDbCommand(q2, obj2);
                Int32 i = cm2.ExecuteNonQuery();
                if (i > 0)
                { MessageBox.Show("Record Updated"); }
                textBox1.Clear();
                String q1 = "select * from STOCK";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj2);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView4.DataSource = d;
                textBox17.Clear();
                textBox18.Clear();
                textBox19.Clear();
                textBox20.Clear();

                obj2.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();
            String q2 = "delete from STOCK where itemid='" + textBox21.Text + "'";


            try
            {
                OleDbCommand cm2 = new OleDbCommand(q2, obj1);
                cm2.ExecuteNonQuery();
                MessageBox.Show("********Record Delete Successfully*******");

                textBox21.Clear();
                String q1 = "select * from STOCK";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView4.DataSource = d;

                obj1.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();

            try
            {
                String q1 = "Select s.itemname, MIN(s.quantity) AS MIN_QUANTITY FROM STOCK s GROUP by s.itemname ";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView3.DataSource = d;

                obj1.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();

            try
            {

                String q1 = "select * from EMPLOYEE ";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
                DataTable d = new DataTable();
                da.Fill(d);
                textBox1.Clear();
                dataGridView2.DataSource = d;
                obj1.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();

            try
            {

                String q1 = "select * from EMPLOYEE where EMP_ID='" + textBox3.Text + "'";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView2.DataSource = d;
                obj1.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();
            String q2 = "delete from EMPLOYEE where EMP_ID='" + textBox2.Text + "'";


            try
            {
                OleDbCommand cm2 = new OleDbCommand(q2, obj1);
                cm2.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");

                textBox1.Clear();
                String q1 = "select * from EMPLOYEE";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView2.DataSource = d;

                obj1.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void button14_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();

            try
            {

                String q1 = "select * from Payment";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView5.DataSource = d;
                obj1.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";

            OleDbConnection obj1 = new OleDbConnection(connection);
            obj1.Open();

            try
            {

                String q1 = "select * from Payment where date_of_payment between '"+textBox22.Text+"'AND'"+textBox23.Text+"'";

                OleDbDataAdapter da = new OleDbDataAdapter(q1, obj1);
                DataTable d = new DataTable();
                da.Fill(d);
                dataGridView6.DataSource = d;
                obj1.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LOGOUT SUCCESSFUL");
            this.Hide();
            LOGIN obj = new LOGIN();
            obj.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LOGOUT SUCCESSFUL");
            this.Hide();
            LOGIN obj = new LOGIN();
            obj.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LOGOUT SUCCESSFUL");
            this.Hide();
            LOGIN obj = new LOGIN();
            obj.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LOGOUT SUCCESSFUL");
            this.Hide();
            LOGIN obj = new LOGIN();
            obj.Show();
        }
    }
}

