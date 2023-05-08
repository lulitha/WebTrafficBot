using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCounter : Form
    {
        private Timer timeX;
        private int minutesLeft;
        public frmCounter()
        {
            InitializeComponent();
            timeX = new Timer() { Interval = 60000 };
            timeX.Tick += new EventHandler(timer1_Tick);
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = timer1.Interval.ToString();
            if (minutesLeft-- <= 0)
            {
                timeX.Stop();
                this.Close();
                // Done!
            }
            else
            {
                guna2HtmlLabel1.Text = "Next ...!!";
            }
            guna2HtmlLabel1.Text = minutesLeft + " sec remaining";

        }

        private void frmCounter_Load(object sender, EventArgs e)
        {
            minutesLeft = RandomNumber(100, 200);

            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Form1 fm = new Form1();
            this.Hide();
            fm.ShowDialog();
            
        }
    }
}
