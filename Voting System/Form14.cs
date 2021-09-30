using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Voting_System
{
    public partial class Form14 : Form
    {
        public string conString = "Data Source=DESKTOP-J8NC7E7\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public Form14()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string q = "select (ElectionName) from PrevElec";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader reader;
            try
            {


                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString("ElectionName");
                    comboBox1.Items.Add(sName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            try
            {
                string q = "select Result FROM PrevElec WHERE ElectionName= '"+ comboBox1.Text.ToString()+"'";
                SqlCommand cmd = new SqlCommand(q, conn);
                var reslt = cmd.ExecuteScalar();
                conn.Close();
                label1.Text = reslt.ToString();
                label1.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
