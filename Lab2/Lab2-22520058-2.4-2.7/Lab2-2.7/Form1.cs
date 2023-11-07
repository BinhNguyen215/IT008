using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_2._7
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer();
        private DateTime scheduledTime;
        private bool isCountingDown = false;
        public int timeLeft;
        public int index;
        public int timeCount = 0;
        public int time;

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeCount++;
            int.TryParse(tb_timer.Text, out timeLeft);
            time = timeLeft - timeCount;
            lbl_status_result.Text = $"Will Executed in {time} s";
            if(time ==0 )
            {
                if(index ==1)
                {
                    Process.Start("shutdown", "/s /t 0");
                }
                else if(index ==2)
                {
                    Process.Start("shutdown", "/r /t 0");
                }
                else if(index ==3)
                {
                    Process.Start("shutdown", "/l");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            isCountingDown = false;
            lbl_status_result.Text = "Timer Canceled";
            tb_timer.Text = "";
        }

        private void btn_shutdown_Click(object sender, EventArgs e)
        {
            index = 1;
            timer.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 2;
            timer.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = 3;
            timer.Start();

        }
    }
}
