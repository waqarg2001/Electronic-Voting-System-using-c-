using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_System
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 6000; // 1 second
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            pictureBox1.Show();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            timer.Stop();
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
