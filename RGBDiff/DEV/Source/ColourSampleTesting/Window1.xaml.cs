using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using mattlant.Imaging;

namespace ColourSampleTesting
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}

		private void btnUpdateRGB_Click(object sender, RoutedEventArgs e)
		{
			SetOutOfGamut(false);
			double r = double.Parse(txtR.Text);
			double g = double.Parse(txtG.Text);
			double b = double.Parse(txtB.Text);

			RGBColour rgb = RGBColour.FromRGB(r, g, b);

			XYZColour xyzcColour = ColourUtil.RGBtoXYZ(rgb);

			xyYColour xyYCol = xyYColour.FromXYZ(xyzcColour);

			txtXYZ_X.Text = xyzcColour.X.ToString();
			txtXYZ_Y.Text = xyzcColour.Y.ToString();
			txtXYZ_Z.Text = xyzcColour.Z.ToString();

			txtxyY_x.Text = xyYCol.x.ToString();
			txtxyY_y.Text = xyYCol.y.ToString();
			txtxyY_Y.Text = xyYCol.Y.ToString();

			Color newColourForRectangle = Color.FromRgb((byte) r, (byte) g, (byte) b);

			SolidColorBrush brush = new SolidColorBrush(newColourForRectangle);
			rectColour.Fill = brush;

		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			SetOutOfGamut(false);
			double X = double.Parse(txtXYZ_X.Text);
			double Y = double.Parse(txtXYZ_Y.Text);
			double Z = double.Parse(txtXYZ_Z.Text);

			XYZColour xyzColour = XYZColour.FromXYZ(X, Y, Z);

			RGBColour rgbColour = ColourUtil.XYZTosRGB(xyzColour);

			xyYColour xyYCol = xyYColour.FromXYZ(xyzColour);

			txtxyY_x.Text = xyYCol.x.ToString();
			txtxyY_y.Text = xyYCol.y.ToString();
			txtxyY_Y.Text = xyYCol.Y.ToString();

			txtR.Text = rgbColour.R.ToString();
			txtG.Text = rgbColour.G.ToString();
			txtB.Text = rgbColour.B.ToString();

			Color newColourForRectangle = Color.FromRgb((byte)rgbColour.R, (byte)rgbColour.G, (byte)rgbColour.B);

			SolidColorBrush brush = new SolidColorBrush(newColourForRectangle);
			rectColour.Fill = brush;

			SetOutOfGamut(rgbColour.OutOfGamut);

		}

		private void btnUpdatexyY_Click(object sender, RoutedEventArgs e)
		{
			SetOutOfGamut(false);
			double x = double.Parse(txtxyY_x.Text);
			double y = double.Parse(txtxyY_y.Text);
			double Y = double.Parse(txtxyY_Y.Text);

			xyYColour xyYCol = xyYColour.FromxyY(x, y, Y);

			XYZColour xyzColour = xyYCol.ToXYZColour();

			RGBColour rgbColour = ColourUtil.XYZTosRGB(xyzColour);

			txtR.Text = rgbColour.R.ToString();
			txtG.Text = rgbColour.G.ToString();
			txtB.Text = rgbColour.B.ToString();

			txtXYZ_X.Text = xyzColour.X.ToString();
			txtXYZ_Y.Text = xyzColour.Y.ToString();
			txtXYZ_Z.Text = xyzColour.Z.ToString();

			Color newColourForRectangle = Color.FromRgb((byte)rgbColour.R, (byte)rgbColour.G, (byte)rgbColour.B);

			SolidColorBrush brush = new SolidColorBrush(newColourForRectangle);
			rectColour.Fill = brush;

			SetOutOfGamut(rgbColour.OutOfGamut);

		}

		private void SetOutOfGamut(bool outOfGamut)
		{
			lblOutOfGamut.Visibility = outOfGamut
			                           	? Visibility.Visible
			                           	: Visibility.Hidden;

		}
	}
}
