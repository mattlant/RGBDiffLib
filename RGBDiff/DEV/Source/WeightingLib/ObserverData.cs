using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mattlant.Imaging;
using silverspun.RGBDiff.Dal.EntityClasses;
using silverspun.RGBDiff.Dal.Linq;


namespace Gmf.Fpa.Imaging
{
	public class ObserverData
	{
		private Dictionary<xyYColour, ColourAngleSet> _colourData;
		double _minRange;
		double _maxRange;
		double _avgRange;

		private double _minMaxHalfway;

		public ObserverData()
		{
		}

		public double AverageRange
		{
			get { return _avgRange; }
		}

		public double MinMaxHalf
		{
			get { return _minMaxHalfway; }
		}

		public double MaxRange
		{
			get { return _maxRange; }
		}

		public double MinRange
		{
			get { return _minRange; }
		}

		public Dictionary<xyYColour, ColourAngleSet> ColourData
		{
			get
			{
				if(_colourData == null)
					LoadData();

				return _colourData;
			}
		}

		public void Refresh()
		{
			LoadData();
		}

		private void LoadData()
		{
			_colourData = new Dictionary<xyYColour, ColourAngleSet>();


			var meta = new LinqMetaData();


			//We get all control colours that are not set to skip
			IQueryable<ControlSetColourEntity> controlCOlours = from col in meta.ControlSetColour
													where col.Skip == false
													select col;

			foreach (ControlSetColourEntity controlSetColourEntity in controlCOlours)
			{
				//Create an xyY Colour
				xyYColour xyYControlCOlour = xyYColour.FromxyY(controlSetColourEntity.XyY_x, controlSetColourEntity.XyY_y,
				                                               controlSetColourEntity.XyY_YY);

				ColourAngleSet angleSet = GetEachAvgAngle(xyYControlCOlour);

				_colourData.Add(xyYControlCOlour, angleSet);

			}

			CalculateMinMaxRange();


		}

		private void CalculateMinMaxRange()
		{
			double max = double.MinValue;
			double min = double.MaxValue;

			double avg = 0;

			int count = 0;

			foreach (KeyValuePair<xyYColour, ColourAngleSet> dataItem in ColourData)
			{
				foreach (KeyValuePair<double, xyYColour> colourAngleSetItem in dataItem.Value)
				{
					double distance = ColourUtil.Delta3D(dataItem.Key.x, dataItem.Key.y, 0, colourAngleSetItem.Value.x, colourAngleSetItem.Value.y, 0, 4);

					if (distance > max)
						max = distance;
					if (distance < min)
						min = distance;

					count++;
					avg += distance;
				}
			}

			_minRange = min;
			_maxRange = max;

			_avgRange = avg/count;

			_minMaxHalfway = _minRange + ((_maxRange - _minRange)/2);
		}

		public static ColourAngleSet GetEachAvgAngle(xyYColour colour)
		{
			ColourAngleSet avgColours = new ColourAngleSet();

			IEnumerable<IGrouping<double, ObserverDataSetColourEntity>> colAngleGroups = GetAngleGroupsForColour(colour);

			foreach (var colAngleGroup in colAngleGroups)
			{
				double x = 0, y = 0, Y = colour.Y;
				int colourCount = colAngleGroup.Count();


				foreach (ObserverDataSetColourEntity colourEntity in colAngleGroup)
				{
					x += colourEntity.XyY_x;
					y += colourEntity.XyY_y;
				}

				x = x / colourCount;
				y = y / colourCount;
				xyYColour newAvg = xyYColour.FromxyY(x, y, Y);
				avgColours.Add(colAngleGroup.Key, newAvg);
			}

			return avgColours;
		}


		private static IEnumerable<IGrouping<double, ObserverDataSetColourEntity>> GetAngleGroupsForColour(xyYColour colour)
		{
			var meta = new LinqMetaData();
			return (from col in meta.ObserverDataSetColour
					where
					 col.ControlxyY_x == colour.x &&
					 col.ControlxyY_y == colour.y
					group col by col.Angle
						into gcol
						select gcol).AsEnumerable();
		}

	}


	public class ColourAngleSet : Dictionary<double, xyYColour>
	{

	}
}
