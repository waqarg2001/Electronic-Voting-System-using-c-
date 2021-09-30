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
    public partial class Form1 : Form
    {
        string finalString;
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
            /*var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[5];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);*/
            CaptchaString();

            pictureBox6.Image = CaptchaToImage(finalString, pictureBox2.Width, pictureBox2.Height);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

       

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() != "admin" || textBox2.Text.ToString() != "a123")
            {
                MessageBox.Show("Incorrect credentials", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                if (textBox3.Text == finalString)
                {
                    
                    this.Hide();
                    Form4 f4 = new Form4();
                    f4.Show();
                    
                }
                else if(textBox3.Text != finalString || textBox3.Text.TrimStart() == "")
                {
                    MessageBox.Show("Enter valid captcha", "Invalid Captcha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Clear();
                    finalString = " ";
                    CaptchaString();
                    pictureBox6.Image = CaptchaToImage(finalString, pictureBox2.Width, pictureBox2.Height);
                }

               
                /*Form4 f4 = new Form4();
                f4.Show();*/

            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }

        private string CaptchaString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[5];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);
            return finalString;
        }

        private Bitmap CaptchaToImage(string text, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            SolidBrush sb = new SolidBrush(Color.White);
            g.FillRectangle(sb, 0, 0, bmp.Width, bmp.Height);
            Font font = new Font("Tahoma", 18);
            sb = new SolidBrush(Color.Black);
            g.DrawString(text, font, sb, bmp.Width / 2 - (text.Length / 2) * font.Size, (bmp.Height / 2) - font.Size);
            int count = 0;
            Random rand = new Random();
            while (count < 20)
            {
                sb = new SolidBrush(Color.YellowGreen);
                g.FillEllipse(sb, rand.Next(0, bmp.Width), rand.Next(0, bmp.Height), 4, 2);
                count++;
            }
            count = 0;
            while (count < 10)
            {
                g.DrawLine(new Pen(Color.Bisque), rand.Next(0, bmp.Width), rand.Next(0, bmp.Height), rand.Next(0, bmp.Width), rand.Next(0, bmp.Height));
                count++;
            }
            return bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
