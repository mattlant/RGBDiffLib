using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RGBDiffLib;
using System.Configuration;


namespace RgbDiffWebsite
{
	public partial class Default : System.Web.UI.Page
	{
		private DataSetStepEngine _engine;

		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnStart_Click(object sender, EventArgs e)
		{
			double startOffset = Convert.ToDouble(ConfigurationManager.AppSettings["StartOffset"]);
			double adjustSize = Convert.ToDouble(ConfigurationManager.AppSettings["AdjustmentSize"]);
			_engine = new DataSetStepEngine(1, startOffset, adjustSize);
			Session["cengine"] = _engine;

			if(Cache.Get("cs") == null)
				Cache["cs"] = new ColourSquareGenerator();

			Response.Redirect("~/StepPage.aspx?new=1");


		}
	}
}
