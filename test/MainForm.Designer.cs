/*
 * Created by SharpDevelop.
 * User: Win10Pro
 * Date: 07.05.2021
 * Time: 22:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace test
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 44);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(179, 45);
			this.button1.TabIndex = 0;
			this.button1.Text = "Старт";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(226, 44);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(184, 45);
			this.button2.TabIndex = 1;
			this.button2.Text = "Стоп";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(133, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(277, 22);
			this.textBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(5, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Введите текст:";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(12, 95);
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(394, 56);
			this.trackBar1.TabIndex = 4;
			this.trackBar1.Value = 5;
			this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1Scroll);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "label2";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 166);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "test";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
