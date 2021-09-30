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
    
    public partial class Form7 : Form
    {
        public static int cand1 = 0;
        public static int cand2 = 0;
        public static int cand3 = 0;
        public static int cand4 = 0;
        public static string candname1;
        public static string candname2;
        public static string candname3;
        public static string candname4;
        public string conString = "Data Source=DESKTOP-J8NC7E7\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public Form7()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select Name from Candidate where Sno= @sno", conn);
            cmd.Parameters.AddWithValue("@sno", 1);
            SqlCommand cmd1 = new SqlCommand("Select Name from Candidate where Sno= @sno", conn);
            cmd1.Parameters.AddWithValue("@sno", 2);
            SqlCommand cmd2 = new SqlCommand("Select Name from Candidate where Sno= @sno", conn);
            cmd2.Parameters.AddWithValue("@sno", 3);
            SqlCommand cmd3 = new SqlCommand("Select Name from Candidate where Sno= @sno", conn);
            cmd3.Parameters.AddWithValue("@sno", 4);
            
            var name = cmd.ExecuteScalar();
            var name1 = cmd1.ExecuteScalar();
            var name2 = cmd2.ExecuteScalar();
            var name3 = cmd3.ExecuteScalar();
            if (name.ToString().Trim()== "")
            {
                radioButton1.Enabled = false;
                linkLabel1.Visible = false;
            }
            if (name1.ToString().Trim() == "")
            {
                radioButton2.Enabled = false;
                linkLabel2.Visible = false;
            }
            if (name2.ToString().Trim() == "")
            {
                radioButton3.Enabled = false;
                linkLabel3.Visible = false;
            }
            if (name3.ToString().Trim() == "")
            {
                radioButton4.Enabled = false;
                linkLabel4.Visible = false;
            }
            radioButton1.Text = name.ToString();
            radioButton2.Text = name1.ToString();
            radioButton3.Text = name2.ToString();
            radioButton4.Text = name3.ToString();
            candname1 = name.ToString();
            candname2 = name1.ToString();
            candname3 = name2.ToString();
            candname4 = name3.ToString();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                cand1 += 1;

            }
            else if (radioButton2.Checked == true)
            {

                cand2 += 1;
            }
            else if (radioButton3.Checked == true)
            {

                cand3 += 1;
            }
            else if (radioButton4.Checked == true)
            {

                cand4 += 1;
            }
            else
            {
                MessageBox.Show("Please select a valid option.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int total = 0;
            total = cand1 + cand2 + cand3 + cand4;
            MessageBox.Show("Your vote has been casted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
