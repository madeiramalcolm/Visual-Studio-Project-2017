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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void lblfn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblrepass_Click(object sender, EventArgs e)
        {

        }

        private void cmbsex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;Workspace=Malcolm;User Id=MALCOLM;Password=madeira;OLEDB.NET=True";
            
            OleDbConnection obj1 = new OleDbConnection(connection);
            string S3 = ComboBox1.SelectedItem.ToString();//sex
            string S1 = ComboBox2.SelectedItem.ToString();
            string S2 = Textbox5.Text+8;//For ID

            if (ComboBox2.SelectedItem.ToString() == "Employee")
            {
                if (Textbox6.Text == Textbox7.Text)
                {
                    String q2 = "insert into Login values ('" + Textbox5.Text + "','" + Textbox6.Text + "','" + S1 + "')";
                    obj1.Open();

                    try
                    {
                        OleDbCommand cm2 = new OleDbCommand(q2, obj1);
                        cm2.ExecuteNonQuery();

                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
                else
                { MessageBox.Show("**********Password Don't Match\nPlease Re-ENTER*********"); }
                //Employee details

                String q3 = "insert into EMPLOYEE values ('" + S2 + "','" + Textbox5.Text + "','" + Textbox2.Text + "','" + Textbox1.Text + "','" + Textbox3.Text + "','" + S3 + "')";


                try
                {
                    OleDbCommand cm2 = new OleDbCommand(q3, obj1);
                    cm2.ExecuteNonQuery();
                    MessageBox.Show("************Record Insert Successfully*********");

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }

            if (ComboBox2.SelectedItem.ToString() == "Customer")
            {
                if (Textbox6.Text == Textbox7.Text)
                {
                    String q4 = "insert into Login values ('" + Textbox5.Text + "','" + Textbox6.Text + "','" + ComboBox2.SelectedItem.ToString()+ "')";
                    obj1.Open();

                    try
                    {
                        OleDbCommand cm2 = new OleDbCommand(q4, obj1);
                        cm2.ExecuteNonQuery();

                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
                else
                { MessageBox.Show("**********Password Don't Match\nPlease Re-ENTER*********"); }
                //Customer details

                String q3 = "insert into CUSTOMER values ('" + Textbox5.Text + "','" +S2+ "','" + Textbox2.Text + "','" + Textbox1.Text + "','" + Textbox3.Text + "','" + S3 + "')";


                try
                {
                    OleDbCommand cm2 = new OleDbCommand(q3, obj1);
                    cm2.ExecuteNonQuery();
                    MessageBox.Show("************Record Insert Successfully*********");

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }

            Textbox5.Clear();
            Textbox6.Clear();
            Textbox7.Clear();
            Textbox1.Clear();
            Textbox2.Clear();
            Textbox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Textbox5.Clear();
            Textbox6.Clear();
            Textbox7.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Textbox1.Clear();
            Textbox2.Clear();
            Textbox3.Clear();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN obj = new LOGIN();
            obj.Show();

        }
    }
}
