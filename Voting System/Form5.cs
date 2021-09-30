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
    public partial class Form5 : Form
    {
        public string conString = "Data Source=DESKTOP-J8NC7E7\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string q = "DELETE FROM Candidate";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static Image image = null;
        public static Image image2 = null;
        public static Image image3 = null;
        public static Image image4 = null;
        public static string elecname;

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            






           

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
           
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
                image = pictureBox1.Image;
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = new Bitmap(opnfd.FileName);
                image2 = pictureBox4.Image;

            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = new Bitmap(opnfd.FileName);
                image3 = pictureBox3.Image;
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox9.Image = new Bitmap(opnfd.FileName);
                image4 = pictureBox9.Image;
            }

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {   
            if (textBox1.Text.Trim()==string.Empty){
                MessageBox.Show("Election Name cannot be empty.","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else { 

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string q = "insert into Candidate(Name, Gender, Age, Email,Sno)values('" + textBox18.Text.ToString() + "', '" + comboBox1.Text.ToString() + "', '" +
                comboBox2.Text.ToString() + "', '" + textBox21.Text.ToString() + "', '" + 1 + "') ";
            string q1 = "insert into Candidate(Name, Gender, Age, Email,Sno)values('" + textBox22.Text.ToString() + "', '" + comboBox3.Text.ToString() + "', '" +
               comboBox4.Text.ToString() + "', '" + textBox6.Text.ToString() + "', '" + 2 + "') ";
            string q2 = "insert into Candidate(Name, Gender, Age, Email,Sno)values('" + textBox24.Text.ToString() + "', '" + comboBox5.Text.ToString() + "', '" +
              comboBox6.Text.ToString() + "', '" + textBox12.Text.ToString() + "', '" + 3 + "') ";
            string q3 = "insert into Candidate(Name, Gender, Age, Email,Sno)values('" + textBox15.Text.ToString() + "', '" + comboBox7.Text.ToString() + "', '" +
               comboBox8.Text.ToString() + "', '" + textBox16.Text.ToString() + "', '" + 4 + "') ";
            string q4 = "delete from Evoters";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlCommand cmd1 = new SqlCommand(q1, conn);
            SqlCommand cmd2 = new SqlCommand(q2, conn);
            SqlCommand cmd3 = new SqlCommand(q3, conn);
            SqlCommand cmd4 = new SqlCommand(q4, conn);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            elecname = textBox1.Text;
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
                }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4();
            f4.Show();

        }
    }
}
