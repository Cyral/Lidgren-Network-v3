using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace ChatServer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (button1.Text == "Start")
			{
				Program.StartServer();
				button1.Text = "Shut down";
			}
			else
			{
				Program.Shutdown();
				button1.Text = "Start";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Program.DisplaySettings();
		}

        private void button3_Click(object sender, EventArgs e)
        {
            Program.paused = !Program.paused;
            if (button3.Text == "Pause")
            {
               Environment.Exit(0);
                button3.Text = "Unpause";
            }
            else
            { 
                button3.Text = "Pause";
            }
        }
    }
}
