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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public string conString = "Data Source=DESKTOP-J8NC7E7\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";


        public void sql()
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into InfoVoter11(Name,Age,Gender,Phone,Email,Password)values('" +Form2.name + "','" +
                    Form2.age + "','" + Form2.gender + "','" + Form2.phone + "','" + Form2.email + "','" + Form2.password + "')";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox1.Text) == Form2.otp)
            {
                sql();
                MessageBox.Show("OTP verified. You are now a registered voter","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("OTP is not verified. Please try again.", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}