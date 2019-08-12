using System;
using System.Collections.Generic;
using System.Linq;
using mattlant.Imaging;
using silverspun.RGBDiff.Dal.EntityClasses;
using silverspun.RGBDiff.Dal.HelperClasses;
using silverspun.RGBDiff.Dal.Linq;


namespace Gmf.Fpa.Imaging
{
	public class RgbDiff
	{
		public static double GetWeight(RGBColour rgbColourSource, RGBColour rgbColourCompare, ObserverData observerData)
		{
			XYZColour xyzColSource = ColourUtil.RGBtoXYZ(rgbColourSource);
			xyYColour colAsxyYSource = xyYColour.FromXYZ(xyzColSource);

			XYZColour xyzColCompare = ColourUtil.RGBtoXYZ(rgbColourCompare);
			xyYColour colAsxyYCompare = xyYColour.FromXYZ(xyzColCompare);

			//****Do calc****
			double angle = ColourUtil.CalcAngle(colAsxyYSource.x, colAsxyYSource.y, colAsxyYCompare.x, colAsxyYCompare.y);


			xyYColour closestObserverSample = GetClosestXy(colAsxyYSource, observerData);

			//NEW BRANCH: Get 3 closest xy colours

			ColourAngleSet angleSet = observerData.ColourData[closestObserverSample];


			return GetWeightingFactor(closestObserverSample, angle, angleSet, observerData);
		}

		public static double GetWeight2(RGBColour rgbColourSource, RGBColour rgbColourCompare, ObserverData observerData)
		{
			XYZColour xyzColSource = ColourUtil.RGBtoXYZ(rgbColourSource);
			xyYColour colAsxyYSource = xyYColour.FromXYZ(xyzColSource);

			XYZColour xyzColCompare = ColourUtil.RGBtoXYZ(rgbColourCompare);
			xyYColour colAsxyYCompare = xyYColour.FromXYZ(xyzColCompare);

			//****Do calc****
			double angle = ColourUtil.CalcAngle(colAsxyYSource.x, colAsxyYSource.y, colAsxyYCompare.x, colAsxyYCompare.y);


			//NEW BRANCH: Get 3 closest xy colours

			IEnumerable<xyYColour> closest3 = Interpolation.GetThreeClosestColours(colAsxyYSource, observerData);

			double influenceA, influenceB, influenceC;

			xyYColour pA = closest3.ElementAt(0);
			xyYColour pB = closest3.ElementAt(1);
			xyYColour pC = closest3.ElementAt(2);

			Interpolation.GetInfluence(colAsxyYSource, pA, pB, pC, out influenceA, out influenceB, out influenceC);

			xyYColour colourAtAngleA = GetClosestAngleColour(observerData.ColourData[pA], angle);
			xyYColour colourAtAngleB = GetClosestAngleColour(observerData.ColourData[pB], angle);
			xyYColour colourAtAngleC = GetClosestAngleColour(observerData.ColourData[pC], angle);

			double distanceA = ColourUtil.Delta3D(pA.x, pA.y, 0, colourAtAngleA.x, colourAtAngleA.y, 0, 8);
			double distanceB = ColourUtil.Delta3D(pB.x, pB.y, 0, colourAtAngleB.x, colourAtAngleB.y, 0, 8);
			double distanceC = ColourUtil.Delta3D(pC.x, pC.y, 0, colourAtAngleC.x, colourAtAngleC.y, 0, 8);

			double interpolatedDistance = Interpolation.GetInterpolatedDistance(distanceA, distanceB, distanceC, influenceA,
			                                                                    influenceB, influenceC);

			return GetWeightingFactor2(interpolatedDistance, observerData);

		}

		private static double GetWeightingFactor2(double distance, ObserverData observerData)
		{
			return 1 / (distance / observerData.AverageRange);
		}

		public static xyYColour GetClosestAngleColour(ColourAngleSet angleSet, double angle)
		{
			xyYColour closestAngleColour = null;

			//TODO: Increase accuracy only if this whole colour system seems to be working
			foreach (var colourAtAngle in angleSet)
			{
				if (ColourUtil.Delta(angle, colourAtAngle.Key) <= 45)
				{
					closestAngleColour = colourAtAngle.Value;
				}
			}
			return closestAngleColour;
		}

