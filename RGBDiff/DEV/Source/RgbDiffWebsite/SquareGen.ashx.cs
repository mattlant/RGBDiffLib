using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Services;
using mattlant.Imaging;
using mattlant.Web;
using RGBDiffLib;


namespace RgbDiffWebsite
{
	/// <summary>
	/// Summary description for $codebehindclassname$
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	public class SquareGen : IHttpHandler
	{
		private ColourSquareGenerator _cs;

		public const string UrlFormatString = "~/SquareGen.ashx?r={0}&g={1}&b={2}&w={3}&h={4}";

		public void ProcessRequest(HttpContext context)
		{

			byte r = QueryString.GetByte("r");
			byte g = QueryString.GetByte("g");
			byte b = QueryString.GetByte("b");
			int w = QueryString.GetInt("w");
			int h = QueryString.GetInt("h");

			SetReusables(context);

			Image sqrImg = _cs.Get(r, g, b, w, h);
			context.Response.StatusCode = 200;
			context.Response.ContentType = "image/png";
			MemoryStream ms = new MemoryStream();
			sqrImg.Save(ms, ImageFormat.Png);
			ms.WriteTo(context.Response.OutputStream);
			context.Response.Flush();

		}

		private void SetReusables(HttpContext context)
		{
			if(_cs != null)
				return;

			_cs = (ColourSquareGenerator)context.Cache["cs"];
			if (_cs == null)
			{
				_cs = new ColourSquareGenerator();
			}
		}

		public bool IsReusable
		{
			get
			{
				return true;
			}
		}

		public static string FormatUrl(byte r, byte g, byte b, int w, int h)
		{
			return string.Format(UrlFormatString, r, g, b, w, h);
		}

		public static string FormatUrl(Color colour, int imgwidth, int imgheight)
		{
			return FormatUrl(colour.R, colour.G, colour.B, imgwidth, imgheight);
		}
	}
}
