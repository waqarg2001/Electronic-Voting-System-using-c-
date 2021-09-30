using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
namespace Voting_System
{
    public partial class Form2 : Form
    {   
        public Form2()
        {
            InitializeComponent();
            textBox1.Focus();
        }
        public string conString = "Data Source=DESKTOP-J8NC7E7\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        public static int otp;
        public static string name;
        public static string age;
        public static string gender;
        public static string phone;
        public static string email;
        public static string password;

        public void sendmail()
        {
            Random rnd = new Random();
            otp = rnd.Next(1000, 9999);
            try
            {
                
                MailMessage message = new MailMessage();
                
                SmtpClient smtp = new SmtpClient();

                message.IsBodyHtml = true;
                message.From = new MailAddress("electronicvotingsystem2021@gmail.com");
                
                message.To.Add(new MailAddress(textBox4.Text.ToString()));
                
                message.Subject = "Verification Code | Electronic Voting System";

                message.Body = @"<head> Verification Code: " + "<b>" + otp+"</b>"+"</head>" +
                    "<p>" +
                    "" +
                    "This message is generated automatically.Please donot reply to this message.</ p > " +
                    "<p>Application built by <i> Muhammad Waqar Gul & Masood-ur-Rehman </i></p>    ";

                smtp.Port = 587;
                
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("electronicvotingsystem2021@gmail.com", "electronicvoting2021");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(message);
                MessageBox.Show("4 digit OTP has been send to your email. Please verify to get registered as voter.","Success", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                name = textBox1.Text.ToString();
                age = comboBox1.Text.ToString();
                gender = comboBox2.Text.ToString();
                phone = textBox2.Text.ToString();
                email = textBox4.Text.ToString();
                password = textBox3.Text.ToString();
                Form3 f3 = new Form3();
                f3.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("err: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
           /* name = textBox1.Text.ToString();
            age = comboBox1.Text.ToString();
            gender = comboBox2.Text.ToString();
            phone = textBox2.Text.ToString();
            email = textBox4.Text.ToString();
            password = textBox3.Text.ToString();
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();*/
           
            
        }
        
        
        public void sql()
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into InfoVoter11(Name,Age,Gender,Phone,Email,Password)values('" + textBox1.Text.ToString() + "','" + 
                    comboBox1.Text.ToString() + "','"+comboBox2.Text.ToString()+ "','"+textBox2.Text.ToString()+ "','"+
                    textBox4.Text.ToString()+ "','"+ textBox3.Text.ToString()+"')";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string q = "SELECT Email FROM InfoVoter11 WHERE Email ='" + textBox4.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(q, conn);

            string iemail = cmd.ExecuteScalar() as string;

            Regex mRegxExpression;
            Regex mobilepattern;
            mobilepattern = new Regex(@"^[0-9]{11}$");
            if (textBox1.Text.Trim() == string.Empty || textBox2.Text.Trim() == string.Empty || textBox3.Text.Trim() == string.Empty ||
                    textBox4.Text.Trim() == string.Empty || comboBox1.Text.Trim() == string.Empty || comboBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("All fields are required","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else if(!mobilepattern.IsMatch(textBox2.Text.Trim()))
            {
                MessageBox.Show("Invalid Format. Please enter a valid phone number.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else
            {
                mRegxExpression = new Regex("@cloud\\.neduet\\.edu\\.pk");

                if (!mRegxExpression.IsMatch(textBox4.Text.Trim()))
                {
                    MessageBox.Show("E-mail address format is not correct.", "Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox4.Focus();
                }
                else if (iemail == textBox4.Text.ToLower().ToString())
                {
                    MessageBox.Show("You are already a registered voter","Registered Already",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox1.Focus();
                    

                }


                else
                {
                    sendmail();

                }

            
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
     
}
