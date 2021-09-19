using PiPlanePanel.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiPlanePanel
{
    public partial class Form1 : Form
    {
        private Thread AxisThread { get; set; }
        private Joystick Stick { get; set; }
        public Form1()
        {
            InitializeComponent();
            Stick = new Joystick();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new();
            timer.Interval = (1 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.roll.Text = Stick.Roll.ToString();
            this.pitch.Text = Stick.Pitch.ToString();
            this.yaw.Text = Stick.Yaw.ToString();
            this.throttle.Text = Stick.Throttle.ToString();
            this.Refresh();
        }

        private void TrackAxis_Click(object sender, EventArgs e)
        {
            Stick.StartUpdateThread();
        }

    }
}
