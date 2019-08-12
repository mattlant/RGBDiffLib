using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mattlant.Imaging;
using Gmf.Fpa.Imaging;


namespace RGBDiffWinForms
{
	public partial class TestTheData : Form
	{
		private RGBColour rgb1;
		private RGBColour rgb2;
		private ObserverData observerData;

		public TestTheData()
		{
			InitializeComponent();
			txtRGB1_TextChanged(null, null);
			txtRGB2_TextChanged(null, null);

			observerData = new ObserverData();
			observerData.Refresh();

			//rgb1 = RGBColour.FromRGB(100, 9, 60);
			//rgb2 = RGBColour.FromRGB(100, 9, 70);
			//SetPanelBackColor(pnlRGB1, rgb1);
			//SetPanelBackColor(pnlRGB2, rgb2);

		}

		private void txtRGB1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				string[] rgb = txtRGB1.Text.Split(new char[] { ',' });

				rgb1 = ExtractRGBColour(rgb);
				SetPanelBackColor(pnlRGB1, rgb1);
			}
			catch (Exception)
			{
				
			}

		}


		private void SetPanelBackColor(Panel pnl, RGBColour colour)
		{
			pnl.BackColor = Color.FromArgb(255, (int)colour.R, (int)colour.G, (int)colour.B);
		}


		private RGBColour ExtractRGBColour(string[] rgb)
		{
			return RGBColour.FromRGB(double.Parse(rgb[0]), double.Parse(rgb[1]), double.Parse(rgb[2]));
		}

		private void txtRGB2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				string[] rgb = txtRGB2.Text.Split(new char[] { ',' });
				rgb2 = ExtractRGBColour(rgb);
				SetPanelBackColor(pnlRGB2, rgb2);
			}
			catch (Exception)
			{
				
			}
		}

		private void btnCalcDelta_Click(object sender, EventArgs e)
		{
			double drgb = ColourUtil.Delta3D(rgb1.R, rgb1.G, rgb1.B, rgb2.R, rgb2.G, rgb2.B, 2);

			double scaler = double.Parse(txtScaler.Text);

			//Apply weighting for new RGB weighting system

			double weight = 1;

			if (rdoUseWeighting.Checked)
				weight = RgbDiff.GetWeight(rgb1, rgb2, observerData);
			else if (rdoUseWeighting2.Checked)
				weight = RgbDiff.GetWeight2(rgb1, rgb2, observerData);

			drgb = drgb * weight * scaler;

			txtDeltaRGBDiff.Text = drgb.ToString();
			txtWeight.Text = weight.ToString();


		}

		private void chkUseWeighting_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
