﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Voting_System
{
    public partial class Form9 : Form
    {
        public string conString = "Data Source=DESKTOP-J8NC7E7\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public Form9()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select Name from Candidate where Sno= @sno", conn);
            cmd.Parameters.AddWithValue("@sno", 2);
            var name = cmd.ExecuteScalar();
            label4.Text = name.ToString();

            SqlCommand cmd1 = new SqlCommand("Select Age from Candidate where Sno= @sno", conn);
            cmd1.Parameters.AddWithValue("@sno", 2);
            var age = cmd1.ExecuteScalar();
            label5.Text = age.ToString();

            SqlCommand cmd2 = new SqlCommand("Select Gender from Candidate where Sno= @sno", conn);
            cmd2.Parameters.AddWithValue("@sno", 2);
            var gend = cmd2.ExecuteScalar();
            label6.Text = gend.ToString();




            pictureBox1.Image = Form5.image2;

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
