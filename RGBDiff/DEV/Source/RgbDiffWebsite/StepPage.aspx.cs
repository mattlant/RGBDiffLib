using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mattlant.Imaging;
using RGBDiffLib;
using System.Net.Mail;
using System.Text;


namespace RgbDiffWebsite
{
	public partial class StepPage : System.Web.UI.Page
	{
		private DataSetStepEngine _engine;
		private ColourSquareGenerator _cs;
		public const int IMGWIDTH = 200;
		public const int IMGHEIGHT = 200;

		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);

			_engine = (DataSetStepEngine)Session["cengine"];
			if (_engine == null)
			{
				throw new ApplicationException("could not get engine");
			}


		}

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		private void SetColourSquares()
		{
			Color controlColour = GetColorFromXYY(_engine.CurrentControlColour);
			Color observerColour = GetColorFromXYY(_engine.CurrentObserverColour);

			imgSource.ImageUrl = SquareGen.FormatUrl(controlColour, IMGWIDTH, IMGHEIGHT);
			if (IsOutOfGamut(_engine.CurrentObserverColour))
				imgMatch.ImageUrl = "~/oog.jpg";
			else
				imgMatch.ImageUrl = SquareGen.FormatUrl(observerColour, IMGWIDTH, IMGHEIGHT);

			//control colour uid, angle, startoffset, adjustSize, currentcolourstep, currentAdjustStep xyY, rgb
			StringBuilder sb = new StringBuilder();

			sb.AppendFormat("A{0}", _engine.CurrentControlColourIndex);
			sb.AppendFormat("|B{0}", _engine.ColourStepEngine.CurrentAngle);
			sb.AppendFormat("|C{0}", _engine.StartOffset);
			sb.AppendFormat("|D{0}", _engine.AdjustSize);
			sb.AppendFormat("|E{0}", _engine.CurrentStep);
			sb.AppendFormat("|F{0}", _engine.ColourStepEngine.CurrentStepIndex);
			sb.AppendFormat("|G{0},{1},{2}", _engine.CurrentControlColour.x, _engine.CurrentControlColour.y, _engine.CurrentControlColour.Y);
			sb.AppendFormat("|H{0},{1},{2}", _engine.CurrentObserverColour.x, _engine.CurrentObserverColour.y, _engine.CurrentObserverColour.Y);

			litstatus.Text = sb.ToString();


		}


		private Color GetColorFromXYY(xyYColour xyy)
		{
			double x = Math.Round(xyy.x, 5, MidpointRounding.ToEven);
			double y = Math.Round(xyy.y, 5, MidpointRounding.ToEven);

			xyYColour temp = xyYColour.FromxyY(x, y, xyy.Y);

			XYZColour xyz = temp.ToXYZColour();
			RGBColour rgb = ColourUtil.XYZTosRGB(xyz);
			Color color = Color.FromArgb(0, (byte)rgb.R, (byte)rgb.G, (byte)rgb.B);
			return color;

		}

		private bool IsOutOfGamut(xyYColour xyy)
		{
			double x = Math.Round(xyy.x, 5, MidpointRounding.ToEven);
			double y = Math.Round(xyy.y, 5, MidpointRounding.ToEven);

			xyYColour temp = xyYColour.FromxyY(x, y, xyy.Y);

			XYZColour xyz = temp.ToXYZColour();
			RGBColour rgb = ColourUtil.XYZTosRGB(xyz);
			return rgb.OutOfGamut;

		}

		protected void btnAccept_Click(object sender, EventArgs e)
		{
			if (_engine.AcceptColourAtAngle())
			{
				Response.Redirect("~/Finished.aspx");
			}

			lblPercentComplete.Text = ((int)(_engine.PercentComplete * 100f)).ToString() + "% Complete";
		}

		protected override void OnPreRender(EventArgs e)
		{
			SetColourSquares();

			base.OnPreRender(e);
		}

		protected void btnBackStep_Click(object sender, EventArgs e)
		{
			Button button = (Button) sender;
			_engine.ColourStepEngine.DecrementStep(button.Text.Length);

		}

		protected void btnForwardStep_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			_engine.ColourStepEngine.IncrementStep(button.Text.Length);
		}

	}
}
