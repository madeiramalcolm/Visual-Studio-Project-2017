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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
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

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
