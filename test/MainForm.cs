using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace test
{

	public partial class MainForm : Form
	{

		
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		public void Button1Click(object sender, EventArgs e)
		{
	   		timer1.Start();			
		}
		void Button2Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
		    SendKeys.Send(textBox1.Text);
            SendKeys.Send("{ENTER}");
		}
		void TrackBar1Scroll(object sender, EventArgs e)
		{
	 		label2.Text = trackBar1.Value + "С";
            timer1.Interval = trackBar1.Value*1000;
		}
	}
}
