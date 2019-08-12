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
using RGBDiffLib;
using silverspun.RGBDiff.Dal.HelperClasses;

namespace RGBDiffWpf
{
	/// <summary>
	/// Interaction logic for StepPage.xaml
	/// </summary>
	public partial class StepPage : Page
	{
		private DataSetStepEngine _engine;
		public StepPage()
		{
			InitializeComponent();

			//DbUtils.ActualConnectionString =
			//"data source=mlcsrv1;initial catalog=DeltaRGBsss;integrated security=SSPI;persist security info=False;packet size=4096";

			try
			{
				_engine = new DataSetStepEngine(1);
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.ToString());
				Application.Current.Shutdown();
			}

			SetColours();

			btnPrevColour.IsEnabled = false;
			btnMatch.IsEnabled = false;


		}


		public void SetColours()
		{

			rectControlColour.Fill = new SolidColorBrush(GetColorFromXYY(_engine.CurrentControlColour));
			rectTargetColour.Fill = new SolidColorBrush(GetColorFromXYY(_engine.CurrentObserverColour));
			
		}

		private Color GetColorFromXYY(xyYColour xyy)
		{
			XYZColour xyz = xyy.ToXYZColour();
			RGBColour rgb = ColourUtil.XYZTosRGB(xyz);
			Color color = Color.FromRgb((byte)rgb.R, (byte)rgb.G, (byte)rgb.B);
			return color;
			
		}

		private void btnPrevColour_Click(object sender, RoutedEventArgs e)
		{
			_engine.ColourStepEngine.DecrementStep();
			SetColours();
		}

		private bool firstTimeClickedNext = true;
		private void btnNextColour_Click(object sender, RoutedEventArgs e)
		{
			if(firstTimeClickedNext)
			{
				MessageBox.Show("Please make sure you have read and understand the instructions and intention of this program before continuing.");
				firstTimeClickedNext = false;
			}

			_engine.ColourStepEngine.IncrementStep();
			SetColours();
			btnPrevColour.IsEnabled = true;
			btnMatch.IsEnabled = true;
		}

		private void btnMatch_Click(object sender, RoutedEventArgs e)
		{
			bool Done = _engine.AcceptColourAtAngle();
			if(Done)
				Finished();
			lblPercentComplete.Text = ((int)(_engine.PercentComplete*100f)).ToString() + "% Complete";
			SetColours();
			btnPrevColour.IsEnabled = false;
			btnMatch.IsEnabled = false;

		}

		private void Finished()
		{
			MessageBox.Show("Thank you for participating.");
			Application.Current.Shutdown();
		}

	}
}
