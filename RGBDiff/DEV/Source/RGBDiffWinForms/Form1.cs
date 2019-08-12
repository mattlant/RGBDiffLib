using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mattlant.Imaging;

namespace RGBDiffWinForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				PointF point1 = GetPoint1();
				PointF point2 = GetPoint2();
				if (chkRecalcPoint1.Checked)
				{
					point2.X -= point1.X;
					point2.Y -= point1.Y;
					point1.X = 0;
					point1.Y = 0;
				}

				double angle = ColourUtil.CalcAngle(point1.X, point1.Y, point2.X, point2.Y);

				txtAngle.Text = angle.ToString();
			}
			catch (Exception)
			{

				MessageBox.Show("Incorrect input");

			}


		}


		private PointF GetPoint2()
		{
			return new PointF(float.Parse(txtP2x.Text), float.Parse(txtP2y.Text));
		}


		private PointF GetPoint1()
		{
			return new PointF(float.Parse(txtP1x.Text), float.Parse(txtP1y.Text));
		}



		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}


		private void Clear()
		{
			txtP1x.Text = "";
			txtP1y.Text = "";
			txtP2x.Text = "";
			txtP2y.Text = "";
		}
	}
}
