using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace Voting_System
{
    public partial class Form6 : Form
    {
        
        public  Form6()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-J8NC7E7\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select Email from Evoters where Email= @email", conn);
            cmd2.Parameters.AddWithValue("@email", this.textBox1.Text);
            var email = cmd2.ExecuteScalar();
           

            SqlCommand cmd = new SqlCommand("Select Password from InfoVoter11 where Email= @email", conn);
            cmd.Parameters.AddWithValue("@email", this.textBox1.Text);
            var pswrd = cmd.ExecuteScalar();


           
           
           

            if (pswrd != null)
            {
                if (email is null)
                {



                    if (email != textBox1.Text.ToString())
                    {
                        if (pswrd.ToString() == textBox2.Text.ToString())
                        {
                            MessageBox.Show("Credentials Verifed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string q1 = "insert into Evoters(Email)values('" + textBox1.Text.ToString() + "')";
                            SqlCommand cmd1 = new SqlCommand(q1, conn);
                            cmd1.ExecuteNonQuery();

                            textBox1.Clear();
                            textBox2.Clear();
                            textBox1.Focus();

                            Form7 f7 = new Form7();
                            f7.Show();
                           



                        }




                        else
                        {
                            MessageBox.Show("Wrong Credentials. Please try again", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox1.Focus();
                        }
                    }
                }

                else
                { 

                   
                     if(email.ToString() != textBox1.Text.ToString())
                    {
                        MessageBox.Show("You have already casted your vote.", "Voted Already", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();

                    }
                }
                
                   
                
               
              
                
            }
            else
            {   
                MessageBox.Show("Voter is not registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }
        
        private void pictureBox4_Click(object sender, EventArgs e)
        {   
            Form12 f12 = new Form12();
            f12.Show();
            

            this.Hide();
            

        }
       
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {

            string input = Interaction.InputBox("Confirm admin password", "Confirmation");
            if (input == "****")
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }
    }
}
