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
   

    public partial class Form13 : Form
    {
        public string conString = "Data Source=DESKTOP-J8NC7E7\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public static string resultdb;
        public Form13()
        {
        

        InitializeComponent();
            

            if (Form7.candname1.ToString().Trim() == "") 
            {
                label2.Visible = false;
            }
            if (Form7.candname2.ToString().Trim() == "")
            {
                label3.Visible = false;
            }
            if (Form7.candname3.ToString().Trim() == "")
            {
                label4.Visible = false;
            }
            if (Form7.candname4.ToString().Trim() == "")
            {
                label5.Visible = false;
            }


            if (Form7.cand1> Form7.cand2 && Form7.cand1 > Form7.cand3 && Form7.cand1 > Form7.cand4)
            {
                label1.Text = $"{Form7.candname1.Trim()} has won by  {Form7.cand1} votes."; 
            }
            else if (Form7.cand2 > Form7.cand1 && Form7.cand2 > Form7.cand3 && Form7.cand2 > Form7.cand4)
            {
                label1.Text = $"{Form7.candname2.Trim()} has won by  {Form7.cand2} votes.";
            }
            else if (Form7.cand3 > Form7.cand1 && Form7.cand3 > Form7.cand2 && Form7.cand3 > Form7.cand4)
            {
                label1.Text = $"{Form7.candname3.Trim()} has won by  {Form7.cand3} votes.";
            }
            else if (Form7.cand4 > Form7.cand1 && Form7.cand4 > Form7.cand2 && Form7.cand4 > Form7.cand3)
            {
                label1.Text = $"{Form7.candname4.Trim()} has won by  {Form7.cand4} votes.";
            }
            else
            {
                label1.Text = "There is a tie";
                
            }
            resultdb = label1.Text;
            label2.Text = $"{Form7.candname1.Trim()} secured {Form7.cand1} votes.";
            label3.Text = $"{Form7.candname2.Trim()} secured {Form7.cand2} votes.";
            label4.Text = $"{Form7.candname3.Trim()} secured {Form7.cand3} votes.";
            label5.Text = $"{Form7.candname4.Trim()} secured {Form7.cand4} votes.";
            
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string q = "insert into PrevElec(ElectionName, Result)values('" + Form5.elecname.ToString() + "', '" + Form13.resultdb.ToString() + "') ";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();




        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
