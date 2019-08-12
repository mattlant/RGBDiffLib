using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;

namespace RGBDiffLib
{
	public class ColourSquareGenerator
	{
		private Dictionary<string, Image> _cache;

		public Dictionary<string, Image> Cache
		{
			get { return _cache; }
		}

		public ColourSquareGenerator()
		{
			_cache = new Dictionary<string, Image>();
		}

		public Image Get(byte r, byte g, byte b, int w, int h)
		{
			string key = GenKey(r, g, b, w, h);

			if (Cache.ContainsKey(key))
			{
				return Cache[key];
			}

			Image img = GenImage(r, g, b, w, h);

			Cache.Add(key, img);

			return img;
		}

		private Image GenImage(byte r, byte g, byte b, int w, int h)
		{
			Color fillColour = Color.FromArgb(r, g, b);
			Image img = new Bitmap(w, h);
			using (Graphics graphics = Graphics.FromImage(img))
			{
				graphics.FillRectangle(new SolidBrush(fillColour), 0, 0, w, h);
			}
			return img;
		}

		private static string GenKey(byte r, byte g, byte b, int w, int h)
		{
			return r.ToString("D3") + g.ToString("D3") + b.ToString("D3") + w.ToString("D3") + h.ToString("D3");
		}
	}
}
