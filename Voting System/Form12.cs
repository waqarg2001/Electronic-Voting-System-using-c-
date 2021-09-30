using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Voting_System
{
    public partial class Form12 : Form
    {
        public string conString = "Data Source=DESKTOP-J8NC7E7\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        void delete_voters()
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string q = "delete from Candidate";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {


            if (textBox1.Text.ToString() != "admin" && textBox2.Text.ToString() != "a123")
            {
                MessageBox.Show("Wrong credentials", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Credentials Verified", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                delete_voters();

                Form13 f13 = new Form13();
                f13.Show();
            }
        }

    }
}