		public static void SetDbConnString(string connstring)
		{
			DbUtils.ActualConnectionString = connstring;
		}


		public static xyYColour GetClosestXy(xyYColour xyYcolour, ObserverData observerData)
		{
			var meta = new LinqMetaData();

			xyYColour closestColour = null;
			double closestDistance = double.MaxValue;


			foreach (xyYColour colour in observerData.ColourData.Keys)
			{
				double distance = ColourUtil.Delta3D(colour.x, colour.y, 0, xyYcolour.x, xyYcolour.y, 0, 8);
				if (distance < closestDistance)
				{
					closestDistance = distance;
					closestColour = xyYColour.FromxyY(colour.x, colour.y, colour.Y);
				}
			}

			return closestColour;
		}


		public static double GetWeightingFactor(xyYColour xyYControlCol,
		                                        double angle,
		                                        ColourAngleSet angleSet, ObserverData observerData)
		{

			//Get the closest angle
			xyYColour closestAngleColour = null;

			//TODO: Increase accuracy only if this whole colour system seems to be working
			foreach (var colourAtAngle in angleSet)
			{
				if (ColourUtil.Delta(angle, colourAtAngle.Key) < 45)
				{
					closestAngleColour = colourAtAngle.Value;
				}
			}

			double realDeltaDIff = ColourUtil.Delta3D(closestAngleColour.x, closestAngleColour.y, 0,
			                                          xyYControlCol.x, xyYControlCol.y, 0, 4);
			return 1 / (realDeltaDIff / observerData.AverageRange);
		}


		public static double GetAvgDistanceForPerceptualLikeness(xyYColour xyYControlCol,
		                                                         IDictionary<double, xyYColour> averagedColours)
		{
			double distAvg = 0;

			foreach (var avgColour in averagedColours)
			{
				distAvg += ColourUtil.Delta3D(avgColour.Value.x, avgColour.Value.y, 0, xyYControlCol.x,
				                              xyYControlCol.y, 0, 4);
			}

			return distAvg/8;
		}

		//***EXAMPLE OF FILTERING***
		//***EXAMPLE OF FILTERING***
		//***EXAMPLE OF FILTERING***
		//private static IEnumerable<IGrouping<int, ObserverDataSetColourEntity>> GetSampleGroups()
		//{
		//    var meta = new LinqMetaData();

		//    //FILTERED OUT IMPOSSIBLE LOW

		//    List<ObserverDataSetColourEntity> obsCols = meta.ObserverDataSetColour.ToList();

		//    List<ObserverDataSetColourEntity> obsColsFinal = new List<ObserverDataSetColourEntity>();

		//    var contCols = meta.ControlSetColour.ToList();


		//    foreach (ObserverDataSetColourEntity obsCol in obsCols)
		//    {
		//        var contCol = contCols.FirstOrDefault(cc => cc.XyY_x == obsCol.ControlxyY_x && cc.XyY_y == obsCol.ControlxyY_y && cc.Skip == false);
		//        if(contCol != null)
		//            obsColsFinal.Add(obsCol);
		//    }


		//    var cols = obsColsFinal.Where(col =>
		//             !(Math.Abs(col.XyY_x - col.ControlxyY_x) < 0.002 && Math.Abs(col.XyY_y - col.ControlxyY_y) < 0.002)
		//             &&
		//             !(Math.Abs(col.ControlxyY_x - col.XyY_x) > 0.018 && Math.Abs(col.ControlxyY_y - col.XyY_y) > 0.018)
		//            );


		//    return (from col in cols

		//            group col by col.ObserverDataSetUID
		//            into gcols
		//                select gcols);

		//}


	}

	#region xyPair

	public class xyPair
	{
		public double x { get; set; }
		public double y { get; set; }


		public xyPair(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return false;
			if (ReferenceEquals(this, obj))
				return true;
			if (obj.GetType() != typeof (xyPair))
				return false;
			return Equals((xyPair) obj);
		}


		public bool Equals(xyPair obj)
		{
			if (ReferenceEquals(null, obj))
				return false;
			if (ReferenceEquals(this, obj))
				return true;
			return obj.x == x && obj.y == y;
		}


		public override int GetHashCode()
		{
			unchecked
			{
				return (x.GetHashCode()*397) ^ y.GetHashCode();
			}
		}
	}

	#endregion
}