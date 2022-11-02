using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12F_Minimal
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}

		Random r = new Random();


		private void button1_Click(object sender, EventArgs e)
		{
			// MessageBox.Show("Halihó");
			label1.Text = "valami";

			Bitmap bmp = new Bitmap(40, 40);
			pictureBox1.Image = bmp;

			Graphics g = Graphics.FromImage(bmp); // ez jelenti azt, hogy erre fog a g rajzolni.
			Pen toll = new Pen(Color.Blue);

			int x = r.Next(0, 10);
			int y = r.Next(0, 10);
			int z = r.Next(0, 10);
			int t = r.Next(0, 10);
			g.DrawLine(toll, 10+x, 20+y, 30-z, 40-t);


		}

	}
}
